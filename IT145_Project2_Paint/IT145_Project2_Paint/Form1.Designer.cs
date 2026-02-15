namespace IT145_Project2_Paint
{
    partial class PaintForm
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
            Paint_Panel = new Panel();
            GenShapeButton = new Button();
            LengthLabel = new Label();
            HeightLabel = new Label();
            PositionLabel = new Label();
            ColorButton = new Button();
            ColorPreviewPanel = new Panel();
            ColorDialogShape = new ColorDialog();
            ExitButton = new Button();
            ResetButton = new Button();
            HeightNumeric = new NumericUpDown();
            LengthNumeric = new NumericUpDown();
            InstructionsButton = new Button();
            CoordXUpDown = new NumericUpDown();
            CoordYUpDown = new NumericUpDown();
            ShapeComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)HeightNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LengthNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CoordXUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CoordYUpDown).BeginInit();
            SuspendLayout();
            // 
            // Paint_Panel
            // 
            Paint_Panel.BackColor = SystemColors.Control;
            Paint_Panel.Location = new Point(25, 25);
            Paint_Panel.Name = "Paint_Panel";
            Paint_Panel.Size = new Size(500, 500);
            Paint_Panel.TabIndex = 0;
            Paint_Panel.MouseClick += Paint_Panel_MouseClick;
            Paint_Panel.MouseDown += Paint_Panel_MouseDown;
            Paint_Panel.MouseMove += Paint_Panel_MouseMove;
            Paint_Panel.MouseUp += Paint_Panel_MouseUp;
            // 
            // GenShapeButton
            // 
            GenShapeButton.Location = new Point(800, 500);
            GenShapeButton.Name = "GenShapeButton";
            GenShapeButton.Size = new Size(150, 30);
            GenShapeButton.TabIndex = 1;
            GenShapeButton.Text = "Generate Shape";
            GenShapeButton.UseVisualStyleBackColor = true;
            GenShapeButton.Click += GenShapeButton_Click;
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Font = new Font("Segoe UI", 11F);
            LengthLabel.Location = new Point(724, 446);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(70, 25);
            LengthLabel.TabIndex = 5;
            LengthLabel.Text = "Length";
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Font = new Font("Segoe UI", 11F);
            HeightLabel.Location = new Point(726, 413);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(68, 25);
            HeightLabel.TabIndex = 6;
            HeightLabel.Text = "Height";
            // 
            // PositionLabel
            // 
            PositionLabel.AutoSize = true;
            PositionLabel.Font = new Font("Segoe UI", 11F);
            PositionLabel.Location = new Point(676, 380);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new Size(118, 25);
            PositionLabel.TabIndex = 7;
            PositionLabel.Text = "Position(x, y)";
            // 
            // ColorButton
            // 
            ColorButton.Location = new Point(800, 346);
            ColorButton.Name = "ColorButton";
            ColorButton.Size = new Size(94, 29);
            ColorButton.TabIndex = 10;
            ColorButton.Text = "Pick Color";
            ColorButton.UseVisualStyleBackColor = true;
            ColorButton.Click += ColorButton_Click;
            // 
            // ColorPreviewPanel
            // 
            ColorPreviewPanel.Location = new Point(900, 346);
            ColorPreviewPanel.Name = "ColorPreviewPanel";
            ColorPreviewPanel.Size = new Size(50, 29);
            ColorPreviewPanel.TabIndex = 11;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(876, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 12;
            ExitButton.Text = "&Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(531, 25);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 29);
            ResetButton.TabIndex = 13;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // HeightNumeric
            // 
            HeightNumeric.Location = new Point(800, 415);
            HeightNumeric.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            HeightNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            HeightNumeric.Name = "HeightNumeric";
            HeightNumeric.Size = new Size(150, 27);
            HeightNumeric.TabIndex = 14;
            HeightNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // LengthNumeric
            // 
            LengthNumeric.Location = new Point(800, 448);
            LengthNumeric.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            LengthNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            LengthNumeric.Name = "LengthNumeric";
            LengthNumeric.Size = new Size(150, 27);
            LengthNumeric.TabIndex = 15;
            LengthNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // InstructionsButton
            // 
            InstructionsButton.Location = new Point(631, 25);
            InstructionsButton.Name = "InstructionsButton";
            InstructionsButton.Size = new Size(94, 29);
            InstructionsButton.TabIndex = 16;
            InstructionsButton.Text = "Instructions";
            InstructionsButton.UseVisualStyleBackColor = true;
            InstructionsButton.Click += InstructionsButton_Click;
            // 
            // CoordXUpDown
            // 
            CoordXUpDown.Location = new Point(800, 383);
            CoordXUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            CoordXUpDown.Name = "CoordXUpDown";
            CoordXUpDown.Size = new Size(70, 27);
            CoordXUpDown.TabIndex = 18;
            CoordXUpDown.ValueChanged += CoordXUpDown_ValueChanged;
            // 
            // CoordYUpDown
            // 
            CoordYUpDown.Location = new Point(880, 383);
            CoordYUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            CoordYUpDown.Name = "CoordYUpDown";
            CoordYUpDown.Size = new Size(70, 27);
            CoordYUpDown.TabIndex = 19;
            CoordYUpDown.ValueChanged += CoordYUpDown_ValueChanged;
            // 
            // ShapeComboBox
            // 
            ShapeComboBox.FormattingEnabled = true;
            ShapeComboBox.Items.AddRange(new object[] { "Square", "Circle", "Rectangle", "Triangle", "Draw" });
            ShapeComboBox.Location = new Point(799, 312);
            ShapeComboBox.Name = "ShapeComboBox";
            ShapeComboBox.Size = new Size(151, 28);
            ShapeComboBox.TabIndex = 20;
            ShapeComboBox.Text = "Rectangle";
            ShapeComboBox.SelectedIndexChanged += ShapeComboBox_SelectedIndexChanged;
            // 
            // PaintForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(982, 553);
            Controls.Add(ShapeComboBox);
            Controls.Add(CoordYUpDown);
            Controls.Add(CoordXUpDown);
            Controls.Add(InstructionsButton);
            Controls.Add(LengthNumeric);
            Controls.Add(HeightNumeric);
            Controls.Add(ResetButton);
            Controls.Add(ExitButton);
            Controls.Add(ColorPreviewPanel);
            Controls.Add(ColorButton);
            Controls.Add(PositionLabel);
            Controls.Add(HeightLabel);
            Controls.Add(LengthLabel);
            Controls.Add(GenShapeButton);
            Controls.Add(Paint_Panel);
            Name = "PaintForm";
            Text = "Paint Shape";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)HeightNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)LengthNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)CoordXUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CoordYUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Paint_Panel;
        private Button GenShapeButton;
        private Label LengthLabel;
        private Label HeightLabel;
        private Label PositionLabel;
        private Button ColorButton;
        private Panel ColorPreviewPanel;
        private ColorDialog ColorDialogShape;
        private Button ExitButton;
        private Button ResetButton;
        private NumericUpDown HeightNumeric;
        private NumericUpDown LengthNumeric;
        private Button InstructionsButton;
        private NumericUpDown CoordXUpDown;
        private NumericUpDown CoordYUpDown;
        private ComboBox ShapeComboBox;
    }
}
