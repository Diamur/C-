using System;
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

namespace VirtualClipBoard
{

	public partial class MainForm : Form
	{
	    String VirtualClipBoard_Name = "VirtualClipBoard"; // название программы
	    string content = ""; // Контент
	   
       // public String VirtualClipBoard_TARGET; // последний значение текстового БО
       // public String VirtualClipBoard_DAT; // путь к файлу истории
       // Dictionary<int, string> VirtualClipBoard_History = new Dictionary<int, string>(); // История нашего буфера
       // Dictionary<int, int> VirtualClipBoard_Index_ListBox; // список индексов в связки с ключами истории буфера

        // Подключение библиотек WIN
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
		
		public MainForm()
		{
			InitializeComponent();
			
			//===================================


          nextClipboardViewer = (IntPtr)SetClipboardViewer((IntPtr)this.Handle);

          //reload_tray(); // Обноавляемменю в трее
          //  reload_list_clipboard(); // Обновляем ListBox

          //  _notifyIcon.Text = VirtualClipBoard_Name;
         //    _notifyIcon.MouseDoubleClick += new MouseEventHandler(_notifyIcon_MouseDoubleClick);

			//==================================
		}
		

		
		void list_clipboard_SelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void autoload_CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void history_size_ValueChanged(object sender, EventArgs e)
		{
	
		}
		void size_tray_ValueChanged(object sender, EventArgs e)
		{
	
		}
		
		// Выход программы
		void exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
	
		}
		
		void clear_Click(object sender, EventArgs e)
		{
			//content="";
			Clipboard.Clear();
			
		}
		
		//====================================================
		      // Сворачивать в трей вместо закрытия программы
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            //ShowInTaskbar = false;
            Hide();
            WindowState = FormWindowState.Minimized;
        }

        // дескриптор окна
        private IntPtr nextClipboardViewer;

        // Константы
        public const int WM_DRAWCLIPBOARD = 0x308;
        public const int WM_CHANGECBCHAIN = 0x030D;
        
        //
        private void SetContent()
        {
        	if(Clipboard.GetText() != "")
        	{
        	content= Clipboard.GetText() + ";" + Environment.NewLine + content  ;
        	//Clipboard.SetText(content);
        	}
        	else content ="";
        	
        	tb_Content.Text= content;
        	
        }

        // Метод для реагирование на изменение вбуфере обмена и т.д.
        protected override void WndProc(ref Message m)
        {
            // Console.WriteLine("WndProc");
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    {
            			SetContent();
            			//tb_Content.Text= Clipboard.GetText();
            		
                       // ClipboardChanged();
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
                        //Console.WriteLine("Файл истории: " + VirtualClipBoard_DAT);
                        break;
                    }
            }
        }
		//====================================================
	}
}
