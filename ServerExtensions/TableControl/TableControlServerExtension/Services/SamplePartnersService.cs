﻿using TableControlServerExtension.Helpers;
using DocsVision.BackOffice.ObjectModel;
using System;
using TableControlServerExtension.Models;
using DocsVision.Platform.WebClient;

namespace TableControlServerExtension.Services
{
    public class SamplePartnersService : ISamplePartnersService
    {
        private readonly IServiceProvider serviceProvider;
        private readonly ServiceHelper serviceHelper;


        /// <summary>
        /// Создаёт новый экземпляр <see cref="LicenseCheckService"/>
        /// </summary>
        /// <param name="provider">Сервис-провайдер</param>
        public SamplePartnersService(IServiceProvider provider)
        {
            if (provider == null)
                throw new ArgumentNullException("provider");

            this.serviceProvider = provider;
            serviceHelper = new ServiceHelper(serviceProvider);
        }

        public PartnerModel GetPartnerInfo(SessionContext sessionContext, Guid id)
        {
            PartnerModel partnerModel = null;
            var partner = sessionContext.ObjectContext.GetObject<PartnersCompany>(id);
            if (partner != null)
            {
                partnerModel = new PartnerModel { Id = id };
                partnerModel.Initialize(partner);
            }

            return partnerModel;
        }
    }
}