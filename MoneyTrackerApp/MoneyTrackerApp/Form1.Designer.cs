namespace MoneyTrackerApp
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
      panel1 = new Panel();
      nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
      label1 = new Label();
      MenuButton = new PictureBox();
      SideBar = new FlowLayoutPanel();
      panel2 = new Panel();
      pictureBox1 = new PictureBox();
      button1 = new Button();
      panel3 = new Panel();
      pictureBox2 = new PictureBox();
      button2 = new Button();
      panel4 = new Panel();
      pictureBox3 = new PictureBox();
      button3 = new Button();
      panel5 = new Panel();
      pictureBox4 = new PictureBox();
      button4 = new Button();
      SidebarTimer = new System.Windows.Forms.Timer(components);
      panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)MenuButton).BeginInit();
      SideBar.SuspendLayout();
      panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
      panel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
      panel5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
      SuspendLayout();
      // 
      // panel1
      // 
      panel1.BackColor = Color.FromArgb(44, 44, 44);
      panel1.Controls.Add(nightControlBox1);
      panel1.Controls.Add(label1);
      panel1.Controls.Add(MenuButton);
      panel1.Dock = DockStyle.Top;
      panel1.Location = new Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(1046, 49);
      panel1.TabIndex = 0;
      panel1.MouseDown += panel1_MouseDown;
      panel1.MouseMove += panel1_MouseMove;
      panel1.MouseUp += panel1_MouseUp;
      // 
      // nightControlBox1
      // 
      nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      nightControlBox1.BackColor = Color.Transparent;
      nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
      nightControlBox1.CloseHoverForeColor = Color.White;
      nightControlBox1.DefaultLocation = true;
      nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
      nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
      nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
      nightControlBox1.EnableMaximizeButton = true;
      nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
      nightControlBox1.EnableMinimizeButton = true;
      nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
      nightControlBox1.Location = new Point(907, 0);
      nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
      nightControlBox1.MaximizeHoverForeColor = Color.White;
      nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
      nightControlBox1.MinimizeHoverForeColor = Color.White;
      nightControlBox1.Name = "nightControlBox1";
      nightControlBox1.Size = new Size(139, 31);
      nightControlBox1.TabIndex = 3;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Franklin Gothic Demi Cond", 15F, FontStyle.Regular, GraphicsUnit.Point);
      label1.Location = new Point(63, 9);
      label1.Name = "label1";
      label1.Size = new Size(42, 25);
      label1.TabIndex = 2;
      label1.Text = "App";
      // 
      // MenuButton
      // 
      MenuButton.BackColor = Color.Transparent;
      MenuButton.BackgroundImage = Properties.Resources.bars_solid;
      MenuButton.BackgroundImageLayout = ImageLayout.Stretch;
      MenuButton.Cursor = Cursors.Hand;
      MenuButton.Location = new Point(3, 3);
      MenuButton.Name = "MenuButton";
      MenuButton.Size = new Size(54, 43);
      MenuButton.TabIndex = 1;
      MenuButton.TabStop = false;
      MenuButton.Click += MenuButton_Click;
      // 
      // SideBar
      // 
      SideBar.BackColor = Color.FromArgb(30, 30, 30);
      SideBar.Controls.Add(panel2);
      SideBar.Controls.Add(panel3);
      SideBar.Controls.Add(panel4);
      SideBar.Controls.Add(panel5);
      SideBar.Dock = DockStyle.Left;
      SideBar.Location = new Point(0, 49);
      SideBar.Name = "SideBar";
      SideBar.Size = new Size(192, 581);
      SideBar.TabIndex = 1;
      // 
      // panel2
      // 
      panel2.BackColor = Color.Black;
      panel2.Controls.Add(pictureBox1);
      panel2.Controls.Add(button1);
      panel2.Location = new Point(0, 50);
      panel2.Margin = new Padding(0, 50, 0, 0);
      panel2.Name = "panel2";
      panel2.Size = new Size(192, 66);
      panel2.TabIndex = 2;
      // 
      // pictureBox1
      // 
      pictureBox1.BackColor = Color.FromArgb(30, 30, 30);
      pictureBox1.BackgroundImage = Properties.Resources.house_chimney_solid;
      pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
      pictureBox1.Enabled = false;
      pictureBox1.Location = new Point(12, 12);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(45, 42);
      pictureBox1.TabIndex = 7;
      pictureBox1.TabStop = false;
      // 
      // button1
      // 
      button1.BackColor = Color.FromArgb(30, 30, 30);
      button1.BackgroundImageLayout = ImageLayout.Stretch;
      button1.Cursor = Cursors.Hand;
      button1.Dock = DockStyle.Fill;
      button1.FlatAppearance.BorderSize = 0;
      button1.FlatStyle = FlatStyle.Flat;
      button1.Font = new Font("Franklin Gothic Demi Cond", 15F, FontStyle.Regular, GraphicsUnit.Point);
      button1.ForeColor = Color.White;
      button1.ImageAlign = ContentAlignment.MiddleLeft;
      button1.Location = new Point(0, 0);
      button1.Margin = new Padding(0);
      button1.Name = "button1";
      button1.Size = new Size(192, 66);
      button1.TabIndex = 0;
      button1.Text = "Main";
      button1.TextAlign = ContentAlignment.MiddleRight;
      button1.UseVisualStyleBackColor = false;
      button1.Click += button1_Click;
      // 
      // panel3
      // 
      panel3.BackColor = Color.Black;
      panel3.Controls.Add(pictureBox2);
      panel3.Controls.Add(button2);
      panel3.Location = new Point(0, 116);
      panel3.Margin = new Padding(0);
      panel3.Name = "panel3";
      panel3.Size = new Size(192, 66);
      panel3.TabIndex = 3;
      // 
      // pictureBox2
      // 
      pictureBox2.BackColor = Color.FromArgb(30, 30, 30);
      pictureBox2.BackgroundImage = Properties.Resources.calendar_regular;
      pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
      pictureBox2.Enabled = false;
      pictureBox2.Location = new Point(12, 12);
      pictureBox2.Name = "pictureBox2";
      pictureBox2.Size = new Size(45, 42);
      pictureBox2.TabIndex = 8;
      pictureBox2.TabStop = false;
      // 
      // button2
      // 
      button2.BackColor = Color.FromArgb(30, 30, 30);
      button2.Cursor = Cursors.Hand;
      button2.Dock = DockStyle.Fill;
      button2.FlatAppearance.BorderSize = 0;
      button2.FlatStyle = FlatStyle.Flat;
      button2.Font = new Font("Franklin Gothic Demi Cond", 15F, FontStyle.Regular, GraphicsUnit.Point);
      button2.ForeColor = Color.White;
      button2.ImageAlign = ContentAlignment.MiddleLeft;
      button2.Location = new Point(0, 0);
      button2.Margin = new Padding(0);
      button2.Name = "button2";
      button2.Size = new Size(192, 66);
      button2.TabIndex = 0;
      button2.Text = "Dashboard";
      button2.TextAlign = ContentAlignment.MiddleRight;
      button2.UseVisualStyleBackColor = false;
      button2.Click += button2_Click;
      // 
      // panel4
      // 
      panel4.BackColor = Color.Black;
      panel4.Controls.Add(pictureBox3);
      panel4.Controls.Add(button3);
      panel4.Location = new Point(0, 182);
      panel4.Margin = new Padding(0);
      panel4.Name = "panel4";
      panel4.Size = new Size(192, 66);
      panel4.TabIndex = 4;
      // 
      // pictureBox3
      // 
      pictureBox3.BackColor = Color.FromArgb(30, 30, 30);
      pictureBox3.BackgroundImage = Properties.Resources.rectangle_list_regular;
      pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
      pictureBox3.Enabled = false;
      pictureBox3.Location = new Point(12, 12);
      pictureBox3.Name = "pictureBox3";
      pictureBox3.Size = new Size(45, 42);
      pictureBox3.TabIndex = 9;
      pictureBox3.TabStop = false;
      // 
      // button3
      // 
      button3.BackColor = Color.FromArgb(30, 30, 30);
      button3.Cursor = Cursors.Hand;
      button3.Dock = DockStyle.Fill;
      button3.FlatAppearance.BorderSize = 0;
      button3.FlatStyle = FlatStyle.Flat;
      button3.Font = new Font("Franklin Gothic Demi Cond", 15F, FontStyle.Regular, GraphicsUnit.Point);
      button3.ForeColor = Color.White;
      button3.ImageAlign = ContentAlignment.MiddleLeft;
      button3.Location = new Point(0, 0);
      button3.Margin = new Padding(0);
      button3.Name = "button3";
      button3.Size = new Size(192, 66);
      button3.TabIndex = 0;
      button3.Text = "Summary";
      button3.TextAlign = ContentAlignment.MiddleRight;
      button3.UseVisualStyleBackColor = false;
      button3.Click += button3_Click;
      // 
      // panel5
      // 
      panel5.BackColor = Color.Black;
      panel5.Controls.Add(pictureBox4);
      panel5.Controls.Add(button4);
      panel5.Location = new Point(0, 248);
      panel5.Margin = new Padding(0);
      panel5.Name = "panel5";
      panel5.Size = new Size(192, 66);
      panel5.TabIndex = 5;
      // 
      // pictureBox4
      // 
      pictureBox4.BackColor = Color.FromArgb(30, 30, 30);
      pictureBox4.BackgroundImage = Properties.Resources.gear_solid;
      pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
      pictureBox4.Enabled = false;
      pictureBox4.Location = new Point(12, 12);
      pictureBox4.Name = "pictureBox4";
      pictureBox4.Size = new Size(45, 42);
      pictureBox4.TabIndex = 10;
      pictureBox4.TabStop = false;
      // 
      // button4
      // 
      button4.BackColor = Color.FromArgb(30, 30, 30);
      button4.Cursor = Cursors.Hand;
      button4.Dock = DockStyle.Fill;
      button4.FlatAppearance.BorderSize = 0;
      button4.FlatStyle = FlatStyle.Flat;
      button4.Font = new Font("Franklin Gothic Demi Cond", 15F, FontStyle.Regular, GraphicsUnit.Point);
      button4.ForeColor = Color.White;
      button4.ImageAlign = ContentAlignment.MiddleLeft;
      button4.Location = new Point(0, 0);
      button4.Margin = new Padding(0);
      button4.Name = "button4";
      button4.RightToLeft = RightToLeft.No;
      button4.Size = new Size(192, 66);
      button4.TabIndex = 0;
      button4.Text = "Options";
      button4.TextAlign = ContentAlignment.MiddleRight;
      button4.UseVisualStyleBackColor = false;
      button4.Click += button4_Click;
      // 
      // SidebarTimer
      // 
      SidebarTimer.Interval = 10;
      SidebarTimer.Tick += timer1_Tick;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoSize = true;
      ClientSize = new Size(1046, 630);
      Controls.Add(SideBar);
      Controls.Add(panel1);
      FormBorderStyle = FormBorderStyle.None;
      IsMdiContainer = true;
      Name = "Form1";
      Text = "Form1";
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)MenuButton).EndInit();
      SideBar.ResumeLayout(false);
      panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      panel3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
      panel4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
      panel5.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
      ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private PictureBox MenuButton;
    private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    private FlowLayoutPanel SideBar;
    private Panel panel2;
    private Button button1;
    private Panel panel3;
    private Button button2;
    private Panel panel4;
    private Button button3;
    private Panel panel5;
    private Button button4;
    private System.Windows.Forms.Timer SidebarTimer;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private PictureBox pictureBox3;
    private PictureBox pictureBox4;
  }
}