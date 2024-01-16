using BlogUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogUniversity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            LayoutData.ChangeDataTitle("active", "", "", "");

            List<BlogDetailModel> HeadBlogs =
                [
                    new(1 , ["Artificial intelligence and machine learning"] 
                    , ["🤖🧑 💻 I am back again after a relatively long time and in this article I am going to talk about artificial intelligence and machine learning, so stay with me until the end of this article:"
                    , "🤖 Scientifically, artificial intelligence is one of the important areas of computer science that examines and designs systems that are capable of doing tasks that require intelligence and learning (intelligent systems) o⁠・⁠) ) . The main goal of artificial intelligence is to design and build systems that are capable of performing tasks such as pattern recognition, decision making, natural language processing, image and sound processing, etc."
                    ,"In the field of artificial intelligence, various technologies such as neural networks, machine learning algorithms, fuzzy logic, evolutionary methods, etc. are used."
                    ,"⚜️ What is machine learning now?"
                    ,"🚀🎭 Machine learning or machine learning is an artificial intelligence method that allows computers to learn from input data and make decisions based on it using special algorithms. In fact, machine learning allows computers to identify patterns by analyzing large data and use them to make predictions and make decisions.\r\nThis method is used in many scientific, industrial and commercial fields."]
                    , ["/Blog/h_1.jpg", "/Blog/aiML.heic.jpg"], 
                        new(1,"mehrab" , "aghaee" ,"Ceo/Engineer","09037834381", "/1687271803119.jpg")
                        , new DateTime(2023, 12, 18, 12, 15, 10), [new(1 , new(1,"ali","qasdcb@gfg.bb") , "dfnfgndfn") ] , "Ai" )                        
                ];

            List<BlogDetailModel> BodyBlogs =
               [
                   new(1, ["Artificial intelligence and machine learning"]
                        , ["🤖🧑 💻 I am back again after a relatively long time and in this article I am going to talk about artificial intelligence and machine learning, so stay with me until the end of this article:"
                        ,"🤖 Scientifically, artificial intelligence is one of the important areas of computer science that examines and designs systems that are capable of doing tasks that require intelligence and learning (intelligent systems) o⁠・⁠) ) . The main goal of artificial intelligence is to design and build systems that are capable of performing tasks such as pattern recognition, decision making, natural language processing, image and sound processing, etc."
                        ,"In the field of artificial intelligence, various technologies such as neural networks, machine learning algorithms, fuzzy logic, evolutionary methods, etc. are used."
                        ,"⚜️ What is machine learning now?"
                        ,"🚀🎭 Machine learning or machine learning is an artificial intelligence method that allows computers to learn from input data and make decisions based on it using special algorithms. In fact, machine learning allows computers to identify patterns by analyzing large data and use them to make predictions and make decisions.\r\nThis method is used in many scientific, industrial and commercial fields."]
                        , ["/Blog/h_1.jpg", "/Blog/aiML.heic"],
                            new(1, "mehrab", "aghaee", "Ceo/Engineer", "09037834381", "/1687271803119.jpg")
                            , new DateTime(2023, 12, 18, 12, 15, 10), [new(1, new(1, "ali", "qasdcb@gfg.bb"), "dfnfgndfn")], "Ai")

                   ,new(2, ["What is DNS ?" , "How DNS works is as follows:"]
                        , ["The Domain Name System, or DNS, is a system used to translate domain names (such as google.com) to their corresponding IP addresses (such as 172.217.168.206). This process of translating a domain name to an IP address allows users to easily access their desired websites and services using domain names."
                        ,"1. DNS request:\r\nWhen a user enters a domain name into their browser, the browser first sends a DNS request to translate that domain name to an IP address. This DNS request is sent to the user's local DNS server."
                        ,"2. Local DNS server:\r\nThe local DNS server (usually provided by the ISP) tries to find the domain name in its memory. If the domain name exists in the local server's memory, the local DNS server returns the corresponding IP address to the browser."]
                        , ["/Blog/doh23.jpg" , "/Blog/Dnswork.heic"],
                            new(1, "mehrab", "aghaee", "Ceo/Engineer", "09037834381", "/1687271803119.jpg")
                            , new DateTime(2023, 9, 11, 22, 30, 0), [new(1, new(1, "ali", "qasdcb@gfg.bb"), "dfnfgndfn")], "Ai")
                   ,
                   new(3, ["Development, DevOps and Cl/Cd"]
                        , ["The word DevOps stands for Operations Development and Collaboration. It refers to several methods that encourage software development professionals (Dev) and information technology operations professionals (Ops) to work together to effectively design and develop system software for companies or consumers."
                        ,"In software engineering, Cl/Cd can be used to check and optimize the performance of algorithms and computational codes. For example, in optimization algorithms, this ratio can be used as an efficiency measure to select and adjust parameters. Also, in the design and development of software related to airplanes and aerospace, Cl/Cd can be used to review and evaluate the performance of systems and algorithms.\r\n​"]
                        , ["/Blog/system-eng.jpg" , "/Blog/clcd.heic"],
                            new(1, "mehrab", "aghaee", "Ceo/Engineer", "09037834381", "/1687271803119.jpg")
                            , new DateTime(2023, 8, 8, 23, 20, 10), [new(1, new(1, "ali", "qasdcb@gfg.bb"), "dfnfgndfn")], "Ai")
                   ,
                   new(4, ["What APIs include and what they are used for?" , "The word API means software programming interface.\r\n(Application Programming Interface)" , "Relationships are structured in different ways. In the following, we introduce three common structures of APIs:"]
                        , ["An API is a set of rules and commands used to communicate and interact between applications and services. Using API, programmers can access the resources and functions of other services and use them in their application. APIs can be of different types and used for different purposes, including web APIs that are used to communicate between web services, operating system APIs that are used to communicate between applications and the operating system, and other APIs. which are designed to communicate between specific programs and services. APIs are usually provided as documentation that includes descriptions and code examples so that programmers can use them properly."
                        , "A: REST (Representational State Transfer): REST is an architectural pattern used to design and develop web APIs. In this structure, each resource on the web is represented by a unique address (URL) and a set of operations that can be performed (such as GET, POST, PUT, DELETE). REST emphasizes the principles of simplicity, adaptability and portability of applications."
                        , "B: SOAP (Simple Object Access Protocol): SOAP is a communication protocol that is used to exchange structured information between different programs. In this structure, information is packaged using XML and sent between the server and the requester using the HTTP or SMTP protocol as the transport layer."
                        , "C: GraphQL: GraphQL is a query language that is used to request data from web services. In this structure, the requester can request exactly the data it needs and get only that. This allows applications to get the data they need without having to make multiple requests and get custom responses based on their needs."]                        
                        , ["/Blog/1700303064569.jfif" , "/Blog/Apiwork.heic"],
                            new(1, "mehrab", "aghaee", "Ceo/Engineer", "09037834381", "/1687271803119.jpg")
                            , new DateTime(2023, 8, 10, 4, 23, 10), [new(1, new(1, "ali", "qasdcb@gfg.bb"), "dfnfgndfn")], "Ai")
                   ,
                   new(5, ["🔶 It should be known that there are many design patterns and each one has its own application, but where do you think these patterns come from?", "🔶 To answer this question, in this series of educational articles, we will learn about the history and useful features of design patterns."]
                        , ["Patterns are common solutions to common problems in object-oriented design. When a solution is repeated over and over in different projects, eventually someone gives it a name and describes the solution in detail. This is basically how to discover a design pattern\r\nDesign patterns were first introduced by Christopher Alexander. Christoph Alexander referred to design patterns as solutions to problems that commonly occur in the programming process. After that, four authors: Erich Gamma," +
                            " John Vlissides, Ralph Johnson, and Richard Helm published the book Design Patterns: Elements of Reusable Object-Oriented Software in 1994, in which they applied the concept of design patterns in programming. The book contained 23 patterns that solved various object-oriented design problems and quickly became one of the best sellers. Because of its long name, people called it \"the book by the gang of four\" or GOF\r\n\r\nSince then, dozens of other object-oriented patterns have been discovered. The \"pattern approach\" became very popular in other areas of programming, so many other patterns now exist outside of object-oriented design." ,
                            "🔺 Some believe that problems such as excessive use of classes, poor design, etc. are among the fundamental problems of object-oriented programming.\r\nDesign patterns provide many benefits to programmers with a correct understanding of the principles of object-oriented programming.\r\nAmong the most important advantages of using them, the following can be mentioned:\r\nIncreasing scalability\r\nIncreasing expandability\r\nIncreasing flexibility\r\nIncreasing the speed of software development\r\nReducing errors and problems\r\n🔸 Reduce the amount of coding"]
                        , ["/Blog/unnamed.png", "/Blog/asdwegefb.jpg"],
                            new(1, "mehrab", "aghaee", "Ceo/Engineer", "09037834381", "/1687271803119.jpg")
                            , new DateTime(2024, 1, 16, 13, 45, 10), [new(1, new(1, "ali", "qasdcb@gfg.bb"), "dfnfgndfn")], "Game")
                   ,
                   new(6, ["What criteria make a junior programmer a professional or senior programmer?" , "Those basic criteria are design patterns." , "What are design patterns and what are their uses?"]
                        , ["Yes, familiarity with data structures, the ability to solve complex problems, object-oriented structure, and work experience are some of the examples that turn a new programmer into a professional programmer, but there is a basic criterion in programming that is very important. It is important because it should be used to improve the speed and quality of software design in order to avoid possible problems such as spaghetti code or non-optimal software."
                        ,"💥 In general, design patterns or design patterns are repeatable general solutions to problems that programmers have struggled with during software development. These solutions were obtained by trial and error by many programmers in a significant period of time and are now known as design patterns.\r\n🌀 Design patterns are not a special or special code that the programmer can add to his project by adding it, they are a set of logical explanations and design algorithms that the programmer must understand in order to be able to use the programming language. Write it yourself.\r\n❗❌ So the design patterns are not related to a specific programming language ❌❗"]
                        , ["/Blog/werg.jpg" , "/Blog/fgjgf.jpg"],
                            new(1, "mehrab", "aghaee", "Ceo/Engineer", "09037834381", "/1687271803119.jpg")
                            , new DateTime(2024, 1, 16, 18, 1, 10), [new(1, new(1, "ali", "qasdcb@gfg.bb"), "dfnfgndfn")], "Game")

               ];

            ViewBag.blogHead = HeadBlogs;
            ViewBag.blogBody = BodyBlogs;

            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
