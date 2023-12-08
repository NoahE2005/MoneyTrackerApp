namespace MoneyTrackerApp.Tabs
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      listViewMinus = new ListView();
      listViewPlus = new ListView();
      panel1 = new Panel();
      panel4 = new Panel();
      tableLayoutPanel3 = new TableLayoutPanel();
      tableLayoutPanel4 = new TableLayoutPanel();
      MoneySum = new Label();
      panel2 = new Panel();
      tableLayoutPanel2 = new TableLayoutPanel();
      panel5 = new Panel();
      GoalPanel = new Panel();
      GoalSubmit = new Button();
      GoalAmount = new TextBox();
      GoalLabel = new Label();
      GoalProgressBar1 = new ReaLTaiizor.Controls.CircleProgressBar();
      panel3 = new Panel();
      AddDataSubmitButton = new Button();
      label1 = new Label();
      tableLayoutPanel1 = new TableLayoutPanel();
      AddDataText = new TextBox();
      PlusMinusComboBox = new ComboBox();
      AddDataAmount = new TextBox();
      panel1.SuspendLayout();
      panel4.SuspendLayout();
      tableLayoutPanel3.SuspendLayout();
      tableLayoutPanel4.SuspendLayout();
      panel2.SuspendLayout();
      tableLayoutPanel2.SuspendLayout();
      panel5.SuspendLayout();
      GoalPanel.SuspendLayout();
      panel3.SuspendLayout();
      tableLayoutPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // listViewMinus
      // 
      listViewMinus.BackColor = Color.FromArgb(54, 54, 54);
      listViewMinus.Dock = DockStyle.Fill;
      listViewMinus.Font = new Font("Franklin Gothic Demi Cond", 20F, FontStyle.Bold, GraphicsUnit.Point);
      listViewMinus.ForeColor = Color.FromArgb(192, 0, 0);
      listViewMinus.GridLines = true;
      listViewMinus.HeaderStyle = ColumnHeaderStyle.None;
      listViewMinus.Location = new Point(206, 8);
      listViewMinus.Margin = new Padding(8);
      listViewMinus.Name = "listViewMinus";
      listViewMinus.Size = new Size(183, 338);
      listViewMinus.TabIndex = 0;
      listViewMinus.UseCompatibleStateImageBehavior = false;
      listViewMinus.View = View.List;
      // 
      // listViewPlus
      // 
      listViewPlus.BackColor = Color.FromArgb(54, 54, 54);
      listViewPlus.Dock = DockStyle.Fill;
      listViewPlus.Font = new Font("Franklin Gothic Demi Cond", 20F, FontStyle.Bold, GraphicsUnit.Point);
      listViewPlus.ForeColor = Color.FromArgb(0, 192, 0);
      listViewPlus.GridLines = true;
      listViewPlus.HeaderStyle = ColumnHeaderStyle.None;
      listViewPlus.Location = new Point(8, 8);
      listViewPlus.Margin = new Padding(8);
      listViewPlus.MultiSelect = false;
      listViewPlus.Name = "listViewPlus";
      listViewPlus.Size = new Size(182, 338);
      listViewPlus.TabIndex = 1;
      listViewPlus.UseCompatibleStateImageBehavior = false;
      listViewPlus.View = View.List;
      // 
      // panel1
      // 
      panel1.AutoSize = true;
      panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      panel1.BackColor = Color.FromArgb(44, 44, 44);
      panel1.Controls.Add(panel4);
      panel1.Dock = DockStyle.Fill;
      panel1.Location = new Point(397, 0);
      panel1.Margin = new Padding(10);
      panel1.Name = "panel1";
      panel1.Size = new Size(403, 450);
      panel1.TabIndex = 2;
      // 
      // panel4
      // 
      panel4.AutoSize = true;
      panel4.BackColor = Color.FromArgb(34, 34, 34);
      panel4.Controls.Add(tableLayoutPanel3);
      panel4.Dock = DockStyle.Fill;
      panel4.Location = new Point(0, 0);
      panel4.Margin = new Padding(10);
      panel4.Name = "panel4";
      panel4.Size = new Size(403, 450);
      panel4.TabIndex = 3;
      // 
      // tableLayoutPanel3
      // 
      tableLayoutPanel3.ColumnCount = 1;
      tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
      tableLayoutPanel3.Controls.Add(MoneySum, 0, 1);
      tableLayoutPanel3.Dock = DockStyle.Fill;
      tableLayoutPanel3.Location = new Point(0, 0);
      tableLayoutPanel3.Margin = new Padding(15);
      tableLayoutPanel3.Name = "tableLayoutPanel3";
      tableLayoutPanel3.RowCount = 2;
      tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
      tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
      tableLayoutPanel3.Size = new Size(403, 450);
      tableLayoutPanel3.TabIndex = 3;
      // 
      // tableLayoutPanel4
      // 
      tableLayoutPanel4.ColumnCount = 2;
      tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      tableLayoutPanel4.Controls.Add(listViewPlus, 0, 0);
      tableLayoutPanel4.Controls.Add(listViewMinus, 1, 0);
      tableLayoutPanel4.Dock = DockStyle.Fill;
      tableLayoutPanel4.Location = new Point(3, 3);
      tableLayoutPanel4.Name = "tableLayoutPanel4";
      tableLayoutPanel4.RowCount = 1;
      tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel4.Size = new Size(397, 354);
      tableLayoutPanel4.TabIndex = 4;
      // 
      // MoneySum
      // 
      MoneySum.AutoSize = true;
      MoneySum.Dock = DockStyle.Top;
      MoneySum.Font = new Font("Franklin Gothic Demi Cond", 15F, FontStyle.Regular, GraphicsUnit.Point);
      MoneySum.ForeColor = Color.White;
      MoneySum.Location = new Point(3, 360);
      MoneySum.Name = "MoneySum";
      MoneySum.Size = new Size(397, 25);
      MoneySum.TabIndex = 2;
      MoneySum.Text = "Sum: ....";
      MoneySum.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // panel2
      // 
      panel2.BackColor = Color.FromArgb(44, 44, 44);
      panel2.Controls.Add(tableLayoutPanel2);
      panel2.Dock = DockStyle.Left;
      panel2.Location = new Point(0, 0);
      panel2.MinimumSize = new Size(100, 0);
      panel2.Name = "panel2";
      panel2.Size = new Size(397, 450);
      panel2.TabIndex = 3;
      // 
      // tableLayoutPanel2
      // 
      tableLayoutPanel2.ColumnCount = 1;
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
      tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
      tableLayoutPanel2.Controls.Add(panel5, 0, 1);
      tableLayoutPanel2.Controls.Add(panel3, 0, 0);
      tableLayoutPanel2.Dock = DockStyle.Fill;
      tableLayoutPanel2.Location = new Point(0, 0);
      tableLayoutPanel2.Name = "tableLayoutPanel2";
      tableLayoutPanel2.RowCount = 2;
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      tableLayoutPanel2.Size = new Size(397, 450);
      tableLayoutPanel2.TabIndex = 6;
      // 
      // panel5
      // 
      panel5.AutoSize = true;
      panel5.BackColor = Color.FromArgb(34, 34, 34);
      panel5.Controls.Add(GoalPanel);
      panel5.Controls.Add(GoalLabel);
      panel5.Controls.Add(GoalProgressBar1);
      panel5.Dock = DockStyle.Fill;
      panel5.Location = new Point(10, 235);
      panel5.Margin = new Padding(10);
      panel5.Name = "panel5";
      panel5.Size = new Size(377, 205);
      panel5.TabIndex = 5;
      // 
      // GoalPanel
      // 
      GoalPanel.Controls.Add(GoalSubmit);
      GoalPanel.Controls.Add(GoalAmount);
      GoalPanel.Location = new Point(71, 43);
      GoalPanel.Name = "GoalPanel";
      GoalPanel.Size = new Size(200, 35);
      GoalPanel.TabIndex = 2;
      // 
      // GoalSubmit
      // 
      GoalSubmit.Font = new Font("Franklin Gothic Demi Cond", 10F, FontStyle.Regular, GraphicsUnit.Point);
      GoalSubmit.Location = new Point(137, 3);
      GoalSubmit.Name = "GoalSubmit";
      GoalSubmit.Size = new Size(60, 23);
      GoalSubmit.TabIndex = 1;
      GoalSubmit.Text = "Submit";
      GoalSubmit.UseVisualStyleBackColor = true;
      GoalSubmit.Click += GoalSubmit_Click;
      // 
      // GoalAmount
      // 
      GoalAmount.BackColor = Color.FromArgb(64, 64, 64);
      GoalAmount.Dock = DockStyle.Left;
      GoalAmount.Font = new Font("Franklin Gothic Demi Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
      GoalAmount.ForeColor = Color.White;
      GoalAmount.Location = new Point(0, 0);
      GoalAmount.Name = "GoalAmount";
      GoalAmount.Size = new Size(131, 21);
      GoalAmount.TabIndex = 0;
      GoalAmount.KeyPress += GoalAmount_KeyPress;
      // 
      // GoalLabel
      // 
      GoalLabel.AutoSize = true;
      GoalLabel.Font = new Font("Franklin Gothic Demi Cond", 10F, FontStyle.Bold, GraphicsUnit.Point);
      GoalLabel.ForeColor = Color.White;
      GoalLabel.Location = new Point(60, 22);
      GoalLabel.Margin = new Padding(0);
      GoalLabel.Name = "GoalLabel";
      GoalLabel.Size = new Size(243, 18);
      GoalLabel.TabIndex = 1;
      GoalLabel.Text = "This is how close you are to your goal";
      GoalLabel.TextAlign = ContentAlignment.TopCenter;
      // 
      // GoalProgressBar1
      // 
      GoalProgressBar1.Font = new Font("Franklin Gothic Demi Cond", 15F, FontStyle.Regular, GraphicsUnit.Point);
      GoalProgressBar1.Location = new Point(92, 69);
      GoalProgressBar1.Maximum = 100L;
      GoalProgressBar1.MinimumSize = new Size(100, 100);
      GoalProgressBar1.Name = "GoalProgressBar1";
      GoalProgressBar1.PercentColor = Color.White;
      GoalProgressBar1.ProgressColor1 = Color.FromArgb(128, 255, 255);
      GoalProgressBar1.ProgressColor2 = Color.FromArgb(0, 192, 192);
      GoalProgressBar1.ProgressShape = ReaLTaiizor.Controls.CircleProgressBar._ProgressShape.Round;
      GoalProgressBar1.Size = new Size(130, 130);
      GoalProgressBar1.TabIndex = 0;
      GoalProgressBar1.Text = "circleProgressBar1";
      GoalProgressBar1.Value = 0L;
      // 
      // panel3
      // 
      panel3.AutoSize = true;
      panel3.BackColor = Color.FromArgb(34, 34, 34);
      panel3.Controls.Add(AddDataSubmitButton);
      panel3.Controls.Add(label1);
      panel3.Controls.Add(tableLayoutPanel1);
      panel3.Dock = DockStyle.Fill;
      panel3.Location = new Point(10, 10);
      panel3.Margin = new Padding(10);
      panel3.Name = "panel3";
      panel3.Size = new Size(377, 205);
      panel3.TabIndex = 4;
      // 
      // AddDataSubmitButton
      // 
      AddDataSubmitButton.Cursor = Cursors.Hand;
      AddDataSubmitButton.ForeColor = Color.White;
      AddDataSubmitButton.Location = new Point(120, 126);
      AddDataSubmitButton.Name = "AddDataSubmitButton";
      AddDataSubmitButton.Size = new Size(142, 46);
      AddDataSubmitButton.TabIndex = 2;
      AddDataSubmitButton.Text = "Submit";
      AddDataSubmitButton.UseVisualStyleBackColor = true;
      AddDataSubmitButton.Click += AddDataSubmitButton_Click;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Franklin Gothic Demi Cond", 20F, FontStyle.Bold, GraphicsUnit.Point);
      label1.ForeColor = Color.White;
      label1.Location = new Point(92, 38);
      label1.Name = "label1";
      label1.Size = new Size(170, 34);
      label1.TabIndex = 3;
      label1.Text = "Type new here";
      label1.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 3;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
      tableLayoutPanel1.Controls.Add(AddDataText, 2, 0);
      tableLayoutPanel1.Controls.Add(PlusMinusComboBox, 0, 0);
      tableLayoutPanel1.Controls.Add(AddDataAmount, 1, 0);
      tableLayoutPanel1.Location = new Point(39, 75);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      tableLayoutPanel1.Size = new Size(281, 45);
      tableLayoutPanel1.TabIndex = 1;
      // 
      // AddDataText
      // 
      AddDataText.BackColor = Color.FromArgb(64, 64, 64);
      AddDataText.Font = new Font("Franklin Gothic Demi Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
      AddDataText.ForeColor = Color.White;
      AddDataText.Location = new Point(171, 15);
      AddDataText.Margin = new Padding(3, 15, 3, 3);
      AddDataText.Name = "AddDataText";
      AddDataText.Size = new Size(107, 21);
      AddDataText.TabIndex = 2;
      // 
      // PlusMinusComboBox
      // 
      PlusMinusComboBox.BackColor = Color.FromArgb(64, 64, 64);
      PlusMinusComboBox.FlatStyle = FlatStyle.Flat;
      PlusMinusComboBox.Font = new Font("Franklin Gothic Demi Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
      PlusMinusComboBox.ForeColor = Color.White;
      PlusMinusComboBox.FormattingEnabled = true;
      PlusMinusComboBox.Items.AddRange(new object[] { "+", "-" });
      PlusMinusComboBox.Location = new Point(3, 15);
      PlusMinusComboBox.Margin = new Padding(3, 15, 3, 3);
      PlusMinusComboBox.Name = "PlusMinusComboBox";
      PlusMinusComboBox.Size = new Size(50, 24);
      PlusMinusComboBox.TabIndex = 0;
      // 
      // AddDataAmount
      // 
      AddDataAmount.AcceptsTab = true;
      AddDataAmount.BackColor = Color.FromArgb(64, 64, 64);
      AddDataAmount.CharacterCasing = CharacterCasing.Lower;
      AddDataAmount.Font = new Font("Franklin Gothic Demi Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
      AddDataAmount.ForeColor = Color.White;
      AddDataAmount.Location = new Point(59, 15);
      AddDataAmount.Margin = new Padding(3, 15, 3, 3);
      AddDataAmount.Name = "AddDataAmount";
      AddDataAmount.Size = new Size(106, 21);
      AddDataAmount.TabIndex = 1;
      AddDataAmount.KeyPress += AddDataAmount_KeyPress;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoSize = true;
      ClientSize = new Size(800, 450);
      Controls.Add(panel1);
      Controls.Add(panel2);
      FormBorderStyle = FormBorderStyle.None;
      Name = "MainForm";
      Text = "MainForm";
      Load += MainForm_Load;
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      panel4.ResumeLayout(false);
      tableLayoutPanel3.ResumeLayout(false);
      tableLayoutPanel3.PerformLayout();
      tableLayoutPanel4.ResumeLayout(false);
      panel2.ResumeLayout(false);
      tableLayoutPanel2.ResumeLayout(false);
      tableLayoutPanel2.PerformLayout();
      panel5.ResumeLayout(false);
      panel5.PerformLayout();
      GoalPanel.ResumeLayout(false);
      GoalPanel.PerformLayout();
      panel3.ResumeLayout(false);
      panel3.PerformLayout();
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private ListView listViewMinus;
    private ListView listViewPlus;
    private Panel panel1;
    private Panel panel2;
    private TableLayoutPanel tableLayoutPanel1;
    private ComboBox PlusMinusComboBox;
    private TextBox AddDataText;
    private TextBox AddDataAmount;
    private Button AddDataSubmitButton;
    private Label label1;
    private Label MoneySum;
    private Panel panel3;
    private Panel panel4;
    private Panel panel5;
    private Label GoalLabel;
    private ReaLTaiizor.Controls.CircleProgressBar GoalProgressBar1;
    private Panel GoalPanel;
    private Button GoalSubmit;
    private TextBox GoalAmount;
    private TableLayoutPanel tableLayoutPanel2;
    private TableLayoutPanel tableLayoutPanel3;
    private TableLayoutPanel tableLayoutPanel4;
  }
}