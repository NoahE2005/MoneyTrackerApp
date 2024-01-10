using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;
using MoneyTrackerApp.Assests;
using MoneyTrackerApp.Assests.Expenses;
using MoneyTrackerApp.Assests.Language;

namespace MoneyTrackerApp
{
  public partial class Form1 : Form
  {
    Tabs.MainForm Main;
    Tabs.FormDashboard Dashboard;
    Tabs.FormSummary Summary;
    Tabs.FormOptions Options;

    bool MouseDown;

    #region Rounded form corners
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn
    (
      int nLeftRect,     // x-coordinate of upper-left corner
      int nTopRect,      // y-coordinate of upper-left corner
      int nRightRect,    // x-coordinate of lower-right corner
      int nBottomRect,   // y-coordinate of lower-right corner
      int nWidthEllipse, // width of ellipse
      int nHeightEllipse // height of ellipse
    );
    #endregion

    public Form1()
    {
      InitializeComponent();
      Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
      string textFilePath = TextFileHandler.GetTextFilePath()[0];
      Image MyImage = null;

      if (Main == null)
      {
        Main = new Tabs.MainForm();
        Main.FormClosed += Main_FormClosed;
        Main.MdiParent = this;
        Main.Dock = DockStyle.Fill;
        Main.Show();
      }
      else
      {
        Main.Activate();
      }

      LoadLocalizedResources();

      #region SettingsInit
      var Settings = new Dictionary<string, string>(SettingsHandler.GetAllConfig());

      if (Settings["StartMinimized"] == "True")
      {
        this.WindowState = FormWindowState.Minimized;
      }
      #endregion

      #region LanguageChange

      button1.Text = localizedResources.BtnMain;
      button2.Text = localizedResources.BtnDashboard;
      button3.Text = localizedResources.BtnSummary;
      button4.Text = localizedResources.BtnOptions;

      #endregion
    }

    private static dynamic localizedResources;
    private void LoadLocalizedResources()
    {
      //ResourceHandler resourceHandler = new ResourceHandler();
      localizedResources = ResourceHandler.LoadResourceFile();

    }

    bool SidebarExpand = true;

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (SidebarExpand)
      {
        SideBar.Width -= 10;
        if (SideBar.Width <= 72)
        {
          SidebarExpand = false;
          SidebarTimer.Stop();
        }
      }
      else
      {
        SideBar.Width += 10;
        if (SideBar.Width >= 192)
        {
          SidebarExpand = true;
          SidebarTimer.Stop();
        }
      }

    }

    private void MenuButton_Click(object sender, EventArgs e)
    {
      SidebarTimer.Start();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (Main == null)
      {
        Main = new Tabs.MainForm();
        Main.FormClosed += Main_FormClosed;
        Main.MdiParent = this;
        Main.Dock = DockStyle.Fill;
        Main.Show();
      }
      else
      {
        Main.Activate();
      }
    }

    private void Main_FormClosed(object? sender, FormClosedEventArgs e)
    {
      Main = null;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (Dashboard == null)
      {
        Dashboard = new Tabs.FormDashboard();
        Dashboard.FormClosed += Dashboard_FormClosed;
        Dashboard.MdiParent = this;
        Dashboard.Dock = DockStyle.Fill;
        Dashboard.Show();
      }
      else
      {
        Dashboard.Activate();
      }
    }

    private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
    {
      Dashboard = null;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (Summary == null)
      {
        Summary = new Tabs.FormSummary();
        Summary.FormClosed += Summary_FormClosed;
        Summary.MdiParent = this;
        Summary.Dock = DockStyle.Fill;
        Summary.Show();
      }
      else
      {
        Summary.Activate();
      }
    }

    private void Summary_FormClosed(object? sender, FormClosedEventArgs e)
    {
      Summary = null;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (Options == null)
      {
        Options = new Tabs.FormOptions();
        Options.FormClosed += Options_FormClosed;
        Options.MdiParent = this;
        Options.Dock = DockStyle.Fill;
        Options.Show();
      }
      else
      {
        Options.Activate();
      }
    }

    private void Options_FormClosed(object? sender, FormClosedEventArgs e)
    {
      Options = null;
    }

    #region Relative app dragging
    private bool isDragging = false;
    private Point offset;

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        isDragging = true;
        offset = e.Location;
      }
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (isDragging)
      {
        Point newLocation = this.PointToScreen(e.Location);
        newLocation.Offset(-offset.X, -offset.Y);
        this.Location = newLocation;
      }
    }

    private void panel1_MouseUp(object sender, MouseEventArgs e)
    {
      isDragging = false;
    }
    #endregion
  }
}