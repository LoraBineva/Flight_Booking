namespace Flights_Agency_App
{
    partial class Booking
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
            label2 = new Label();
            flightID_lbl = new Label();
            Flight_Data = new DataGridView();
            passengerName_lbl = new Label();
            DOB_lbl = new Label();
            book_btn = new Button();
            cancel_btn = new Button();
            back_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)Flight_Data).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(191, 24);
            label2.Name = "label2";
            label2.Size = new Size(232, 50);
            label2.TabIndex = 38;
            label2.Text = "Booking Info";
            // 
            // flightID_lbl
            // 
            flightID_lbl.AutoSize = true;
            flightID_lbl.BackColor = Color.Transparent;
            flightID_lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            flightID_lbl.ForeColor = SystemColors.ControlLightLight;
            flightID_lbl.Location = new Point(60, 90);
            flightID_lbl.Name = "flightID_lbl";
            flightID_lbl.Size = new Size(81, 25);
            flightID_lbl.TabIndex = 45;
            flightID_lbl.Text = "FlightID:";
            // 
            // Flight_Data
            // 
            Flight_Data.BackgroundColor = Color.LightSteelBlue;
            Flight_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Flight_Data.Location = new Point(36, 136);
            Flight_Data.Name = "Flight_Data";
            Flight_Data.RowTemplate.Height = 25;
            Flight_Data.Size = new Size(537, 91);
            Flight_Data.TabIndex = 46;
            // 
            // passengerName_lbl
            // 
            passengerName_lbl.AutoSize = true;
            passengerName_lbl.BackColor = Color.Transparent;
            passengerName_lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            passengerName_lbl.ForeColor = SystemColors.ControlLightLight;
            passengerName_lbl.Location = new Point(36, 259);
            passengerName_lbl.Name = "passengerName_lbl";
            passengerName_lbl.Size = new Size(0, 25);
            passengerName_lbl.TabIndex = 47;
            // 
            // DOB_lbl
            // 
            DOB_lbl.AutoSize = true;
            DOB_lbl.BackColor = Color.Transparent;
            DOB_lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            DOB_lbl.ForeColor = SystemColors.ControlLightLight;
            DOB_lbl.Location = new Point(364, 259);
            DOB_lbl.Name = "DOB_lbl";
            DOB_lbl.Size = new Size(0, 25);
            DOB_lbl.TabIndex = 48;
            // 
            // book_btn
            // 
            book_btn.BackColor = Color.LightSteelBlue;
            book_btn.FlatAppearance.BorderColor = Color.WhiteSmoke;
            book_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            book_btn.Location = new Point(36, 318);
            book_btn.Name = "book_btn";
            book_btn.Size = new Size(113, 47);
            book_btn.TabIndex = 49;
            book_btn.Text = "Book";
            book_btn.UseVisualStyleBackColor = false;
            book_btn.Click += book_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.BackColor = Color.LightSteelBlue;
            cancel_btn.FlatAppearance.BorderColor = Color.WhiteSmoke;
            cancel_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cancel_btn.Location = new Point(220, 318);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(144, 47);
            cancel_btn.TabIndex = 50;
            cancel_btn.Text = "Cancel Booking";
            cancel_btn.UseVisualStyleBackColor = false;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // back_btn
            // 
            back_btn.BackColor = Color.LightSteelBlue;
            back_btn.FlatAppearance.BorderColor = Color.WhiteSmoke;
            back_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            back_btn.Location = new Point(435, 318);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(113, 47);
            back_btn.TabIndex = 51;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = false;
            back_btn.Click += back_btn_Click;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_170958625_612x612;
            ClientSize = new Size(613, 410);
            Controls.Add(back_btn);
            Controls.Add(cancel_btn);
            Controls.Add(book_btn);
            Controls.Add(DOB_lbl);
            Controls.Add(passengerName_lbl);
            Controls.Add(Flight_Data);
            Controls.Add(flightID_lbl);
            Controls.Add(label2);
            Name = "Booking";
            Text = "Booking";
            Load += Booking_Load;
            ((System.ComponentModel.ISupportInitialize)Flight_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label flightID_lbl;
        private DataGridView Flight_Data;
        private Label passengerName_lbl;
        private Label DOB_lbl;
        private Button book_btn;
        private Button cancel_btn;
        private Button back_btn;
    }
}