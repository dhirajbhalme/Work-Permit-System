using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ManageVisitors.Models;
using System.Threading.Tasks;
using Firebase.Iid;

namespace ManageVisitors.Activities
{
    [Activity(Label = "ManageVisitors", MainLauncher = true, Icon = "@drawable/mahindralogo")]
    public class LogInMainActivity : Activity
    {
        Button btnDepartmentLogIn, btnVisitorLogIn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.LogInMainlayout);

            btnDepartmentLogIn = FindViewById<Button>(Resource.Id.btnDepartmentLogIn);
            btnVisitorLogIn = FindViewById<Button>(Resource.Id.btnVisitorLogIn);

            btnDepartmentLogIn.Click += BtnDepartmentLogIn_Click;
            btnVisitorLogIn.Click += BtnVisitorLogIn_Click;
        }

        private void BtnVisitorLogIn_Click(object sender, EventArgs e)
        {
            StatusModel.LoginUserStatus = 1;
            Intent intent = new Intent(this, typeof(LogInActivity));
            this.StartActivity(intent);
        }

        private void BtnDepartmentLogIn_Click(object sender, EventArgs e)
        {
            StatusModel.LoginUserStatus = 0;
            Intent intent = new Intent(this, typeof(LogInActivity));
            this.StartActivity(intent);
        }
    }
}