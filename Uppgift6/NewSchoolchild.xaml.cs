﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Uppgift6
{
    /// <summary>
    /// Interaction logic for NewSchoolchild.xaml
    /// </summary>
    public partial class NewSchoolchild : Window
    {
        public NewSchoolchild()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            DbOperations db = new DbOperations();
            string firstname = txtBoxFirstname.Text;
            string lastname = txtBoxLastname.Text;
            int section = int.Parse(txtBoxSection.Text);

            db.AddSchoolchild(firstname, lastname, section);
            
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            StaffChildren win = new StaffChildren();
            win.Show();
            this.Close();
        }
    }
}
