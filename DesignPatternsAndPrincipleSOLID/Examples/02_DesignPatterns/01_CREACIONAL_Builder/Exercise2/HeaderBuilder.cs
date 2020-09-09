using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Examples._02_DesignPatterns._01_CREACIONAL_Builder.Exercise2
{
    public class HeaderBuilder
    {
        private readonly Header _header;

        public HeaderBuilder()
        {
            _header = new Header();
        }

        public static HeaderBuilder CreateNewHeader()
        {
            return new HeaderBuilder();
        }

        public HeaderBuilder AddAgent(string src, string alt, string name, string email, string phone, string city)
        {
            _header.agent = new Agent()
            {
                city = city,
                email = email,
                name = name,
                phone = phone,
                image = new Image() { src = src, alt = alt }
            };
            return this;
        }

        public HeaderBuilder AddLogo(string src, string alt, string href, string title)
        {
            _header.logo = new Logo()
            {
                alt = alt,
                src = src,
                link = new Link() { href = href, title = title }
            };
            return this;
        }

        public Header Build()
        {
            return _header;
        }
    }
}
