﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmotionProyecto.Web.Models
{
    public class EmotionProyectoWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public EmotionProyectoWebContext() : base("name=EmotionProyectoWebContext")
        {
            //Se utiliza para cambiar la base de datos si sufre cambios
            Database.SetInitializer<EmotionProyectoWebContext>(new DropCreateDatabaseIfModelChanges<EmotionProyectoWebContext>());
        }

        public DbSet<EmoPicture> EmoPictures { get; set; }

        public DbSet<EmoFace> EmoFaces { get; set; }

        public DbSet<EmoEmotion> EmoEmotions { get; set; }

        public System.Data.Entity.DbSet<EmotionProyecto.Web.Models.Home> Homes { get; set; }
    }
}
