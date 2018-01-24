﻿using Docsvision.Platform.Tools.LayoutEditor.Infrostructure;
using System;
using System.Collections.Generic;
using Docsvision.Platform.Tools.LayoutEditor.ObjectModel.Descriptions;
using Docsvision.Platform.Tools.LayoutEditor.Extensibility;
using System.Resources;

namespace UrlPropertyDesignerExtension.Extension
{
    /// <summary>
    /// Представляет собой пример расширения для редактора разметок
    /// </summary>
    public class SampleWebLayoutsDesignerExtension : WebLayoutsDesignerExtension
    {       
        /// <summary>
        /// Создаёт новый экземпляр <see cref="SampleWebLayoutsDesignerExtension"/>
        /// </summary>
        /// <param name="provider">Сервис-провайдер</param>
        public SampleWebLayoutsDesignerExtension(IServiceProvider provider)
            : base(provider)
        {
        }

        /// <summary>
        /// Возвращает словарь ключ/описание свойства, которые будут использоваться в пользовательских контролах
        /// </summary>
        protected override Dictionary<string, PropertyDescription> GetPropertyDescriptions()
        {
            return new Dictionary<string, PropertyDescription>
            {
                { Constants.CommonProperties.Url, GetUrlPropertyDescription() }
                
            };
        }


        /// <summary>
        /// Возвращает ResourceManager этого расширения (расширяет словарь локализации конструктора разметок, не путать с окном Localization конструктора разметок)
        /// </summary>
        protected override List<ResourceManager> GetResourceManagers()
        {
            return new List<ResourceManager>
            {
                Resources.ResourceManager
            };
        }               

        private PropertyDescription GetUrlPropertyDescription()
        {
            return new PropertyDescription
            {
                Type = typeof(string),
                Name = Constants.CommonProperties.Url,
                Category = PropertyCategoryConstants.DataCategory,
                DisplayName = Resources.ControlTypes_UrlProperty
            };
        }

    }
}
