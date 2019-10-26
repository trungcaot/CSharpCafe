using CSharpCafeApp.Domain.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCafeApp.Domain.Mapping
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(x => x.Id);

            Map(x => x.Name).Length(50).Not.Nullable();

            Map(x => x.UrlSlug).Length(50).Not.Nullable();

            Map(x => x.Description).Length(200);

            HasMany(x => x.Posts)
                .Inverse()
                .Cascade.All()
                .KeyColumn("Category");
        }
    }
}
