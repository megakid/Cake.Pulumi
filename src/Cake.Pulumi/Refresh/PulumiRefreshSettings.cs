﻿namespace Cake.Pulumi
{
    public class PulumiRefreshSettings : PulumiSettings
    {
        public bool ExpectNoChanges { get; set; }
        public bool AutoApprove { get; set; }
        public string Stack { get; set; }
    }
}