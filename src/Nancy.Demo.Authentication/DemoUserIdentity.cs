﻿namespace Nancy.Demo.Authentication
{
    using System.Collections.Generic;

    using Nancy.Security;

    public class DemoUserIdentity : IUserIdentity
    {
        public string UserName { get; set; }

        public IEnumerable<string> Claims { get; set; }
    }
}