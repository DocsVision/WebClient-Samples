﻿using ShiftTasksEndDateServerExtension.Controllers;
using ShiftTasksEndDateServerExtension.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Web.Mvc;
using Autofac;
using DocsVision.WebClient.Extensibility;

namespace ShiftTasksEndDateServerExtension
{
    /// <summary>
    /// Задаёт описание расширения для WebClient, которое задано в текущей сборке
    /// </summary>
    public class LayoutWebClientExtension : WebClientExtension
    {
        /// <summary>
        /// Создаёт новый экземпляр <see cref="LayoutWebClientExtension" />
        /// </summary>
        /// <param name="serviceProvider">Сервис-провайдер</param>
        public LayoutWebClientExtension(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        /// <summary>
        /// Получить название расширения
        /// </summary>
        public override string ExtensionName
        {
            get { return Assembly.GetAssembly(typeof(LayoutWebClientExtension)).GetName().Name; }
        }

        /// <summary>
        /// Получить версию расширения
        /// </summary>
        public override Version ExtensionVersion
        {
            get { return new Version(FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion); }
        }

        #region WebClientExtension Overrides

        /// <summary>
        /// Регистрация типов в IoC контейнере
        /// </summary>
        /// <param name="containerBuilder"></param>
        public override void InitializeContainer(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<ShiftTasksEndDateService>().As<IShiftTasksEndDateService>().SingleInstance();
        }

        /// <summary>
        /// Получить менеджеры ресурсов для расширения разметки
        /// </summary>
        /// <returns></returns>
        protected override List<ResourceManager> GetLayoutExtensionResourceManagers()
        {
            return new List<ResourceManager>
            {
                { Resources.ResourceManager }
            };
        }

        #endregion
    }
}