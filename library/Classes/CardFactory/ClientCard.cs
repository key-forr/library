﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using library.Forms.Client;
using library.Classes.Configuration;
using library.Forms.Book;
using library.Forms.Order;

namespace library.Classes.CardFactory
{
    public class ClientCard
    {
        private ClientsForm clientsForm;

        public ClientCard(ClientsForm clientsForm)
        {
            this.clientsForm = clientsForm;
        }

        public Guna.UI2.WinForms.Guna2GroupBox CreateClientCard(ClientConfig clientConfig, int x, int y)
        {
            var group_box = new Guna.UI2.WinForms.Guna2GroupBox()
            {
                BorderColor = Color.FromArgb(22, 26, 50),
                BorderRadius = 20,
                BorderThickness = 0,
                CustomBorderThickness = new Padding(0),
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(125, 137, 149),
                Location = new Point(x, y),
                Name = "group_box",
                Size = new Size(440, 120),
                Tag = false
            };

            var text_box_name = new Guna.UI2.WinForms.Guna2TextBox()
            {
                BorderThickness = 0,
                DefaultText = $"{clientConfig.Surname} {clientConfig.Name} {clientConfig.Patronymic}",
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold),
                ForeColor = Color.White,
                Multiline = true,
                ReadOnly = true,
                Location = new Point(10, 10),
                Padding = new Padding(10, 5, 10, 5),
                Size = new Size(300, 50),
                TextAlign = HorizontalAlignment.Left
            };

            var text_box_role = new Guna.UI2.WinForms.Guna2TextBox()
            {
                BorderThickness = 0,
                DefaultText = clientConfig.Phone,
                FillColor = Color.FromArgb(36, 42, 78),
                Font = new Font("Microsoft Sans Serif", 14F),
                ForeColor = Color.DarkGray,
                Multiline = true,
                ReadOnly = true,
                Location = new Point(10, text_box_name.Bottom + 5),
                Padding = new Padding(10, 5, 10, 5),
                Size = new Size(300, 50),
                TextAlign = HorizontalAlignment.Left
            };

            EventHandler hoverEffect = (sender, e) =>
            {
                group_box.BorderThickness = 3;
                group_box.BorderColor = Color.FromArgb(72, 169, 118);
            };

            EventHandler resetEffect = (sender, e) =>
            {
                group_box.BorderThickness = 0;
                group_box.BorderColor = Color.FromArgb(22, 26, 50);
            };

            EventHandler openDetails = (sender, e) =>
            {
                clientsForm.OpenClientDetails(clientConfig);
            };

            group_box.MouseEnter += hoverEffect;
            group_box.MouseLeave += resetEffect;
            group_box.DoubleClick += openDetails;

            text_box_name.MouseEnter += hoverEffect;
            text_box_name.MouseLeave += resetEffect;
            text_box_name.DoubleClick += openDetails;

            text_box_role.MouseEnter += hoverEffect;
            text_box_role.MouseLeave += resetEffect;
            text_box_role.DoubleClick += openDetails;


            group_box.Controls.Add(text_box_name);
            group_box.Controls.Add(text_box_role);

            return group_box;
        }
    }
}