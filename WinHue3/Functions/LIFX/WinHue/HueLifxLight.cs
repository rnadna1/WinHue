﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WinHue3.Annotations;
using WinHue3.LIFX.Framework;
using WinHue3.Utils;

namespace WinHue3.Functions.LIFX.WinHue
{
    public class HueLifxLight : LifxLight, ILifxObject
    {
        private ImageSource _image;
        
        public HueLifxLight(IPAddress ip, byte[] mac) : base(ip,mac)
        {
            this._validationContext = new ValidationContext(this);
        }

        public string Name => this.Label;
          
        public ImageSource Image { get => _image; set => SetProperty(ref _image,value); }

        #region INOTIFY
        private ValidationContext _validationContext { get; set; }
        private bool _isChanged;

        [Browsable(false), JsonIgnore]
        public string this[string propertyName]
        {
            get
            {
                var prop = GetType().GetProperty(propertyName);
                var validationMap = prop.GetCustomAttributes(typeof(ValidationAttribute), true).Cast<ValidationAttribute>();
                List<string> errormessages = new List<string>();
                foreach (var v in validationMap)
                {
                    try
                    {
                        v.Validate(prop.GetValue(this, null), _validationContext);
                    }
                    catch (Exception)
                    {
                        errormessages.Add((string)v.GetType().GetProperty("ErrorMessageString", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).GetValue(v));
                    }

                }

                return errormessages.Count == 0 ? null : string.Join(",", errormessages);
            }
        }

        protected virtual bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value)) return false;
            storage = value;
            RaisePropertyChanged(propertyName);

            return true;
        }

        [Browsable(false), JsonIgnore]
        public string Error { get; internal set; }

        [Browsable(false), JsonIgnore]
        public bool IsChanged
        {
            get => _isChanged;
            private set => _isChanged = value;
        }
        string ILifxObject.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AcceptChanges()
        {
            this.IsChanged = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            IsChanged = true;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
