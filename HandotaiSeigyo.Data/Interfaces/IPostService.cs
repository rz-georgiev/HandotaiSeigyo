﻿using HandotaiSeigyo.Data.Models;
using System.Collections.Generic;

namespace HandotaiSeigyo.Data.Interfaces
{
    public interface IPostService
    {
        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetLast15Posts();
    }
}