using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab7Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Member> members = new ObservableCollection<Member>();

        string[] types = new string[] { "Full", "Off Peak", "Student" };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboxMemberType.ItemsSource = types;

            int year1, year2;
            Random rng = new Random();
            year1 = rng.Next(2000, 2016);
            year2 = rng.Next(2000, 2016);

            Member m1 = new Member() { MemberName = "Emmet Carroll", MemberType = "Full", Joindate = new DateTime(year1, 11, 4) };
            Member m2 = new Member() { MemberName = "Vas Eline", MemberType = "Student", Joindate = new DateTime(year2, 6, 14) };

            members.Add(m1);
            members.Add(m2);

            lbxMember.ItemsSource = members;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string memberType = cboxMemberType.SelectedValue as string;
            string name = tbxName.Text;
            DateTime joinDate = dpDate.SelectedDate.Value;

            Member newMember = new Member() { MemberName = name, MemberType = memberType, Joindate = joinDate };

            Member.NumberofMembers++;

            members.Add(newMember);

            tblkNumberofMembers.Text = Member.NumberofMembers.ToString();

            ClearScreen();
        }

        private void ClearScreen()
        {
            cboxMemberType.SelectedIndex = -1;
            tbxName.Clear();
            dpDate.ClearValue(DatePicker.SelectedDateProperty);
        }
    }
  }

