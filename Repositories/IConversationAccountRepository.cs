﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IConversationAccountRepository
    {
        public bool AddConversationAccount(ConversationAccount conversationAccount);

        public bool DelConversationAccounts(int id);

        public List<ConversationAccount> GetConversationAccounts();

        public bool UpdateConversationAccounts(ConversationAccount conversationAccount);
    }
}
