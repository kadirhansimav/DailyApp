using DailyApp.Entities;
using DailyApp.Services.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DailyApp.Web
{
    public partial class Form1 : Form
    {
        EventService _eventService = new EventService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            var events = _eventService.GetAll();
            if (events != null)
            {
                DgvData.DataSource = events;
            }
            
        }

        private void ButtonNewDaily_Click(object sender, EventArgs e)
        {
            _eventService.Add(new Event
            {
                Title = TbxTitleNewDaily.Text,
                Description = TbxDescriptionNewDaily.Text,
                IsDone = CbxIsDoneNewDaily.Checked,
                 

            });
            UpdateDataGrid();
            MessageBox.Show("Daily Added!!");
        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TbxDescriptionUpdateDaily.Text = DgvData.CurrentRow.Cells[2].Value.ToString();
            TbxTitleUpdateDaily.Text = DgvData.CurrentRow.Cells[1].Value.ToString();
            
            if( DgvData.CurrentRow.Cells[6].Value.ToString()=="True")
            {
                CbxIsDoneUpdateDaily.Checked = true;
            }

        }

        private void ButtonUpdateDaily_Click(object sender, EventArgs e)
        {

            _eventService.Update(new Event
            {
                Id = Convert.ToInt32(DgvData.CurrentRow.Cells[0].Value),
                Title = TbxTitleUpdateDaily.Text,
                Description = TbxDescriptionUpdateDaily.Text,
                IsDone = CbxIsDoneUpdateDaily.Checked,
                IsDeleted = false,
                CreatedDate =Convert.ToDateTime(DgvData.CurrentRow.Cells[3].Value),
               

            }) ;
            UpdateDataGrid();
            MessageBox.Show("Daily Update!!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DgvData.CurrentRow.Cells[0].Value);
            _eventService.Delete(new Event
            {
                Id = id
            });
            UpdateDataGrid();
            MessageBox.Show("Daily Deleted!!");
        }
        private void SearchEvent(string key)
        {
            // dataGridView1.DataSource = _productDal.GetAll().Where(p=>p.Name.Contains(key)).ToList();
            var result = _eventService.SearchWithName(key);
            DgvData.DataSource = result;
           
        }
        private void TbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchEvent(TbxSearch.Text);
        }
    }
}
