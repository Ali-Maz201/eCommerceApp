﻿namespace EntityORM.DbEntities
{
    public class ProductCategory
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime Created_At { get; set; }

        public DateTime Modified_At { get; set; }

        public DateTime Deleted_At { get; set; }

    }
}
