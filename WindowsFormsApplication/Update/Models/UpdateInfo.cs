﻿using System;
using System.Collections.Generic;

namespace Update.Models
{
    public class UpdateInfo : Model
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String ver;

        public String Ver
        {
            get { return ver; }
            set { ver = value; }
        }

        private List<UpdateItem> items = null;

        public List<UpdateItem> Items
        {
            get { return items; }
            set { items = value; }
        }
    }
}
