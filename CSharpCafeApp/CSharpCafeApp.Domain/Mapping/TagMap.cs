using CSharpCafeApp.Domain.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCafeApp.Domain.Mapping
{
    public class TagMap : ClassMap<Tag>
    {
        public TagMap()
        {
            Id(x => x.Id);

            Map(x => x.Name).Length(50).Not.Nullable();

            Map(x => x.UrlSlug).Length(50).Not.Nullable();

            Map(x => x.Description).Length(200);

            HasManyToMany(x => x.Posts)
                .Cascade.All().Inverse()
                .Table("PostTagMap");
        }
    }
}
