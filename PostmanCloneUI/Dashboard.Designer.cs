namespace PostmanCloneUI;

partial class Dashboard : Form
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
        label1 = new Label();
        apiLabel = new Label();
        apiText = new TextBox();
        apiButton = new Button();
        clearButton = new Button(); // Added Clear button
        resultOutput = new TextBox();
        resultLabel = new Label();
        statusStrip1 = new StatusStrip();
        currentStatus = new ToolStripStatusLabel();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = SystemColors.AppWorkspace;
        label1.Location = new Point(20, 20);
        label1.Name = "label1";
        label1.Size = new Size(142, 28);
        label1.TabIndex = 0;
        label1.Text = "Postman Clone";
        // 
        // apiLabel
        // 
        apiLabel.AutoSize = true;
        apiLabel.Location = new Point(20, 80);
        apiLabel.Name = "apiLabel";
        apiLabel.Size = new Size(45, 28);
        apiLabel.TabIndex = 1;
        apiLabel.Text = "API:";
        // 
        // apiText
        // 
        apiText.Location = new Point(80, 75);
        apiText.Name = "apiText";
        apiText.Size = new Size(650, 34);
        apiText.TabIndex = 2;
        // 
        // apiButton
        // 
        apiButton.Location = new Point(740, 75);
        apiButton.Name = "apiButton";
        apiButton.Size = new Size(100, 35);
        apiButton.TabIndex = 3;
        apiButton.Text = "GO!";
        apiButton.UseVisualStyleBackColor = true;
        apiButton.Click += apiButton_Click;
        // 
        // clearButton
        // 
        clearButton.Location = new Point(850, 75); // Adjusted position
        clearButton.Name = "clearButton";
        clearButton.Size = new Size(100, 35);
        clearButton.TabIndex = 7;
        clearButton.Text = "Clear";
        clearButton.UseVisualStyleBackColor = true;
        clearButton.Click += clearButton_Click; // Event handler for Clear button
                                                // 
                                                // resultOutput
                                                // 
        resultOutput.Location = new Point(20, 200);
        resultOutput.Multiline = true;
        resultOutput.Name = "resultOutput";
        resultOutput.ReadOnly = true;
        resultOutput.ScrollBars = ScrollBars.Vertical;
        resultOutput.Size = new Size(820, 300);
        resultOutput.TabIndex = 4;
        // 
        // resultLabel
        // 
        resultLabel.AutoSize = true;
        resultLabel.Location = new Point(20, 170);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new Size(68, 28);
        resultLabel.TabIndex = 5;
        resultLabel.Text = "Result:";
        // 
        // statusStrip1
        // 
        statusStrip1.ImageScalingSize = new Size(20, 20);
        statusStrip1.Items.AddRange(new ToolStripItem[] { currentStatus });
        statusStrip1.Location = new Point(0, 573);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(951, 26);
        statusStrip1.TabIndex = 6;
        statusStrip1.Text = "statusStrip1";
        // 
        // currentStatus
        // 
        currentStatus.Name = "currentStatus";
        currentStatus.Size = new Size(50, 20);
        currentStatus.Text = "Ready";
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(11F, 28F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(951, 599);
        Controls.Add(statusStrip1);
        Controls.Add(resultLabel);
        Controls.Add(resultOutput);
        Controls.Add(apiButton);
        Controls.Add(clearButton); // Added Clear button to form controls
        Controls.Add(apiText);
        Controls.Add(apiLabel);
        Controls.Add(label1);
        Font = new Font("Segoe UI", 12F);
        Margin = new Padding(5);
        Name = "Dashboard";
        Text = "Postman Clone By Tzur";
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label apiLabel;
    private TextBox apiText;
    private Button apiButton;
    private Button clearButton; // Added declaration for the Clear button
    private TextBox resultOutput;
    private Label resultLabel;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel currentStatus;

    // Event handler for the Clear button
    private void clearButton_Click(object sender, EventArgs e)
    {
        resultOutput.Clear(); // Clears the content of the resultOutput TextBox
    }

}
