
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFleet.Data.Models;

namespace SmartFleet.Data.Data.Seeds
{
    public class AccountPostingSeed : IEntityTypeConfiguration<AccountPostingSettings>
    {
        public void Configure(EntityTypeBuilder<AccountPostingSettings> builder)
        {
            builder.HasData(    
            new AccountPostingSettings{ Id=16, DocumentType= "Invoice", DocumentSubType ="Main", CreditAccountID =0, DebitAccountId =0},
            new AccountPostingSettings{ Id=17, DocumentType= "Invoice", DocumentSubType ="FreightExpenseAcc", CreditAccountID =0, DebitAccountId =0},
            new AccountPostingSettings{ Id=18, DocumentType= "Invoice", DocumentSubType ="HaltingExpenseAcc", CreditAccountID =0, DebitAccountId =0},
            new AccountPostingSettings{ Id=19, DocumentType= "Invoice", DocumentSubType ="HandlingExpenseAcc", CreditAccountID =0, DebitAccountId =0},
            new AccountPostingSettings{ Id=20, DocumentType= "Invoice", DocumentSubType ="LRChargesExpenseAcc", CreditAccountID =0, DebitAccountId =0},
            new AccountPostingSettings{ Id=21, DocumentType= "Invoice", DocumentSubType ="AdditionalExpenseAcc", CreditAccountID =0, DebitAccountId =0},
            new AccountPostingSettings{ Id=22, DocumentType= "Invoice", DocumentSubType ="LoadingExpenseAcc", CreditAccountID =0, DebitAccountId =0}
            );
        }
    }
}
