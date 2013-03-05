﻿namespace DemoApplication.Extensions
{
    using System.Web.Mvc;

    public static class InputExtensions
    {       
        public static BootstrapInputOptions GetOptions(this ModelMetadata metadata)
        {
            object options;

            metadata.AdditionalValues.TryGetValue("InputOptions", out options);

            return (BootstrapInputOptions)options;
        }
    }
}