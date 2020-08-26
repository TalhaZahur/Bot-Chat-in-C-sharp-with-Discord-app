using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace bot
{
    public class ping : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task Pingasync()
        {
            await ReplyAsync("Hello World");
        }

        [Command("Your Private Message")]
        public async Task tingasync()
        {
            await ReplyAsync("Any Response");
        }

        [Command("Where are you?")]
        public async Task reply()
        {
            await ReplyAsync("I will not tell you");
        }

        [Command("kya kar rahay ho")]
        public async Task reply1()
        {
            await ReplyAsync("mar wa raha");
        }
        [Command("tell me something")]
        public async Task reply2()
        {
            await ReplyAsync("Please ask something");
        }
        [Command("whats your favourite colour?")]
        public async Task reply3()
        {
            await ReplyAsync("yellow");
        }

        [Command("time")]
        public async Task reply4()
        {
            await ReplyAsync(DateTime.Now.Day.ToString());
        }
        [Command("rate")]
        public async Task reply5()
        {
            await ReplyAsync("Enter ammount in numbers!");
            
        }
        
        public double cal(double num)
        {
            double result;
            result = num * 129.7;
            return result; 
        }
        //[Command(R)]
        //public async Task Say()
        //{
        //    double result;
        //    result =  1* 129.7;
            
        //    // ReplyAsync is a method on ModuleBase
        //    await ReplyAsync(result.ToString());
            
        //}

    }
}
