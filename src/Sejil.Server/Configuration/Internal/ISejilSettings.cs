// Copyright (C) 2017 Alaa Masoud
// See the LICENSE file in the project root for more information.

using Serilog.Events;
using Serilog.Core;
using System.IO;

namespace SejilSQL.Configuration
{
    public interface ISejilSettings
    {
        string SejilAppHtml { get; }
        string Url { get; }
        LoggingLevelSwitch LoggingLevelSwitch { get; }
        string ConnectionString { get; set; }
        string[] NonPropertyColumns { get; }
        int PageSize { get; set; }
        bool TrySetMinimumLogLevel(string minLogLevel);

        /// <summary>
        /// Gets or sets the title shown in the front end
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the authentication scheme, used for the index page. Leave empty for no authentication.
        /// </summary>
        string AuthenticationScheme { get; set; }

        int LogRetentionDays { get; set; }
    }
}