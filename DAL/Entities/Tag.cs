﻿using System;
using System.Collections.Generic;

namespace DAL.Entities;

public partial class Tag
{
    public int TagId { get; set; }

    public string? TagName { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<NewsArticle> NewsArticle { get; set; } = new List<NewsArticle>();
}
