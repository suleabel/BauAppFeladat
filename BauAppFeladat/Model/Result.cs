using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauAppFeladat.Model
{
    [Serializable]
    public class Result
    {
        public int companyId { get; set; }
        public int userId { get; set; }
        public object idpIssuer { get; set; }
        public string usern { get; set; }
        public string emailAddress { get; set; }
        public string displayName { get; set; }
        public string mobileNumber { get; set; }
        public string mobilePlatform { get; set; }
        public bool hwValidation { get; set; }
        public string role { get; set; }
        public bool webformAccess { get; set; }
        public bool biAccess { get; set; }
        public DateTime created { get; set; }
        public bool activated { get; set; }
        public DateTime? lastLoginDate { get; set; }
        public object lastMobileActivityDate { get; set; }
        public DateTime? lastBOLoginDate { get; set; }
        public object lastWefSubmitDate { get; set; }

        public Result()
        {
        }

        public Result(int companyId, int userId, object idpIssuer, string usern, string emailAddress, string displayName, string mobileNumber, string mobilePlatform, bool hwValidation, string role, bool webformAccess, bool biAccess, DateTime created, bool activated, DateTime? lastLoginDate, object lastMobileActivityDate, DateTime? lastBOLoginDate, object lastWefSubmitDate)
        {
            this.companyId = companyId;
            this.userId = userId;
            this.idpIssuer = idpIssuer;
            this.usern = usern;
            this.emailAddress = emailAddress;
            this.displayName = displayName;
            this.mobileNumber = mobileNumber;
            this.mobilePlatform = mobilePlatform;
            this.hwValidation = hwValidation;
            this.role = role;
            this.webformAccess = webformAccess;
            this.biAccess = biAccess;
            this.created = created;
            this.activated = activated;
            this.lastLoginDate = lastLoginDate;
            this.lastMobileActivityDate = lastMobileActivityDate;
            this.lastBOLoginDate = lastBOLoginDate;
            this.lastWefSubmitDate = lastWefSubmitDate;
        }

        public override string ToString()
        {
            return $"{{{nameof(companyId)}={companyId.ToString()}, {nameof(userId)}={userId.ToString()}, {nameof(idpIssuer)}={idpIssuer}, {nameof(usern)}={usern}, {nameof(emailAddress)}={emailAddress}, {nameof(displayName)}={displayName}, {nameof(mobileNumber)}={mobileNumber}, {nameof(mobilePlatform)}={mobilePlatform}, {nameof(hwValidation)}={hwValidation.ToString()}, {nameof(role)}={role}, {nameof(webformAccess)}={webformAccess.ToString()}, {nameof(biAccess)}={biAccess.ToString()}, {nameof(created)}={created.ToString()}, {nameof(activated)}={activated.ToString()}, {nameof(lastLoginDate)}={lastLoginDate.ToString()}, {nameof(lastMobileActivityDate)}={lastMobileActivityDate}, {nameof(lastBOLoginDate)}={lastBOLoginDate.ToString()}, {nameof(lastWefSubmitDate)}={lastWefSubmitDate}}}";
        }
    }
}
