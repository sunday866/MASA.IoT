﻿using System.ComponentModel.DataAnnotations;

namespace MASA.IoT.WebApi.Contract
{
    public class DeviceRegRequest
    {
        [Required]
        [StringLength(50)]
        public string UUID { get; set; }

        [Required]
        [StringLength(20)]
        public string ProductCode { get; set; }

    }
}
