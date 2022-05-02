﻿using asp_net_po_schedule_management_server.Utils;
using asp_net_po_schedule_management_server.Ssh.SshInterceptor;


namespace asp_net_po_schedule_management_server.Ssh.SshEmailService
{
    public sealed class SshEmailServiceImplementation : ISshEmailService
    {
        private readonly ISshInterceptor _sshInterceptor;

        public SshEmailServiceImplementation(ISshInterceptor sshInterceptor)
        {
            _sshInterceptor = sshInterceptor;
        }
        
        //--------------------------------------------------------------------------------------------------------------
        
        // dodawanie nowej skrzynki pocztowej i ustawianie jej pojemności
        public void AddNewEmailAccount(string emailAddress, string emailPassword)
        {
            _sshInterceptor.ExecuteCommand(
                $"echo " +
                $"\"['--json', 'mail', 'account', 'add', '{emailAddress}', '{emailPassword}']\" " +
                $"| nc -U /var/run/devil2.sock"
            );
            // ustawienie maksymalnej pojemności skrzynki pocztowej
            _sshInterceptor.ExecuteCommand(
                $"devil mail quota {emailAddress} {GlobalConfigurer.UserEmailMaxSizeMb}M"
            );
        }

        //--------------------------------------------------------------------------------------------------------------
        
        // aktualizacja hasła na podstawie adresu email
        public void UpdateEmailPassword(string emailAddress, string newEmailPassword)
        {
            _sshInterceptor.ExecuteCommand(
                $"echo " +
                $"\"['--json', 'mail', 'passwd', '{emailAddress}', '{newEmailPassword}']\" " +
                $"| nc -U /var/run/devil2.sock"
            );
        }
        
        //--------------------------------------------------------------------------------------------------------------
        
        // usuwanie skrzynki pocztowej
        public void DeleteEmailAccount(string emailAddress)
        {
            _sshInterceptor.ExecuteCommand(
                $"echo " +
                $"\"['--json', 'mail', 'account', 'del', '{emailAddress}']\" " +
                $"| nc -U /var/run/devil2.sock"
            );
        }
    }
}