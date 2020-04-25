﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_WF.Models;
using CRUD_WF.Presentation;

namespace CRUD_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        
        #region HELPER
        public void Refresh()
        {
            using (DBPersonEntities1 db=new DBPersonEntities1())
            {
                //Linq
                var lst = from d in db.People
                          select d;

                dataGridView1.DataSource = lst.ToList();
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            frmPerson OfrmPErson = new frmPerson();
            OfrmPErson.ShowDialog();
            Refresh();
        }
    }



}
