using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.Lang;

namespace XGPush.Droid
{
    [Activity(Label = "XGPush", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            new CallBack().Init();
            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new App());
            Com.Tencent.Android.Tpush.XGPushManager.RegisterPush(this, new CallBack());
        }

        public class CallBack : Java.Lang.Object, Com.Tencent.Android.Tpush.IXGIOperateCallback
        {
            public CallBack()
            {
            }
            public void OnFail(Java.Lang.Object p0, int p1, string p2)
            {
                throw new NotImplementedException();
            }

            public void OnSuccess(Java.Lang.Object p0, int p1)
            {
                var aaa = p0.ToString();
                var bb = p1;
            }

            public void Init()
            {
                var dt = DateTime.Now;
            }
        }
    }
}