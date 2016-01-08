using System;
using MyClipBoard.BL;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Data.Sql;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Windows;


namespace MyClipBoard
{
// Копировать отсюда==========            
     public class Presenter
    {
        private readonly IMainForm _view;
        private readonly IModel _model;
        private readonly IMessageService _messageService;
// собственные поля для многократного использования в этом классе 
		private string content;
// Подключение библиотек WIN
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        
        // дескриптор окна
        private IntPtr nextClipboardViewer;

        // Константы
        public const int WM_DRAWCLIPBOARD = 0x308;
        public const int WM_CHANGECBCHAIN = 0x030D;
        
        
        
        public Presenter( IMainForm view, IModel model, IMessageService messageService)
        {
            _view = view;
            _model = model;
            _messageService = messageService;
            
            nextClipboardViewer = (IntPtr)SetClipboardViewer((IntPtr)this.Handle);
            
        //События которые нужно залить слить обсчитать
        // _view.FileOPenClick += new EventHandler(_view_FileOPenClick);
        _view.b_ClearClick+= new EventHandler(_view_b_ClearClick);
        _view.b_CopyClick+=new EventHandler(_view_b_CopyClick);
        
        // Задание параметров формы при первоначальном запуске программы
        
        }

		void _view_b_ClearClick(object sender, EventArgs e)
		{
			_view.Bufer="";
		}

		void _view_b_CopyClick(object sender, EventArgs e)
		{
			content = _view.Content;
			
			_view.Bufer=content ;
			
			_view.SetContent();
			
		}
		
        
        // Метод для реагирование на изменение вбуфере обмена и т.д.
        protected override void WndProc(ref Message m)
        {
            // Console.WriteLine("WndProc");
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    {
                        ClipboardChanged();
                        //Console.WriteLine("WM_DRAWCLIPBOARD ClipboardChanged();");
                        SendMessage(nextClipboardViewer, WM_DRAWCLIPBOARD, m.WParam, m.LParam);
                        break;
                    }
                case WM_CHANGECBCHAIN:
                    {
                        if (m.WParam == nextClipboardViewer)
                        {
                            nextClipboardViewer = m.LParam;
                        }
                        else
                        {
                            SendMessage(nextClipboardViewer, WM_CHANGECBCHAIN, m.WParam, m.LParam);
                        }
                        m.Result = IntPtr.Zero;
                        break;
                    }
                default:
                    {
                        base.WndProc(ref m);
                        break;
                    }
            }
        }
        
        
         private void SetContent()
        {
         	if(_view.Bufer != "")
            {
            content= _view.Bufer  + ";" + Environment.NewLine + content  ;
            //Clipboard.SetText(content);
            }
            else content ="";
            
            _view.Content = content;
            
        }
        
        
        
    }
}