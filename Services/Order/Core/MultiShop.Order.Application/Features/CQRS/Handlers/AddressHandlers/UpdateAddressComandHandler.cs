﻿using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;


namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
public class UpdateAddressComandHandler
    {
        private readonly IRepository<Address> _repository;

        public UpdateAddressComandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAddressCommand command)
        {
            var values = await _repository.GetByIdAsync(command.AddressId);
            values.Detail = command.Detail;
            values.District = command.District;
            values.City = command.City;
            values.UserId = command.UserId;
            await _repository.UpdateAsync(values);
        }
    }
}
