using InstagramDemo.AbstractServices;
using InstagramDemo.Data;
using InstagramDemo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstagramDemo
{
    public partial class AdminHomePageFom : Form
    {
        private readonly User _user;
        private readonly IPostService _postService;
        private readonly IUserService _userService;
        private readonly Post _post;

        public AdminHomePageFom(User user, IPostService postService, IUserService userService,Post post)
        {
            InitializeComponent();
            _user = user;
            _postService = postService;
            _userService = userService;
            _post = post;

          
           
            AddDeleteButtonColumn();
           

            LoadUserList();
            dgcUserList.Columns[4].Visible = false;
            dgcUserList.Columns[5].Visible = false;
            dgcUserList.Columns[6].Visible = false;
        }

       
        private void AddComplaintCountColumn()
        {
            DataGridViewTextBoxColumn complaintCountColumn = new DataGridViewTextBoxColumn();
            complaintCountColumn.Name = "ComplaintCount";
            complaintCountColumn.HeaderText = "Şikayet Sayısı";
            dgcUserList.Columns.Add(complaintCountColumn);
        }

        // Silme butonu sütununu eklemek
        private void AddDeleteButtonColumn()
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButton";
            deleteButtonColumn.HeaderText = "Sil";
            deleteButtonColumn.Text = "Sil";
        
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgcUserList.Columns.Add(deleteButtonColumn);
            dgcUserList.CellClick += dgcUserList_CellClick;
        }
        private void AddCountButtonColumn(Post post)
        {


            if (!dgcUserList.Columns.Contains("Report"))
            {
                DataGridViewButtonColumn complainColumn = new DataGridViewButtonColumn();
                complainColumn.Name = "Report";
                complainColumn.HeaderText = "Report";
                complainColumn.Text = _postService.GetPostComplainCount(post).ToString();
                complainColumn.UseColumnTextForButtonValue = true;
                dgcUserList.Columns.Add(complainColumn);
            }



        }

        private void LoadUserList()
        {
           
            dgcUserList.DataSource = _userService.GetAllUserAdminFalse();
        }

        private void LoadPostList(Post post)
        {
             
            
            

            dgcUserList.DataSource =_postService.GetAllPostAllPostComplain();
          
            
                 AddCountButtonColumn(post);
               
            
            
        }

        private void dgcUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
               
                if (dgcUserList.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    var selected = dgcUserList.Rows[e.RowIndex].DataBoundItem.GetType();
                    if (selected.Name == "User")
                    {
                        var selectedUser = (User)dgcUserList.Rows[e.RowIndex].DataBoundItem;
                        if (selectedUser != null && selectedUser.Id != _user.Id)
                        {
                            DialogResult result = MessageBox.Show(
                                $"Kullanıcı Adı: {selectedUser.Username}\nolan kullanıcıyı silmek istediğinize emin misiniz?",
                                "Kullanıcı Sil",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            );

                            if (result == DialogResult.Yes)
                            {
                                var allComplain = _postService.GetAllPostComplain().Where(x => x.UserId == selectedUser.Id).ToList();
                                foreach (var item in allComplain)
                                {
                                    _postService.DeletePostComplainWithUser(item.Id);
                                }
                                _userService.DeleteUser(selectedUser.Id);
                                LoadUserList();
                                MessageBox.Show("İşlem Başarılı");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Giriş yapan kullanıcıyı silemezsiniz.");
                        }
                    }
                    else if (selected.Name == "Post")
                    {
                        var selectedPost = (Post)dgcUserList.Rows[e.RowIndex].DataBoundItem;
                        if (selectedPost != null)
                        {
                            DialogResult result = MessageBox.Show(
                                $"Title: {selectedPost.Title}\nolan postu silmek istediğinize emin misiniz?",
                                "Post Sil",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            );

                            if (result == DialogResult.Yes)
                            {
                                var allComplain = _postService.GetAllPostComplain().Where(x => x.PostId == selectedPost.Id).ToList();
                                foreach (var item in allComplain)
                                {
                                    _postService.DeletePostComplainWithUser(item.Id);
                                }
                                _postService.DeletePost(selectedPost.Id);
                                LoadPostList(_post);
                                MessageBox.Show("İşlem Başarılı");
                            }
                        }
                    }
                }
            }
        }

        private void btnGetAllPost_Click(object sender, EventArgs e)
        {
            LoadPostList(_post);
            dgcUserList.Columns[3].Visible = false;
            dgcUserList.Columns[4].Visible = false;
            dgcUserList.Columns[5].Visible = false;
            dgcUserList.Columns[6].Visible = false;
            dgcUserList.Columns[8].Visible = false;
            dgcUserList.Columns[9].Visible = false;
        }

        private void btnGetAllUser_Click(object sender, EventArgs e)
        {
            LoadUserList();
           
        }
    }




}