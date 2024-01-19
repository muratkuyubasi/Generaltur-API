using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;
using TourV2.Common.UnitOfWork;
using TourV2.Data.Dto;
using TourV2.Data.Dto.ValuesEducation;
using TourV2.Domain;
using TourV2.MediatR.Commands.EducaitonForm;
using TourV2.Repository;
using TourV2.Data;
using TourV2.Data.Entities;
using TourV2.Helper;

namespace TourV2.MediatR.Handlers
{
    public class AddEducationFormCommandHandler : IRequestHandler<AddEducationFormCommand, ServiceResponse<EducationFormDTO>>
    {
        private readonly IEducationFormRepository _educationFormRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<AddEducationFormCommandHandler> _logger;
        private readonly UserInfoToken _userInfoToken;
        private readonly IUnitOfWork<TourContext> _uow;

        public AddEducationFormCommandHandler(IEducationFormRepository EducationFormRepository, IMapper mapper, ILogger<AddEducationFormCommandHandler> logger,
            UserInfoToken userInfoToken, IUnitOfWork<TourContext> uow)
        {
            _educationFormRepository = EducationFormRepository;
            _mapper = mapper;
            _logger = logger;
            _userInfoToken = userInfoToken;
            _uow = uow;
        }

        public async Task<ServiceResponse<EducationFormDTO>> Handle(AddEducationFormCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<EducationForm>(request);

            _educationFormRepository.Add(entity);

            if (await _uow.SaveAsync() <= 0)
            {
                _logger.LogError("Kayıt Gerçekleşmedi");
                return ServiceResponse<EducationFormDTO>.Return500();
            }

            var entityDto = _mapper.Map<EducationFormDTO>(entity);
            return ServiceResponse<EducationFormDTO>.ReturnResultWith200(entityDto);


        }
    }
}