﻿using System;
using System.ComponentModel.DataAnnotations;
using Maddalena;

namespace ServerSideAnalytics.SqLite
{
    public class SqliteWebRequest
    {
        public long Id { get; set; }

        public DateTime Timestamp { get; set; }

        [MaxLength(32)]
        public string Identity { get; set; }

        [MaxLength(32)]
        public string RemoteIpAddress { get; set; }

        [MaxLength(16)]
        public string Method { get; set; }

        [MaxLength(1024)]
        public string Path { get; set; }

        [MaxLength(512)]
        public string UserAgent { get; set; }

        [MaxLength(1024)]
        public string Referer { get; set; }

        public CountryCode Country { get; set; }
    }
}