﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            Notifications = new List<Notifies>();
        }

        [NotMapped]
        public string PropertyName { get; set; }
        [NotMapped]
        public string Message { get; set; }
        [NotMapped]
        public List<Notifies> Notifications { get; set; }

        public bool ValidatePropertyString(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(
                        new Notifies
                        {
                            Message = "Campo obrigatório",
                            PropertyName = propertyName,
                        });
                return false;
            }

            return true;
        }

        public bool ValidatePropertyInt(int value, string propertyName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notifies
                {
                    Message = "O valor deve ser maior do que 0.",
                    PropertyName = propertyName
                });

                return false;
            }

            return true;
        }

        public bool ValidatePropertyDecimal(decimal value, string propertyName)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notifies
                {
                    Message = "O valor deve ser maior do que 0.",
                    PropertyName = propertyName
                });

                return false;
            }

            return true;
        }


    }
}
