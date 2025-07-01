using GalaSoft.MvvmLight.Command;
using LauncherLes1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace LauncherLes1.ViewModel
{
    internal class MainViewModel : ViewModedBase
    {
        private Page CB = new CBpage();
        private Page CB2 = new CB2page();
        private Page CBW = new CBWpage();
        private Page _CurPage = new CBpage();
        private Page CBASH = new CBASHpage();
        private Page CTR = new CTRpage();
        private Page Mod = new Modpage();
        private Page MGAMES = new MGAMESpage();
        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }
        public ICommand OpenCB2page
        {
            get
            {
                return new RelayCommand(() => CurPage = CB2);
            }
        }
        public ICommand OpenCBpage
        {
            get
            {
                return new RelayCommand(() => CurPage = CB);
            }
        }
        public ICommand OpenCBWpage
        {
            get
            {
                return new RelayCommand(() => CurPage = CBW);
            }
        }
        public ICommand OpenCBASHpage
        {
            get
            {
                return new RelayCommand(() => CurPage = CBASH);
            }
        }
        public ICommand OpenCTRpage
        {
            get
            {
                return new RelayCommand(() => CurPage = CTR);
            }
        }
        public ICommand OpenModpage
        {
            get
            {
                return new RelayCommand(() => CurPage = Mod);
            }
        }
        public ICommand OpenMGAMESpage
        {
            get
            {
                return new RelayCommand(() => CurPage = MGAMES);
            }
        }



    }
}
