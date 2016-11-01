using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using FluentValidation;

// Fluent Validation
public class VCard: AbstractValidator<Card> {
  public VCard() {
    RuleFor(c => c.Title).NotEmpty().WithMessage("Please specify a title");
    RuleFor(c => c.Content).NotEmpty();
    
    // RuleFor(customer => customer.Forename).NotEmpty().WithMessage("Please specify a first name");
    // RuleFor(customer => customer.Discount).NotEqual(0).When(customer => customer.HasDiscount);
    // RuleFor(customer => customer.Address).Length(20, 250);
    // RuleFor(customer => customer.Postcode).Must(BeAValidPostcode).WithMessage("Please specify a valid postcode");
    // RuleFor(customer => customer.Address).SetValidator(new AddressValidator()) <-- can use sub-validators
    // RuleFor(x => x.Orders).SetCollectionValidator(new OrderValidator()); <-- and list validators
  }
}
// Card c = new Card();
// VCard v = new VCard();
// ValidationResult results = v.Validate(c);
// bool validationSucceeded = results.IsValid;
// IList<ValidationFailure> failures = results.Errors;