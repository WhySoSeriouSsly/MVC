﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public class CustomIdentityUser:IdentityUser
    {
        //kullanıcın çalıştığı birim gibi koyulabilir bunlar veritabanı kaydedilir.
    }
}
