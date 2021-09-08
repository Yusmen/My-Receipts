﻿namespace MyReceipts.Web.ViewModels.Recipes
{
    using AutoMapper;
    using MyReceipts.Data.Models;
    using MyReceipts.Services.Mapping;

    public class EditRecipeInputModel : BaseRecipeInputModel, IMapFrom<Recipe>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Recipe, EditRecipeInputModel>()
                .ForMember(x => x.CookingTime, opt =>
                opt.MapFrom(x => (int)x.CookingTime.TotalMinutes))
                .ForMember(x => x.PeparationTime, opt =>
                opt.MapFrom(x => (int)x.PeparationTime.TotalMinutes));
        }
    }
}
