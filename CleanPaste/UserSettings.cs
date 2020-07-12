using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace CleanPaste
{
    public class UserSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("true")]
        public bool RemoveTextFormattings
        {
            get
            {
                return ((bool)this["RemoveTextFormattings"]);
            }
            set
            {
                this["RemoveTextFormattings"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool RemoveLineBreaks
        {
            get
            {
                return ((bool)this["RemoveLineBreaks"]);
            }
            set
            {
                this["RemoveLineBreaks"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("true")]
        public bool RemoveUnicodeChars
        {
            get
            {
                return ((bool)this["RemoveUnicodeChars"]);
            }
            set
            {
                this["RemoveUnicodeChars"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool ConvertToHTML
        {
            get
            {
                return ((bool)this["ConvertToHTML"]);
            }
            set
            {
                this["ConvertToHTML"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool AutoStart
        {
            get
            {
                return ((bool)this["AutoStart"]);
            }
            set
            {
                this["AutoStart"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool AddLineBreaks
        {
            get
            {
                return ((bool)this["AddLineBreaks"]);
            }
            set
            {
                this["AddLineBreaks"] = value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string AddLineBreaksAfter
        {
            get
            {
                return ((string)this["AddLineBreaksAfter"]);
            }
            set
            {
                this["AddLineBreaksAfter"] = value;
            }
        }
    }
}
