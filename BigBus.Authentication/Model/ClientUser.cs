using System;
using System.Collections.Generic;
using System.Linq;

namespace BigBus.Authentication.Model
{
    public class ClientUser
    {
        public List<string> Profiles { get; set; }

        public List<string> Roles { get; set; }

        public Guid Id { get; set; }

        public string FullName { get; set; }

        public Guid MicrositeId { get; set; }

        public string Email { get; set; }

        public string AgentRef { get; set; }

        public bool IsInRole(Model.Roles[] requiredroles)
        {
            return requiredroles.All(rrole => this.Roles.Contains(((int)rrole).ToString()));
        }

        public bool HasRole(int roleid)
        {
            return this.Roles.Contains(roleid.ToString());
        }

        //public bool IsInProfile(List<string> profiles)
        //{
        //    return !profiles.Except(this.Profiles).Any();
        //}

        //public bool IsInProfile(Profiles[] requiredprofiles)
        //{
        //    return requiredprofiles.All(rprof => this.Profiles.Contains(((int)rprof).ToString(CultureInfo.InvariantCulture)));
        //}

        //public bool HasProfile(int profileid)
        //{
        //    return this.Profiles.Contains(profileid.ToString());
        //}
    }
}
