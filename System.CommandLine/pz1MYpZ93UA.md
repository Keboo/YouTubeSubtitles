[YouTube Video](https://youtu.be/pz1MYpZ93UA)


[00:04:44,230 --> 00:04:49,520](https://youtu.be/pz1MYpZ93UA?t=00h04m44s)

okay I think it's about time we are


[00:04:47,060 --> 00:04:52,610](https://youtu.be/pz1MYpZ93UA?t=00h04m47s)

going to get going so for anybody


[00:04:49,520 --> 00:04:55,550](https://youtu.be/pz1MYpZ93UA?t=00h04m49s)

jumping on expecting to see material


[00:04:52,610 --> 00:04:58,850](https://youtu.be/pz1MYpZ93UA?t=00h04m52s)

design in zamel taking a break from that


[00:04:55,550 --> 00:05:02,210](https://youtu.be/pz1MYpZ93UA?t=00h04m55s)

tonight to go play on a library called


[00:04:58,850 --> 00:05:03,470](https://youtu.be/pz1MYpZ93UA?t=00h04m58s)

system command line so just a brief


[00:05:02,210 --> 00:05:05,900](https://youtu.be/pz1MYpZ93UA?t=00h05m02s)

history for those people who are


[00:05:03,470 --> 00:05:08,720](https://youtu.be/pz1MYpZ93UA?t=00h05m03s)

unfamiliar with it system command line


[00:05:05,900 --> 00:05:11,600](https://youtu.be/pz1MYpZ93UA?t=00h05m05s)

is an open source project being backed


[00:05:08,720 --> 00:05:13,000](https://youtu.be/pz1MYpZ93UA?t=00h05m08s)

by some Microsoft folks who are


[00:05:11,600 --> 00:05:15,860](https://youtu.be/pz1MYpZ93UA?t=00h05m11s)

interested in seeing a better


[00:05:13,000 --> 00:05:18,200](https://youtu.be/pz1MYpZ93UA?t=00h05m13s)

command-line library so it handles


[00:05:15,860 --> 00:05:20,810](https://youtu.be/pz1MYpZ93UA?t=00h05m15s)

parsing of your command-line arguments


[00:05:18,200 --> 00:05:23,390](https://youtu.be/pz1MYpZ93UA?t=00h05m18s)

it handles invocation and there's even a


[00:05:20,810 --> 00:05:25,070](https://youtu.be/pz1MYpZ93UA?t=00h05m20s)

rendering portion of it as well the more


[00:05:23,390 --> 00:05:28,400](https://youtu.be/pz1MYpZ93UA?t=00h05m23s)

interesting portion of it is called


[00:05:25,070 --> 00:05:31,160](https://youtu.be/pz1MYpZ93UA?t=00h05m25s)

there's a library that still kind of to


[00:05:28,400 --> 00:05:33,250](https://youtu.be/pz1MYpZ93UA?t=00h05m28s)

be determined to be named that has been


[00:05:31,160 --> 00:05:36,740](https://youtu.be/pz1MYpZ93UA?t=00h05m31s)

called system command-line dragonfruit


[00:05:33,250 --> 00:05:39,970](https://youtu.be/pz1MYpZ93UA?t=00h05m33s)

and that's kind of where our saga starts


[00:05:36,740 --> 00:05:44,120](https://youtu.be/pz1MYpZ93UA?t=00h05m36s)

tonight so I'm going to flip over to


[00:05:39,970 --> 00:05:47,960](https://youtu.be/pz1MYpZ93UA?t=00h05m39s)

share my screen and I will I will catch


[00:05:44,120 --> 00:05:50,300](https://youtu.be/pz1MYpZ93UA?t=00h05m44s)

everyone up to where we were at so this


[00:05:47,960 --> 00:05:52,640](https://youtu.be/pz1MYpZ93UA?t=00h05m47s)

issue came in because system


[00:05:50,300 --> 00:05:55,669](https://youtu.be/pz1MYpZ93UA?t=00h05m50s)

command-line dragonfruit lets you create


[00:05:52,640 --> 00:05:57,169](https://youtu.be/pz1MYpZ93UA?t=00h05m52s)

strongly typed main methods so what that


[00:05:55,669 --> 00:05:59,360](https://youtu.be/pz1MYpZ93UA?t=00h05m55s)

means let's let's jump over here and


[00:05:57,169 --> 00:06:02,960](https://youtu.be/pz1MYpZ93UA?t=00h05m57s)

I'll show just a quick example from the


[00:05:59,360 --> 00:06:07,060](https://youtu.be/pz1MYpZ93UA?t=00h05m59s)

wiki normally in a command-line


[00:06:02,960 --> 00:06:12,020](https://youtu.be/pz1MYpZ93UA?t=00h06m02s)

application you type your standard


[00:06:07,060 --> 00:06:14,750](https://youtu.be/pz1MYpZ93UA?t=00h06m07s)

public static void main string args just


[00:06:12,020 --> 00:06:16,660](https://youtu.be/pz1MYpZ93UA?t=00h06m12s)

like this it's fine the problem is is


[00:06:14,750 --> 00:06:20,960](https://youtu.be/pz1MYpZ93UA?t=00h06m14s)

dealing with this string array can be


[00:06:16,660 --> 00:06:23,150](https://youtu.be/pz1MYpZ93UA?t=00h06m16s)

far from trivial so what system


[00:06:20,960 --> 00:06:24,890](https://youtu.be/pz1MYpZ93UA?t=00h06m20s)

command-line dragonfruit does is aims to


[00:06:23,150 --> 00:06:27,470](https://youtu.be/pz1MYpZ93UA?t=00h06m23s)

make the the simple use case for


[00:06:24,890 --> 00:06:30,470](https://youtu.be/pz1MYpZ93UA?t=00h06m24s)

command-line apps easier so rather than


[00:06:27,470 --> 00:06:32,840](https://youtu.be/pz1MYpZ93UA?t=00h06m27s)

typing static void main string args it


[00:06:30,470 --> 00:06:34,729](https://youtu.be/pz1MYpZ93UA?t=00h06m30s)

ends up being static void main


[00:06:32,840 --> 00:06:37,220](https://youtu.be/pz1MYpZ93UA?t=00h06m32s)

and then you just declare your arguments


[00:06:34,729 --> 00:06:38,840](https://youtu.be/pz1MYpZ93UA?t=00h06m34s)

in here and dragon fruits got all kinds


[00:06:37,220 --> 00:06:40,640](https://youtu.be/pz1MYpZ93UA?t=00h06m37s)

of fancy bells and whistles to try to


[00:06:38,840 --> 00:06:43,580](https://youtu.be/pz1MYpZ93UA?t=00h06m38s)

make this awesome


[00:06:40,640 --> 00:06:46,100](https://youtu.be/pz1MYpZ93UA?t=00h06m40s)

by default it handles showing up version


[00:06:43,580 --> 00:06:51,200](https://youtu.be/pz1MYpZ93UA?t=00h06m43s)

with - - version it handles generating


[00:06:46,100 --> 00:06:51,620](https://youtu.be/pz1MYpZ93UA?t=00h06m46s)

help with - - help it even reads the xml


[00:06:51,200 --> 00:06:53,210](https://youtu.be/pz1MYpZ93UA?t=00h06m51s)

docs


[00:06:51,620 --> 00:06:56,680](https://youtu.be/pz1MYpZ93UA?t=00h06m51s)

if you've generated those for your help


[00:06:53,210 --> 00:07:00,130](https://youtu.be/pz1MYpZ93UA?t=00h06m53s)

output so all of that works and it makes


[00:06:56,680 --> 00:07:01,690](https://youtu.be/pz1MYpZ93UA?t=00h06m56s)

the at least the sort of the 80 or 90%


[00:07:00,130 --> 00:07:04,780](https://youtu.be/pz1MYpZ93UA?t=00h07m00s)

case of what most people do with


[00:07:01,690 --> 00:07:06,699](https://youtu.be/pz1MYpZ93UA?t=00h07m01s)

command-line apps really really easy so


[00:07:04,780 --> 00:07:10,300](https://youtu.be/pz1MYpZ93UA?t=00h07m04s)

that you don't have to think about how


[00:07:06,699 --> 00:07:11,590](https://youtu.be/pz1MYpZ93UA?t=00h07m06s)

do I go from this into the method where


[00:07:10,300 --> 00:07:13,210](https://youtu.be/pz1MYpZ93UA?t=00h07m10s)

that's actually going to do the work it


[00:07:11,590 --> 00:07:15,100](https://youtu.be/pz1MYpZ93UA?t=00h07m11s)

just jumps straight into the method


[00:07:13,210 --> 00:07:18,970](https://youtu.be/pz1MYpZ93UA?t=00h07m13s)

that's actually going to start doing the


[00:07:15,100 --> 00:07:25,600](https://youtu.be/pz1MYpZ93UA?t=00h07m15s)

work of your command line app so where


[00:07:18,970 --> 00:07:27,039](https://youtu.be/pz1MYpZ93UA?t=00h07m18s)

that leaves us is Elin hasten hasten I


[00:07:25,600 --> 00:07:30,479](https://youtu.be/pz1MYpZ93UA?t=00h07m25s)

apologize I'm probably butchering that


[00:07:27,039 --> 00:07:33,000](https://youtu.be/pz1MYpZ93UA?t=00h07m27s)

name horrendously pointed out that


[00:07:30,479 --> 00:07:36,340](https://youtu.be/pz1MYpZ93UA?t=00h07m30s)

dragon fruit is actually failing on


[00:07:33,000 --> 00:07:37,440](https://youtu.be/pz1MYpZ93UA?t=00h07m33s)

slightly older MS builds I believe this


[00:07:36,340 --> 00:07:40,000](https://youtu.be/pz1MYpZ93UA?t=00h07m36s)

is msbuild


[00:07:37,440 --> 00:07:43,030](https://youtu.be/pz1MYpZ93UA?t=00h07m37s)

V 14 I think that's the Visual Studio


[00:07:40,000 --> 00:07:45,820](https://youtu.be/pz1MYpZ93UA?t=00h07m40s)

2015 if I'm not mistaken and dotnet


[00:07:43,030 --> 00:07:47,680](https://youtu.be/pz1MYpZ93UA?t=00h07m43s)

4-6-2 specifically calling out that it


[00:07:45,820 --> 00:07:50,860](https://youtu.be/pz1MYpZ93UA?t=00h07m45s)

was the old project file format so if


[00:07:47,680 --> 00:07:53,229](https://youtu.be/pz1MYpZ93UA?t=00h07m47s)

you edit your CSP tonnes of XML you're


[00:07:50,860 --> 00:07:56,410](https://youtu.be/pz1MYpZ93UA?t=00h07m50s)

probably on the old CS proj the telltale


[00:07:53,229 --> 00:07:59,860](https://youtu.be/pz1MYpZ93UA?t=00h07m53s)

sign is if you see that root level


[00:07:56,410 --> 00:08:01,660](https://youtu.be/pz1MYpZ93UA?t=00h07m56s)

project tag if that has like XML


[00:07:59,860 --> 00:08:03,729](https://youtu.be/pz1MYpZ93UA?t=00h07m59s)

namespace stuff in it and it's not just


[00:08:01,660 --> 00:08:06,430](https://youtu.be/pz1MYpZ93UA?t=00h08m01s)

a straight tag by itself you're on the


[00:08:03,729 --> 00:08:09,310](https://youtu.be/pz1MYpZ93UA?t=00h08m03s)

old CS project and so he pointed out


[00:08:06,430 --> 00:08:11,800](https://youtu.be/pz1MYpZ93UA?t=00h08m06s)

that this guy was failing and so I I


[00:08:09,310 --> 00:08:14,440](https://youtu.be/pz1MYpZ93UA?t=00h08m09s)

took a took a stab at trying to fix this


[00:08:11,800 --> 00:08:16,960](https://youtu.be/pz1MYpZ93UA?t=00h08m11s)

and point it out one of the key problems


[00:08:14,440 --> 00:08:19,510](https://youtu.be/pz1MYpZ93UA?t=00h08m14s)

is that dragonfruit generates an async


[00:08:16,960 --> 00:08:23,349](https://youtu.be/pz1MYpZ93UA?t=00h08m16s)

main method so let's go look at that


[00:08:19,510 --> 00:08:25,180](https://youtu.be/pz1MYpZ93UA?t=00h08m19s)

real quick so even though you write your


[00:08:23,349 --> 00:08:27,669](https://youtu.be/pz1MYpZ93UA?t=00h08m23s)

normal main mat you write a method like


[00:08:25,180 --> 00:08:30,099](https://youtu.be/pz1MYpZ93UA?t=00h08m25s)

this and it does support async mains so


[00:08:27,669 --> 00:08:33,669](https://youtu.be/pz1MYpZ93UA?t=00h08m27s)

you can do the the return type of int


[00:08:30,099 --> 00:08:37,440](https://youtu.be/pz1MYpZ93UA?t=00h08m30s)

and or tasks event depending on what you


[00:08:33,669 --> 00:08:40,450](https://youtu.be/pz1MYpZ93UA?t=00h08m33s)

end up needing but let's look at how


[00:08:37,440 --> 00:08:42,400](https://youtu.be/pz1MYpZ93UA?t=00h08m37s)

dragonfruit actually works so it's


[00:08:40,450 --> 00:08:43,690](https://youtu.be/pz1MYpZ93UA?t=00h08m40s)

actually a fairly simple path to


[00:08:42,400 --> 00:08:46,600](https://youtu.be/pz1MYpZ93UA?t=00h08m42s)

actually what am i doing I've got Visual


[00:08:43,690 --> 00:08:49,450](https://youtu.be/pz1MYpZ93UA?t=00h08m43s)

Studio open let's go here instead so


[00:08:46,600 --> 00:08:53,589](https://youtu.be/pz1MYpZ93UA?t=00h08m46s)

inside of dragon fruit there are some


[00:08:49,450 --> 00:08:56,830](https://youtu.be/pz1MYpZ93UA?t=00h08m49s)

targets and props files and with nougat


[00:08:53,589 --> 00:08:59,050](https://youtu.be/pz1MYpZ93UA?t=00h08m53s)

packages if you happen to create a


[00:08:56,830 --> 00:09:02,200](https://youtu.be/pz1MYpZ93UA?t=00h08m56s)

target or a props file where the file


[00:08:59,050 --> 00:09:04,750](https://youtu.be/pz1MYpZ93UA?t=00h08m59s)

name before the dot targets matches your


[00:09:02,200 --> 00:09:07,390](https://youtu.be/pz1MYpZ93UA?t=00h09m02s)

nougat package ID these automatically


[00:09:04,750 --> 00:09:10,100](https://youtu.be/pz1MYpZ93UA?t=00h09m04s)

get included with the project when the


[00:09:07,390 --> 00:09:11,660](https://youtu.be/pz1MYpZ93UA?t=00h09m07s)

nougat gets installed which is great


[00:09:10,100 --> 00:09:14,750](https://youtu.be/pz1MYpZ93UA?t=00h09m10s)

it gives you a nice injection point to


[00:09:11,660 --> 00:09:17,509](https://youtu.be/pz1MYpZ93UA?t=00h09m11s)

be able to have your library do stuff so


[00:09:14,750 --> 00:09:20,389](https://youtu.be/pz1MYpZ93UA?t=00h09m14s)

in this case dragonfruit injects this


[00:09:17,509 --> 00:09:23,149](https://youtu.be/pz1MYpZ93UA?t=00h09m17s)

target so core generate dragon fruit


[00:09:20,389 --> 00:09:25,399](https://youtu.be/pz1MYpZ93UA?t=00h09m20s)

program file currently we're only doing


[00:09:23,149 --> 00:09:27,769](https://youtu.be/pz1MYpZ93UA?t=00h09m23s)

c-sharp there is an outstanding request


[00:09:25,399 --> 00:09:31,040](https://youtu.be/pz1MYpZ93UA?t=00h09m25s)

if anybody wants to do Visual Basic as


[00:09:27,769 --> 00:09:33,670](https://youtu.be/pz1MYpZ93UA?t=00h09m27s)

well but then more importantly it goes


[00:09:31,040 --> 00:09:37,279](https://youtu.be/pz1MYpZ93UA?t=00h09m31s)

through and it just generates this file


[00:09:33,670 --> 00:09:40,579](https://youtu.be/pz1MYpZ93UA?t=00h09m33s)

it's nothing fancy public static async


[00:09:37,279 --> 00:09:43,519](https://youtu.be/pz1MYpZ93UA?t=00h09m37s)

task int of main and then it calls this


[00:09:40,579 --> 00:09:45,980](https://youtu.be/pz1MYpZ93UA?t=00h09m40s)

execute assembly async which is great


[00:09:43,519 --> 00:09:48,440](https://youtu.be/pz1MYpZ93UA?t=00h09m43s)

it's an asynchronous method and this all


[00:09:45,980 --> 00:09:50,750](https://youtu.be/pz1MYpZ93UA?t=00h09m45s)

works and the problem is is right now


[00:09:48,440 --> 00:09:52,940](https://youtu.be/pz1MYpZ93UA?t=00h09m48s)

this is using the new CS proj format and


[00:09:50,750 --> 00:09:55,339](https://youtu.be/pz1MYpZ93UA?t=00h09m50s)

so it needs to be updated to support the


[00:09:52,940 --> 00:09:57,860](https://youtu.be/pz1MYpZ93UA?t=00h09m52s)

old CS proj format for anybody working


[00:09:55,339 --> 00:09:59,630](https://youtu.be/pz1MYpZ93UA?t=00h09m55s)

with maybe it's still stuck in Visual


[00:09:57,860 --> 00:10:03,529](https://youtu.be/pz1MYpZ93UA?t=00h09m57s)

Studio 2015 who wants to take advantage


[00:09:59,630 --> 00:10:05,509](https://youtu.be/pz1MYpZ93UA?t=00h09m59s)

of dragon fruit the problem is is just


[00:10:03,529 --> 00:10:08,269](https://youtu.be/pz1MYpZ93UA?t=00h10m03s)

updating this isn't quite good enough


[00:10:05,509 --> 00:10:11,120](https://youtu.be/pz1MYpZ93UA?t=00h10m05s)

because once we update the targets file


[00:10:08,269 --> 00:10:13,899](https://youtu.be/pz1MYpZ93UA?t=00h10m08s)

to support the old CS proj format we now


[00:10:11,120 --> 00:10:18,760](https://youtu.be/pz1MYpZ93UA?t=00h10m11s)

have the problem of targeting the old


[00:10:13,899 --> 00:10:22,430](https://youtu.be/pz1MYpZ93UA?t=00h10m13s)

dotnet framework 4-6-2 doesn't allow


[00:10:18,760 --> 00:10:25,670](https://youtu.be/pz1MYpZ93UA?t=00h10m18s)

asynchronous mains specifically and I


[00:10:22,430 --> 00:10:27,560](https://youtu.be/pz1MYpZ93UA?t=00h10m22s)

should say dotnet framework 462 using


[00:10:25,670 --> 00:10:29,870](https://youtu.be/pz1MYpZ93UA?t=00h10m25s)

the older compiler doesn't support


[00:10:27,560 --> 00:10:32,480](https://youtu.be/pz1MYpZ93UA?t=00h10m27s)

asynchronous main methods which is a


[00:10:29,870 --> 00:10:37,040](https://youtu.be/pz1MYpZ93UA?t=00h10m29s)

problem so now this whole method needs


[00:10:32,480 --> 00:10:39,019](https://youtu.be/pz1MYpZ93UA?t=00h10m32s)

to change to support synchronous okay we


[00:10:37,040 --> 00:10:41,839](https://youtu.be/pz1MYpZ93UA?t=00h10m37s)

can do that so when targeting the old CS


[00:10:39,019 --> 00:10:43,490](https://youtu.be/pz1MYpZ93UA?t=00h10m39s)

proj mirin doing an asynchronous main we


[00:10:41,839 --> 00:10:45,199](https://youtu.be/pz1MYpZ93UA?t=00h10m41s)

generate an old main method like you


[00:10:43,490 --> 00:10:47,149](https://youtu.be/pz1MYpZ93UA?t=00h10m43s)

normally would the problem is is


[00:10:45,199 --> 00:10:49,550](https://youtu.be/pz1MYpZ93UA?t=00h10m45s)

everything all the way down starting


[00:10:47,149 --> 00:10:52,279](https://youtu.be/pz1MYpZ93UA?t=00h10m47s)

from this execute assembly async so


[00:10:49,550 --> 00:11:00,139](https://youtu.be/pz1MYpZ93UA?t=00h10m49s)

let's just jump to that real quick


[00:10:52,279 --> 00:11:03,350](https://youtu.be/pz1MYpZ93UA?t=00h10m52s)

didja to do why is my our sharpers


[00:11:00,139 --> 00:11:05,329](https://youtu.be/pz1MYpZ93UA?t=00h11m00s)

disabled one second let's refire this up


[00:11:03,350 --> 00:11:09,079](https://youtu.be/pz1MYpZ93UA?t=00h11m03s)

resharper should not be disabled


[00:11:05,329 --> 00:11:12,800](https://youtu.be/pz1MYpZ93UA?t=00h11m05s)

I was mucking around with a bunch of my


[00:11:09,079 --> 00:11:14,990](https://youtu.be/pz1MYpZ93UA?t=00h11m09s)

settings earlier and I suspect I had too


[00:11:12,800 --> 00:11:18,199](https://youtu.be/pz1MYpZ93UA?t=00h11m12s)

many visual studios open and I just need


[00:11:14,990 --> 00:11:22,490](https://youtu.be/pz1MYpZ93UA?t=00h11m14s)

to close everything down and relaunch


[00:11:18,199 --> 00:11:23,930](https://youtu.be/pz1MYpZ93UA?t=00h11m18s)

because unfortunately when you modify


[00:11:22,490 --> 00:11:25,250](https://youtu.be/pz1MYpZ93UA?t=00h11m22s)

registry settings and


[00:11:23,930 --> 00:11:28,100](https://youtu.be/pz1MYpZ93UA?t=00h11m23s)

they're weird things to try to get your


[00:11:25,250 --> 00:11:31,820](https://youtu.be/pz1MYpZ93UA?t=00h11m25s)

profile stuff working occasionally you


[00:11:28,100 --> 00:11:37,970](https://youtu.be/pz1MYpZ93UA?t=00h11m28s)

break stuff and I think it just needs a


[00:11:31,820 --> 00:11:40,970](https://youtu.be/pz1MYpZ93UA?t=00h11m31s)

good solid kick but working through this


[00:11:37,970 --> 00:11:42,950](https://youtu.be/pz1MYpZ93UA?t=00h11m37s)

so it calls into an asynchronous method


[00:11:40,970 --> 00:11:45,230](https://youtu.be/pz1MYpZ93UA?t=00h11m40s)

and the problem with our sensei problem


[00:11:42,950 --> 00:11:47,660](https://youtu.be/pz1MYpZ93UA?t=00h11m42s)

the what ends up happening when you're


[00:11:45,230 --> 00:11:49,730](https://youtu.be/pz1MYpZ93UA?t=00h11m45s)

working with async methods inside of


[00:11:47,660 --> 00:11:52,580](https://youtu.be/pz1MYpZ93UA?t=00h11m47s)

c-sharp is that it really ends up being


[00:11:49,730 --> 00:11:56,060](https://youtu.be/pz1MYpZ93UA?t=00h11m49s)

a sink all the way down so if you've got


[00:11:52,580 --> 00:11:57,980](https://youtu.be/pz1MYpZ93UA?t=00h11m52s)

an async task method everything that


[00:11:56,060 --> 00:12:00,170](https://youtu.be/pz1MYpZ93UA?t=00h11m56s)

call that really should be a waiting on


[00:11:57,980 --> 00:12:02,089](https://youtu.be/pz1MYpZ93UA?t=00h11m57s)

that and so you get an async task method


[00:12:00,170 --> 00:12:04,700](https://youtu.be/pz1MYpZ93UA?t=00h12m00s)

who's invoking it and it works its way


[00:12:02,089 --> 00:12:07,370](https://youtu.be/pz1MYpZ93UA?t=00h12m02s)

up there is technically a sink void


[00:12:04,700 --> 00:12:09,500](https://youtu.be/pz1MYpZ93UA?t=00h12m04s)

however a sink void should be avoided in


[00:12:07,370 --> 00:12:12,320](https://youtu.be/pz1MYpZ93UA?t=00h12m07s)

almost all circumstances the one


[00:12:09,500 --> 00:12:15,860](https://youtu.be/pz1MYpZ93UA?t=00h12m09s)

exception is top-level event handler so


[00:12:12,320 --> 00:12:17,690](https://youtu.be/pz1MYpZ93UA?t=00h12m12s)

for people who have seen me do WPF if


[00:12:15,860 --> 00:12:19,820](https://youtu.be/pz1MYpZ93UA?t=00h12m15s)

you say you have a click handler on a


[00:12:17,690 --> 00:12:21,800](https://youtu.be/pz1MYpZ93UA?t=00h12m17s)

button that needs to invoke an async


[00:12:19,820 --> 00:12:24,670](https://youtu.be/pz1MYpZ93UA?t=00h12m19s)

method that's an acceptable case where


[00:12:21,800 --> 00:12:27,920](https://youtu.be/pz1MYpZ93UA?t=00h12m21s)

it's okay to use async void I also


[00:12:24,670 --> 00:12:31,100](https://youtu.be/pz1MYpZ93UA?t=00h12m24s)

personally extend that to mean async


[00:12:27,920 --> 00:12:32,360](https://youtu.be/pz1MYpZ93UA?t=00h12m27s)

void is acceptable for command execute


[00:12:31,100 --> 00:12:35,720](https://youtu.be/pz1MYpZ93UA?t=00h12m31s)

methods as well because those are


[00:12:32,360 --> 00:12:39,740](https://youtu.be/pz1MYpZ93UA?t=00h12m32s)

effectively top-level event handlers but


[00:12:35,720 --> 00:12:41,630](https://youtu.be/pz1MYpZ93UA?t=00h12m35s)

they're there there is some I won't say


[00:12:39,740 --> 00:12:45,610](https://youtu.be/pz1MYpZ93UA?t=00h12m39s)

that's a universally held opinion let's


[00:12:41,630 --> 00:12:48,110](https://youtu.be/pz1MYpZ93UA?t=00h12m41s)

just put it that way ok there we go


[00:12:45,610 --> 00:12:51,950](https://youtu.be/pz1MYpZ93UA?t=00h12m45s)

resharper cause Visual Studio hang on


[00:12:48,110 --> 00:12:53,540](https://youtu.be/pz1MYpZ93UA?t=00h12m48s)

launch that sounds more right ok so


[00:12:51,950 --> 00:13:00,320](https://youtu.be/pz1MYpZ93UA?t=00h12m51s)

let's go find this method here real


[00:12:53,540 --> 00:13:03,620](https://youtu.be/pz1MYpZ93UA?t=00h12m53s)

quick and we will come on come on what's


[00:13:00,320 --> 00:13:07,670](https://youtu.be/pz1MYpZ93UA?t=00h13m00s)

going on resharper you've lost your mind


[00:13:03,620 --> 00:13:10,420](https://youtu.be/pz1MYpZ93UA?t=00h13m03s)

you still think you're disabled nope if


[00:13:07,670 --> 00:13:10,420](https://youtu.be/pz1MYpZ93UA?t=00h13m07s)

I heard yourself out


[00:13:11,640 --> 00:13:17,550](https://youtu.be/pz1MYpZ93UA?t=00h13m11s)

why do I not have my navigate methods


[00:13:14,810 --> 00:13:20,250](https://youtu.be/pz1MYpZ93UA?t=00h13m14s)

what is going on this might be a quick


[00:13:17,550 --> 00:13:22,500](https://youtu.be/pz1MYpZ93UA?t=00h13m17s)

detour or well you reset environments


[00:13:20,250 --> 00:13:24,570](https://youtu.be/pz1MYpZ93UA?t=00h13m20s)

though it seems like it's still figuring


[00:13:22,500 --> 00:13:27,690](https://youtu.be/pz1MYpZ93UA?t=00h13m22s)

itself out so resharper might just need


[00:13:24,570 --> 00:13:31,050](https://youtu.be/pz1MYpZ93UA?t=00h13m24s)

to be it might just be trying to process


[00:13:27,690 --> 00:13:34,680](https://youtu.be/pz1MYpZ93UA?t=00h13m27s)

the whole file come on little buddy you


[00:13:31,050 --> 00:13:36,240](https://youtu.be/pz1MYpZ93UA?t=00h13m31s)

can do this you can do it it is


[00:13:34,680 --> 00:13:38,420](https://youtu.be/pz1MYpZ93UA?t=00h13m34s)

important to make sure that you always


[00:13:36,240 --> 00:13:42,570](https://youtu.be/pz1MYpZ93UA?t=00h13m36s)

talk to your visual studio


[00:13:38,420 --> 00:13:44,279](https://youtu.be/pz1MYpZ93UA?t=00h13m38s)

hey mr. demon wolf unfortunately this


[00:13:42,570 --> 00:13:47,640](https://youtu.be/pz1MYpZ93UA?t=00h13m42s)

does tend to happen to me from time to


[00:13:44,279 --> 00:13:51,480](https://youtu.be/pz1MYpZ93UA?t=00h13m44s)

time especially I have an odd habit of


[00:13:47,640 --> 00:13:53,550](https://youtu.be/pz1MYpZ93UA?t=00h13m47s)

getting my visual studio profiles in all


[00:13:51,480 --> 00:13:56,519](https://youtu.be/pz1MYpZ93UA?t=00h13m51s)

sorts of bad states and so I tend to


[00:13:53,550 --> 00:14:01,350](https://youtu.be/pz1MYpZ93UA?t=00h13m53s)

just occasionally reset pull the plug


[00:13:56,519 --> 00:14:02,700](https://youtu.be/pz1MYpZ93UA?t=00h13m56s)

and wipe and redo everything so the fact


[00:14:01,350 --> 00:14:05,279](https://youtu.be/pz1MYpZ93UA?t=00h14m01s)

that this little circle is sitting here


[00:14:02,700 --> 00:14:12,329](https://youtu.be/pz1MYpZ93UA?t=00h14m02s)

is sort of what I'm waiting on for it to


[00:14:05,279 --> 00:14:12,720](https://youtu.be/pz1MYpZ93UA?t=00h14m05s)

catch up yeah I understand okay there we


[00:14:12,329 --> 00:14:15,600](https://youtu.be/pz1MYpZ93UA?t=00h14m12s)

go


[00:14:12,720 --> 00:14:21,420](https://youtu.be/pz1MYpZ93UA?t=00h14m12s)

that took way too long execute assembly


[00:14:15,600 --> 00:14:23,899](https://youtu.be/pz1MYpZ93UA?t=00h14m15s)

async go go go go go yeah I do tend to


[00:14:21,420 --> 00:14:27,180](https://youtu.be/pz1MYpZ93UA?t=00h14m21s)

jump into vs code quite a bit myself


[00:14:23,899 --> 00:14:30,060](https://youtu.be/pz1MYpZ93UA?t=00h14m23s)

there's a if you go and find the


[00:14:27,180 --> 00:14:34,170](https://youtu.be/pz1MYpZ93UA?t=00h14m27s)

previous streamed that I did on system


[00:14:30,060 --> 00:14:38,100](https://youtu.be/pz1MYpZ93UA?t=00h14m30s)

command line with John I think it's like


[00:14:34,170 --> 00:14:41,399](https://youtu.be/pz1MYpZ93UA?t=00h14m34s)

about an hour and a half hour 42 in he


[00:14:38,100 --> 00:14:43,860](https://youtu.be/pz1MYpZ93UA?t=00h14m38s)

shows a pretty slick setup that he has


[00:14:41,399 --> 00:14:47,130](https://youtu.be/pz1MYpZ93UA?t=00h14m41s)

for toggling out of visual studio into


[00:14:43,860 --> 00:14:48,630](https://youtu.be/pz1MYpZ93UA?t=00h14m43s)

vs code keeping the cursor at the same


[00:14:47,130 --> 00:14:50,640](https://youtu.be/pz1MYpZ93UA?t=00h14m47s)

position so that he can take advantage


[00:14:48,630 --> 00:14:54,870](https://youtu.be/pz1MYpZ93UA?t=00h14m48s)

of the multiple cursor support in vs


[00:14:50,640 --> 00:14:56,940](https://youtu.be/pz1MYpZ93UA?t=00h14m50s)

code which is always a clever trick I


[00:14:54,870 --> 00:14:58,440](https://youtu.be/pz1MYpZ93UA?t=00h14m54s)

need to go through I had it set up on


[00:14:56,940 --> 00:15:01,529](https://youtu.be/pz1MYpZ93UA?t=00h14m56s)

mine and then once again reset my


[00:14:58,440 --> 00:15:05,220](https://youtu.be/pz1MYpZ93UA?t=00h14m58s)

profile and yeah nita set it back up


[00:15:01,529 --> 00:15:08,339](https://youtu.be/pz1MYpZ93UA?t=00h15m01s)

again okay so back so back to the


[00:15:05,220 --> 00:15:09,990](https://youtu.be/pz1MYpZ93UA?t=00h15m05s)

problem so if we were to go through and


[00:15:08,339 --> 00:15:12,269](https://youtu.be/pz1MYpZ93UA?t=00h15m08s)

generate a synchronous main method we


[00:15:09,990 --> 00:15:15,089](https://youtu.be/pz1MYpZ93UA?t=00h15m09s)

now now have the problem of we have this


[00:15:12,269 --> 00:15:17,880](https://youtu.be/pz1MYpZ93UA?t=00h15m12s)

execute assembly async and now we have


[00:15:15,089 --> 00:15:19,620](https://youtu.be/pz1MYpZ93UA?t=00h15m15s)

async although all the way down and


[00:15:17,880 --> 00:15:21,990](https://youtu.be/pz1MYpZ93UA?t=00h15m17s)

basically async throughout the rest of


[00:15:19,620 --> 00:15:23,459](https://youtu.be/pz1MYpZ93UA?t=00h15m19s)

this library so this is still


[00:15:21,990 --> 00:15:24,980](https://youtu.be/pz1MYpZ93UA?t=00h15m21s)

technically up in system command-line


[00:15:23,459 --> 00:15:26,770](https://youtu.be/pz1MYpZ93UA?t=00h15m23s)

dragonfruit land


[00:15:24,980 --> 00:15:30,080](https://youtu.be/pz1MYpZ93UA?t=00h15m24s)

but ultimately if we follow these


[00:15:26,770 --> 00:15:33,380](https://youtu.be/pz1MYpZ93UA?t=00h15m26s)

methods all the way down we'll end up


[00:15:30,080 --> 00:15:36,710](https://youtu.be/pz1MYpZ93UA?t=00h15m30s)

down in the regular system command-line


[00:15:33,380 --> 00:15:41,510](https://youtu.be/pz1MYpZ93UA?t=00h15m33s)

core library with all of its extra stuff


[00:15:36,710 --> 00:15:43,279](https://youtu.be/pz1MYpZ93UA?t=00h15m36s)

so ultimately what we need to do is just


[00:15:41,510 --> 00:15:45,740](https://youtu.be/pz1MYpZ93UA?t=00h15m41s)

jump back over here


[00:15:43,279 --> 00:15:49,550](https://youtu.be/pz1MYpZ93UA?t=00h15m43s)

there was a second request that came in


[00:15:45,740 --> 00:15:51,709](https://youtu.be/pz1MYpZ93UA?t=00h15m45s)

about the parser invoke async forces


[00:15:49,550 --> 00:15:54,680](https://youtu.be/pz1MYpZ93UA?t=00h15m49s)

everyone into the asynchronous pattern


[00:15:51,709 --> 00:15:56,750](https://youtu.be/pz1MYpZ93UA?t=00h15m51s)

which is normally fine except for there


[00:15:54,680 --> 00:15:59,180](https://youtu.be/pz1MYpZ93UA?t=00h15m54s)

are plenty of use cases where maybe you


[00:15:56,750 --> 00:16:01,550](https://youtu.be/pz1MYpZ93UA?t=00h15m56s)

aren't in an async method or you're not


[00:15:59,180 --> 00:16:04,600](https://youtu.be/pz1MYpZ93UA?t=00h15m59s)

in a system that allows for easy async


[00:16:01,550 --> 00:16:07,220](https://youtu.be/pz1MYpZ93UA?t=00h16m01s)

so then what do you do and so the plan


[00:16:04,600 --> 00:16:10,070](https://youtu.be/pz1MYpZ93UA?t=00h16m04s)

at some point was to go through and add


[00:16:07,220 --> 00:16:14,360](https://youtu.be/pz1MYpZ93UA?t=00h16m07s)

a synchronous overload well that plan


[00:16:10,070 --> 00:16:16,190](https://youtu.be/pz1MYpZ93UA?t=00h16m10s)

now gets to be realized tonight the the


[00:16:14,360 --> 00:16:19,790](https://youtu.be/pz1MYpZ93UA?t=00h16m14s)

problem is is there's only so many ways


[00:16:16,190 --> 00:16:22,459](https://youtu.be/pz1MYpZ93UA?t=00h16m16s)

to go through and actually do sync over


[00:16:19,790 --> 00:16:27,050](https://youtu.be/pz1MYpZ93UA?t=00h16m19s)

a sink and so I'm gonna share a couple


[00:16:22,459 --> 00:16:30,290](https://youtu.be/pz1MYpZ93UA?t=00h16m22s)

links in chat these are two articles


[00:16:27,050 --> 00:16:34,370](https://youtu.be/pz1MYpZ93UA?t=00h16m27s)

from Stephen Tao - I hope I'm not


[00:16:30,290 --> 00:16:37,700](https://youtu.be/pz1MYpZ93UA?t=00h16m30s)

butchering that too badly and no the


[00:16:34,370 --> 00:16:39,830](https://youtu.be/pz1MYpZ93UA?t=00h16m34s)

these are two separate links so


[00:16:37,700 --> 00:16:41,959](https://youtu.be/pz1MYpZ93UA?t=00h16m37s)

asynchronous wrappers over synchronous


[00:16:39,830 --> 00:16:44,570](https://youtu.be/pz1MYpZ93UA?t=00h16m39s)

and then the inverse of synchronous


[00:16:41,959 --> 00:16:46,970](https://youtu.be/pz1MYpZ93UA?t=00h16m41s)

wrappers over asynchronous methods so


[00:16:44,570 --> 00:16:48,740](https://youtu.be/pz1MYpZ93UA?t=00h16m44s)

this this one here is actually the case


[00:16:46,970 --> 00:16:51,529](https://youtu.be/pz1MYpZ93UA?t=00h16m46s)

that we find ourselves in however these


[00:16:48,740 --> 00:16:52,850](https://youtu.be/pz1MYpZ93UA?t=00h16m48s)

are very complementary articles and very


[00:16:51,529 --> 00:16:55,550](https://youtu.be/pz1MYpZ93UA?t=00h16m51s)

worthwhile reading if you find yourself


[00:16:52,850 --> 00:17:00,920](https://youtu.be/pz1MYpZ93UA?t=00h16m52s)

needing to do or I should say combining


[00:16:55,550 --> 00:17:02,600](https://youtu.be/pz1MYpZ93UA?t=00h16m55s)

async and synchronous methods so this is


[00:17:00,920 --> 00:17:06,110](https://youtu.be/pz1MYpZ93UA?t=00h17m00s)

the case that we find ourselves in and


[00:17:02,600 --> 00:17:10,579](https://youtu.be/pz1MYpZ93UA?t=00h17m02s)

the the too long didn't read version of


[00:17:06,110 --> 00:17:12,110](https://youtu.be/pz1MYpZ93UA?t=00h17m06s)

this is there's not a great way of going


[00:17:10,579 --> 00:17:14,150](https://youtu.be/pz1MYpZ93UA?t=00h17m10s)

back and forth effectively there's a


[00:17:12,110 --> 00:17:16,069](https://youtu.be/pz1MYpZ93UA?t=00h17m12s)

couple cheater options which we're going


[00:17:14,150 --> 00:17:20,179](https://youtu.be/pz1MYpZ93UA?t=00h17m14s)

to end up needing one of them a little


[00:17:16,069 --> 00:17:22,579](https://youtu.be/pz1MYpZ93UA?t=00h17m16s)

later down in this what if I really do


[00:17:20,179 --> 00:17:24,140](https://youtu.be/pz1MYpZ93UA?t=00h17m20s)

need synchronous ink over a sink which


[00:17:22,579 --> 00:17:26,780](https://youtu.be/pz1MYpZ93UA?t=00h17m22s)

is effectively what we're going to run


[00:17:24,140 --> 00:17:29,780](https://youtu.be/pz1MYpZ93UA?t=00h17m24s)

into but in most cases the correct


[00:17:26,780 --> 00:17:33,410](https://youtu.be/pz1MYpZ93UA?t=00h17m26s)

solution is async all the way down which


[00:17:29,780 --> 00:17:35,870](https://youtu.be/pz1MYpZ93UA?t=00h17m29s)

means effectively having two versions of


[00:17:33,410 --> 00:17:37,760](https://youtu.be/pz1MYpZ93UA?t=00h17m33s)

your method now in c-sharp this ends up


[00:17:35,870 --> 00:17:38,240](https://youtu.be/pz1MYpZ93UA?t=00h17m35s)

looking really weird because you end up


[00:17:37,760 --> 00:17:40,370](https://youtu.be/pz1MYpZ93UA?t=00h17m37s)

with two


[00:17:38,240 --> 00:17:42,740](https://youtu.be/pz1MYpZ93UA?t=00h17m38s)

it's that are almost identical with a


[00:17:40,370 --> 00:17:45,470](https://youtu.be/pz1MYpZ93UA?t=00h17m40s)

few minor exceptions where you drop like


[00:17:42,740 --> 00:17:47,299](https://youtu.be/pz1MYpZ93UA?t=00h17m42s)

the words a weight and a sink out of the


[00:17:45,470 --> 00:17:50,750](https://youtu.be/pz1MYpZ93UA?t=00h17m45s)

method but other than that the code is


[00:17:47,299 --> 00:17:53,899](https://youtu.be/pz1MYpZ93UA?t=00h17m47s)

effectively the same which is really


[00:17:50,750 --> 00:17:55,760](https://youtu.be/pz1MYpZ93UA?t=00h17m50s)

kind of frustrating and from a lot of us


[00:17:53,899 --> 00:17:57,890](https://youtu.be/pz1MYpZ93UA?t=00h17m53s)

programmers we we get this whole dry


[00:17:55,760 --> 00:17:58,610](https://youtu.be/pz1MYpZ93UA?t=00h17m55s)

mentality stuck in our head of do not


[00:17:57,890 --> 00:18:00,710](https://youtu.be/pz1MYpZ93UA?t=00h17m57s)

repeat yourself


[00:17:58,610 --> 00:18:02,570](https://youtu.be/pz1MYpZ93UA?t=00h17m58s)

do not repeat yourself and it looks a


[00:18:00,710 --> 00:18:07,640](https://youtu.be/pz1MYpZ93UA?t=00h18m00s)

whole lot like we're repeating ourselves


[00:18:02,570 --> 00:18:10,850](https://youtu.be/pz1MYpZ93UA?t=00h18m02s)

so we'll do our best to not I should say


[00:18:07,640 --> 00:18:14,000](https://youtu.be/pz1MYpZ93UA?t=00h18m07s)

not necessarily repeat ourselves too


[00:18:10,850 --> 00:18:15,679](https://youtu.be/pz1MYpZ93UA?t=00h18m10s)

much but there is going to be a little


[00:18:14,000 --> 00:18:20,330](https://youtu.be/pz1MYpZ93UA?t=00h18m14s)

bit of copy and paste code or as I'll


[00:18:15,679 --> 00:18:22,580](https://youtu.be/pz1MYpZ93UA?t=00h18m15s)

call it editor inheritance so so going


[00:18:20,330 --> 00:18:24,559](https://youtu.be/pz1MYpZ93UA?t=00h18m20s)

down that just as a little bit more of


[00:18:22,580 --> 00:18:27,020](https://youtu.be/pz1MYpZ93UA?t=00h18m22s)

an explanation so there's a fundamental


[00:18:24,559 --> 00:18:29,539](https://youtu.be/pz1MYpZ93UA?t=00h18m24s)

change that happens when you make an


[00:18:27,020 --> 00:18:32,240](https://youtu.be/pz1MYpZ93UA?t=00h18m27s)

async method even though the c-sharp


[00:18:29,539 --> 00:18:34,880](https://youtu.be/pz1MYpZ93UA?t=00h18m29s)

looks the same the actual compiled il is


[00:18:32,240 --> 00:18:37,130](https://youtu.be/pz1MYpZ93UA?t=00h18m32s)

very very different and that's


[00:18:34,880 --> 00:18:41,960](https://youtu.be/pz1MYpZ93UA?t=00h18m34s)

fundamentally why you end up needing to


[00:18:37,130 --> 00:18:44,390](https://youtu.be/pz1MYpZ93UA?t=00h18m37s)

create two versions of your API so we


[00:18:41,960 --> 00:18:45,919](https://youtu.be/pz1MYpZ93UA?t=00h18m41s)

are going to effectively start as though


[00:18:44,390 --> 00:18:47,330](https://youtu.be/pz1MYpZ93UA?t=00h18m44s)

we were going to write this and we're


[00:18:45,919 --> 00:18:50,600](https://youtu.be/pz1MYpZ93UA?t=00h18m45s)

just going to follow this all the way


[00:18:47,330 --> 00:18:54,590](https://youtu.be/pz1MYpZ93UA?t=00h18m47s)

down and I think for now in the interest


[00:18:50,600 --> 00:18:58,250](https://youtu.be/pz1MYpZ93UA?t=00h18m50s)

of speed we're just going to start from


[00:18:54,590 --> 00:19:01,340](https://youtu.be/pz1MYpZ93UA?t=00h18m54s)

here create a synchronous version and


[00:18:58,250 --> 00:19:04,100](https://youtu.be/pz1MYpZ93UA?t=00h18m58s)

then just chase the rabbit all the way


[00:19:01,340 --> 00:19:06,710](https://youtu.be/pz1MYpZ93UA?t=00h19m01s)

down the hole as it were so that there


[00:19:04,100 --> 00:19:10,909](https://youtu.be/pz1MYpZ93UA?t=00h19m04s)

are effectively two versions of this so


[00:19:06,710 --> 00:19:14,690](https://youtu.be/pz1MYpZ93UA?t=00h19m06s)

we are going to drop a sync from the


[00:19:10,909 --> 00:19:16,669](https://youtu.be/pz1MYpZ93UA?t=00h19m10s)

name change the return type 2-inch drop


[00:19:14,690 --> 00:19:19,190](https://youtu.be/pz1MYpZ93UA?t=00h19m14s)

the async keyword which means we can no


[00:19:16,669 --> 00:19:24,799](https://youtu.be/pz1MYpZ93UA?t=00h19m16s)

longer await this method which means we


[00:19:19,190 --> 00:19:26,570](https://youtu.be/pz1MYpZ93UA?t=00h19m19s)

need invoke method not async so and we


[00:19:24,799 --> 00:19:32,179](https://youtu.be/pz1MYpZ93UA?t=00h19m24s)

are going to just follow this all the


[00:19:26,570 --> 00:19:33,710](https://youtu.be/pz1MYpZ93UA?t=00h19m26s)

way down so jump to here and yeah


[00:19:32,179 --> 00:19:36,289](https://youtu.be/pz1MYpZ93UA?t=00h19m32s)

resharper is thinking I'm very familiar


[00:19:33,710 --> 00:19:38,899](https://youtu.be/pz1MYpZ93UA?t=00h19m33s)

with that concept oh and it's literally


[00:19:36,289 --> 00:19:42,080](https://youtu.be/pz1MYpZ93UA?t=00h19m36s)

right below me so we are gonna copy this


[00:19:38,899 --> 00:19:44,659](https://youtu.be/pz1MYpZ93UA?t=00h19m38s)

guy and just keep going my plan is to


[00:19:42,080 --> 00:19:46,789](https://youtu.be/pz1MYpZ93UA?t=00h19m42s)

come back through these methods and


[00:19:44,659 --> 00:19:49,789](https://youtu.be/pz1MYpZ93UA?t=00h19m44s)

figure out how much of this code can be


[00:19:46,789 --> 00:19:51,740](https://youtu.be/pz1MYpZ93UA?t=00h19m46s)

broken out and shared but at least for


[00:19:49,789 --> 00:19:54,620](https://youtu.be/pz1MYpZ93UA?t=00h19m49s)

the purpose of figuring out what the


[00:19:51,740 --> 00:19:56,780](https://youtu.be/pz1MYpZ93UA?t=00h19m51s)

scope of this is and sort of how much


[00:19:54,620 --> 00:19:58,880](https://youtu.be/pz1MYpZ93UA?t=00h19m54s)

we're gonna end up falling through and


[00:19:56,780 --> 00:20:00,290](https://youtu.be/pz1MYpZ93UA?t=00h19m56s)

needing to change we're just gonna start


[00:19:58,880 --> 00:20:02,090](https://youtu.be/pz1MYpZ93UA?t=00h19m58s)

with a straight up copy and paste and


[00:20:00,290 --> 00:20:04,790](https://youtu.be/pz1MYpZ93UA?t=00h20m00s)

work from there so this gets us down


[00:20:02,090 --> 00:20:07,220](https://youtu.be/pz1MYpZ93UA?t=00h20m02s)

into the parser and vogue async which is


[00:20:04,790 --> 00:20:09,290](https://youtu.be/pz1MYpZ93UA?t=00h20m04s)

what that second issue was commenting on


[00:20:07,220 --> 00:20:12,140](https://youtu.be/pz1MYpZ93UA?t=00h20m07s)

this is effectively the point where


[00:20:09,290 --> 00:20:14,890](https://youtu.be/pz1MYpZ93UA?t=00h20m09s)

we're switching from system command line


[00:20:12,140 --> 00:20:18,410](https://youtu.be/pz1MYpZ93UA?t=00h20m12s)

dragonfruit into system command line


[00:20:14,890 --> 00:20:21,170](https://youtu.be/pz1MYpZ93UA?t=00h20m14s)

core or proper or whatever we want to


[00:20:18,410 --> 00:20:23,809](https://youtu.be/pz1MYpZ93UA?t=00h20m18s)

call it so this is effectively where we


[00:20:21,170 --> 00:20:28,070](https://youtu.be/pz1MYpZ93UA?t=00h20m21s)

need to go so we are going to go in here


[00:20:23,809 --> 00:20:35,240](https://youtu.be/pz1MYpZ93UA?t=00h20m23s)

and we probably actually are going to


[00:20:28,070 --> 00:20:37,340](https://youtu.be/pz1MYpZ93UA?t=00h20m28s)

want to overload all of these yeah let's


[00:20:35,240 --> 00:20:38,510](https://youtu.be/pz1MYpZ93UA?t=00h20m35s)

do them all let's thinking we might just


[00:20:37,340 --> 00:20:40,460](https://youtu.be/pz1MYpZ93UA?t=00h20m37s)

pick on the one but it looks like a


[00:20:38,510 --> 00:20:41,660](https://youtu.be/pz1MYpZ93UA?t=00h20m38s)

bunch of these overloads invoke other


[00:20:40,460 --> 00:20:46,130](https://youtu.be/pz1MYpZ93UA?t=00h20m40s)

versions of the overloads


[00:20:41,660 --> 00:20:51,370](https://youtu.be/pz1MYpZ93UA?t=00h20m41s)

so rather than selectively just picking


[00:20:46,130 --> 00:20:56,470](https://youtu.be/pz1MYpZ93UA?t=00h20m46s)

a couple we're just gonna do them all so


[00:20:51,370 --> 00:21:01,480](https://youtu.be/pz1MYpZ93UA?t=00h20m51s)

invoke this becomes task


[00:20:56,470 --> 00:21:06,200](https://youtu.be/pz1MYpZ93UA?t=00h20m56s)

this becomes invocation pipeline invoke


[00:21:01,480 --> 00:21:09,679](https://youtu.be/pz1MYpZ93UA?t=00h21m01s)

and let's just keep going so this


[00:21:06,200 --> 00:21:14,809](https://youtu.be/pz1MYpZ93UA?t=00h21m06s)

becomes invoke async and this might be a


[00:21:09,679 --> 00:21:17,720](https://youtu.be/pz1MYpZ93UA?t=00h21m09s)

bug here come back to this so there


[00:21:14,809 --> 00:21:19,850](https://youtu.be/pz1MYpZ93UA?t=00h21m14s)

there's a general idea with stack traces


[00:21:17,720 --> 00:21:22,190](https://youtu.be/pz1MYpZ93UA?t=00h21m17s)

that in general you don't necessarily


[00:21:19,850 --> 00:21:23,750](https://youtu.be/pz1MYpZ93UA?t=00h21m19s)

always want to just straight-up return


[00:21:22,190 --> 00:21:25,660](https://youtu.be/pz1MYpZ93UA?t=00h21m22s)

the tasks you always want to await it


[00:21:23,750 --> 00:21:27,860](https://youtu.be/pz1MYpZ93UA?t=00h21m23s)

even if it ends up being a one-liner


[00:21:25,660 --> 00:21:30,200](https://youtu.be/pz1MYpZ93UA?t=00h21m25s)

and I might have to look at that one


[00:21:27,860 --> 00:21:34,270](https://youtu.be/pz1MYpZ93UA?t=00h21m27s)

more closely but in general you


[00:21:30,200 --> 00:21:37,880](https://youtu.be/pz1MYpZ93UA?t=00h21m30s)

typically always want to wait your TAS


[00:21:34,270 --> 00:21:45,080](https://youtu.be/pz1MYpZ93UA?t=00h21m34s)

so that goes to there that goes there


[00:21:37,880 --> 00:21:48,230](https://youtu.be/pz1MYpZ93UA?t=00h21m37s)

let's see here and invoke there this


[00:21:45,080 --> 00:21:51,200](https://youtu.be/pz1MYpZ93UA?t=00h21m45s)

becomes invoke I'm hoping when we get to


[00:21:48,230 --> 00:21:54,290](https://youtu.be/pz1MYpZ93UA?t=00h21m48s)

this last overload it all just kind of


[00:21:51,200 --> 00:21:56,630](https://youtu.be/pz1MYpZ93UA?t=00h21m51s)

falls out yeah see here's another


[00:21:54,290 --> 00:22:00,620](https://youtu.be/pz1MYpZ93UA?t=00h21m54s)

situation where it wasn't awaiting the


[00:21:56,630 --> 00:22:05,030](https://youtu.be/pz1MYpZ93UA?t=00h21m56s)

task it probably should be and it looks


[00:22:00,620 --> 00:22:07,160](https://youtu.be/pz1MYpZ93UA?t=00h22m00s)

like both of these overloads are going


[00:22:05,030 --> 00:22:10,940](https://youtu.be/pz1MYpZ93UA?t=00h22m05s)

to end up falling into invocation


[00:22:07,160 --> 00:22:13,910](https://youtu.be/pz1MYpZ93UA?t=00h22m07s)

pipeline invoke async which is fine


[00:22:10,940 --> 00:22:20,360](https://youtu.be/pz1MYpZ93UA?t=00h22m10s)

that's kind of where would you be ending


[00:22:13,910 --> 00:22:22,460](https://youtu.be/pz1MYpZ93UA?t=00h22m13s)

up anyway okay you need to go not invoke


[00:22:20,360 --> 00:22:26,540](https://youtu.be/pz1MYpZ93UA?t=00h22m20s)

async you need to be invoked


[00:22:22,460 --> 00:22:28,370](https://youtu.be/pz1MYpZ93UA?t=00h22m22s)

you need to not be in a wait and let's


[00:22:26,540 --> 00:22:32,300](https://youtu.be/pz1MYpZ93UA?t=00h22m26s)

see that leaves us just down to


[00:22:28,370 --> 00:22:36,290](https://youtu.be/pz1MYpZ93UA?t=00h22m28s)

invocation pipeline invoke a sink needs


[00:22:32,300 --> 00:22:37,430](https://youtu.be/pz1MYpZ93UA?t=00h22m32s)

to become straight-up invoke and this is


[00:22:36,290 --> 00:22:40,760](https://youtu.be/pz1MYpZ93UA?t=00h22m36s)

where we're going to start to run into


[00:22:37,430 --> 00:22:46,190](https://youtu.be/pz1MYpZ93UA?t=00h22m37s)

problems so in system command line


[00:22:40,760 --> 00:22:48,110](https://youtu.be/pz1MYpZ93UA?t=00h22m40s)

there's an idea about commands options


[00:22:46,190 --> 00:22:49,970](https://youtu.be/pz1MYpZ93UA?t=00h22m46s)

and arguments and there's there's a


[00:22:48,110 --> 00:22:50,870](https://youtu.be/pz1MYpZ93UA?t=00h22m48s)

whole bunch of kind of terminology that


[00:22:49,970 --> 00:22:55,880](https://youtu.be/pz1MYpZ93UA?t=00h22m49s)

goes along with it


[00:22:50,870 --> 00:22:58,070](https://youtu.be/pz1MYpZ93UA?t=00h22m50s)

so over here let's just jump back I


[00:22:55,880 --> 00:23:01,370](https://youtu.be/pz1MYpZ93UA?t=00h22m55s)

believe there was something about this


[00:22:58,070 --> 00:23:04,240](https://youtu.be/pz1MYpZ93UA?t=00h22m58s)

in the wiki if I'm not mistaken and it


[00:23:01,370 --> 00:23:09,830](https://youtu.be/pz1MYpZ93UA?t=00h23m01s)

could just be on the the root level page


[00:23:04,240 --> 00:23:12,860](https://youtu.be/pz1MYpZ93UA?t=00h23m04s)

try it out contribute doo doo syntax


[00:23:09,830 --> 00:23:15,260](https://youtu.be/pz1MYpZ93UA?t=00h23m09s)

concepts and parser so there's kind of a


[00:23:12,860 --> 00:23:17,570](https://youtu.be/pz1MYpZ93UA?t=00h23m12s)

lot of stuff in here about what all of


[00:23:15,260 --> 00:23:20,570](https://youtu.be/pz1MYpZ93UA?t=00h23m15s)

the terminology means and how this all


[00:23:17,570 --> 00:23:22,820](https://youtu.be/pz1MYpZ93UA?t=00h23m17s)

breaks out but the key part that we're


[00:23:20,570 --> 00:23:25,100](https://youtu.be/pz1MYpZ93UA?t=00h23m20s)

going to be interested in is commands


[00:23:22,820 --> 00:23:26,600](https://youtu.be/pz1MYpZ93UA?t=00h23m22s)

and sub commands so for example on


[00:23:25,100 --> 00:23:29,960](https://youtu.be/pz1MYpZ93UA?t=00h23m25s)

something like dot when you execute


[00:23:26,600 --> 00:23:31,820](https://youtu.be/pz1MYpZ93UA?t=00h23m26s)

dotnet build for the purposes of how


[00:23:29,960 --> 00:23:34,670](https://youtu.be/pz1MYpZ93UA?t=00h23m29s)

system command-line ends up parsing this


[00:23:31,820 --> 00:23:37,250](https://youtu.be/pz1MYpZ93UA?t=00h23m31s)

dotnet is your route command build is


[00:23:34,670 --> 00:23:38,810](https://youtu.be/pz1MYpZ93UA?t=00h23m34s)

your sub command and ultimately when


[00:23:37,250 --> 00:23:42,170](https://youtu.be/pz1MYpZ93UA?t=00h23m37s)

you're doing a command line invocation


[00:23:38,810 --> 00:23:45,080](https://youtu.be/pz1MYpZ93UA?t=00h23m38s)

you only invoke a single command at a


[00:23:42,170 --> 00:23:47,120](https://youtu.be/pz1MYpZ93UA?t=00h23m42s)

time so in this case the the innermost


[00:23:45,080 --> 00:23:49,670](https://youtu.be/pz1MYpZ93UA?t=00h23m45s)

sub command is the command that's going


[00:23:47,120 --> 00:23:53,060](https://youtu.be/pz1MYpZ93UA?t=00h23m47s)

to get executed so in this case build


[00:23:49,670 --> 00:23:57,260](https://youtu.be/pz1MYpZ93UA?t=00h23m49s)

would get executed or dotnet add package


[00:23:53,060 --> 00:23:58,460](https://youtu.be/pz1MYpZ93UA?t=00h23m53s)

package is the innermost sub command so


[00:23:57,260 --> 00:24:01,070](https://youtu.be/pz1MYpZ93UA?t=00h23m57s)

it's going to be the command that gets


[00:23:58,460 --> 00:24:02,750](https://youtu.be/pz1MYpZ93UA?t=00h23m58s)

executed so for system command line


[00:24:01,070 --> 00:24:05,780](https://youtu.be/pz1MYpZ93UA?t=00h24m01s)

there's this idea of being able to


[00:24:02,750 --> 00:24:08,800](https://youtu.be/pz1MYpZ93UA?t=00h24m02s)

attach handler methods to each of those


[00:24:05,780 --> 00:24:13,460](https://youtu.be/pz1MYpZ93UA?t=00h24m05s)

commands so when the command is invoked


[00:24:08,800 --> 00:24:15,470](https://youtu.be/pz1MYpZ93UA?t=00h24m08s)

it goes through and will invoke your


[00:24:13,460 --> 00:24:18,830](https://youtu.be/pz1MYpZ93UA?t=00h24m13s)

method for you and pass the appropriate


[00:24:15,470 --> 00:24:22,130](https://youtu.be/pz1MYpZ93UA?t=00h24m15s)

options or various other things that


[00:24:18,830 --> 00:24:24,409](https://youtu.be/pz1MYpZ93UA?t=00h24m18s)

might want and you can attach both


[00:24:22,130 --> 00:24:26,179](https://youtu.be/pz1MYpZ93UA?t=00h24m22s)

synchronous and asynchronous methods as


[00:24:24,409 --> 00:24:29,809](https://youtu.be/pz1MYpZ93UA?t=00h24m24s)

command handlers and it's perfectly


[00:24:26,179 --> 00:24:31,730](https://youtu.be/pz1MYpZ93UA?t=00h24m26s)

happy to deal with that the problem is


[00:24:29,809 --> 00:24:33,710](https://youtu.be/pz1MYpZ93UA?t=00h24m29s)

is now now we've run into this state


[00:24:31,730 --> 00:24:36,289](https://youtu.be/pz1MYpZ93UA?t=00h24m31s)

where we've got an invoke method that's


[00:24:33,710 --> 00:24:38,809](https://youtu.be/pz1MYpZ93UA?t=00h24m33s)

being called and if your command handler


[00:24:36,289 --> 00:24:40,880](https://youtu.be/pz1MYpZ93UA?t=00h24m36s)

is async we're going to have to deal


[00:24:38,809 --> 00:24:43,370](https://youtu.be/pz1MYpZ93UA?t=00h24m38s)

with that here so you'll note right here


[00:24:40,880 --> 00:24:46,070](https://youtu.be/pz1MYpZ93UA?t=00h24m40s)

it goes through on the command result


[00:24:43,370 --> 00:24:46,760](https://youtu.be/pz1MYpZ93UA?t=00h24m43s)

finds the command and grabs the handler


[00:24:46,070 --> 00:24:49,130](https://youtu.be/pz1MYpZ93UA?t=00h24m46s)

off of it


[00:24:46,760 --> 00:24:52,279](https://youtu.be/pz1MYpZ93UA?t=00h24m46s)

which is an I command Handler and then


[00:24:49,130 --> 00:24:55,460](https://youtu.be/pz1MYpZ93UA?t=00h24m49s)

calls invoke async on it and I think


[00:24:52,279 --> 00:24:57,500](https://youtu.be/pz1MYpZ93UA?t=00h24m52s)

this is where we're effectively gonna I


[00:24:55,460 --> 00:24:59,899](https://youtu.be/pz1MYpZ93UA?t=00h24m55s)

think this is where we we have to call


[00:24:57,500 --> 00:25:02,360](https://youtu.be/pz1MYpZ93UA?t=00h24m57s)

in the cheater methods so we want


[00:24:59,899 --> 00:25:04,669](https://youtu.be/pz1MYpZ93UA?t=00h24m59s)

synchronous all the way down as far as


[00:25:02,360 --> 00:25:07,399](https://youtu.be/pz1MYpZ93UA?t=00h25m02s)

it's possible however at a certain point


[00:25:04,669 --> 00:25:10,010](https://youtu.be/pz1MYpZ93UA?t=00h25m04s)

it's no longer possible because this


[00:25:07,399 --> 00:25:12,500](https://youtu.be/pz1MYpZ93UA?t=00h25m07s)

command handler is no longer going to be


[00:25:10,010 --> 00:25:15,820](https://youtu.be/pz1MYpZ93UA?t=00h25m10s)

in our code it's going to be in the


[00:25:12,500 --> 00:25:20,950](https://youtu.be/pz1MYpZ93UA?t=00h25m12s)

user's code of system command line and


[00:25:15,820 --> 00:25:25,029](https://youtu.be/pz1MYpZ93UA?t=00h25m15s)

let's jump back over here so on this


[00:25:20,950 --> 00:25:25,029](https://youtu.be/pz1MYpZ93UA?t=00h25m20s)

article from Stephen


[00:25:25,779 --> 00:25:33,889](https://youtu.be/pz1MYpZ93UA?t=00h25m25s)

let's see offload to another thread this


[00:25:31,519 --> 00:25:36,380](https://youtu.be/pz1MYpZ93UA?t=00h25m31s)

is the the key line right here of what


[00:25:33,889 --> 00:25:38,929](https://youtu.be/pz1MYpZ93UA?t=00h25m33s)

we're looking for so in general you want


[00:25:36,380 --> 00:25:40,610](https://youtu.be/pz1MYpZ93UA?t=00h25m36s)

to avoid dot result calls and I will


[00:25:38,929 --> 00:25:43,549](https://youtu.be/pz1MYpZ93UA?t=00h25m38s)

leave it as an exercise to the reader


[00:25:40,610 --> 00:25:46,490](https://youtu.be/pz1MYpZ93UA?t=00h25m40s)

but if you go through his article above


[00:25:43,549 --> 00:25:48,200](https://youtu.be/pz1MYpZ93UA?t=00h25m43s)

he outlines why dot result is bad and


[00:25:46,490 --> 00:25:50,029](https://youtu.be/pz1MYpZ93UA?t=00h25m46s)

how it can result in deadlock and


[00:25:48,200 --> 00:25:52,549](https://youtu.be/pz1MYpZ93UA?t=00h25m48s)

performance problems so be aware if


[00:25:50,029 --> 00:25:53,929](https://youtu.be/pz1MYpZ93UA?t=00h25m50s)

you're using dot result anywhere go back


[00:25:52,549 --> 00:25:57,980](https://youtu.be/pz1MYpZ93UA?t=00h25m52s)

and double check your code you almost


[00:25:53,929 --> 00:26:00,649](https://youtu.be/pz1MYpZ93UA?t=00h25m53s)

never want it the key trick here is the


[00:25:57,980 --> 00:26:02,480](https://youtu.be/pz1MYpZ93UA?t=00h25m57s)

deadlock situation occurs because you


[00:26:00,649 --> 00:26:04,340](https://youtu.be/pz1MYpZ93UA?t=00h26m00s)

don't necessarily know the execution


[00:26:02,480 --> 00:26:08,899](https://youtu.be/pz1MYpZ93UA?t=00h26m02s)

context in which your method is being


[00:26:04,340 --> 00:26:10,580](https://youtu.be/pz1MYpZ93UA?t=00h26m04s)

invoked so what does that mean some


[00:26:08,899 --> 00:26:14,210](https://youtu.be/pz1MYpZ93UA?t=00h26m08s)

people may be familiar with the concept


[00:26:10,580 --> 00:26:17,120](https://youtu.be/pz1MYpZ93UA?t=00h26m10s)

of thread local variables the idea that


[00:26:14,210 --> 00:26:19,130](https://youtu.be/pz1MYpZ93UA?t=00h26m14s)

you can declare a variable and decorate


[00:26:17,120 --> 00:26:22,159](https://youtu.be/pz1MYpZ93UA?t=00h26m17s)

it with the thread local attribute and


[00:26:19,130 --> 00:26:23,990](https://youtu.be/pz1MYpZ93UA?t=00h26m19s)

for each thread that accesses that


[00:26:22,159 --> 00:26:27,080](https://youtu.be/pz1MYpZ93UA?t=00h26m22s)

variable they effectively get their own


[00:26:23,990 --> 00:26:30,889](https://youtu.be/pz1MYpZ93UA?t=00h26m23s)

instance or backing field as it were for


[00:26:27,080 --> 00:26:32,480](https://youtu.be/pz1MYpZ93UA?t=00h26m27s)

for that variable when the TPL was


[00:26:30,889 --> 00:26:34,370](https://youtu.be/pz1MYpZ93UA?t=00h26m30s)

introduced with the


[00:26:32,480 --> 00:26:39,220](https://youtu.be/pz1MYpZ93UA?t=00h26m32s)

test parallel library there's an


[00:26:34,370 --> 00:26:41,750](https://youtu.be/pz1MYpZ93UA?t=00h26m34s)

equivalent concept of a sink local where


[00:26:39,220 --> 00:26:46,720](https://youtu.be/pz1MYpZ93UA?t=00h26m39s)

when you're looking at code so for


[00:26:41,750 --> 00:26:50,090](https://youtu.be/pz1MYpZ93UA?t=00h26m41s)

example above and below this a weight


[00:26:46,720 --> 00:26:52,550](https://youtu.be/pz1MYpZ93UA?t=00h26m46s)

could very easily be different threads


[00:26:50,090 --> 00:26:54,650](https://youtu.be/pz1MYpZ93UA?t=00h26m50s)

that execute on it so thread-local is


[00:26:52,550 --> 00:26:57,620](https://youtu.be/pz1MYpZ93UA?t=00h26m52s)

less than ideal however there is a


[00:26:54,650 --> 00:27:00,230](https://youtu.be/pz1MYpZ93UA?t=00h26m54s)

concept of async local where the


[00:26:57,620 --> 00:27:02,480](https://youtu.be/pz1MYpZ93UA?t=00h26m57s)

asynchronous context flows through from


[00:27:00,230 --> 00:27:03,740](https://youtu.be/pz1MYpZ93UA?t=00h27m00s)

before and after the await so that


[00:27:02,480 --> 00:27:08,960](https://youtu.be/pz1MYpZ93UA?t=00h27m02s)

there's some means of preserving


[00:27:03,740 --> 00:27:11,810](https://youtu.be/pz1MYpZ93UA?t=00h27m03s)

variables and by doing this task run


[00:27:08,960 --> 00:27:14,210](https://youtu.be/pz1MYpZ93UA?t=00h27m08s)

what this effectively does is forces


[00:27:11,810 --> 00:27:16,040](https://youtu.be/pz1MYpZ93UA?t=00h27m11s)

this asynchronous method off onto a


[00:27:14,210 --> 00:27:18,710](https://youtu.be/pz1MYpZ93UA?t=00h27m14s)

thread pool thread where we know we


[00:27:16,040 --> 00:27:20,900](https://youtu.be/pz1MYpZ93UA?t=00h27m16s)

won't necessarily have an execution


[00:27:18,710 --> 00:27:23,750](https://youtu.be/pz1MYpZ93UA?t=00h27m18s)

context to cause a deadlock and then


[00:27:20,900 --> 00:27:28,220](https://youtu.be/pz1MYpZ93UA?t=00h27m20s)

call dot result on it now this is far


[00:27:23,750 --> 00:27:31,100](https://youtu.be/pz1MYpZ93UA?t=00h27m23s)

from ideal but it gets us out of the


[00:27:28,220 --> 00:27:32,870](https://youtu.be/pz1MYpZ93UA?t=00h27m28s)

scary deadlock situation because there


[00:27:31,100 --> 00:27:36,140](https://youtu.be/pz1MYpZ93UA?t=00h27m31s)

won't be a synchronization context for


[00:27:32,870 --> 00:27:38,390](https://youtu.be/pz1MYpZ93UA?t=00h27m32s)

it to sink back on and we should be able


[00:27:36,140 --> 00:27:40,490](https://youtu.be/pz1MYpZ93UA?t=00h27m36s)

to run fine because system command line


[00:27:38,390 --> 00:27:43,310](https://youtu.be/pz1MYpZ93UA?t=00h27m38s)

being a generic command line processor


[00:27:40,490 --> 00:27:45,770](https://youtu.be/pz1MYpZ93UA?t=00h27m40s)

it could be used in a WPF application it


[00:27:43,310 --> 00:27:47,330](https://youtu.be/pz1MYpZ93UA?t=00h27m43s)

could be used in asp net core


[00:27:45,770 --> 00:27:50,240](https://youtu.be/pz1MYpZ93UA?t=00h27m45s)

application if somebody wanted to


[00:27:47,330 --> 00:27:53,540](https://youtu.be/pz1MYpZ93UA?t=00h27m47s)

process those or just a straight-up CLI


[00:27:50,240 --> 00:27:56,000](https://youtu.be/pz1MYpZ93UA?t=00h27m50s)

app so because we're acting kind of both


[00:27:53,540 --> 00:28:00,410](https://youtu.be/pz1MYpZ93UA?t=00h27m53s)

as a library and a framework we have to


[00:27:56,000 --> 00:28:02,150](https://youtu.be/pz1MYpZ93UA?t=00h27m56s)

try and be diligent to block or to


[00:28:00,410 --> 00:28:03,830](https://youtu.be/pz1MYpZ93UA?t=00h28m00s)

prevent problems from occurring so I


[00:28:02,150 --> 00:28:09,560](https://youtu.be/pz1MYpZ93UA?t=00h28m02s)

believe this is the trick that we want


[00:28:03,830 --> 00:28:13,150](https://youtu.be/pz1MYpZ93UA?t=00h28m03s)

to deal with right about in here because


[00:28:09,560 --> 00:28:16,130](https://youtu.be/pz1MYpZ93UA?t=00h28m09s)

we've got two places where we've got


[00:28:13,150 --> 00:28:19,310](https://youtu.be/pz1MYpZ93UA?t=00h28m13s)

invocations happening so invocation


[00:28:16,130 --> 00:28:20,510](https://youtu.be/pz1MYpZ93UA?t=00h28m16s)

chain and I'm just gonna have to dig


[00:28:19,310 --> 00:28:24,380](https://youtu.be/pz1MYpZ93UA?t=00h28m19s)

through this forum instance it's been a


[00:28:20,510 --> 00:28:26,390](https://youtu.be/pz1MYpZ93UA?t=00h28m20s)

little while since I looked at this one


[00:28:24,380 --> 00:28:28,490](https://youtu.be/pz1MYpZ93UA?t=00h28m24s)

of these I believe is an asynchronous


[00:28:26,390 --> 00:28:33,490](https://youtu.be/pz1MYpZ93UA?t=00h28m26s)

method and let me turn off my


[00:28:28,490 --> 00:28:36,260](https://youtu.be/pz1MYpZ93UA?t=00h28m28s)

notifications so those stop pestering


[00:28:33,490 --> 00:28:39,880](https://youtu.be/pz1MYpZ93UA?t=00h28m33s)

because I believe this method right here


[00:28:36,260 --> 00:28:42,320](https://youtu.be/pz1MYpZ93UA?t=00h28m36s)

is where we want to do the task run


[00:28:39,880 --> 00:28:43,790](https://youtu.be/pz1MYpZ93UA?t=00h28m39s)

cheater mode because again we wanted we


[00:28:42,320 --> 00:28:46,190](https://youtu.be/pz1MYpZ93UA?t=00h28m42s)

want to avoid doing that cheater


[00:28:43,790 --> 00:28:49,940](https://youtu.be/pz1MYpZ93UA?t=00h28m43s)

approach as long as possible


[00:28:46,190 --> 00:28:54,020](https://youtu.be/pz1MYpZ93UA?t=00h28m46s)

and one of these so this adds in the


[00:28:49,940 --> 00:28:57,170](https://youtu.be/pz1MYpZ93UA?t=00h28m49s)

invocation this one aggregates so if


[00:28:54,020 --> 00:29:01,310](https://youtu.be/pz1MYpZ93UA?t=00h28m54s)

first second context next so each one


[00:28:57,170 --> 00:29:06,980](https://youtu.be/pz1MYpZ93UA?t=00h28m57s)

calls the next one and then this passes


[00:29:01,310 --> 00:29:10,400](https://youtu.be/pz1MYpZ93UA?t=00h29m01s)

it in invocation chain context task


[00:29:06,980 --> 00:29:14,660](https://youtu.be/pz1MYpZ93UA?t=00h29m06s)

completed source so this guy was the one


[00:29:10,400 --> 00:29:16,670](https://youtu.be/pz1MYpZ93UA?t=00h29m10s)

that was previously I think the problem


[00:29:14,660 --> 00:29:22,670](https://youtu.be/pz1MYpZ93UA?t=00h29m14s)

is this bar here is making it really


[00:29:16,670 --> 00:29:25,490](https://youtu.be/pz1MYpZ93UA?t=00h29m16s)

hard to see what's happening there it is


[00:29:22,670 --> 00:29:30,040](https://youtu.be/pz1MYpZ93UA?t=00h29m22s)

so this guy is a task returning


[00:29:25,490 --> 00:29:33,260](https://youtu.be/pz1MYpZ93UA?t=00h29m25s)

effectively an asynchronous method that


[00:29:30,040 --> 00:29:36,800](https://youtu.be/pz1MYpZ93UA?t=00h29m30s)

right there is the crux of our problems


[00:29:33,260 --> 00:29:39,400](https://youtu.be/pz1MYpZ93UA?t=00h29m33s)

so I think this is where we actually


[00:29:36,800 --> 00:29:39,400](https://youtu.be/pz1MYpZ93UA?t=00h29m36s)

want to do it


[00:29:40,300 --> 00:29:51,680](https://youtu.be/pz1MYpZ93UA?t=00h29m40s)

tasks run and I believe we just want to


[00:29:46,370 --> 00:29:53,450](https://youtu.be/pz1MYpZ93UA?t=00h29m46s)

do this this here here I think we just


[00:29:51,680 --> 00:29:54,980](https://youtu.be/pz1MYpZ93UA?t=00h29m51s)

want wait because I don't believe we


[00:29:53,450 --> 00:29:57,080](https://youtu.be/pz1MYpZ93UA?t=00h29m53s)

care about the return this is


[00:29:54,980 --> 00:30:00,620](https://youtu.be/pz1MYpZ93UA?t=00h29m54s)

effectively avoid returning asynchronous


[00:29:57,080 --> 00:30:04,030](https://youtu.be/pz1MYpZ93UA?t=00h29m57s)

method we'll wait for it here we'll let


[00:30:00,620 --> 00:30:09,590](https://youtu.be/pz1MYpZ93UA?t=00h30m00s)

this guy flow all the way through I


[00:30:04,030 --> 00:30:13,340](https://youtu.be/pz1MYpZ93UA?t=00h30m04s)

think that gets us pretty close so now


[00:30:09,590 --> 00:30:15,770](https://youtu.be/pz1MYpZ93UA?t=00h30m09s)

we've modified a bunch of stuff let's go


[00:30:13,340 --> 00:30:19,850](https://youtu.be/pz1MYpZ93UA?t=00h30m13s)

through and I think what we're gonna try


[00:30:15,770 --> 00:30:22,310](https://youtu.be/pz1MYpZ93UA?t=00h30m15s)

next is to fix up all the corresponding


[00:30:19,850 --> 00:30:24,080](https://youtu.be/pz1MYpZ93UA?t=00h30m19s)

unit tests because I want to make sure I


[00:30:22,310 --> 00:30:26,060](https://youtu.be/pz1MYpZ93UA?t=00h30m22s)

haven't broken anything in the process


[00:30:24,080 --> 00:30:29,570](https://youtu.be/pz1MYpZ93UA?t=00h30m24s)

because we only modified a few files all


[00:30:26,060 --> 00:30:37,990](https://youtu.be/pz1MYpZ93UA?t=00h30m26s)

the way down just take a look at exactly


[00:30:29,570 --> 00:30:40,730](https://youtu.be/pz1MYpZ93UA?t=00h30m29s)

what it is one in dragonfruit invocation


[00:30:37,990 --> 00:30:43,100](https://youtu.be/pz1MYpZ93UA?t=00h30m37s)

extensions and invocation pipeline and I


[00:30:40,730 --> 00:30:47,950](https://youtu.be/pz1MYpZ93UA?t=00h30m40s)

suspect those might be unit tested in


[00:30:43,100 --> 00:30:47,950](https://youtu.be/pz1MYpZ93UA?t=00h30m43s)

the same place let's take a look


[00:30:49,720 --> 00:30:56,540](https://youtu.be/pz1MYpZ93UA?t=00h30m49s)

location location pipeline test and


[00:30:54,260 --> 00:30:59,710](https://youtu.be/pz1MYpZ93UA?t=00h30m54s)

extensions tests this is almost


[00:30:56,540 --> 00:30:59,710](https://youtu.be/pz1MYpZ93UA?t=00h30m56s)

assuredly where we want to go


[00:31:02,990 --> 00:31:12,510](https://youtu.be/pz1MYpZ93UA?t=00h31m02s)

so I think let's see here so we have a


[00:31:09,150 --> 00:31:15,000](https://youtu.be/pz1MYpZ93UA?t=00h31m09s)

command we have a description set on the


[00:31:12,510 --> 00:31:20,220](https://youtu.be/pz1MYpZ93UA?t=00h31m12s)

command with some help text and when the


[00:31:15,000 --> 00:31:23,520](https://youtu.be/pz1MYpZ93UA?t=00h31m15s)

command is invoked with - H we expect


[00:31:20,220 --> 00:31:26,940](https://youtu.be/pz1MYpZ93UA?t=00h31m20s)

the help output to be generated or to be


[00:31:23,520 --> 00:31:36,570](https://youtu.be/pz1MYpZ93UA?t=00h31m23s)

included in the output which is fine so


[00:31:26,940 --> 00:31:38,280](https://youtu.be/pz1MYpZ93UA?t=00h31m26s)

I think I think we just start here and


[00:31:36,570 --> 00:31:40,440](https://youtu.be/pz1MYpZ93UA?t=00h31m36s)

start cleaning some of this up so rather


[00:31:38,280 --> 00:31:43,530](https://youtu.be/pz1MYpZ93UA?t=00h31m38s)

than invoke async start with the name


[00:31:40,440 --> 00:31:48,210](https://youtu.be/pz1MYpZ93UA?t=00h31m40s)

and work our way down and we don't do


[00:31:43,530 --> 00:31:51,660](https://youtu.be/pz1MYpZ93UA?t=00h31m43s)

invoke async we do invoke we no longer


[00:31:48,210 --> 00:31:56,520](https://youtu.be/pz1MYpZ93UA?t=00h31m48s)

oh wait it just do that this is now a


[00:31:51,660 --> 00:31:59,600](https://youtu.be/pz1MYpZ93UA?t=00h31m51s)

void returning method because it's no


[00:31:56,520 --> 00:32:03,240](https://youtu.be/pz1MYpZ93UA?t=00h31m56s)

longer asynchronous and the way we go


[00:31:59,600 --> 00:32:13,680](https://youtu.be/pz1MYpZ93UA?t=00h31m59s)

okay I think we can probably do that


[00:32:03,240 --> 00:32:16,970](https://youtu.be/pz1MYpZ93UA?t=00h32m03s)

most of the way down it would be nice to


[00:32:13,680 --> 00:32:19,950](https://youtu.be/pz1MYpZ93UA?t=00h32m13s)

share some of this code between these


[00:32:16,970 --> 00:32:24,630](https://youtu.be/pz1MYpZ93UA?t=00h32m16s)

but I don't think there's an effective


[00:32:19,950 --> 00:32:26,280](https://youtu.be/pz1MYpZ93UA?t=00h32m19s)

way to do that so this I'm gonna switch


[00:32:24,630 --> 00:32:29,100](https://youtu.be/pz1MYpZ93UA?t=00h32m24s)

this off a bar because I don't think


[00:32:26,280 --> 00:32:35,700](https://youtu.be/pz1MYpZ93UA?t=00h32m26s)

that's very intuitive that that's an


[00:32:29,100 --> 00:32:40,500](https://youtu.be/pz1MYpZ93UA?t=00h32m29s)

intra turn root command VOC returning


[00:32:35,700 --> 00:32:42,960](https://youtu.be/pz1MYpZ93UA?t=00h32m35s)

zero when command is invoked so we've


[00:32:40,500 --> 00:32:49,380](https://youtu.be/pz1MYpZ93UA?t=00h32m40s)

got a root command we attach a handler


[00:32:42,960 --> 00:32:51,780](https://youtu.be/pz1MYpZ93UA?t=00h32m42s)

to it this guy up an action delegate is


[00:32:49,380 --> 00:32:56,070](https://youtu.be/pz1MYpZ93UA?t=00h32m49s)

worth noting to create these handlers on


[00:32:51,780 --> 00:32:58,050](https://youtu.be/pz1MYpZ93UA?t=00h32m51s)

the commands this command handler class


[00:32:56,070 --> 00:33:00,870](https://youtu.be/pz1MYpZ93UA?t=00h32m56s)

is the easiest way to go about doing it


[00:32:58,050 --> 00:33:05,820](https://youtu.be/pz1MYpZ93UA?t=00h32m58s)

there are tons of overloads for various


[00:33:00,870 --> 00:33:08,280](https://youtu.be/pz1MYpZ93UA?t=00h33m00s)

generic sets there currently the create


[00:33:05,820 --> 00:33:10,890](https://youtu.be/pz1MYpZ93UA?t=00h33m05s)

is capped at seven generic parameters


[00:33:08,280 --> 00:33:12,560](https://youtu.be/pz1MYpZ93UA?t=00h33m08s)

but it's worth knowing that you if you


[00:33:10,890 --> 00:33:14,960](https://youtu.be/pz1MYpZ93UA?t=00h33m10s)

end up needing more than


[00:33:12,560 --> 00:33:18,440](https://youtu.be/pz1MYpZ93UA?t=00h33m12s)

an alternative option is to just declare


[00:33:14,960 --> 00:33:19,550](https://youtu.be/pz1MYpZ93UA?t=00h33m14s)

a poco and use that as the parameter and


[00:33:18,440 --> 00:33:24,160](https://youtu.be/pz1MYpZ93UA?t=00h33m18s)

have it bind up there


[00:33:19,550 --> 00:33:29,690](https://youtu.be/pz1MYpZ93UA?t=00h33m19s)

that's probably simpler so equivalent


[00:33:24,160 --> 00:33:36,560](https://youtu.be/pz1MYpZ93UA?t=00h33m24s)

functions etc etc etc and get result


[00:33:29,690 --> 00:33:49,910](https://youtu.be/pz1MYpZ93UA?t=00h33m29s)

code wondering if this is actually where


[00:33:36,560 --> 00:33:51,310](https://youtu.be/pz1MYpZ93UA?t=00h33m36s)

we should change this because this got


[00:33:49,910 --> 00:33:53,990](https://youtu.be/pz1MYpZ93UA?t=00h33m49s)

here


[00:33:51,310 --> 00:34:00,350](https://youtu.be/pz1MYpZ93UA?t=00h33m51s)

you know I'm thinking we may want to


[00:33:53,990 --> 00:34:05,510](https://youtu.be/pz1MYpZ93UA?t=00h33m53s)

change up this code just a little bit so


[00:34:00,350 --> 00:34:09,350](https://youtu.be/pz1MYpZ93UA?t=00h34m00s)

rather than going through and doing this


[00:34:05,510 --> 00:34:17,480](https://youtu.be/pz1MYpZ93UA?t=00h34m05s)

guy here I'm wondering if we should push


[00:34:09,350 --> 00:34:20,630](https://youtu.be/pz1MYpZ93UA?t=00h34m09s)

this down a little bit further I'm


[00:34:17,480 --> 00:34:23,200](https://youtu.be/pz1MYpZ93UA?t=00h34m17s)

thinking so I am thinking that is what


[00:34:20,630 --> 00:34:25,909](https://youtu.be/pz1MYpZ93UA?t=00h34m20s)

we want to do so let's let's take this


[00:34:23,200 --> 00:34:29,060](https://youtu.be/pz1MYpZ93UA?t=00h34m23s)

out because again we want to push this


[00:34:25,909 --> 00:34:39,740](https://youtu.be/pz1MYpZ93UA?t=00h34m25s)

down as far as we can go which means


[00:34:29,060 --> 00:34:43,340](https://youtu.be/pz1MYpZ93UA?t=00h34m29s)

this guy here invocation chain this well


[00:34:39,740 --> 00:34:46,640](https://youtu.be/pz1MYpZ93UA?t=00h34m39s)

let's let's come back to let's come back


[00:34:43,340 --> 00:34:58,210](https://youtu.be/pz1MYpZ93UA?t=00h34m43s)

to that in just a second so invoke async


[00:34:46,640 --> 00:34:58,210](https://youtu.be/pz1MYpZ93UA?t=00h34m46s)

I think what we want is invoke like that


[00:34:59,570 --> 00:35:06,490](https://youtu.be/pz1MYpZ93UA?t=00h34m59s)

like it's that much going handler invoke


[00:35:04,500 --> 00:35:10,510](https://youtu.be/pz1MYpZ93UA?t=00h35m04s)

[Music]


[00:35:06,490 --> 00:35:10,510](https://youtu.be/pz1MYpZ93UA?t=00h35m06s)

what are you squawking at before


[00:35:15,180 --> 00:35:28,829](https://youtu.be/pz1MYpZ93UA?t=00h35m15s)

and natto copass terms of value well


[00:35:25,890 --> 00:35:35,099](https://youtu.be/pz1MYpZ93UA?t=00h35m25s)

what are you expecting invocation


[00:35:28,829 --> 00:35:36,029](https://youtu.be/pz1MYpZ93UA?t=00h35m28s)

middleware oh boy oh boy oh boy oh boy


[00:35:35,099 --> 00:35:42,599](https://youtu.be/pz1MYpZ93UA?t=00h35m35s)

oh boy oh boy


[00:35:36,029 --> 00:35:50,750](https://youtu.be/pz1MYpZ93UA?t=00h35m36s)

cuz this guy wants a task I think it's


[00:35:42,599 --> 00:35:50,750](https://youtu.be/pz1MYpZ93UA?t=00h35m42s)

probably okay to just default that is


[00:35:52,339 --> 00:36:02,160](https://youtu.be/pz1MYpZ93UA?t=00h35m52s)

that a change in behavior the problem is


[00:36:00,180 --> 00:36:05,990](https://youtu.be/pz1MYpZ93UA?t=00h36m00s)

that means this guy is effectively to


[00:36:02,160 --> 00:36:05,990](https://youtu.be/pz1MYpZ93UA?t=00h36m02s)

returning to TAS so


[00:36:17,000 --> 00:36:20,930](https://youtu.be/pz1MYpZ93UA?t=00h36m17s)

how to handle this


[00:36:26,119 --> 00:36:33,390](https://youtu.be/pz1MYpZ93UA?t=00h36m26s)

mmm I do not know I do not know well


[00:36:31,800 --> 00:36:35,280](https://youtu.be/pz1MYpZ93UA?t=00h36m31s)

let's keep let's come back to that in a


[00:36:33,390 --> 00:36:40,609](https://youtu.be/pz1MYpZ93UA?t=00h36m33s)

minute so because this is effectively


[00:36:35,280 --> 00:36:40,609](https://youtu.be/pz1MYpZ93UA?t=00h36m35s)

our one spot where we do the invoke


[00:36:41,240 --> 00:36:55,160](https://youtu.be/pz1MYpZ93UA?t=00h36m41s)

copy/paste again implement the sync


[00:36:46,710 --> 00:37:02,309](https://youtu.be/pz1MYpZ93UA?t=00h36m46s)

version and then get result code sync


[00:36:55,160 --> 00:37:05,819](https://youtu.be/pz1MYpZ93UA?t=00h36m55s)

it's going to become get result code so


[00:37:02,309 --> 00:37:10,140](https://youtu.be/pz1MYpZ93UA?t=00h37m02s)

come in here and I think because here we


[00:37:05,819 --> 00:37:12,450](https://youtu.be/pz1MYpZ93UA?t=00h37m05s)

can avoid having to do that extra task


[00:37:10,140 --> 00:37:16,260](https://youtu.be/pz1MYpZ93UA?t=00h37m10s)

allocation so in the event that somebody


[00:37:12,450 --> 00:37:20,280](https://youtu.be/pz1MYpZ93UA?t=00h37m12s)

has no asynchronous methods we don't


[00:37:16,260 --> 00:37:28,040](https://youtu.be/pz1MYpZ93UA?t=00h37m16s)

necessarily need to do task allocations


[00:37:20,280 --> 00:37:28,040](https://youtu.be/pz1MYpZ93UA?t=00h37m20s)

if unless the return type was a task I


[00:37:30,140 --> 00:37:35,180](https://youtu.be/pz1MYpZ93UA?t=00h37m30s)

think this is where we want to go


[00:37:32,490 --> 00:37:35,180](https://youtu.be/pz1MYpZ93UA?t=00h37m32s)

through and do it


[00:37:35,240 --> 00:37:42,510](https://youtu.be/pz1MYpZ93UA?t=00h37m35s)

let's see same methods already declared


[00:37:38,990 --> 00:37:49,950](https://youtu.be/pz1MYpZ93UA?t=00h37m38s)

didn't rename it properly let's go back


[00:37:42,510 --> 00:37:59,450](https://youtu.be/pz1MYpZ93UA?t=00h37m42s)

here because that's effectively what we


[00:37:49,950 --> 00:37:59,450](https://youtu.be/pz1MYpZ93UA?t=00h37m49s)

want here is we want to return let's see


[00:38:04,849 --> 00:38:16,200](https://youtu.be/pz1MYpZ93UA?t=00h38m04s)

this is awaiting the task that's a


[00:38:12,660 --> 00:38:19,319](https://youtu.be/pz1MYpZ93UA?t=00h38m12s)

problem though isn't it because we


[00:38:16,200 --> 00:38:23,990](https://youtu.be/pz1MYpZ93UA?t=00h38m16s)

actually want to invoke that this invoke


[00:38:19,319 --> 00:38:23,990](https://youtu.be/pz1MYpZ93UA?t=00h38m19s)

is what we want inside of that method


[00:38:37,220 --> 00:38:42,460](https://youtu.be/pz1MYpZ93UA?t=00h38m37s)

I believe we can cheat this a little bit


[00:38:48,590 --> 00:39:01,930](https://youtu.be/pz1MYpZ93UA?t=00h38m48s)

is that the same so let's think this guy


[00:38:56,270 --> 00:39:04,280](https://youtu.be/pz1MYpZ93UA?t=00h38m56s)

all the way through and here we have


[00:39:01,930 --> 00:39:08,510](https://youtu.be/pz1MYpZ93UA?t=00h39m01s)

just comment you out for the moment so


[00:39:04,280 --> 00:39:11,120](https://youtu.be/pz1MYpZ93UA?t=00h39m04s)

you stops complaining so we in call


[00:39:08,510 --> 00:39:17,990](https://youtu.be/pz1MYpZ93UA?t=00h39m08s)

dynamic invoke which will run through


[00:39:11,120 --> 00:39:28,850](https://youtu.be/pz1MYpZ93UA?t=00h39m11s)

and return the task already started we


[00:39:17,990 --> 00:39:33,100](https://youtu.be/pz1MYpZ93UA?t=00h39m17s)

call get result code on it a problem


[00:39:28,850 --> 00:39:33,100](https://youtu.be/pz1MYpZ93UA?t=00h39m28s)

being that that is not quite the same


[00:39:36,220 --> 00:39:41,200](https://youtu.be/pz1MYpZ93UA?t=00h39m36s)

fully sync will now be invoked on the


[00:39:38,720 --> 00:39:41,200](https://youtu.be/pz1MYpZ93UA?t=00h39m38s)

thread pool


[00:39:46,100 --> 00:39:50,840](https://youtu.be/pz1MYpZ93UA?t=00h39m46s)

which is the whole point of doing this


[00:39:50,960 --> 00:40:00,330](https://youtu.be/pz1MYpZ93UA?t=00h39m50s)

so we need to do something slightly


[00:39:53,340 --> 00:40:03,980](https://youtu.be/pz1MYpZ93UA?t=00h39m53s)

different up here so where does a result


[00:40:00,330 --> 00:40:03,980](https://youtu.be/pz1MYpZ93UA?t=00h40m00s)

come from one of these two places


[00:40:08,190 --> 00:40:15,210](https://youtu.be/pz1MYpZ93UA?t=00h40m08s)

so I think what we do is we're gonna


[00:40:10,010 --> 00:40:20,520](https://youtu.be/pz1MYpZ93UA?t=00h40m10s)

change this up a little bit but I'd


[00:40:15,210 --> 00:40:25,430](https://youtu.be/pz1MYpZ93UA?t=00h40m15s)

really hate to do this but I think what


[00:40:20,520 --> 00:40:25,430](https://youtu.be/pz1MYpZ93UA?t=00h40m20s)

we do is something like this


[00:40:36,809 --> 00:40:46,179](https://youtu.be/pz1MYpZ93UA?t=00h40m36s)

task is sealed right


[00:40:39,369 --> 00:40:49,659](https://youtu.be/pz1MYpZ93UA?t=00h40m39s)

I think it's seal I'd really hate to go


[00:40:46,179 --> 00:40:54,839](https://youtu.be/pz1MYpZ93UA?t=00h40m46s)

through and do this task run which is


[00:40:49,659 --> 00:40:54,839](https://youtu.be/pz1MYpZ93UA?t=00h40m49s)

fairly expensive unless I have to


[00:41:00,450 --> 00:41:15,380](https://youtu.be/pz1MYpZ93UA?t=00h41m00s)

you know and I so we could check oh that


[00:41:12,060 --> 00:41:15,380](https://youtu.be/pz1MYpZ93UA?t=00h41m12s)

might be better option


[00:41:28,910 --> 00:41:39,690](https://youtu.be/pz1MYpZ93UA?t=00h41m28s)

because what I'd really love to do is


[00:41:31,020 --> 00:41:45,780](https://youtu.be/pz1MYpZ93UA?t=00h41m31s)

change this up so that rather than wrong


[00:41:39,690 --> 00:41:48,900](https://youtu.be/pz1MYpZ93UA?t=00h41m39s)

spot okay model binding handler so that


[00:41:45,780 --> 00:41:52,310](https://youtu.be/pz1MYpZ93UA?t=00h41m45s)

rather than doing this invoke here this


[00:41:48,900 --> 00:42:03,200](https://youtu.be/pz1MYpZ93UA?t=00h41m48s)

gets invoked as potentially part of a


[00:41:52,310 --> 00:42:05,670](https://youtu.be/pz1MYpZ93UA?t=00h41m52s)

callback because at this point here we


[00:42:03,200 --> 00:42:08,550](https://youtu.be/pz1MYpZ93UA?t=00h42m03s)

effectively know our return type


[00:42:05,670 --> 00:42:10,740](https://youtu.be/pz1MYpZ93UA?t=00h42m05s)

right because handler delegate will have


[00:42:08,550 --> 00:42:14,460](https://youtu.be/pz1MYpZ93UA?t=00h42m08s)

a method info that we can get the return


[00:42:10,740 --> 00:42:16,050](https://youtu.be/pz1MYpZ93UA?t=00h42m10s)

type off of or handler method info will


[00:42:14,460 --> 00:42:18,540](https://youtu.be/pz1MYpZ93UA?t=00h42m14s)

have a return type that we can also get


[00:42:16,050 --> 00:42:22,710](https://youtu.be/pz1MYpZ93UA?t=00h42m16s)

the return return value off of or the


[00:42:18,540 --> 00:42:31,380](https://youtu.be/pz1MYpZ93UA?t=00h42m18s)

return type off of so in either of those


[00:42:22,710 --> 00:42:34,020](https://youtu.be/pz1MYpZ93UA?t=00h42m22s)

cases that would be acceptable I'm just


[00:42:31,380 --> 00:42:37,190](https://youtu.be/pz1MYpZ93UA?t=00h42m31s)

trying to decide how this get result


[00:42:34,020 --> 00:42:37,190](https://youtu.be/pz1MYpZ93UA?t=00h42m34s)

code needs to work


[00:42:47,990 --> 00:42:52,980](https://youtu.be/pz1MYpZ93UA?t=00h42m47s)

Soho because we don't necessarily need


[00:42:50,430 --> 00:42:56,360](https://youtu.be/pz1MYpZ93UA?t=00h42m50s)

to handle all return types just task


[00:42:52,980 --> 00:42:56,360](https://youtu.be/pz1MYpZ93UA?t=00h42m52s)

vent and task


[00:43:07,680 --> 00:43:16,170](https://youtu.be/pz1MYpZ93UA?t=00h43m07s)

I'm wondering if something like so just


[00:43:12,310 --> 00:43:16,170](https://youtu.be/pz1MYpZ93UA?t=00h43m12s)

playing with this for the moment so I


[00:43:21,990 --> 00:43:30,400](https://youtu.be/pz1MYpZ93UA?t=00h43m21s)

think we do something like if is a sync


[00:43:26,320 --> 00:43:47,140](https://youtu.be/pz1MYpZ93UA?t=00h43m26s)

method and this is the more interesting


[00:43:30,400 --> 00:43:49,920](https://youtu.be/pz1MYpZ93UA?t=00h43m30s)

case task run get value just put you


[00:43:47,140 --> 00:43:49,920](https://youtu.be/pz1MYpZ93UA?t=00h43m47s)

down in here


[00:44:02,240 --> 00:44:05,890](https://youtu.be/pz1MYpZ93UA?t=00h44m02s)

because the question is what


[00:44:11,280 --> 00:44:18,420](https://youtu.be/pz1MYpZ93UA?t=00h44m11s)

what to actually do here because this


[00:44:14,190 --> 00:44:26,340](https://youtu.be/pz1MYpZ93UA?t=00h44m14s)

effectively needs to do this sort of


[00:44:18,420 --> 00:44:28,560](https://youtu.be/pz1MYpZ93UA?t=00h44m18s)

thing with the context result code if


[00:44:26,340 --> 00:44:31,440](https://youtu.be/pz1MYpZ93UA?t=00h44m26s)

there's a an integer return from the


[00:44:28,560 --> 00:44:34,349](https://youtu.be/pz1MYpZ93UA?t=00h44m28s)

handler method we want that otherwise we


[00:44:31,440 --> 00:44:43,890](https://youtu.be/pz1MYpZ93UA?t=00h44m31s)

want the integer off of the contacts


[00:44:34,349 --> 00:44:45,210](https://youtu.be/pz1MYpZ93UA?t=00h44m34s)

result code so well this is effectively


[00:44:43,890 --> 00:44:51,660](https://youtu.be/pz1MYpZ93UA?t=00h44m43s)

where the switch statement would come


[00:44:45,210 --> 00:44:54,109](https://youtu.be/pz1MYpZ93UA?t=00h44m45s)

into play here but it's going to be more


[00:44:51,660 --> 00:44:54,109](https://youtu.be/pz1MYpZ93UA?t=00h44m51s)

like this


[00:44:55,920 --> 00:45:02,340](https://youtu.be/pz1MYpZ93UA?t=00h44m55s)

and then we can actually go back to more


[00:44:58,920 --> 00:45:08,609](https://youtu.be/pz1MYpZ93UA?t=00h44m58s)

akin to these if this is effectively


[00:45:02,340 --> 00:45:11,750](https://youtu.be/pz1MYpZ93UA?t=00h45m02s)

exactly what we have and then this can


[00:45:08,609 --> 00:45:11,750](https://youtu.be/pz1MYpZ93UA?t=00h45m08s)

become a sink


[00:45:24,940 --> 00:45:36,890](https://youtu.be/pz1MYpZ93UA?t=00h45m24s)

and that works a little nicer and then


[00:45:29,950 --> 00:45:52,910](https://youtu.be/pz1MYpZ93UA?t=00h45m29s)

this else case becomes the rest of the


[00:45:36,890 --> 00:45:56,300](https://youtu.be/pz1MYpZ93UA?t=00h45m36s)

rest of the switch where we do something


[00:45:52,910 --> 00:45:58,930](https://youtu.be/pz1MYpZ93UA?t=00h45m52s)

like that this is taking advantage of


[00:45:56,300 --> 00:46:01,550](https://youtu.be/pz1MYpZ93UA?t=00h45m56s)

the C sharp seven pattern matching


[00:45:58,930 --> 00:46:05,900](https://youtu.be/pz1MYpZ93UA?t=00h45m58s)

except for a neither of these cases need


[00:46:01,550 --> 00:46:08,210](https://youtu.be/pz1MYpZ93UA?t=00h46m01s)

to be handled and it's more like this oh


[00:46:05,900 --> 00:46:10,510](https://youtu.be/pz1MYpZ93UA?t=00h46m05s)

thank you for sharper telling me that I


[00:46:08,210 --> 00:46:13,510](https://youtu.be/pz1MYpZ93UA?t=00h46m08s)

can throw that away


[00:46:10,510 --> 00:46:13,510](https://youtu.be/pz1MYpZ93UA?t=00h46m10s)

wonderful


[00:46:22,660 --> 00:46:26,819](https://youtu.be/pz1MYpZ93UA?t=00h46m22s)

does this work for me


[00:46:30,370 --> 00:46:38,720](https://youtu.be/pz1MYpZ93UA?t=00h46m30s)

it technically works not overly happy


[00:46:33,950 --> 00:46:40,490](https://youtu.be/pz1MYpZ93UA?t=00h46m33s)

with it but it works so let's let's go


[00:46:38,720 --> 00:46:48,170](https://youtu.be/pz1MYpZ93UA?t=00h46m38s)

with works first and then clean up


[00:46:40,490 --> 00:46:55,610](https://youtu.be/pz1MYpZ93UA?t=00h46m40s)

second so this is going to become lambda


[00:46:48,170 --> 00:47:03,110](https://youtu.be/pz1MYpZ93UA?t=00h46m48s)

there and this is going to become pool


[00:46:55,610 --> 00:47:05,330](https://youtu.be/pz1MYpZ93UA?t=00h46m55s)

is a sink method gets let's see this is


[00:47:03,110 --> 00:47:09,170](https://youtu.be/pz1MYpZ93UA?t=00h47m03s)

a little simpler because this just


[00:47:05,330 --> 00:47:11,210](https://youtu.be/pz1MYpZ93UA?t=00h47m05s)

becomes a straight-up returned this goes


[00:47:09,170 --> 00:47:19,060](https://youtu.be/pz1MYpZ93UA?t=00h47m09s)

away and this becomes a straight-up


[00:47:11,210 --> 00:47:19,060](https://youtu.be/pz1MYpZ93UA?t=00h47m11s)

return and this is


[00:47:25,190 --> 00:47:32,310](https://youtu.be/pz1MYpZ93UA?t=00h47m25s)

so let's do the same check if handle or


[00:47:28,830 --> 00:47:39,410](https://youtu.be/pz1MYpZ93UA?t=00h47m28s)

delegate equals equals null then we will


[00:47:32,310 --> 00:47:44,210](https://youtu.be/pz1MYpZ93UA?t=00h47m32s)

do well start with this type return type


[00:47:39,410 --> 00:47:44,210](https://youtu.be/pz1MYpZ93UA?t=00h47m39s)

so the return type is either going to be


[00:47:45,110 --> 00:48:02,390](https://youtu.be/pz1MYpZ93UA?t=00h47m45s)

handle or delegate or into their method


[00:47:56,670 --> 00:48:15,510](https://youtu.be/pz1MYpZ93UA?t=00h47m56s)

info return type so return type equals


[00:48:02,390 --> 00:48:21,810](https://youtu.be/pz1MYpZ93UA?t=00h48m02s)

type of task or return type equals task


[00:48:15,510 --> 00:48:24,000](https://youtu.be/pz1MYpZ93UA?t=00h48m15s)

of int and that variable isn't needed


[00:48:21,810 --> 00:48:28,860](https://youtu.be/pz1MYpZ93UA?t=00h48m21s)

anymore and that goes away and so then


[00:48:24,000 --> 00:48:35,400](https://youtu.be/pz1MYpZ93UA?t=00h48m24s)

we pass is async method not sure I like


[00:48:28,860 --> 00:48:43,280](https://youtu.be/pz1MYpZ93UA?t=00h48m28s)

the name of this to rename this I think


[00:48:35,400 --> 00:48:43,280](https://youtu.be/pz1MYpZ93UA?t=00h48m35s)

it's more clear how about returns tasks


[00:48:45,230 --> 00:48:52,940](https://youtu.be/pz1MYpZ93UA?t=00h48m45s)

still not happy with it but we'll come


[00:48:47,490 --> 00:48:57,510](https://youtu.be/pz1MYpZ93UA?t=00h48m47s)

back to it again okay so command handler


[00:48:52,940 --> 00:48:59,550](https://youtu.be/pz1MYpZ93UA?t=00h48m52s)

is up here and let's go we'd started


[00:48:57,510 --> 00:49:01,440](https://youtu.be/pz1MYpZ93UA?t=00h48m57s)

writing unit tests and then I got


[00:48:59,550 --> 00:49:03,840](https://youtu.be/pz1MYpZ93UA?t=00h48m59s)

distracted and decided to move some


[00:49:01,440 --> 00:49:09,960](https://youtu.be/pz1MYpZ93UA?t=00h49m01s)

stuff so let's start once again with


[00:49:03,840 --> 00:49:19,380](https://youtu.be/pz1MYpZ93UA?t=00h49m03s)

these guys and a specific invocation


[00:49:09,960 --> 00:49:21,540](https://youtu.be/pz1MYpZ93UA?t=00h49m09s)

handler so command handler create so


[00:49:19,380 --> 00:49:23,100](https://youtu.be/pz1MYpZ93UA?t=00h49m19s)

aside from all of these calling in vote


[00:49:21,540 --> 00:49:29,520](https://youtu.be/pz1MYpZ93UA?t=00h49m21s)

all of these are ultimately going


[00:49:23,100 --> 00:49:33,380](https://youtu.be/pz1MYpZ93UA?t=00h49m23s)

through invoke async just the same spot


[00:49:29,520 --> 00:49:33,380](https://youtu.be/pz1MYpZ93UA?t=00h49m29s)

our other one went through


[00:49:39,119 --> 00:49:44,160](https://youtu.be/pz1MYpZ93UA?t=00h49m39s)

because ultimately a lot of these are


[00:49:41,190 --> 00:49:46,619](https://youtu.be/pz1MYpZ93UA?t=00h49m41s)

trying to handle testing this model


[00:49:44,160 --> 00:49:50,359](https://youtu.be/pz1MYpZ93UA?t=00h49m44s)

binding command handler because right


[00:49:46,619 --> 00:49:52,529](https://youtu.be/pz1MYpZ93UA?t=00h49m46s)

now this is the only implementation of I


[00:49:50,359 --> 00:49:56,489](https://youtu.be/pz1MYpZ93UA?t=00h49m50s)

command handler that's built into the


[00:49:52,529 --> 00:49:58,079](https://youtu.be/pz1MYpZ93UA?t=00h49m52s)

library obviously that's an


[00:49:56,489 --> 00:50:00,569](https://youtu.be/pz1MYpZ93UA?t=00h49m56s)

implementation detail and subject to


[00:49:58,079 --> 00:50:05,789](https://youtu.be/pz1MYpZ93UA?t=00h49m58s)

change at any point but currently that


[00:50:00,569 --> 00:50:09,839](https://youtu.be/pz1MYpZ93UA?t=00h50m00s)

is true so I'm trying to decide if any


[00:50:05,789 --> 00:50:11,729](https://youtu.be/pz1MYpZ93UA?t=00h50m05s)

of these is just flatten these so all of


[00:50:09,839 --> 00:50:22,019](https://youtu.be/pz1MYpZ93UA?t=00h50m09s)

these are only async because they're


[00:50:11,729 --> 00:50:27,539](https://youtu.be/pz1MYpZ93UA?t=00h50m11s)

doing command and boquete sink which is


[00:50:22,019 --> 00:50:32,640](https://youtu.be/pz1MYpZ93UA?t=00h50m22s)

that this is the same this is the same


[00:50:27,539 --> 00:50:35,130](https://youtu.be/pz1MYpZ93UA?t=00h50m27s)

entry method as before I'm inclined to


[00:50:32,640 --> 00:50:43,400](https://youtu.be/pz1MYpZ93UA?t=00h50m32s)

ignore those tests at least for now and


[00:50:35,130 --> 00:50:50,009](https://youtu.be/pz1MYpZ93UA?t=00h50m35s)

focus on these ones so this guy here


[00:50:43,400 --> 00:50:52,440](https://youtu.be/pz1MYpZ93UA?t=00h50m43s)

let's root command okay always like even


[00:50:50,009 --> 00:50:55,200](https://youtu.be/pz1MYpZ93UA?t=00h50m50s)

white space Roo command invoke a sink


[00:50:52,440 --> 00:51:03,479](https://youtu.be/pz1MYpZ93UA?t=00h50m52s)

root command invoke the command invoke a


[00:50:55,200 --> 00:51:05,819](https://youtu.be/pz1MYpZ93UA?t=00h50m55s)

sink let's once again change this up and


[00:51:03,479 --> 00:51:07,769](https://youtu.be/pz1MYpZ93UA?t=00h51m03s)

make this a void returning method and


[00:51:05,819 --> 00:51:09,299](https://youtu.be/pz1MYpZ93UA?t=00h51m05s)

then we'll actually run this and verify


[00:51:07,769 --> 00:51:16,519](https://youtu.be/pz1MYpZ93UA?t=00h51m07s)

that things actually work the way we


[00:51:09,299 --> 00:51:19,680](https://youtu.be/pz1MYpZ93UA?t=00h51m09s)

expect let's see so this creates it up


[00:51:16,519 --> 00:51:24,630](https://youtu.be/pz1MYpZ93UA?t=00h51m16s)

this is no longer an async method so we


[00:51:19,680 --> 00:51:33,930](https://youtu.be/pz1MYpZ93UA?t=00h51m19s)

remove that that becomes a straight-up


[00:51:24,630 --> 00:51:39,479](https://youtu.be/pz1MYpZ93UA?t=00h51m24s)

invoke and then let's do this let's see


[00:51:33,930 --> 00:51:44,279](https://youtu.be/pz1MYpZ93UA?t=00h51m33s)

here void return replace invoke a sink


[00:51:39,479 --> 00:51:46,859](https://youtu.be/pz1MYpZ93UA?t=00h51m39s)

with invoke drop the await I'm gonna


[00:51:44,279 --> 00:51:52,279](https://youtu.be/pz1MYpZ93UA?t=00h51m44s)

change this nope


[00:51:46,859 --> 00:51:52,279](https://youtu.be/pz1MYpZ93UA?t=00h51m46s)

rename this then I'll auto code the bar


[00:51:54,679 --> 00:52:04,829](https://youtu.be/pz1MYpZ93UA?t=00h51m54s)

okay so let's start with that and let's


[00:52:01,019 --> 00:52:07,289](https://youtu.be/pz1MYpZ93UA?t=00h52m01s)

make sure we haven't broken anything and


[00:52:04,829 --> 00:52:11,849](https://youtu.be/pz1MYpZ93UA?t=00h52m04s)

then we'll see about refactoring some of


[00:52:07,289 --> 00:52:17,519](https://youtu.be/pz1MYpZ93UA?t=00h52m07s)

these methods for reuse there's probably


[00:52:11,849 --> 00:52:18,869](https://youtu.be/pz1MYpZ93UA?t=00h52m11s)

a decent amount of code I hope that


[00:52:17,519 --> 00:52:22,609](https://youtu.be/pz1MYpZ93UA?t=00h52m17s)

could be shared between both the


[00:52:18,869 --> 00:52:22,609](https://youtu.be/pz1MYpZ93UA?t=00h52m18s)

synchronous and asynchronous versions


[00:52:24,979 --> 00:52:30,559](https://youtu.be/pz1MYpZ93UA?t=00h52m24s)

because just because you have to declare


[00:52:27,409 --> 00:52:32,640](https://youtu.be/pz1MYpZ93UA?t=00h52m27s)

effectively two versions of the API


[00:52:30,559 --> 00:52:33,619](https://youtu.be/pz1MYpZ93UA?t=00h52m30s)

doesn't mean that there can't be code


[00:52:32,640 --> 00:52:36,419](https://youtu.be/pz1MYpZ93UA?t=00h52m32s)

sharing between them


[00:52:33,619 --> 00:52:39,599](https://youtu.be/pz1MYpZ93UA?t=00h52m33s)

obviously I started with the editor


[00:52:36,419 --> 00:52:44,390](https://youtu.be/pz1MYpZ93UA?t=00h52m36s)

inheritance copy and paste approach but


[00:52:39,599 --> 00:52:46,579](https://youtu.be/pz1MYpZ93UA?t=00h52m39s)

that is that is just as a starting point


[00:52:44,390 --> 00:52:49,049](https://youtu.be/pz1MYpZ93UA?t=00h52m44s)

okay


[00:52:46,579 --> 00:52:51,539](https://youtu.be/pz1MYpZ93UA?t=00h52m46s)

let this guy go through and compile it


[00:52:49,049 --> 00:52:52,859](https://youtu.be/pz1MYpZ93UA?t=00h52m49s)

up I'm I'm guessing there's a few more


[00:52:51,539 --> 00:52:58,279](https://youtu.be/pz1MYpZ93UA?t=00h52m51s)

than eight tests once this thing


[00:52:52,859 --> 00:53:00,359](https://youtu.be/pz1MYpZ93UA?t=00h52m52s)

actually runs I suspect this was the


[00:52:58,279 --> 00:53:02,239](https://youtu.be/pz1MYpZ93UA?t=00h52m58s)

possibly the live unit testing


[00:53:00,359 --> 00:53:08,299](https://youtu.be/pz1MYpZ93UA?t=00h53m00s)

discovering the tests as I added them


[00:53:02,239 --> 00:53:11,099](https://youtu.be/pz1MYpZ93UA?t=00h53m02s)

just great there's probably a few more


[00:53:08,299 --> 00:53:13,159](https://youtu.be/pz1MYpZ93UA?t=00h53m08s)

yeah just a few things to compile and


[00:53:11,099 --> 00:53:13,159](https://youtu.be/pz1MYpZ93UA?t=00h53m11s)

run


[00:53:23,500 --> 00:53:35,570](https://youtu.be/pz1MYpZ93UA?t=00h53m23s)

and as always I need my caffeine to keep


[00:53:27,110 --> 00:53:38,660](https://youtu.be/pz1MYpZ93UA?t=00h53m27s)

going those who are a little unfamiliar


[00:53:35,570 --> 00:53:46,040](https://youtu.be/pz1MYpZ93UA?t=00h53m35s)

with it I have a small caffeine


[00:53:38,660 --> 00:53:49,520](https://youtu.be/pz1MYpZ93UA?t=00h53m38s)

addiction there that looks more like the


[00:53:46,040 --> 00:53:53,330](https://youtu.be/pz1MYpZ93UA?t=00h53m46s)

unit test I was expecting like all the


[00:53:49,520 --> 00:53:55,430](https://youtu.be/pz1MYpZ93UA?t=00h53m49s)

things suppose we technically don't need


[00:53:53,330 --> 00:53:58,520](https://youtu.be/pz1MYpZ93UA?t=00h53m53s)

to be running all of these I'm really


[00:53:55,430 --> 00:54:01,250](https://youtu.be/pz1MYpZ93UA?t=00h53m55s)

mostly concerned just with the actually


[00:53:58,520 --> 00:54:05,240](https://youtu.be/pz1MYpZ93UA?t=00h53m58s)

just with these 39 for the moment it's


[00:54:01,250 --> 00:54:06,740](https://youtu.be/pz1MYpZ93UA?t=00h54m01s)

really all I care about but will let the


[00:54:05,240 --> 00:54:09,080](https://youtu.be/pz1MYpZ93UA?t=00h54m05s)

whole suite run for the moment and then


[00:54:06,740 --> 00:54:10,900](https://youtu.be/pz1MYpZ93UA?t=00h54m06s)

we'll go see about fixing up some more


[00:54:09,080 --> 00:54:14,210](https://youtu.be/pz1MYpZ93UA?t=00h54m09s)

of them I do think that we probably need


[00:54:10,900 --> 00:54:18,760](https://youtu.be/pz1MYpZ93UA?t=00h54m10s)

some of the command handler tests to get


[00:54:14,210 --> 00:54:18,760](https://youtu.be/pz1MYpZ93UA?t=00h54m14s)

changed or at least more to be added


[00:54:19,300 --> 00:54:26,540](https://youtu.be/pz1MYpZ93UA?t=00h54m19s)

we'll see how this plays out and most of


[00:54:24,920 --> 00:54:30,260](https://youtu.be/pz1MYpZ93UA?t=00h54m24s)

these tests are fairly fast but again


[00:54:26,540 --> 00:54:33,980](https://youtu.be/pz1MYpZ93UA?t=00h54m26s)

this was a clean clone ish for me


[00:54:30,260 --> 00:54:36,130](https://youtu.be/pz1MYpZ93UA?t=00h54m30s)

so it's this hasn't been run in a little


[00:54:33,980 --> 00:54:36,130](https://youtu.be/pz1MYpZ93UA?t=00h54m33s)

while


[00:54:42,890 --> 00:54:47,910](https://youtu.be/pz1MYpZ93UA?t=00h54m42s)

and you can say most these tests are


[00:54:45,569 --> 00:54:51,359](https://youtu.be/pz1MYpZ93UA?t=00h54m45s)

pretty fast the slow part is usually


[00:54:47,910 --> 00:54:56,700](https://youtu.be/pz1MYpZ93UA?t=00h54m47s)

just getting the run or spun up and


[00:54:51,359 --> 00:54:59,760](https://youtu.be/pz1MYpZ93UA?t=00h54m51s)

running huzzah those ones worked great


[00:54:56,700 --> 00:55:04,680](https://youtu.be/pz1MYpZ93UA?t=00h54m56s)

we are making progress


[00:54:59,760 --> 00:55:07,260](https://youtu.be/pz1MYpZ93UA?t=00h54m59s)

let's see model binding so we only


[00:55:04,680 --> 00:55:11,960](https://youtu.be/pz1MYpZ93UA?t=00h55m04s)

handled the invocation extensions let's


[00:55:07,260 --> 00:55:11,960](https://youtu.be/pz1MYpZ93UA?t=00h55m07s)

handle the invocation pipeline as well


[00:55:12,020 --> 00:55:20,180](https://youtu.be/pz1MYpZ93UA?t=00h55m12s)

let's go take a look at these clean out


[00:55:17,059 --> 00:55:33,450](https://youtu.be/pz1MYpZ93UA?t=00h55m17s)

the clear tab bankruptcy and start over


[00:55:20,180 --> 00:55:35,520](https://youtu.be/pz1MYpZ93UA?t=00h55m20s)

okay so see use middleware and this is


[00:55:33,450 --> 00:55:39,690](https://youtu.be/pz1MYpZ93UA?t=00h55m33s)

where it gets weird because just because


[00:55:35,520 --> 00:55:42,780](https://youtu.be/pz1MYpZ93UA?t=00h55m35s)

this is using invoke async I do want to


[00:55:39,690 --> 00:55:48,000](https://youtu.be/pz1MYpZ93UA?t=00h55m39s)

validate that invoke behaves the same as


[00:55:42,780 --> 00:55:52,549](https://youtu.be/pz1MYpZ93UA?t=00h55m42s)

in vogue async but most of these are


[00:55:48,000 --> 00:55:52,549](https://youtu.be/pz1MYpZ93UA?t=00h55m48s)

just simply shelling out


[00:56:00,890 --> 00:56:08,900](https://youtu.be/pz1MYpZ93UA?t=00h56m00s)

let's do this for the moment let's see


[00:56:04,430 --> 00:56:13,219](https://youtu.be/pz1MYpZ93UA?t=00h56m04s)

test lives unit testing go let's get


[00:56:08,900 --> 00:56:18,799](https://youtu.be/pz1MYpZ93UA?t=00h56m08s)

this going and I'm I'm curious to to see


[00:56:13,219 --> 00:56:21,910](https://youtu.be/pz1MYpZ93UA?t=00h56m13s)

this because all of these doing call and


[00:56:18,799 --> 00:56:21,910](https://youtu.be/pz1MYpZ93UA?t=00h56m18s)

VOC async


[00:56:41,000 --> 00:56:46,490](https://youtu.be/pz1MYpZ93UA?t=00h56m41s)

parsa's oh it can be replaced by


[00:56:43,099 --> 00:56:48,440](https://youtu.be/pz1MYpZ93UA?t=00h56m43s)

middleware see this is more testing the


[00:56:46,490 --> 00:56:50,240](https://youtu.be/pz1MYpZ93UA?t=00h56m46s)

used middleware and less about the


[00:56:48,440 --> 00:56:52,910](https://youtu.be/pz1MYpZ93UA?t=00h56m48s)

invocation so I think some of these


[00:56:50,240 --> 00:56:56,240](https://youtu.be/pz1MYpZ93UA?t=00h56m50s)

tests are worth adding but I don't


[00:56:52,910 --> 00:56:57,859](https://youtu.be/pz1MYpZ93UA?t=00h56m52s)

necessarily think all of them are so for


[00:56:56,240 --> 00:56:59,930](https://youtu.be/pz1MYpZ93UA?t=00h56m56s)

example invoke async chooses the


[00:56:57,859 --> 00:57:02,390](https://youtu.be/pz1MYpZ93UA?t=00h56m57s)

appropriate command this is an this is


[00:56:59,930 --> 00:57:04,970](https://youtu.be/pz1MYpZ93UA?t=00h56m59s)

absolutely because invoke async is the


[00:57:02,390 --> 00:57:08,119](https://youtu.be/pz1MYpZ93UA?t=00h57m02s)

method under test this absolutely should


[00:57:04,970 --> 00:57:11,630](https://youtu.be/pz1MYpZ93UA?t=00h57m04s)

be added but the ones that are testing


[00:57:08,119 --> 00:57:14,450](https://youtu.be/pz1MYpZ93UA?t=00h57m08s)

to use middleware I don't think it's


[00:57:11,630 --> 00:57:16,460](https://youtu.be/pz1MYpZ93UA?t=00h57m11s)

worth having a second test to call


[00:57:14,450 --> 00:57:26,150](https://youtu.be/pz1MYpZ93UA?t=00h57m14s)

invoke for something that's not actually


[00:57:16,460 --> 00:57:32,210](https://youtu.be/pz1MYpZ93UA?t=00h57m16s)

being tested so this guy here I'm


[00:57:26,150 --> 00:57:36,800](https://youtu.be/pz1MYpZ93UA?t=00h57m26s)

curious why I'm not seeing my see output


[00:57:32,210 --> 00:57:40,119](https://youtu.be/pz1MYpZ93UA?t=00h57m32s)

live unit testing has started it's great


[00:57:36,800 --> 00:57:44,180](https://youtu.be/pz1MYpZ93UA?t=00h57m36s)

why do I not see output results from it


[00:57:40,119 --> 00:57:46,790](https://youtu.be/pz1MYpZ93UA?t=00h57m40s)

let's just continue through here when


[00:57:44,180 --> 00:57:50,839](https://youtu.be/pz1MYpZ93UA?t=00h57m44s)

middleware throws invoke async does not


[00:57:46,790 --> 00:57:53,690](https://youtu.be/pz1MYpZ93UA?t=00h57m46s)

handle the exception perfect let's this


[00:57:50,839 --> 00:57:58,400](https://youtu.be/pz1MYpZ93UA?t=00h57m50s)

is another great one when middleware


[00:57:53,690 --> 00:58:03,470](https://youtu.be/pz1MYpZ93UA?t=00h57m53s)

throws in VOC does not handle the


[00:57:58,400 --> 00:58:05,270](https://youtu.be/pz1MYpZ93UA?t=00h57m58s)

exception so we should drop this and VOC


[00:58:03,470 --> 00:58:10,250](https://youtu.be/pz1MYpZ93UA?t=00h58m03s)

which means no longer a weight which


[00:58:05,270 --> 00:58:19,970](https://youtu.be/pz1MYpZ93UA?t=00h58m05s)

means no longer async which means func


[00:58:10,250 --> 00:58:25,970](https://youtu.be/pz1MYpZ93UA?t=00h58m10s)

of int perfect that should work to one


[00:58:19,970 --> 00:58:27,800](https://youtu.be/pz1MYpZ93UA?t=00h58m19s)

command handler throws this is when


[00:58:25,970 --> 00:58:31,190](https://youtu.be/pz1MYpZ93UA?t=00h58m25s)

middleware throws one command handler


[00:58:27,800 --> 00:58:34,240](https://youtu.be/pz1MYpZ93UA?t=00h58m27s)

throws okay so that's fine we should we


[00:58:31,190 --> 00:58:34,240](https://youtu.be/pz1MYpZ93UA?t=00h58m31s)

should add this one as well


[00:58:37,800 --> 00:58:46,360](https://youtu.be/pz1MYpZ93UA?t=00h58m37s)

command handle earth rose invoke does


[00:58:42,460 --> 00:58:47,920](https://youtu.be/pz1MYpZ93UA?t=00h58m42s)

not handle the exception great so let's


[00:58:46,360 --> 00:58:49,990](https://youtu.be/pz1MYpZ93UA?t=00h58m46s)

make sure we actually invoke the


[00:58:47,920 --> 00:58:54,630](https://youtu.be/pz1MYpZ93UA?t=00h58m47s)

appropriate method there's my live unit


[00:58:49,990 --> 00:58:57,310](https://youtu.be/pz1MYpZ93UA?t=00h58m49s)

testing and I see you to catch up to me


[00:58:54,630 --> 00:58:58,810](https://youtu.be/pz1MYpZ93UA?t=00h58m54s)

my poor little machine trying to keep up


[00:58:57,310 --> 00:59:08,730](https://youtu.be/pz1MYpZ93UA?t=00h58m57s)

with all of this stuff that I'm asking


[00:58:58,810 --> 00:59:08,730](https://youtu.be/pz1MYpZ93UA?t=00h58m58s)

it to do ok parser invoke great


[00:59:09,120 --> 00:59:13,330](https://youtu.be/pz1MYpZ93UA?t=00h59m09s)

let's see parser invocation be


[00:59:11,590 --> 00:59:23,790](https://youtu.be/pz1MYpZ93UA?t=00h59m11s)

short-circuited by middleware not


[00:59:13,330 --> 00:59:27,340](https://youtu.be/pz1MYpZ93UA?t=00h59m13s)

calling next think this one I want to do


[00:59:23,790 --> 00:59:30,910](https://youtu.be/pz1MYpZ93UA?t=00h59m23s)

because even though this isn't directly


[00:59:27,340 --> 00:59:34,660](https://youtu.be/pz1MYpZ93UA?t=00h59m27s)

there this ties into the command handle


[00:59:30,910 --> 00:59:38,670](https://youtu.be/pz1MYpZ93UA?t=00h59m30s)

or work that we just did and I would


[00:59:34,660 --> 00:59:38,670](https://youtu.be/pz1MYpZ93UA?t=00h59m34s)

like to make sure that those actually


[00:59:41,970 --> 00:59:46,570](https://youtu.be/pz1MYpZ93UA?t=00h59m41s)

don't do this for your method names


[00:59:44,070 --> 00:59:51,100](https://youtu.be/pz1MYpZ93UA?t=00h59m44s)

there's no way that will get passed code


[00:59:46,570 --> 00:59:54,070](https://youtu.be/pz1MYpZ93UA?t=00h59m46s)

review but deal with that in a minute I


[00:59:51,100 --> 00:59:57,240](https://youtu.be/pz1MYpZ93UA?t=00h59m51s)

just want to get this rewritten first


[00:59:54,070 --> 00:59:57,240](https://youtu.be/pz1MYpZ93UA?t=00h59m54s)

and then we'll look at a better name


[00:59:59,610 --> 01:00:07,050](https://youtu.be/pz1MYpZ93UA?t=00h59m59s)

because this is effectively that that


[01:00:02,580 --> 01:00:07,050](https://youtu.be/pz1MYpZ93UA?t=01h00m02s)

interesting case where we have a


[01:00:07,200 --> 01:00:14,490](https://youtu.be/pz1MYpZ93UA?t=01h00m07s)

synchronous invoke and an asynchronous


[01:00:11,100 --> 01:00:14,490](https://youtu.be/pz1MYpZ93UA?t=01h00m11s)

middleware handler


[01:00:28,750 --> 01:00:38,650](https://youtu.be/pz1MYpZ93UA?t=01h00m28s)

huh synchronous oh hey that was not the


[01:00:36,020 --> 01:00:42,020](https://youtu.be/pz1MYpZ93UA?t=01h00m36s)

order I pressed those keys in


[01:00:38,650 --> 01:00:49,760](https://youtu.be/pz1MYpZ93UA?t=01h00m38s)

synchronous invocation can be


[01:00:42,020 --> 01:00:52,760](https://youtu.be/pz1MYpZ93UA?t=01h00m42s)

short-circuited by a sync middleware and


[01:00:49,760 --> 01:00:57,050](https://youtu.be/pz1MYpZ93UA?t=01h00m49s)

not calling next there that's a better


[01:00:52,760 --> 01:00:59,570](https://youtu.be/pz1MYpZ93UA?t=01h00m52s)

name that actually reflects what it does


[01:00:57,050 --> 01:01:02,120](https://youtu.be/pz1MYpZ93UA?t=01h00m57s)

when Noel billows of specify uses


[01:00:59,570 --> 01:01:04,790](https://youtu.be/pz1MYpZ93UA?t=01h00m59s)

default implementation great helpful the


[01:01:02,120 --> 01:01:14,540](https://youtu.be/pz1MYpZ93UA?t=01h01m02s)

fact is great those are all around they


[01:01:04,790 --> 01:01:17,350](https://youtu.be/pz1MYpZ93UA?t=01h01m04s)

use help and I can't spell what the heck


[01:01:14,540 --> 01:01:17,350](https://youtu.be/pz1MYpZ93UA?t=01h01m14s)

did we do here


[01:01:33,770 --> 01:01:36,490](https://youtu.be/pz1MYpZ93UA?t=01h01m33s)

q


[01:01:44,770 --> 01:01:52,030](https://youtu.be/pz1MYpZ93UA?t=01h01m44s)

it is worth noting some of these unit


[01:01:49,089 --> 01:01:59,440](https://youtu.be/pz1MYpZ93UA?t=01h01m49s)

tests do not play nice with live unit


[01:01:52,030 --> 01:02:03,490](https://youtu.be/pz1MYpZ93UA?t=01h01m52s)

testing so for now I'm really only


[01:01:59,440 --> 01:02:06,400](https://youtu.be/pz1MYpZ93UA?t=01h01m59s)

concerned with these ones more


[01:02:03,490 --> 01:02:10,599](https://youtu.be/pz1MYpZ93UA?t=01h02m03s)

importantly jebra one just failed in


[01:02:06,400 --> 01:02:21,270](https://youtu.be/pz1MYpZ93UA?t=01h02m06s)

here so let's see when middleware throws


[01:02:10,599 --> 01:02:21,270](https://youtu.be/pz1MYpZ93UA?t=01h02m10s)

this test didn't pass this is a problem


[01:02:21,450 --> 01:02:29,670](https://youtu.be/pz1MYpZ93UA?t=01h02m21s)

so when middleware throws an exception


[01:02:31,500 --> 01:02:34,500](https://youtu.be/pz1MYpZ93UA?t=01h02m31s)

okay


[01:02:41,380 --> 01:02:44,390](https://youtu.be/pz1MYpZ93UA?t=01h02m41s)

okay


[01:02:42,590 --> 01:02:46,010](https://youtu.be/pz1MYpZ93UA?t=01h02m42s)

live unit testing I feel like you're


[01:02:44,390 --> 01:02:50,720](https://youtu.be/pz1MYpZ93UA?t=01h02m44s)

causing me more problems in your solving


[01:02:46,010 --> 01:02:53,300](https://youtu.be/pz1MYpZ93UA?t=01h02m46s)

right now so go away and turn off let's


[01:02:50,720 --> 01:02:55,310](https://youtu.be/pz1MYpZ93UA?t=01h02m50s)

run the invocation pipeline tests I'm


[01:02:53,300 --> 01:02:57,230](https://youtu.be/pz1MYpZ93UA?t=01h02m53s)

sort of wondering if that was just out


[01:02:55,310 --> 01:02:59,270](https://youtu.be/pz1MYpZ93UA?t=01h02m55s)

of date and didn't catch up with me in


[01:02:57,230 --> 01:03:07,040](https://youtu.be/pz1MYpZ93UA?t=01h02m57s)

time which is a very distinct


[01:02:59,270 --> 01:03:10,390](https://youtu.be/pz1MYpZ93UA?t=01h02m59s)

possibility you think about that and


[01:03:07,040 --> 01:03:13,670](https://youtu.be/pz1MYpZ93UA?t=01h03m07s)

let's continue on our way down so that


[01:03:10,390 --> 01:03:15,440](https://youtu.be/pz1MYpZ93UA?t=01h03m10s)

thinks about running these command


[01:03:13,670 --> 01:03:28,000](https://youtu.be/pz1MYpZ93UA?t=01h03m13s)

handle or tests of the next ones I'm


[01:03:15,440 --> 01:03:34,310](https://youtu.be/pz1MYpZ93UA?t=01h03m15s)

interested in looking at to see okay so


[01:03:28,000 --> 01:03:38,540](https://youtu.be/pz1MYpZ93UA?t=01h03m28s)

that is legitimately failing so what is


[01:03:34,310 --> 01:03:42,790](https://youtu.be/pz1MYpZ93UA?t=01h03m34s)

the problem then expect its system


[01:03:38,540 --> 01:03:42,790](https://youtu.be/pz1MYpZ93UA?t=01h03m38s)

exception but no exception was thrown


[01:03:43,150 --> 01:03:52,160](https://youtu.be/pz1MYpZ93UA?t=01h03m43s)

very likely because we wrap it in a task


[01:03:47,330 --> 01:04:05,450](https://youtu.be/pz1MYpZ93UA?t=01h03m47s)

dot run and it's being swallowed I would


[01:03:52,160 --> 01:04:13,480](https://youtu.be/pz1MYpZ93UA?t=01h03m52s)

suspect that is the problem so far so


[01:04:05,450 --> 01:04:13,480](https://youtu.be/pz1MYpZ93UA?t=01h04m05s)

don't invoke low VOC folk


[01:04:17,000 --> 01:04:26,630](https://youtu.be/pz1MYpZ93UA?t=01h04m17s)

go to implementation I do wonder real


[01:04:24,829 --> 01:04:36,859](https://youtu.be/pz1MYpZ93UA?t=01h04m24s)

quick something the back of my mind is


[01:04:26,630 --> 01:04:39,410](https://youtu.be/pz1MYpZ93UA?t=01h04m26s)

telling me that there was a comment


[01:04:36,859 --> 01:04:42,290](https://youtu.be/pz1MYpZ93UA?t=01h04m36s)

about that swallowing but I'm also


[01:04:39,410 --> 01:04:49,130](https://youtu.be/pz1MYpZ93UA?t=01h04m39s)

realizing that my async handler is


[01:04:42,290 --> 01:04:56,030](https://youtu.be/pz1MYpZ93UA?t=01h04m42s)

slightly different because this is


[01:04:49,130 --> 01:05:02,470](https://youtu.be/pz1MYpZ93UA?t=01h04m49s)

labeled as async so I think what we


[01:04:56,030 --> 01:05:02,470](https://youtu.be/pz1MYpZ93UA?t=01h04m56s)

wanted that I think what we want is that


[01:05:07,750 --> 01:05:10,750](https://youtu.be/pz1MYpZ93UA?t=01h05m07s)

did


[01:05:18,490 --> 01:05:37,390](https://youtu.be/pz1MYpZ93UA?t=01h05m18s)

I think I do that that's not quite right


[01:05:25,960 --> 01:05:39,580](https://youtu.be/pz1MYpZ93UA?t=01h05m25s)

now is it though okay I think I was


[01:05:37,390 --> 01:05:41,619](https://youtu.be/pz1MYpZ93UA?t=01h05m37s)

trying to be clever and not do this task


[01:05:39,580 --> 01:05:44,410](https://youtu.be/pz1MYpZ93UA?t=01h05m39s)

run multiple times but I think I just


[01:05:41,619 --> 01:06:01,109](https://youtu.be/pz1MYpZ93UA?t=01h05m41s)

need to stop get over myself and just do


[01:05:44,410 --> 01:06:01,109](https://youtu.be/pz1MYpZ93UA?t=01h05m44s)

it up here turn tasks run and results


[01:06:01,349 --> 01:06:10,270](https://youtu.be/pz1MYpZ93UA?t=01h06m01s)

let's see here


[01:06:03,070 --> 01:06:18,510](https://youtu.be/pz1MYpZ93UA?t=01h06m03s)

so I'm going to need that and then I'm


[01:06:10,270 --> 01:06:22,260](https://youtu.be/pz1MYpZ93UA?t=01h06m10s)

going to need to return let's see


[01:06:18,510 --> 01:06:22,260](https://youtu.be/pz1MYpZ93UA?t=01h06m18s)

Chase's task and


[01:06:26,980 --> 01:06:36,220](https://youtu.be/pz1MYpZ93UA?t=01h06m26s)

so I think we are just going to


[01:06:29,619 --> 01:06:40,480](https://youtu.be/pz1MYpZ93UA?t=01h06m29s)

straight-up cast this because that


[01:06:36,220 --> 01:06:42,849](https://youtu.be/pz1MYpZ93UA?t=01h06m36s)

should work you're no longer value


[01:06:40,480 --> 01:06:49,690](https://youtu.be/pz1MYpZ93UA?t=01h06m40s)

you're now going to be tasks return


[01:06:42,849 --> 01:06:56,890](https://youtu.be/pz1MYpZ93UA?t=01h06m42s)

tasks like that okay get that out of my


[01:06:49,690 --> 01:07:07,450](https://youtu.be/pz1MYpZ93UA?t=01h06m49s)

way let's see here this is going to be


[01:06:56,890 --> 01:07:09,460](https://youtu.be/pz1MYpZ93UA?t=01h06m56s)

test run get value wait oh sure we can


[01:07:07,450 --> 01:07:12,640](https://youtu.be/pz1MYpZ93UA?t=01h07m07s)

go to a method group that sounds great


[01:07:09,460 --> 01:07:18,070](https://youtu.be/pz1MYpZ93UA?t=01h07m09s)

thanks and then that goes there so the


[01:07:12,640 --> 01:07:21,700](https://youtu.be/pz1MYpZ93UA?t=01h07m12s)

problem now is this switch see end


[01:07:18,070 --> 01:07:33,250](https://youtu.be/pz1MYpZ93UA?t=01h07m18s)

result code I think rather than this


[01:07:21,700 --> 01:07:40,109](https://youtu.be/pz1MYpZ93UA?t=01h07m21s)

returns task I think we're just going to


[01:07:33,250 --> 01:07:42,550](https://youtu.be/pz1MYpZ93UA?t=01h07m33s)

do that whack all of that for now


[01:07:40,109 --> 01:07:54,460](https://youtu.be/pz1MYpZ93UA?t=01h07m40s)

because this doesn't need to be get


[01:07:42,550 --> 01:07:56,849](https://youtu.be/pz1MYpZ93UA?t=01h07m42s)

value let see get value we can cast to


[01:07:54,460 --> 01:07:56,849](https://youtu.be/pz1MYpZ93UA?t=01h07m54s)

an INT


[01:08:10,450 --> 01:08:28,420](https://youtu.be/pz1MYpZ93UA?t=01h08m10s)

I think this one this the case and


[01:08:14,000 --> 01:08:32,480](https://youtu.be/pz1MYpZ93UA?t=01h08m14s)

default need to be combined if a turn


[01:08:28,420 --> 01:08:37,540](https://youtu.be/pz1MYpZ93UA?t=01h08m28s)

context result code otherwise we'll just


[01:08:32,480 --> 01:08:37,540](https://youtu.be/pz1MYpZ93UA?t=01h08m32s)

throw so that brings that out of here I


[01:08:41,410 --> 01:08:50,690](https://youtu.be/pz1MYpZ93UA?t=01h08m41s)

think the last bit is we're not going to


[01:08:46,609 --> 01:08:54,730](https://youtu.be/pz1MYpZ93UA?t=01h08m46s)

be able to get away with this


[01:08:50,690 --> 01:08:54,730](https://youtu.be/pz1MYpZ93UA?t=01h08m50s)

so if


[01:09:09,029 --> 01:09:18,509](https://youtu.be/pz1MYpZ93UA?t=01h09m09s)

and convert this all the way down okay


[01:09:13,920 --> 01:09:21,929](https://youtu.be/pz1MYpZ93UA?t=01h09m13s)

so this is quickly turning ugly but I


[01:09:18,509 --> 01:09:30,089](https://youtu.be/pz1MYpZ93UA?t=01h09m18s)

think this will come out okay else--if


[01:09:21,929 --> 01:09:32,759](https://youtu.be/pz1MYpZ93UA?t=01h09m21s)

return type is I am wondering if this


[01:09:30,089 --> 01:09:38,489](https://youtu.be/pz1MYpZ93UA?t=01h09m30s)

should be handling there's a subtle


[01:09:32,759 --> 01:09:40,859](https://youtu.be/pz1MYpZ93UA?t=01h09m32s)

change in behavior by doing this and I


[01:09:38,489 --> 01:09:46,289](https://youtu.be/pz1MYpZ93UA?t=01h09m38s)

should probably change this to not just


[01:09:40,859 --> 01:09:48,630](https://youtu.be/pz1MYpZ93UA?t=01h09m40s)

be a straight type of comparison because


[01:09:46,289 --> 01:09:53,039](https://youtu.be/pz1MYpZ93UA?t=01h09m46s)

this will not handle derived classes of


[01:09:48,630 --> 01:09:55,039](https://youtu.be/pz1MYpZ93UA?t=01h09m48s)

tasks but in the interest of getting


[01:09:53,039 --> 01:09:58,590](https://youtu.be/pz1MYpZ93UA?t=01h09m53s)

this working we're going to start here


[01:09:55,039 --> 01:10:00,090](https://youtu.be/pz1MYpZ93UA?t=01h09m55s)

and the perks of this being a stream is


[01:09:58,590 --> 01:10:03,920](https://youtu.be/pz1MYpZ93UA?t=01h09m58s)

I can go back and watch my video later


[01:10:00,090 --> 01:10:09,570](https://youtu.be/pz1MYpZ93UA?t=01h10m00s)

see all the things I forgot to do so


[01:10:03,920 --> 01:10:15,510](https://youtu.be/pz1MYpZ93UA?t=01h10m03s)

this will be type of int and turn this


[01:10:09,570 --> 01:10:23,270](https://youtu.be/pz1MYpZ93UA?t=01h10m09s)

guy all the way out and then the default


[01:10:15,510 --> 01:10:27,239](https://youtu.be/pz1MYpZ93UA?t=01h10m15s)

case just becomes what's left over and


[01:10:23,270 --> 01:10:32,039](https://youtu.be/pz1MYpZ93UA?t=01h10m23s)

that works a little bit nicer okay so


[01:10:27,239 --> 01:10:36,480](https://youtu.be/pz1MYpZ93UA?t=01h10m27s)

jump back to our caller just right here


[01:10:32,039 --> 01:10:40,710](https://youtu.be/pz1MYpZ93UA?t=01h10m32s)

and we whack our boolean and instead


[01:10:36,480 --> 01:10:42,599](https://youtu.be/pz1MYpZ93UA?t=01h10m36s)

just give it return type okay there's a


[01:10:40,710 --> 01:10:44,760](https://youtu.be/pz1MYpZ93UA?t=01h10m40s)

general rule I find that if I'm writing


[01:10:42,599 --> 01:10:50,000](https://youtu.be/pz1MYpZ93UA?t=01h10m42s)

less code I'm probably writing better


[01:10:44,760 --> 01:10:50,000](https://youtu.be/pz1MYpZ93UA?t=01h10m44s)

code fewer spots for me to have bugs


[01:10:50,449 --> 01:10:58,739](https://youtu.be/pz1MYpZ93UA?t=01h10m50s)

okay and I think that makes the


[01:10:53,159 --> 01:11:00,929](https://youtu.be/pz1MYpZ93UA?t=01h10m53s)

exception propagate through I think the


[01:10:58,739 --> 01:11:03,119](https://youtu.be/pz1MYpZ93UA?t=01h10m58s)

the key change is we no longer have an


[01:11:00,929 --> 01:11:07,650](https://youtu.be/pz1MYpZ93UA?t=01h11m00s)

asynchronous delegate being passed into


[01:11:03,119 --> 01:11:10,020](https://youtu.be/pz1MYpZ93UA?t=01h11m03s)

task dot run and now it's just a


[01:11:07,650 --> 01:11:11,699](https://youtu.be/pz1MYpZ93UA?t=01h11m07s)

straight-up one and I apparently got way


[01:11:10,020 --> 01:11:18,780](https://youtu.be/pz1MYpZ93UA?t=01h11m10s)

too many closing braces and broke


[01:11:11,699 --> 01:11:20,670](https://youtu.be/pz1MYpZ93UA?t=01h11m11s)

something okay try again


[01:11:18,780 --> 01:11:23,850](https://youtu.be/pz1MYpZ93UA?t=01h11m18s)

as I think going to a synchronous


[01:11:20,670 --> 01:11:29,640](https://youtu.be/pz1MYpZ93UA?t=01h11m20s)

delegate fixes the exception propagation


[01:11:23,850 --> 01:11:37,410](https://youtu.be/pz1MYpZ93UA?t=01h11m23s)

I think just know this doesn't have a


[01:11:29,640 --> 01:11:42,810](https://youtu.be/pz1MYpZ93UA?t=01h11m29s)

sink in front of it come on throw the


[01:11:37,410 --> 01:11:45,090](https://youtu.be/pz1MYpZ93UA?t=01h11m37s)

exception make me happy so jumping back


[01:11:42,810 --> 01:11:49,380](https://youtu.be/pz1MYpZ93UA?t=01h11m42s)

just for those who are interested in


[01:11:45,090 --> 01:11:51,960](https://youtu.be/pz1MYpZ93UA?t=01h11m45s)

noting so we have a command whose and


[01:11:49,380 --> 01:11:54,510](https://youtu.be/pz1MYpZ93UA?t=01h11m49s)

some middleware that's job is just


[01:11:51,960 --> 01:12:01,110](https://youtu.be/pz1MYpZ93UA?t=01h11m51s)

straight throwing except oh wait this is


[01:11:54,510 --> 01:12:04,500](https://youtu.be/pz1MYpZ93UA?t=01h11m54s)

middleware not a command handler our


[01:12:01,110 --> 01:12:09,060](https://youtu.be/pz1MYpZ93UA?t=01h12m01s)

command handler worked just fine I still


[01:12:04,500 --> 01:12:13,050](https://youtu.be/pz1MYpZ93UA?t=01h12m04s)

like to refactor but middleware is


[01:12:09,060 --> 01:12:15,390](https://youtu.be/pz1MYpZ93UA?t=01h12m09s)

losing Oh interesting


[01:12:13,050 --> 01:12:23,810](https://youtu.be/pz1MYpZ93UA?t=01h12m13s)

Oh interesting Oh interesting so let's


[01:12:15,390 --> 01:12:38,790](https://youtu.be/pz1MYpZ93UA?t=01h12m15s)

look at that so this is straight up


[01:12:23,810 --> 01:12:47,540](https://youtu.be/pz1MYpZ93UA?t=01h12m23s)

middleware that is oh this thing down


[01:12:38,790 --> 01:12:47,540](https://youtu.be/pz1MYpZ93UA?t=01h12m38s)

here that we so cleverly put in place


[01:12:50,840 --> 01:12:57,570](https://youtu.be/pz1MYpZ93UA?t=01h12m50s)

again don't do this but in the interest


[01:12:54,420 --> 01:12:59,520](https://youtu.be/pz1MYpZ93UA?t=01h12m54s)

of proving that this is the right change


[01:12:57,570 --> 01:13:06,090](https://youtu.be/pz1MYpZ93UA?t=01h12m57s)

let's just create a new delegate real


[01:12:59,520 --> 01:13:10,560](https://youtu.be/pz1MYpZ93UA?t=01h12m59s)

quick call it two rather than tasks it's


[01:13:06,090 --> 01:13:16,950](https://youtu.be/pz1MYpZ93UA?t=01h13m06s)

just going to be action and this will be


[01:13:10,560 --> 01:13:22,130](https://youtu.be/pz1MYpZ93UA?t=01h13m10s)

void returning okay so hopefully this


[01:13:16,950 --> 01:13:24,720](https://youtu.be/pz1MYpZ93UA?t=01h13m16s)

gets us one step closer to having a


[01:13:22,130 --> 01:13:29,730](https://youtu.be/pz1MYpZ93UA?t=01h13m22s)

synchronous API where we only had an


[01:13:24,720 --> 01:13:31,500](https://youtu.be/pz1MYpZ93UA?t=01h13m24s)

asynchronous one okay so in the interest


[01:13:29,730 --> 01:13:32,280](https://youtu.be/pz1MYpZ93UA?t=01h13m29s)

of testing and that becomes a two that


[01:13:31,500 --> 01:13:36,260](https://youtu.be/pz1MYpZ93UA?t=01h13m31s)

becomes a two


[01:13:32,280 --> 01:13:47,099](https://youtu.be/pz1MYpZ93UA?t=01h13m32s)

this return goes away this becomes an


[01:13:36,260 --> 01:13:53,179](https://youtu.be/pz1MYpZ93UA?t=01h13m36s)

empty action delegate boom and this goes


[01:13:47,099 --> 01:13:56,179](https://youtu.be/pz1MYpZ93UA?t=01h13m47s)

away because you know our void returning


[01:13:53,179 --> 01:13:56,179](https://youtu.be/pz1MYpZ93UA?t=01h13m53s)

huzzah


[01:13:58,340 --> 01:14:03,420](https://youtu.be/pz1MYpZ93UA?t=01h13m58s)

okay so what is your problem with it


[01:14:01,889 --> 01:14:04,559](https://youtu.be/pz1MYpZ93UA?t=01h14m01s)

okay let's collapse this you're just in


[01:14:03,420 --> 01:14:10,190](https://youtu.be/pz1MYpZ93UA?t=01h14m03s)

the way


[01:14:04,559 --> 01:14:10,190](https://youtu.be/pz1MYpZ93UA?t=01h14m04s)

let's see list configuration middleware


[01:14:11,599 --> 01:14:20,550](https://youtu.be/pz1MYpZ93UA?t=01h14m11s)

right and this is assuredly where our


[01:14:16,909 --> 01:14:22,400](https://youtu.be/pz1MYpZ93UA?t=01h14m16s)

problem lies because this is the


[01:14:20,550 --> 01:14:27,030](https://youtu.be/pz1MYpZ93UA?t=01h14m20s)

collection that's being added into oh


[01:14:22,400 --> 01:14:33,480](https://youtu.be/pz1MYpZ93UA?t=01h14m22s)

sure will will update will update to the


[01:14:27,030 --> 01:14:36,199](https://youtu.be/pz1MYpZ93UA?t=01h14m27s)

fancy new pretty operator so for those


[01:14:33,480 --> 01:14:41,639](https://youtu.be/pz1MYpZ93UA?t=01h14m33s)

people who didn't catch that there is a


[01:14:36,199 --> 01:14:46,230](https://youtu.be/pz1MYpZ93UA?t=01h14m36s)

new operator so when you previously had


[01:14:41,639 --> 01:14:47,789](https://youtu.be/pz1MYpZ93UA?t=01h14m41s)

to do the know coalescing and then


[01:14:46,230 --> 01:14:50,699](https://youtu.be/pz1MYpZ93UA?t=01h14m46s)

effectively do a setter on it and


[01:14:47,789 --> 01:14:55,500](https://youtu.be/pz1MYpZ93UA?t=01h14m47s)

something you can now do that in a


[01:14:50,699 --> 01:14:59,639](https://youtu.be/pz1MYpZ93UA?t=01h14m50s)

single line because c-sharp is awesome


[01:14:55,500 --> 01:15:00,719](https://youtu.be/pz1MYpZ93UA?t=01h14m55s)

and the creator's like to make it so


[01:14:59,639 --> 01:15:02,849](https://youtu.be/pz1MYpZ93UA?t=01h14m59s)

that anything that we have to type


[01:15:00,719 --> 01:15:08,969](https://youtu.be/pz1MYpZ93UA?t=01h15m00s)

repeatedly we don't have to anymore


[01:15:02,849 --> 01:15:10,800](https://youtu.be/pz1MYpZ93UA?t=01h15m02s)

which is awesome okay so in our unit


[01:15:08,969 --> 01:15:13,770](https://youtu.be/pz1MYpZ93UA?t=01h15m08s)

tests we're adding a piece of middleware


[01:15:10,800 --> 01:15:15,630](https://youtu.be/pz1MYpZ93UA?t=01h15m10s)

to our configuration list which is what


[01:15:13,770 --> 01:15:18,389](https://youtu.be/pz1MYpZ93UA?t=01h15m13s)

this used middleware ultimately ends up


[01:15:15,630 --> 01:15:21,949](https://youtu.be/pz1MYpZ93UA?t=01h15m15s)

doing so this extension method here


[01:15:18,389 --> 01:15:25,280](https://youtu.be/pz1MYpZ93UA?t=01h15m18s)

calls builder add middleware which


[01:15:21,949 --> 01:15:25,280](https://youtu.be/pz1MYpZ93UA?t=01h15m21s)

registers up


[01:15:28,060 --> 01:15:40,830](https://youtu.be/pz1MYpZ93UA?t=01h15m28s)

and add something to the list that may


[01:15:37,450 --> 01:15:43,450](https://youtu.be/pz1MYpZ93UA?t=01h15m37s)

change my mind on where this needs to go


[01:15:40,830 --> 01:15:47,410](https://youtu.be/pz1MYpZ93UA?t=01h15m40s)

because we no longer have the problem of


[01:15:43,450 --> 01:15:50,410](https://youtu.be/pz1MYpZ93UA?t=01h15m43s)

a synchronous main method needing to


[01:15:47,410 --> 01:15:53,680](https://youtu.be/pz1MYpZ93UA?t=01h15m47s)

call an asynchronous command handler but


[01:15:50,410 --> 01:15:57,810](https://youtu.be/pz1MYpZ93UA?t=01h15m50s)

we also have a synchronous main needing


[01:15:53,680 --> 01:15:57,810](https://youtu.be/pz1MYpZ93UA?t=01h15m53s)

to call a synchronous middleware which


[01:15:58,290 --> 01:16:04,480](https://youtu.be/pz1MYpZ93UA?t=01h15m58s)

is effectively one of the cases that's


[01:16:00,910 --> 01:16:06,070](https://youtu.be/pz1MYpZ93UA?t=01h16m00s)

being tested here in that we expect that


[01:16:04,480 --> 01:16:08,500](https://youtu.be/pz1MYpZ93UA?t=01h16m04s)

if this middleware goes to throw an


[01:16:06,070 --> 01:16:10,630](https://youtu.be/pz1MYpZ93UA?t=01h16m06s)

exception that that exception properly


[01:16:08,500 --> 01:16:17,410](https://youtu.be/pz1MYpZ93UA?t=01h16m08s)

propagates all the way up which it's not


[01:16:10,630 --> 01:16:20,530](https://youtu.be/pz1MYpZ93UA?t=01h16m10s)

it's being swallowed right now which is


[01:16:17,410 --> 01:16:24,900](https://youtu.be/pz1MYpZ93UA?t=01h16m17s)

all coming about because of the


[01:16:20,530 --> 01:16:24,900](https://youtu.be/pz1MYpZ93UA?t=01h16m20s)

obnoxious way that I implemented this


[01:16:25,890 --> 01:16:35,140](https://youtu.be/pz1MYpZ93UA?t=01h16m25s)

because if we go back to this delegate


[01:16:28,420 --> 01:16:43,450](https://youtu.be/pz1MYpZ93UA?t=01h16m28s)

that guy is now happy this guy is now


[01:16:35,140 --> 01:16:45,610](https://youtu.be/pz1MYpZ93UA?t=01h16m35s)

happy because the command handler stuff


[01:16:43,450 --> 01:16:48,420](https://youtu.be/pz1MYpZ93UA?t=01h16m43s)

is effectively being implemented as a


[01:16:45,610 --> 01:16:48,420](https://youtu.be/pz1MYpZ93UA?t=01h16m45s)

middleware


[01:16:55,480 --> 01:17:05,020](https://youtu.be/pz1MYpZ93UA?t=01h16m55s)

I'm going back to where we had it before


[01:16:57,860 --> 01:17:05,020](https://youtu.be/pz1MYpZ93UA?t=01h16m57s)

I think that is the better approach


[01:17:06,940 --> 01:17:14,630](https://youtu.be/pz1MYpZ93UA?t=01h17m06s)

because we don't really have synchronous


[01:17:10,610 --> 01:17:19,600](https://youtu.be/pz1MYpZ93UA?t=01h17m10s)

middleware what was that an async


[01:17:14,630 --> 01:17:23,239](https://youtu.be/pz1MYpZ93UA?t=01h17m14s)

delegate yeah so a synchronous delegate


[01:17:19,600 --> 01:17:24,710](https://youtu.be/pz1MYpZ93UA?t=01h17m19s)

passes all the way through that works


[01:17:23,239 --> 01:17:30,469](https://youtu.be/pz1MYpZ93UA?t=01h17m23s)

that works that works


[01:17:24,710 --> 01:17:33,440](https://youtu.be/pz1MYpZ93UA?t=01h17m24s)

this becomes task completed and then


[01:17:30,469 --> 01:17:38,750](https://youtu.be/pz1MYpZ93UA?t=01h17m30s)

where we previous where we previously


[01:17:33,440 --> 01:17:53,030](https://youtu.be/pz1MYpZ93UA?t=01h17m33s)

had to await it here we will do a task


[01:17:38,750 --> 01:18:02,090](https://youtu.be/pz1MYpZ93UA?t=01h17m38s)

start run actually we can just do wait -


[01:17:53,030 --> 01:18:05,750](https://youtu.be/pz1MYpZ93UA?t=01h17m53s)

I guess we end up with this right and


[01:18:02,090 --> 01:18:12,650](https://youtu.be/pz1MYpZ93UA?t=01h18m02s)

that that's very let's verify that this


[01:18:05,750 --> 01:18:15,140](https://youtu.be/pz1MYpZ93UA?t=01h18m05s)

works the fact that this is swallowing


[01:18:12,650 --> 01:18:17,380](https://youtu.be/pz1MYpZ93UA?t=01h18m12s)

the exceptions as being somewhat


[01:18:15,140 --> 01:18:17,380](https://youtu.be/pz1MYpZ93UA?t=01h18m15s)

problematic


[01:18:26,150 --> 01:18:31,220](https://youtu.be/pz1MYpZ93UA?t=01h18m26s)

they would like this to bubble all the


[01:18:28,250 --> 01:18:33,410](https://youtu.be/pz1MYpZ93UA?t=01h18m28s)

way through something then back my mind


[01:18:31,220 --> 01:18:43,580](https://youtu.be/pz1MYpZ93UA?t=01h18m31s)

is telling me that that's expected there


[01:18:33,410 --> 01:18:45,110](https://youtu.be/pz1MYpZ93UA?t=01h18m33s)

we go there we go okay I'm thinking this


[01:18:43,580 --> 01:18:48,830](https://youtu.be/pz1MYpZ93UA?t=01h18m43s)

is the appropriate place to implement


[01:18:45,110 --> 01:18:53,600](https://youtu.be/pz1MYpZ93UA?t=01h18m45s)

the cheater approach because if we try


[01:18:48,830 --> 01:18:56,270](https://youtu.be/pz1MYpZ93UA?t=01h18m48s)

to do it further down we run into this


[01:18:53,600 --> 01:18:57,890](https://youtu.be/pz1MYpZ93UA?t=01h18m53s)

problem of users can effectively not


[01:18:56,270 --> 01:18:59,330](https://youtu.be/pz1MYpZ93UA?t=01h18m56s)

necessarily have their own callbacks at


[01:18:57,890 --> 01:19:03,310](https://youtu.be/pz1MYpZ93UA?t=01h18m57s)

the command handler but they can have


[01:18:59,330 --> 01:19:03,310](https://youtu.be/pz1MYpZ93UA?t=01h18m59s)

arbitrary callbacks at the middleware


[01:19:05,140 --> 01:19:09,440](https://youtu.be/pz1MYpZ93UA?t=01h19m05s)

yeah so let's go team Explorer real


[01:19:08,780 --> 01:19:14,390](https://youtu.be/pz1MYpZ93UA?t=01h19m08s)

quick


[01:19:09,440 --> 01:19:17,680](https://youtu.be/pz1MYpZ93UA?t=01h19m09s)

let's see command handler let's move you


[01:19:14,390 --> 01:19:21,650](https://youtu.be/pz1MYpZ93UA?t=01h19m14s)

over here unit tests out of the way so


[01:19:17,680 --> 01:19:23,990](https://youtu.be/pz1MYpZ93UA?t=01h19m17s)

throw away that change because we don't


[01:19:21,650 --> 01:19:26,420](https://youtu.be/pz1MYpZ93UA?t=01h19m21s)

need it anymore we are only going to


[01:19:23,990 --> 01:19:31,820](https://youtu.be/pz1MYpZ93UA?t=01h19m23s)

invoke directly compare with unmodified


[01:19:26,420 --> 01:19:38,600](https://youtu.be/pz1MYpZ93UA?t=01h19m26s)

I think this guy here command handler


[01:19:31,820 --> 01:19:43,790](https://youtu.be/pz1MYpZ93UA?t=01h19m31s)

goes away as well don't need it let's


[01:19:38,600 --> 01:19:49,580](https://youtu.be/pz1MYpZ93UA?t=01h19m38s)

see here let's just continue down the


[01:19:43,790 --> 01:20:00,440](https://youtu.be/pz1MYpZ93UA?t=01h19m43s)

list let's make sure this works so


[01:19:49,580 --> 01:20:04,280](https://youtu.be/pz1MYpZ93UA?t=01h19m49s)

there's all the invoke overloads this


[01:20:00,440 --> 01:20:07,840](https://youtu.be/pz1MYpZ93UA?t=01h20m00s)

one we want to throw away because that's


[01:20:04,280 --> 01:20:07,840](https://youtu.be/pz1MYpZ93UA?t=01h20m04s)

a horrible name for a delegate


[01:20:13,199 --> 01:20:21,120](https://youtu.be/pz1MYpZ93UA?t=01h20m13s)

okay and this is effectively our cheater


[01:20:15,880 --> 01:20:24,400](https://youtu.be/pz1MYpZ93UA?t=01h20m15s)

approach here where it builds it up and


[01:20:21,120 --> 01:20:27,400](https://youtu.be/pz1MYpZ93UA?t=01h20m21s)

model binding command handler I think


[01:20:24,400 --> 01:20:32,260](https://youtu.be/pz1MYpZ93UA?t=01h20m24s)

this is where yeah we no longer need


[01:20:27,400 --> 01:20:39,630](https://youtu.be/pz1MYpZ93UA?t=01h20m27s)

that anymore so we keep it simple we


[01:20:32,260 --> 01:20:41,590](https://youtu.be/pz1MYpZ93UA?t=01h20m32s)

hijack it at the invocation pipeline and


[01:20:39,630 --> 01:20:45,310](https://youtu.be/pz1MYpZ93UA?t=01h20m39s)

everything works and I think this is


[01:20:41,590 --> 01:20:52,750](https://youtu.be/pz1MYpZ93UA?t=01h20m41s)

just the operator update yeah so we'll


[01:20:45,310 --> 01:20:56,260](https://youtu.be/pz1MYpZ93UA?t=01h20m45s)

flatten that in okay so close old


[01:20:52,750 --> 01:20:57,910](https://youtu.be/pz1MYpZ93UA?t=01h20m52s)

documents and let's just real quick make


[01:20:56,260 --> 01:21:04,120](https://youtu.be/pz1MYpZ93UA?t=01h20m56s)

sure I'm not crazy and that all our


[01:20:57,910 --> 01:21:07,000](https://youtu.be/pz1MYpZ93UA?t=01h20m57s)

tests still run I think we're probably


[01:21:04,120 --> 01:21:08,800](https://youtu.be/pz1MYpZ93UA?t=01h21m04s)

pretty close with each of these because


[01:21:07,000 --> 01:21:10,360](https://youtu.be/pz1MYpZ93UA?t=01h21m07s)

the next thing that I would like to do


[01:21:08,800 --> 01:21:12,250](https://youtu.be/pz1MYpZ93UA?t=01h21m08s)

before we jump all the way up into


[01:21:10,360 --> 01:21:14,650](https://youtu.be/pz1MYpZ93UA?t=01h21m10s)

dragon fruit is go back and look at


[01:21:12,250 --> 01:21:16,780](https://youtu.be/pz1MYpZ93UA?t=01h21m12s)

these methods once we verify that all


[01:21:14,650 --> 01:21:22,770](https://youtu.be/pz1MYpZ93UA?t=01h21m14s)

our tests are passing and do a little


[01:21:16,780 --> 01:21:26,520](https://youtu.be/pz1MYpZ93UA?t=01h21m16s)

refactoring because we have a lot of


[01:21:22,770 --> 01:21:30,340](https://youtu.be/pz1MYpZ93UA?t=01h21m22s)

duplicated code that I think can be


[01:21:26,520 --> 01:21:33,540](https://youtu.be/pz1MYpZ93UA?t=01h21m26s)

reduced into ace into some shared


[01:21:30,340 --> 01:21:36,989](https://youtu.be/pz1MYpZ93UA?t=01h21m30s)

methods like even these where there's


[01:21:33,540 --> 01:21:41,140](https://youtu.be/pz1MYpZ93UA?t=01h21m33s)

just invoke methods this bit is


[01:21:36,989 --> 01:21:44,530](https://youtu.be/pz1MYpZ93UA?t=01h21m36s)

duplicated across and or at least this


[01:21:41,140 --> 01:21:49,469](https://youtu.be/pz1MYpZ93UA?t=01h21m41s)

much is and there is no reason that it


[01:21:44,530 --> 01:21:52,060](https://youtu.be/pz1MYpZ93UA?t=01h21m44s)

needs to be so I think we could well


[01:21:49,469 --> 01:21:56,860](https://youtu.be/pz1MYpZ93UA?t=01h21m49s)

yeah we'll see I think there there's


[01:21:52,060 --> 01:21:59,500](https://youtu.be/pz1MYpZ93UA?t=01h21m52s)

room for improvement I think we'll start


[01:21:56,860 --> 01:22:03,130](https://youtu.be/pz1MYpZ93UA?t=01h21m56s)

with the invocation pipeline though this


[01:21:59,500 --> 01:22:06,120](https://youtu.be/pz1MYpZ93UA?t=01h21m59s)

is probably the biggest biggest hurdle


[01:22:03,130 --> 01:22:06,120](https://youtu.be/pz1MYpZ93UA?t=01h22m03s)

is this guy right here


[01:22:06,810 --> 01:22:12,070](https://youtu.be/pz1MYpZ93UA?t=01h22m06s)

but again I want to make sure that all


[01:22:09,130 --> 01:22:14,020](https://youtu.be/pz1MYpZ93UA?t=01h22m09s)

my tests pass before before I get too


[01:22:12,070 --> 01:22:17,410](https://youtu.be/pz1MYpZ93UA?t=01h22m12s)

carried away and just start hacking it


[01:22:14,020 --> 01:22:19,810](https://youtu.be/pz1MYpZ93UA?t=01h22m14s)

code and replacing stuff okay I'll click


[01:22:17,410 --> 01:22:24,540](https://youtu.be/pz1MYpZ93UA?t=01h22m17s)

playing around I'll wait for the unit


[01:22:19,810 --> 01:22:24,540](https://youtu.be/pz1MYpZ93UA?t=01h22m19s)

test run to finish come on come on


[01:22:24,850 --> 01:22:29,200](https://youtu.be/pz1MYpZ93UA?t=01h22m24s)

you can do it you can do it


[01:22:35,620 --> 01:22:43,200](https://youtu.be/pz1MYpZ93UA?t=01h22m35s)

whoo man these streaming really does


[01:22:40,540 --> 01:22:46,060](https://youtu.be/pz1MYpZ93UA?t=01h22m40s)

slow down the running of Visual Studio I


[01:22:43,200 --> 01:22:57,100](https://youtu.be/pz1MYpZ93UA?t=01h22m43s)

think there's a competition to see who


[01:22:46,060 --> 01:22:59,170](https://youtu.be/pz1MYpZ93UA?t=01h22m46s)

can chew up the most memory and CPU okay


[01:22:57,100 --> 01:23:05,400](https://youtu.be/pz1MYpZ93UA?t=01h22m57s)

well that's thinking I'm gonna go start


[01:22:59,170 --> 01:23:05,400](https://youtu.be/pz1MYpZ93UA?t=01h22m59s)

looking at this and location pipeline


[01:23:06,330 --> 01:23:13,930](https://youtu.be/pz1MYpZ93UA?t=01h23m06s)

okay so we've got collapse you collapse


[01:23:10,810 --> 01:23:20,220](https://youtu.be/pz1MYpZ93UA?t=01h23m10s)

you okay so we've got these two methods


[01:23:13,930 --> 01:23:20,220](https://youtu.be/pz1MYpZ93UA?t=01h23m13s)

invoke async and invoke and effectively


[01:23:20,280 --> 01:23:27,310](https://youtu.be/pz1MYpZ93UA?t=01h23m20s)

this much is all the same in fact


[01:23:24,570 --> 01:23:32,440](https://youtu.be/pz1MYpZ93UA?t=01h23m24s)

everything is the same except for this


[01:23:27,310 --> 01:23:34,870](https://youtu.be/pz1MYpZ93UA?t=01h23m27s)

one line right here so I'm thinking we


[01:23:32,440 --> 01:23:40,840](https://youtu.be/pz1MYpZ93UA?t=01h23m32s)

can combine some code because that's a


[01:23:34,870 --> 01:23:43,060](https://youtu.be/pz1MYpZ93UA?t=01h23m34s)

lot of duplication so I think the first


[01:23:40,840 --> 01:23:53,380](https://youtu.be/pz1MYpZ93UA?t=01h23m40s)

thing we do is probably start whacking


[01:23:43,060 --> 01:23:53,620](https://youtu.be/pz1MYpZ93UA?t=01h23m43s)

some of these VARs yeah so all the tests


[01:23:53,380 --> 01:24:05,490](https://youtu.be/pz1MYpZ93UA?t=01h23m53s)

pass


[01:23:53,620 --> 01:24:08,410](https://youtu.be/pz1MYpZ93UA?t=01h23m53s)

great so private void foo for the moment


[01:24:05,490 --> 01:24:12,100](https://youtu.be/pz1MYpZ93UA?t=01h24m05s)

till we figure out what we're doing here


[01:24:08,410 --> 01:24:17,620](https://youtu.be/pz1MYpZ93UA?t=01h24m08s)

and I think I'm gonna bring this guy


[01:24:12,100 --> 01:24:21,990](https://youtu.be/pz1MYpZ93UA?t=01h24m12s)

down let's get rid of this bar real


[01:24:17,620 --> 01:24:28,030](https://youtu.be/pz1MYpZ93UA?t=01h24m17s)

quick cuz I think this invocation


[01:24:21,990 --> 01:24:35,620](https://youtu.be/pz1MYpZ93UA?t=01h24m21s)

middleware I think this much we we just


[01:24:28,030 --> 01:24:43,470](https://youtu.be/pz1MYpZ93UA?t=01h24m28s)

want to take wholesale right so let's go


[01:24:35,620 --> 01:24:43,470](https://youtu.be/pz1MYpZ93UA?t=01h24m35s)

with a console console bring that in


[01:24:43,800 --> 01:24:53,889](https://youtu.be/pz1MYpZ93UA?t=01h24m43s)

let's see how about build in


[01:24:49,360 --> 01:24:58,650](https://youtu.be/pz1MYpZ93UA?t=01h24m49s)

location chain and we'll return the


[01:24:53,889 --> 01:25:12,119](https://youtu.be/pz1MYpZ93UA?t=01h24m53s)

middle we're back don't try that again


[01:24:58,650 --> 01:25:17,800](https://youtu.be/pz1MYpZ93UA?t=01h24m58s)

that and return so this becomes filled


[01:25:12,119 --> 01:25:25,090](https://youtu.be/pz1MYpZ93UA?t=01h25m12s)

invocation chain passing our console and


[01:25:17,800 --> 01:25:33,239](https://youtu.be/pz1MYpZ93UA?t=01h25m17s)

all of this goes away right oh so this


[01:25:25,090 --> 01:25:40,630](https://youtu.be/pz1MYpZ93UA?t=01h25m25s)

guy is still going to want see context


[01:25:33,239 --> 01:25:42,489](https://youtu.be/pz1MYpZ93UA?t=01h25m33s)

and context context context okay so we


[01:25:40,630 --> 01:25:45,429](https://youtu.be/pz1MYpZ93UA?t=01h25m40s)

changed this guy up so rather than


[01:25:42,489 --> 01:25:50,889](https://youtu.be/pz1MYpZ93UA?t=01h25m42s)

taking it an i console he'll take in the


[01:25:45,429 --> 01:25:59,650](https://youtu.be/pz1MYpZ93UA?t=01h25m45s)

context and it will bring this guy back


[01:25:50,889 --> 01:26:05,409](https://youtu.be/pz1MYpZ93UA?t=01h25m50s)

outside and this becomes context simple


[01:25:59,650 --> 01:26:10,300](https://youtu.be/pz1MYpZ93UA?t=01h25m59s)

enough so this gets a little better we


[01:26:05,409 --> 01:26:15,730](https://youtu.be/pz1MYpZ93UA?t=01h26m05s)

take everything up from here and well


[01:26:10,300 --> 01:26:22,179](https://youtu.be/pz1MYpZ93UA?t=01h26m10s)

let's just change this to be build and


[01:26:15,730 --> 01:26:29,460](https://youtu.be/pz1MYpZ93UA?t=01h26m15s)

location chain context all of this goes


[01:26:22,179 --> 01:26:39,760](https://youtu.be/pz1MYpZ93UA?t=01h26m22s)

away that cleans all of that up okay


[01:26:29,460 --> 01:26:42,929](https://youtu.be/pz1MYpZ93UA?t=01h26m29s)

that up okay and all of this is just to


[01:26:39,760 --> 01:26:42,929](https://youtu.be/pz1MYpZ93UA?t=01h26m39s)

get the result code


[01:26:45,220 --> 01:26:49,350](https://youtu.be/pz1MYpZ93UA?t=01h26m45s)

a method can be made static excellent


[01:26:56,250 --> 01:27:12,820](https://youtu.be/pz1MYpZ93UA?t=01h26m56s)

private static int process or apply


[01:27:07,660 --> 01:27:19,960](https://youtu.be/pz1MYpZ93UA?t=01h27m07s)

results apply invocation result seems


[01:27:12,820 --> 01:27:27,370](https://youtu.be/pz1MYpZ93UA?t=01h27m12s)

wrong that let's see this guy really


[01:27:19,960 --> 01:27:36,150](https://youtu.be/pz1MYpZ93UA?t=01h27m19s)

should just take the context and we're


[01:27:27,370 --> 01:27:36,150](https://youtu.be/pz1MYpZ93UA?t=01h27m27s)

gonna bring you in and you in and return


[01:27:37,680 --> 01:27:49,810](https://youtu.be/pz1MYpZ93UA?t=01h27m37s)

turn apply results not sure I like that


[01:27:42,820 --> 01:27:56,440](https://youtu.be/pz1MYpZ93UA?t=01h27m42s)

method but it'll do for now and then


[01:27:49,810 --> 01:28:00,700](https://youtu.be/pz1MYpZ93UA?t=01h27m49s)

this becomes a term apply result context


[01:27:56,440 --> 01:28:04,840](https://youtu.be/pz1MYpZ93UA?t=01h27m56s)

okay so that cleans that up I don't know


[01:28:00,700 --> 01:28:10,390](https://youtu.be/pz1MYpZ93UA?t=01h28m00s)

if there's much more usefulness that can


[01:28:04,840 --> 01:28:18,670](https://youtu.be/pz1MYpZ93UA?t=01h28m04s)

happen from this let's first make sure


[01:28:10,390 --> 01:28:19,930](https://youtu.be/pz1MYpZ93UA?t=01h28m10s)

we haven't broken anything and I'm


[01:28:18,670 --> 01:28:26,110](https://youtu.be/pz1MYpZ93UA?t=01h28m18s)

trying to think of a better name for


[01:28:19,930 --> 01:28:30,040](https://youtu.be/pz1MYpZ93UA?t=01h28m19s)

this apply result method because it


[01:28:26,110 --> 01:28:34,480](https://youtu.be/pz1MYpZ93UA?t=01h28m26s)

checks the invocation result applies it


[01:28:30,040 --> 01:28:38,070](https://youtu.be/pz1MYpZ93UA?t=01h28m30s)

to the context and then grabs the result


[01:28:34,480 --> 01:28:38,070](https://youtu.be/pz1MYpZ93UA?t=01h28m34s)

code from the context


[01:28:52,270 --> 01:28:58,300](https://youtu.be/pz1MYpZ93UA?t=01h28m52s)

I'm wondering if you get result code


[01:28:55,430 --> 01:28:58,300](https://youtu.be/pz1MYpZ93UA?t=01h28m55s)

makes more sense


[01:29:06,730 --> 01:29:13,390](https://youtu.be/pz1MYpZ93UA?t=01h29m06s)

they can get result code might make more


[01:29:09,040 --> 01:29:15,580](https://youtu.be/pz1MYpZ93UA?t=01h29m09s)

sense let this thing run first and then


[01:29:13,390 --> 01:29:18,179](https://youtu.be/pz1MYpZ93UA?t=01h29m13s)

we'll just do the rename I think get


[01:29:15,580 --> 01:29:21,670](https://youtu.be/pz1MYpZ93UA?t=01h29m15s)

result code is going to be the winner


[01:29:18,179 --> 01:29:28,480](https://youtu.be/pz1MYpZ93UA?t=01h29m18s)

yeah you're sold code and I lied about


[01:29:21,670 --> 01:29:32,650](https://youtu.be/pz1MYpZ93UA?t=01h29m21s)

waiting I'm impatient so let's go back


[01:29:28,480 --> 01:29:35,340](https://youtu.be/pz1MYpZ93UA?t=01h29m28s)

here and look at our other guy location


[01:29:32,650 --> 01:29:35,340](https://youtu.be/pz1MYpZ93UA?t=01h29m32s)

extensions


[01:29:41,700 --> 01:29:51,210](https://youtu.be/pz1MYpZ93UA?t=01h29m41s)

this guy here has its user middleware


[01:29:47,730 --> 01:29:55,980](https://youtu.be/pz1MYpZ93UA?t=01h29m47s)

use debug directives so we tried not to


[01:29:51,210 --> 01:29:57,750](https://youtu.be/pz1MYpZ93UA?t=01h29m51s)

not be too opinionated on the API for


[01:29:55,980 --> 01:29:58,350](https://youtu.be/pz1MYpZ93UA?t=01h29m55s)

this because some people like fluent


[01:29:57,750 --> 01:30:03,510](https://youtu.be/pz1MYpZ93UA?t=01h29m57s)

syntax


[01:29:58,350 --> 01:30:06,000](https://youtu.be/pz1MYpZ93UA?t=01h29m58s)

some people don't but at least when it


[01:30:03,510 --> 01:30:08,460](https://youtu.be/pz1MYpZ93UA?t=01h30m03s)

comes to building up this command-line


[01:30:06,000 --> 01:30:11,430](https://youtu.be/pz1MYpZ93UA?t=01h30m06s)

builder the Builder itself does follow a


[01:30:08,460 --> 01:30:15,300](https://youtu.be/pz1MYpZ93UA?t=01h30m08s)

fluent syntax the Builder pattern really


[01:30:11,430 --> 01:30:18,870](https://youtu.be/pz1MYpZ93UA?t=01h30m11s)

lends itself well to that so that one


[01:30:15,300 --> 01:30:27,480](https://youtu.be/pz1MYpZ93UA?t=01h30m15s)

does exist okay so we've got all of


[01:30:18,870 --> 01:30:32,430](https://youtu.be/pz1MYpZ93UA?t=01h30m18s)

these invoke a sink this parse room this


[01:30:27,480 --> 01:30:39,750](https://youtu.be/pz1MYpZ93UA?t=01h30m27s)

builder here might be the only only bit


[01:30:32,430 --> 01:30:42,960](https://youtu.be/pz1MYpZ93UA?t=01h30m32s)

that is that I could reuse because


[01:30:39,750 --> 01:30:44,370](https://youtu.be/pz1MYpZ93UA?t=01h30m39s)

effectively the difference is this


[01:30:42,960 --> 01:30:48,530](https://youtu.be/pz1MYpZ93UA?t=01h30m42s)

invoke async


[01:30:44,370 --> 01:30:54,510](https://youtu.be/pz1MYpZ93UA?t=01h30m44s)

I guess building out the parse result


[01:30:48,530 --> 01:31:00,750](https://youtu.be/pz1MYpZ93UA?t=01h30m48s)

could be shared yeah let's let's share


[01:30:54,510 --> 01:31:11,460](https://youtu.be/pz1MYpZ93UA?t=01h30m54s)

that so private static this isn't clear


[01:31:00,750 --> 01:31:17,940](https://youtu.be/pz1MYpZ93UA?t=01h31m00s)

what this is parse results what do we


[01:31:11,460 --> 01:31:23,970](https://youtu.be/pz1MYpZ93UA?t=01h31m11s)

call this parse for now I'll just bring


[01:31:17,940 --> 01:31:27,830](https://youtu.be/pz1MYpZ93UA?t=01h31m17s)

this stuff down let's see because you're


[01:31:23,970 --> 01:31:27,830](https://youtu.be/pz1MYpZ93UA?t=01h31m23s)

going to need a command


[01:31:31,039 --> 01:31:42,500](https://youtu.be/pz1MYpZ93UA?t=01h31m31s)

the command and you're going to need


[01:31:36,110 --> 01:31:51,679](https://youtu.be/pz1MYpZ93UA?t=01h31m36s)

some string args nope one too many


[01:31:42,500 --> 01:31:54,289](https://youtu.be/pz1MYpZ93UA?t=01h31m42s)

things that gets that much through let's


[01:31:51,679 --> 01:31:59,000](https://youtu.be/pz1MYpZ93UA?t=01h31m51s)

see just verifying this does take a


[01:31:54,289 --> 01:32:06,190](https://youtu.be/pz1MYpZ93UA?t=01h31m54s)

command all the way through and this is


[01:31:59,000 --> 01:32:16,219](https://youtu.be/pz1MYpZ93UA?t=01h31m59s)

effectively just straight return parse


[01:32:06,190 --> 01:32:21,340](https://youtu.be/pz1MYpZ93UA?t=01h32m06s)

with defaults so this becomes parse with


[01:32:16,219 --> 01:32:25,480](https://youtu.be/pz1MYpZ93UA?t=01h32m16s)

default too many parses too many parses


[01:32:21,340 --> 01:32:29,320](https://youtu.be/pz1MYpZ93UA?t=01h32m21s)

cool it down cool it down there we go


[01:32:25,480 --> 01:32:29,320](https://youtu.be/pz1MYpZ93UA?t=01h32m25s)

something more like that


[01:32:36,630 --> 01:32:41,290](https://youtu.be/pz1MYpZ93UA?t=01h32m36s)

I'm wondering if we should go one step


[01:32:39,310 --> 01:32:43,980](https://youtu.be/pz1MYpZ93UA?t=01h32m39s)

further and return the invocation


[01:32:41,290 --> 01:32:43,980](https://youtu.be/pz1MYpZ93UA?t=01h32m41s)

pipeline


[01:33:12,250 --> 01:33:21,460](https://youtu.be/pz1MYpZ93UA?t=01h33m12s)

too much I don't know I always have


[01:33:18,940 --> 01:33:23,410](https://youtu.be/pz1MYpZ93UA?t=01h33m18s)

mixed feelings about sometimes trying to


[01:33:21,460 --> 01:33:27,400](https://youtu.be/pz1MYpZ93UA?t=01h33m21s)

do these types of reef actors you it's


[01:33:23,410 --> 01:33:29,440](https://youtu.be/pz1MYpZ93UA?t=01h33m23s)

easy to get into the habit of two things


[01:33:27,400 --> 01:33:41,770](https://youtu.be/pz1MYpZ93UA?t=01h33m27s)

look alike therefore they should do the


[01:33:29,440 --> 01:33:53,230](https://youtu.be/pz1MYpZ93UA?t=01h33m29s)

same thing and I'm not just trying to


[01:33:41,770 --> 01:33:58,630](https://youtu.be/pz1MYpZ93UA?t=01h33m41s)

decide if this is come on come on get


[01:33:53,230 --> 01:34:06,880](https://youtu.be/pz1MYpZ93UA?t=01h33m53s)

invocation pipelined command args it's


[01:33:58,630 --> 01:34:10,920](https://youtu.be/pz1MYpZ93UA?t=01h33m58s)

that a better looking API I mean it


[01:34:06,880 --> 01:34:15,900](https://youtu.be/pz1MYpZ93UA?t=01h34m06s)

certainly reduces this down to a


[01:34:10,920 --> 01:34:15,900](https://youtu.be/pz1MYpZ93UA?t=01h34m10s)

one-liner is that good


[01:34:24,949 --> 01:34:30,420](https://youtu.be/pz1MYpZ93UA?t=01h34m24s)

and there's an argument to be made that


[01:34:27,270 --> 01:34:42,000](https://youtu.be/pz1MYpZ93UA?t=01h34m27s)

these things should be separated but for


[01:34:30,420 --> 01:34:45,480](https://youtu.be/pz1MYpZ93UA?t=01h34m30s)

now we're going with it because that


[01:34:42,000 --> 01:34:52,650](https://youtu.be/pz1MYpZ93UA?t=01h34m42s)

will at least save us a teeny bit of


[01:34:45,480 --> 01:34:55,110](https://youtu.be/pz1MYpZ93UA?t=01h34m45s)

code and in a lot of cases the phils one


[01:34:52,650 --> 01:35:00,390](https://youtu.be/pz1MYpZ93UA?t=01h34m52s)

liner type methods the compiler will


[01:34:55,110 --> 01:35:03,030](https://youtu.be/pz1MYpZ93UA?t=01h34m55s)

inline which might very well help so


[01:35:00,390 --> 01:35:09,060](https://youtu.be/pz1MYpZ93UA?t=01h35m00s)

let's go ahead just make sure I don't


[01:35:03,030 --> 01:35:11,640](https://youtu.be/pz1MYpZ93UA?t=01h35m03s)

think we've broken anything here rerun


[01:35:09,060 --> 01:35:15,960](https://youtu.be/pz1MYpZ93UA?t=01h35m09s)

those and then let's go and work our way


[01:35:11,640 --> 01:35:21,330](https://youtu.be/pz1MYpZ93UA?t=01h35m11s)

back up because we made some changes to


[01:35:15,960 --> 01:35:26,250](https://youtu.be/pz1MYpZ93UA?t=01h35m15s)

dragon fruit and I believe we have some


[01:35:21,330 --> 01:35:31,199](https://youtu.be/pz1MYpZ93UA?t=01h35m21s)

reasonable unit tests on this so execute


[01:35:26,250 --> 01:35:33,239](https://youtu.be/pz1MYpZ93UA?t=01h35m26s)

assembly let's go let's go look at the


[01:35:31,199 --> 01:35:36,540](https://youtu.be/pz1MYpZ93UA?t=01h35m31s)

unit tests on that and see what needs to


[01:35:33,239 --> 01:35:40,340](https://youtu.be/pz1MYpZ93UA?t=01h35m33s)

be done and then after those are passing


[01:35:36,540 --> 01:35:40,340](https://youtu.be/pz1MYpZ93UA?t=01h35m36s)

we will go through and see about


[01:35:45,080 --> 01:35:49,350](https://youtu.be/pz1MYpZ93UA?t=01h35m45s)

actually running it the hard part for


[01:35:47,130 --> 01:35:52,380](https://youtu.be/pz1MYpZ93UA?t=01h35m47s)

this is part of what system command


[01:35:49,350 --> 01:35:56,550](https://youtu.be/pz1MYpZ93UA?t=01h35m49s)

light or yes system command line dragon


[01:35:52,380 --> 01:35:59,310](https://youtu.be/pz1MYpZ93UA?t=01h35m52s)

fruit does is this entry point discover


[01:35:56,550 --> 01:36:03,480](https://youtu.be/pz1MYpZ93UA?t=01h35m56s)

and an execution on that so there might


[01:35:59,310 --> 01:36:09,930](https://youtu.be/pz1MYpZ93UA?t=01h35m59s)

not be there might not be that many unit


[01:36:03,480 --> 01:36:13,170](https://youtu.be/pz1MYpZ93UA?t=01h36m03s)

tests directly on that method let's just


[01:36:09,930 --> 01:36:19,949](https://youtu.be/pz1MYpZ93UA?t=01h36m09s)

pin you for the moment you go ahead and


[01:36:13,170 --> 01:36:21,840](https://youtu.be/pz1MYpZ93UA?t=01h36m13s)

sit on the side because it wants to act


[01:36:19,949 --> 01:36:25,400](https://youtu.be/pz1MYpZ93UA?t=01h36m19s)

on an assembly which means it would have


[01:36:21,840 --> 01:36:29,120](https://youtu.be/pz1MYpZ93UA?t=01h36m21s)

to have a compiled assembly to act on


[01:36:25,400 --> 01:36:29,120](https://youtu.be/pz1MYpZ93UA?t=01h36m25s)

let's take a quick peek


[01:36:30,270 --> 01:36:35,679](https://youtu.be/pz1MYpZ93UA?t=01h36m30s)

spend out dragonfruit


[01:36:32,110 --> 01:36:38,139](https://youtu.be/pz1MYpZ93UA?t=01h36m32s)

command line because there's those


[01:36:35,679 --> 01:36:40,770](https://youtu.be/pz1MYpZ93UA?t=01h36m35s)

command line tests execute assembly


[01:36:38,139 --> 01:36:40,770](https://youtu.be/pz1MYpZ93UA?t=01h36m38s)

async


[01:36:41,309 --> 01:36:47,590](https://youtu.be/pz1MYpZ93UA?t=01h36m41s)

that's the imports fortunate part no


[01:36:44,619 --> 01:36:51,340](https://youtu.be/pz1MYpZ93UA?t=01h36m44s)

reference oh six references where are


[01:36:47,590 --> 01:37:02,800](https://youtu.be/pz1MYpZ93UA?t=01h36m47s)

they oh let's see


[01:36:51,340 --> 01:37:13,650](https://youtu.be/pz1MYpZ93UA?t=01h36m51s)

perf and dragon fruit and then the


[01:37:02,800 --> 01:37:13,650](https://youtu.be/pz1MYpZ93UA?t=01h37m02s)

rendering playground not helpful


[01:37:20,100 --> 01:37:30,870](https://youtu.be/pz1MYpZ93UA?t=01h37m20s)

our fax oej sure version is there are no


[01:37:26,160 --> 01:37:34,740](https://youtu.be/pz1MYpZ93UA?t=01h37m26s)

direct tests on this guy the hard part


[01:37:30,870 --> 01:37:39,390](https://youtu.be/pz1MYpZ93UA?t=01h37m30s)

being that this would require a an entry


[01:37:34,740 --> 01:37:50,090](https://youtu.be/pz1MYpZ93UA?t=01h37m34s)

assembly entry point full type name XML


[01:37:39,390 --> 01:37:50,090](https://youtu.be/pz1MYpZ93UA?t=01h37m39s)

Doc's oh boy oh boy oh boy oh boy


[01:38:02,450 --> 01:38:06,640](https://youtu.be/pz1MYpZ93UA?t=01h38m02s)

so let's see entry point


[01:38:12,699 --> 01:38:18,159](https://youtu.be/pz1MYpZ93UA?t=01h38m12s)

not a lot of code sharing to be had here


[01:38:15,760 --> 01:38:21,159](https://youtu.be/pz1MYpZ93UA?t=01h38m15s)

though there's definitely a need for


[01:38:18,159 --> 01:38:23,289](https://youtu.be/pz1MYpZ93UA?t=01h38m18s)

unit testing over these methods the


[01:38:21,159 --> 01:38:27,130](https://youtu.be/pz1MYpZ93UA?t=01h38m21s)

problem being to test something that


[01:38:23,289 --> 01:38:30,369](https://youtu.be/pz1MYpZ93UA?t=01h38m23s)

takes in an assembly probably means


[01:38:27,130 --> 01:38:32,550](https://youtu.be/pz1MYpZ93UA?t=01h38m27s)

reflection omit to generate the assembly


[01:38:30,369 --> 01:38:34,300](https://youtu.be/pz1MYpZ93UA?t=01h38m30s)

on the fly


[01:38:32,550 --> 01:38:38,079](https://youtu.be/pz1MYpZ93UA?t=01h38m32s)

trying to think if there's a better


[01:38:34,300 --> 01:38:45,090](https://youtu.be/pz1MYpZ93UA?t=01h38m34s)

option because that is ugly ugly ugly


[01:38:38,079 --> 01:38:47,829](https://youtu.be/pz1MYpZ93UA?t=01h38m38s)

ugly it's certainly certainly doable I


[01:38:45,090 --> 01:38:50,320](https://youtu.be/pz1MYpZ93UA?t=01h38m45s)

was thinking for now given that this one


[01:38:47,829 --> 01:38:54,090](https://youtu.be/pz1MYpZ93UA?t=01h38m47s)

wasn't unit tested I might just not


[01:38:50,320 --> 01:38:54,090](https://youtu.be/pz1MYpZ93UA?t=01h38m50s)

bother with this one at the moment


[01:38:56,999 --> 01:39:09,099](https://youtu.be/pz1MYpZ93UA?t=01h38m56s)

and let this guy go


[01:39:00,369 --> 01:39:11,679](https://youtu.be/pz1MYpZ93UA?t=01h39m00s)

I think that makes it simplest okay so


[01:39:09,099 --> 01:39:17,289](https://youtu.be/pz1MYpZ93UA?t=01h39m09s)

with that said let's go and see about


[01:39:11,679 --> 01:39:19,199](https://youtu.be/pz1MYpZ93UA?t=01h39m11s)

submitting a pull request I've already


[01:39:17,289 --> 01:39:25,409](https://youtu.be/pz1MYpZ93UA?t=01h39m17s)

forgot my issue number so let's back up


[01:39:19,199 --> 01:39:25,409](https://youtu.be/pz1MYpZ93UA?t=01h39m19s)

let's see not that one this one for 12


[01:39:25,979 --> 01:39:38,260](https://youtu.be/pz1MYpZ93UA?t=01h39m25s)

excellent so branches a new local branch


[01:39:32,070 --> 01:39:42,489](https://youtu.be/pz1MYpZ93UA?t=01h39m32s)

fix for 12 created off master what am i


[01:39:38,260 --> 01:39:44,789](https://youtu.be/pz1MYpZ93UA?t=01h39m38s)

doing I've got a cracking open let's go


[01:39:42,489 --> 01:39:49,989](https://youtu.be/pz1MYpZ93UA?t=01h39m42s)

let's go play on cracking for the moment


[01:39:44,789 --> 01:39:51,969](https://youtu.be/pz1MYpZ93UA?t=01h39m44s)

so a new branch great think we want all


[01:39:49,989 --> 01:39:55,300](https://youtu.be/pz1MYpZ93UA?t=01h39m49s)

of our changes so let's stage them all


[01:39:51,969 --> 01:39:57,639](https://youtu.be/pz1MYpZ93UA?t=01h39m51s)

and just quickly quickly scan them again


[01:39:55,300 --> 01:40:01,809](https://youtu.be/pz1MYpZ93UA?t=01h39m55s)

just to make sure it is always a good


[01:39:57,639 --> 01:40:07,389](https://youtu.be/pz1MYpZ93UA?t=01h39m57s)

idea to review your commit before


[01:40:01,809 --> 01:40:12,300](https://youtu.be/pz1MYpZ93UA?t=01h40m01s)

pushing it so execute oh I forgot about


[01:40:07,389 --> 01:40:12,300](https://youtu.be/pz1MYpZ93UA?t=01h40m07s)

invoke method


[01:40:15,830 --> 01:40:25,380](https://youtu.be/pz1MYpZ93UA?t=01h40m15s)

what and this is what I'm glad we


[01:40:18,330 --> 01:40:29,429](https://youtu.be/pz1MYpZ93UA?t=01h40m18s)

checked because this one I believe does


[01:40:25,380 --> 01:40:31,080](https://youtu.be/pz1MYpZ93UA?t=01h40m25s)

have you know I believe this one


[01:40:29,429 --> 01:40:34,710](https://youtu.be/pz1MYpZ93UA?t=01h40m29s)

actually does have unit tests on it


[01:40:31,080 --> 01:40:41,280](https://youtu.be/pz1MYpZ93UA?t=01h40m31s)

because it's much easier to unit test a


[01:40:34,710 --> 01:40:50,699](https://youtu.be/pz1MYpZ93UA?t=01h40m34s)

method info command line tests yes it


[01:40:41,280 --> 01:40:59,719](https://youtu.be/pz1MYpZ93UA?t=01h40m41s)

does yes it does


[01:40:50,699 --> 01:41:02,850](https://youtu.be/pz1MYpZ93UA?t=01h40m50s)

okay so we we want to duplicate these


[01:40:59,719 --> 01:41:04,860](https://youtu.be/pz1MYpZ93UA?t=01h40m59s)

okay so we do we do want to do a little


[01:41:02,850 --> 01:41:09,020](https://youtu.be/pz1MYpZ93UA?t=01h41m02s)

work here okay so before we get carried


[01:41:04,860 --> 01:41:14,100](https://youtu.be/pz1MYpZ93UA?t=01h41m04s)

away let's get the unit test working


[01:41:09,020 --> 01:41:16,980](https://youtu.be/pz1MYpZ93UA?t=01h41m09s)

okay so this becomes avoid we need to


[01:41:14,100 --> 01:41:23,340](https://youtu.be/pz1MYpZ93UA?t=01h41m14s)

have a better name this becomes invoke


[01:41:16,980 --> 01:41:27,199](https://youtu.be/pz1MYpZ93UA?t=01h41m16s)

method this becomes a weight test


[01:41:23,340 --> 01:41:27,199](https://youtu.be/pz1MYpZ93UA?t=01h41m23s)

program test method info


[01:41:31,989 --> 01:41:41,700](https://youtu.be/pz1MYpZ93UA?t=01h41m31s)

this is asynchronous method execute


[01:41:47,900 --> 01:41:50,900](https://youtu.be/pz1MYpZ93UA?t=01h41m47s)

sinker


[01:41:55,530 --> 01:42:02,820](https://youtu.be/pz1MYpZ93UA?t=01h41m55s)

also if it wasn't clear my spelling is


[01:41:59,280 --> 01:42:02,820](https://youtu.be/pz1MYpZ93UA?t=01h41m59s)

I'll say Lac


[01:42:11,390 --> 01:42:29,550](https://youtu.be/pz1MYpZ93UA?t=01h42m11s)

so let's see so collapse collapse let's


[01:42:22,620 --> 01:42:31,290](https://youtu.be/pz1MYpZ93UA?t=01h42m22s)

see it just help based on XML Doc's see


[01:42:29,550 --> 01:42:33,330](https://youtu.be/pz1MYpZ93UA?t=01h42m29s)

all of these are I think fair game


[01:42:31,290 --> 01:42:40,890](https://youtu.be/pz1MYpZ93UA?t=01h42m31s)

because ultimately what these are


[01:42:33,330 --> 01:42:46,170](https://youtu.be/pz1MYpZ93UA?t=01h42m33s)

testing is the Builder configuration so


[01:42:40,890 --> 01:42:55,370](https://youtu.be/pz1MYpZ93UA?t=01h42m40s)

this becomes not a sink and this becomes


[01:42:46,170 --> 01:42:55,370](https://youtu.be/pz1MYpZ93UA?t=01h42m46s)

a void and to do to do to do to do to do


[01:43:01,900 --> 01:43:06,130](https://youtu.be/pz1MYpZ93UA?t=01h43m01s)

thinking there's probably some code


[01:43:04,360 --> 01:43:08,889](https://youtu.be/pz1MYpZ93UA?t=01h43m04s)

reuse that can be happening in here


[01:43:06,130 --> 01:43:15,960](https://youtu.be/pz1MYpZ93UA?t=01h43m06s)

because most of these tests are not the


[01:43:08,889 --> 01:43:15,960](https://youtu.be/pz1MYpZ93UA?t=01h43m08s)

invocation but the method here


[01:43:22,069 --> 01:43:26,349](https://youtu.be/pz1MYpZ93UA?t=01h43m22s)

just grab this because I think this is


[01:43:29,820 --> 01:43:35,190](https://youtu.be/pz1MYpZ93UA?t=01h43m29s)

I think that's ultimately what we're


[01:43:31,470 --> 01:43:36,990](https://youtu.be/pz1MYpZ93UA?t=01h43m31s)

gonna end up doing here it's making a


[01:43:35,190 --> 01:43:46,340](https://youtu.be/pz1MYpZ93UA?t=01h43m35s)

lot of these things just straight-up


[01:43:36,990 --> 01:43:53,610](https://youtu.be/pz1MYpZ93UA?t=01h43m36s)

synchronous ooh nope


[01:43:46,340 --> 01:43:58,380](https://youtu.be/pz1MYpZ93UA?t=01h43m46s)

clipboard pollution that one that goes


[01:43:53,610 --> 01:44:01,500](https://youtu.be/pz1MYpZ93UA?t=01h43m53s)

away you become a void you become a


[01:43:58,380 --> 01:44:03,840](https://youtu.be/pz1MYpZ93UA?t=01h43m58s)

synchronous call it does seem weird that


[01:44:01,500 --> 01:44:07,500](https://youtu.be/pz1MYpZ93UA?t=01h44m01s)

these exit codes are testing for zero


[01:44:03,840 --> 01:44:10,680](https://youtu.be/pz1MYpZ93UA?t=01h44m03s)

despite these methods both being void


[01:44:07,500 --> 01:44:12,510](https://youtu.be/pz1MYpZ93UA?t=01h44m07s)

returns these unit tests are very much


[01:44:10,680 --> 01:44:15,860](https://youtu.be/pz1MYpZ93UA?t=01h44m10s)

lacking there's a lot of cases in here


[01:44:12,510 --> 01:44:15,860](https://youtu.be/pz1MYpZ93UA?t=01h44m12s)

that are not being covered


[01:44:23,020 --> 01:44:28,810](https://youtu.be/pz1MYpZ93UA?t=01h44m23s)

this is passing a target of null just


[01:44:27,280 --> 01:44:32,739](https://youtu.be/pz1MYpZ93UA?t=01h44m27s)

fine


[01:44:28,810 --> 01:44:35,250](https://youtu.be/pz1MYpZ93UA?t=01h44m28s)

so let's private let's make that guy


[01:44:32,739 --> 01:44:35,250](https://youtu.be/pz1MYpZ93UA?t=01h44m32s)

static


[01:44:50,440 --> 01:45:01,659](https://youtu.be/pz1MYpZ93UA?t=01h44m50s)

this becomes a void this lacks the sink


[01:44:56,050 --> 01:45:13,170](https://youtu.be/pz1MYpZ93UA?t=01h44m56s)

we dropped the weight and that all works


[01:45:01,659 --> 01:45:13,170](https://youtu.be/pz1MYpZ93UA?t=01h45m01s)

and the last one let's see void here


[01:45:19,590 --> 01:45:37,650](https://youtu.be/pz1MYpZ93UA?t=01h45m19s)

and we go here and here make sure that


[01:45:27,690 --> 01:45:39,810](https://youtu.be/pz1MYpZ93UA?t=01h45m27s)

all works okay we run the dragon fruit


[01:45:37,650 --> 01:45:44,160](https://youtu.be/pz1MYpZ93UA?t=01h45m37s)

tests let's make sure we didn't break


[01:45:39,810 --> 01:45:46,260](https://youtu.be/pz1MYpZ93UA?t=01h45m39s)

anything and then I think there is room


[01:45:44,160 --> 01:45:49,380](https://youtu.be/pz1MYpZ93UA?t=01h45m44s)

for these two methods we can certainly


[01:45:46,260 --> 01:45:58,650](https://youtu.be/pz1MYpZ93UA?t=01h45m46s)

do something building up this parser is


[01:45:49,380 --> 01:46:04,110](https://youtu.be/pz1MYpZ93UA?t=01h45m49s)

an easy easy win just make sure all


[01:45:58,650 --> 01:46:06,560](https://youtu.be/pz1MYpZ93UA?t=01h45m58s)

these tests currently pass and we should


[01:46:04,110 --> 01:46:06,560](https://youtu.be/pz1MYpZ93UA?t=01h46m04s)

be good


[01:46:08,780 --> 01:46:23,310](https://youtu.be/pz1MYpZ93UA?t=01h46m08s)

Berbick okay private static parser build


[01:46:18,470 --> 01:46:28,440](https://youtu.be/pz1MYpZ93UA?t=01h46m18s)

parser and we are just going to grab all


[01:46:23,310 --> 01:46:37,050](https://youtu.be/pz1MYpZ93UA?t=01h46m23s)

this bring all of you down and let's see


[01:46:28,440 --> 01:46:42,870](https://youtu.be/pz1MYpZ93UA?t=01h46m28s)

your return and we need method c xml


[01:46:37,050 --> 01:46:46,170](https://youtu.be/pz1MYpZ93UA?t=01h46m37s)

docs and target need you three keep them


[01:46:42,870 --> 01:46:50,130](https://youtu.be/pz1MYpZ93UA?t=01h46m42s)

in the same order there is no point in


[01:46:46,170 --> 01:46:57,510](https://youtu.be/pz1MYpZ93UA?t=01h46m46s)

these things being optional private


[01:46:50,130 --> 01:47:07,260](https://youtu.be/pz1MYpZ93UA?t=01h46m50s)

helper method so this then becomes build


[01:46:57,510 --> 01:47:12,810](https://youtu.be/pz1MYpZ93UA?t=01h46m57s)

parser method xml docs and target wax


[01:47:07,260 --> 01:47:15,140](https://youtu.be/pz1MYpZ93UA?t=01h47m07s)

this wax this then this is common shared


[01:47:12,810 --> 01:47:15,140](https://youtu.be/pz1MYpZ93UA?t=01h47m12s)

code


[01:47:19,250 --> 01:47:29,730](https://youtu.be/pz1MYpZ93UA?t=01h47m19s)

okay you're gonna test all the things go


[01:47:25,740 --> 01:47:34,940](https://youtu.be/pz1MYpZ93UA?t=01h47m25s)

back and stage those additional changes


[01:47:29,730 --> 01:47:34,940](https://youtu.be/pz1MYpZ93UA?t=01h47m29s)

okay so let's just double-check these


[01:47:37,160 --> 01:47:41,130](https://youtu.be/pz1MYpZ93UA?t=01h47m37s)

does still bother me I want to share


[01:47:39,600 --> 01:47:50,700](https://youtu.be/pz1MYpZ93UA?t=01h47m39s)

some of this code in the test and I'm


[01:47:41,130 --> 01:47:54,770](https://youtu.be/pz1MYpZ93UA?t=01h47m41s)

not sure a great way to do it not sure


[01:47:50,700 --> 01:47:54,770](https://youtu.be/pz1MYpZ93UA?t=01h47m50s)

there is a clean option


[01:48:00,140 --> 01:48:10,100](https://youtu.be/pz1MYpZ93UA?t=01h48m00s)

yeah I'm I'm less concerned about those


[01:48:03,400 --> 01:48:11,260](https://youtu.be/pz1MYpZ93UA?t=01h48m03s)

okay let's check command line you're


[01:48:10,100 --> 01:48:13,850](https://youtu.be/pz1MYpZ93UA?t=01h48m10s)

still running


[01:48:11,260 --> 01:48:17,900](https://youtu.be/pz1MYpZ93UA?t=01h48m11s)

okay so execute assembly we said we


[01:48:13,850 --> 01:48:22,060](https://youtu.be/pz1MYpZ93UA?t=01h48m13s)

weren't gonna directly unit test instead


[01:48:17,900 --> 01:48:30,110](https://youtu.be/pz1MYpZ93UA?t=01h48m17s)

will unit test the invoke method calls


[01:48:22,060 --> 01:48:36,160](https://youtu.be/pz1MYpZ93UA?t=01h48m22s)

great oak extension tests same thing all


[01:48:30,110 --> 01:48:38,660](https://youtu.be/pz1MYpZ93UA?t=01h48m30s)

the way down duplicate duplicate tests


[01:48:36,160 --> 01:48:41,410](https://youtu.be/pz1MYpZ93UA?t=01h48m36s)

see invoke chooses the appropriate


[01:48:38,660 --> 01:48:41,410](https://youtu.be/pz1MYpZ93UA?t=01h48m38s)

command


[01:48:46,880 --> 01:48:49,840](https://youtu.be/pz1MYpZ93UA?t=01h48m46s)

these ones


[01:49:04,169 --> 01:49:08,909](https://youtu.be/pz1MYpZ93UA?t=01h49m04s)

yeah that's fine it looks like we


[01:49:06,869 --> 01:49:11,099](https://youtu.be/pz1MYpZ93UA?t=01h49m06s)

covered all of those unit tests that


[01:49:08,909 --> 01:49:14,249](https://youtu.be/pz1MYpZ93UA?t=01h49m08s)

matter this is just the refactor for the


[01:49:11,099 --> 01:49:18,809](https://youtu.be/pz1MYpZ93UA?t=01h49m11s)

new operator just great


[01:49:14,249 --> 01:49:22,079](https://youtu.be/pz1MYpZ93UA?t=01h49m14s)

huzzah let's see here so invoke async


[01:49:18,809 --> 01:49:24,619](https://youtu.be/pz1MYpZ93UA?t=01h49m18s)

invoke we've got a shared method down


[01:49:22,079 --> 01:49:24,619](https://youtu.be/pz1MYpZ93UA?t=01h49m22s)

here


[01:49:27,050 --> 01:49:39,479](https://youtu.be/pz1MYpZ93UA?t=01h49m27s)

it's adds an invoke a sink an invoke and


[01:49:32,689 --> 01:49:41,550](https://youtu.be/pz1MYpZ93UA?t=01h49m32s)

cheater method down here shared logic


[01:49:39,479 --> 01:49:49,760](https://youtu.be/pz1MYpZ93UA?t=01h49m39s)

before building up the middleware but


[01:49:41,550 --> 01:49:55,699](https://youtu.be/pz1MYpZ93UA?t=01h49m41s)

let me cheat there perfect so fix is


[01:49:49,760 --> 01:49:55,699](https://youtu.be/pz1MYpZ93UA?t=01h49m49s)

pound four one two and that is not a for


[01:49:58,070 --> 01:50:12,149](https://youtu.be/pz1MYpZ93UA?t=01h49m58s)

this adds hey this overload for parser


[01:50:07,999 --> 01:50:14,340](https://youtu.be/pz1MYpZ93UA?t=01h50m07s)

vote these days I'm gonna learn how to


[01:50:12,149 --> 01:50:20,610](https://youtu.be/pz1MYpZ93UA?t=01h50m12s)

spell synchronous ah let's see


[01:50:14,340 --> 01:50:31,219](https://youtu.be/pz1MYpZ93UA?t=01h50m14s)

parser invoke all so let's see that's


[01:50:20,610 --> 01:50:39,030](https://youtu.be/pz1MYpZ93UA?t=01h50m20s)

effectively for location pipeline invoke


[01:50:31,219 --> 01:50:55,789](https://youtu.be/pz1MYpZ93UA?t=01h50m31s)

this change propagates up parser dot


[01:50:39,030 --> 01:51:01,669](https://youtu.be/pz1MYpZ93UA?t=01h50m39s)

invoke and system command line and up to


[01:50:55,789 --> 01:51:01,669](https://youtu.be/pz1MYpZ93UA?t=01h50m55s)

was the command line


[01:51:03,520 --> 01:51:18,360](https://youtu.be/pz1MYpZ93UA?t=01h51m03s)

mine the cute assembly in system command


[01:51:13,000 --> 01:51:18,360](https://youtu.be/pz1MYpZ93UA?t=01h51m13s)

line dragon fruit


[01:51:19,140 --> 01:51:38,680](https://youtu.be/pz1MYpZ93UA?t=01h51m19s)

dragon fruit perfect a change and great


[01:51:32,440 --> 01:51:45,190](https://youtu.be/pz1MYpZ93UA?t=01h51m32s)

push let's see we can't go to origin go


[01:51:38,680 --> 01:51:46,780](https://youtu.be/pz1MYpZ93UA?t=01h51m38s)

to my fork because I do not have pushed


[01:51:45,190 --> 01:51:51,700](https://youtu.be/pz1MYpZ93UA?t=01h51m45s)

for missions all the way up into the


[01:51:46,780 --> 01:51:55,270](https://youtu.be/pz1MYpZ93UA?t=01h51m46s)

dotnet system command line will pull


[01:51:51,700 --> 01:51:59,590](https://youtu.be/pz1MYpZ93UA?t=01h51m51s)

request this guy in hopefully it gets


[01:51:55,270 --> 01:52:03,550](https://youtu.be/pz1MYpZ93UA?t=01h51m55s)

reviewed and merged not too long so


[01:51:59,590 --> 01:52:05,820](https://youtu.be/pz1MYpZ93UA?t=01h51m59s)

let's jump over here to pull requests


[01:52:03,550 --> 01:52:05,820](https://youtu.be/pz1MYpZ93UA?t=01h52m03s)

and


[01:52:11,709 --> 01:52:17,530](https://youtu.be/pz1MYpZ93UA?t=01h52m11s)

how does it not show up here maybe the


[01:52:15,729 --> 01:52:20,860](https://youtu.be/pz1MYpZ93UA?t=01h52m15s)

helpful button is only on the root of


[01:52:17,530 --> 01:52:23,670](https://youtu.be/pz1MYpZ93UA?t=01h52m17s)

the repo there we go hey give it back


[01:52:20,860 --> 01:52:23,670](https://youtu.be/pz1MYpZ93UA?t=01h52m20s)

there you go


[01:52:33,300 --> 01:52:54,150](https://youtu.be/pz1MYpZ93UA?t=01h52m33s)

I'm gonna move this down put a little


[01:52:37,710 --> 01:52:56,160](https://youtu.be/pz1MYpZ93UA?t=01h52m37s)

bit better added the guy overloads to


[01:52:54,150 --> 01:52:57,870](https://youtu.be/pz1MYpZ93UA?t=01h52m54s)

just kind of scan this real quick and


[01:52:56,160 --> 01:53:00,690](https://youtu.be/pz1MYpZ93UA?t=01h52m56s)

make sure this still matches what we


[01:52:57,870 --> 01:53:06,270](https://youtu.be/pz1MYpZ93UA?t=01h52m57s)

expect and that there's nothing nothing


[01:53:00,690 --> 01:53:09,240](https://youtu.be/pz1MYpZ93UA?t=01h53m00s)

new nothing unexpected it's still just


[01:53:06,270 --> 01:53:12,750](https://youtu.be/pz1MYpZ93UA?t=01h53m06s)

these same you know tests operator


[01:53:09,240 --> 01:53:15,810](https://youtu.be/pz1MYpZ93UA?t=01h53m09s)

change invoke overloads shared method


[01:53:12,750 --> 01:53:17,100](https://youtu.be/pz1MYpZ93UA?t=01h53m12s)

because this is effectively when


[01:53:15,810 --> 01:53:20,670](https://youtu.be/pz1MYpZ93UA?t=01h53m15s)

somebody goes to review this what


[01:53:17,100 --> 01:53:23,610](https://youtu.be/pz1MYpZ93UA?t=01h53m17s)

they're going to be looking at so going


[01:53:20,670 --> 01:53:26,180](https://youtu.be/pz1MYpZ93UA?t=01h53m20s)

into master from my branch great great


[01:53:23,610 --> 01:53:26,180](https://youtu.be/pz1MYpZ93UA?t=01h53m23s)

ball request


[01:53:32,649 --> 01:53:39,519](https://youtu.be/pz1MYpZ93UA?t=01h53m32s)

perfect and we will let that guy cook


[01:53:35,530 --> 01:53:42,099](https://youtu.be/pz1MYpZ93UA?t=01h53m35s)

and roll and hopefully that that goes


[01:53:39,519 --> 01:53:43,539](https://youtu.be/pz1MYpZ93UA?t=01h53m39s)

through I'm gonna hold on here for just


[01:53:42,099 --> 01:53:47,619](https://youtu.be/pz1MYpZ93UA?t=01h53m42s)

a little bit just to make sure that the


[01:53:43,539 --> 01:53:51,820](https://youtu.be/pz1MYpZ93UA?t=01h53m43s)

CI build passes it can be a little bit


[01:53:47,619 --> 01:53:54,969](https://youtu.be/pz1MYpZ93UA?t=01h53m47s)

problematic at times the kind of backing


[01:53:51,820 --> 01:53:59,459](https://youtu.be/pz1MYpZ93UA?t=01h53m51s)

CI pipeline is called arcade and as you


[01:53:54,969 --> 01:54:02,079](https://youtu.be/pz1MYpZ93UA?t=01h53m54s)

can see it it compiles for everything


[01:53:59,459 --> 01:54:04,840](https://youtu.be/pz1MYpZ93UA?t=01h53m59s)

because we want to make sure it's tested


[01:54:02,079 --> 01:54:06,459](https://youtu.be/pz1MYpZ93UA?t=01h54m02s)

across various configurations and


[01:54:04,840 --> 01:54:11,099](https://youtu.be/pz1MYpZ93UA?t=01h54m04s)

operating systems and that kind of thing


[01:54:06,459 --> 01:54:11,099](https://youtu.be/pz1MYpZ93UA?t=01h54m06s)

so just gonna let that guy


[01:54:11,709 --> 01:54:18,729](https://youtu.be/pz1MYpZ93UA?t=01h54m11s)

chug for a little bit and then we will


[01:54:13,840 --> 01:54:21,939](https://youtu.be/pz1MYpZ93UA?t=01h54m13s)

come back for so switching gears off of


[01:54:18,729 --> 01:54:24,999](https://youtu.be/pz1MYpZ93UA?t=01h54m18s)

system command line for people who are


[01:54:21,939 --> 01:54:28,179](https://youtu.be/pz1MYpZ93UA?t=01h54m21s)

interested I have been looking at an


[01:54:24,999 --> 01:54:31,449](https://youtu.be/pz1MYpZ93UA?t=01h54m24s)

outline together for the material design


[01:54:28,179 --> 01:54:34,090](https://youtu.be/pz1MYpZ93UA?t=01h54m28s)

and zamel stuff specifically for things


[01:54:31,449 --> 01:54:37,719](https://youtu.be/pz1MYpZ93UA?t=01h54m31s)

to go into the three oh release I've


[01:54:34,090 --> 01:54:39,729](https://youtu.be/pz1MYpZ93UA?t=01h54m34s)

been somewhat ignoring chat for a little


[01:54:37,719 --> 01:54:42,159](https://youtu.be/pz1MYpZ93UA?t=01h54m37s)

bit just trying to get all of the


[01:54:39,729 --> 01:54:44,349](https://youtu.be/pz1MYpZ93UA?t=01h54m39s)

documentation and pipeline work done for


[01:54:42,159 --> 01:54:46,659](https://youtu.be/pz1MYpZ93UA?t=01h54m42s)

the two 6l release so anyone who's


[01:54:44,349 --> 01:54:49,719](https://youtu.be/pz1MYpZ93UA?t=01h54m44s)

looked at the history has probably seen


[01:54:46,659 --> 01:54:53,019](https://youtu.be/pz1MYpZ93UA?t=01h54m46s)

a huge number of yeah mole changes from


[01:54:49,719 --> 01:54:54,459](https://youtu.be/pz1MYpZ93UA?t=01h54m49s)

me just trying to get stuff working it's


[01:54:53,019 --> 01:54:59,409](https://youtu.be/pz1MYpZ93UA?t=01h54m53s)

been a good learning experience I'll say


[01:54:54,459 --> 01:55:02,619](https://youtu.be/pz1MYpZ93UA?t=01h54m54s)

that but so hopefully that release is


[01:54:59,409 --> 01:55:04,959](https://youtu.be/pz1MYpZ93UA?t=01h54m59s)

coming in the very near future as soon


[01:55:02,619 --> 01:55:08,469](https://youtu.be/pz1MYpZ93UA?t=01h55m02s)

as I can get my act together and get the


[01:55:04,959 --> 01:55:09,909](https://youtu.be/pz1MYpZ93UA?t=01h55m04s)

rest of those tasks done I've got a


[01:55:08,469 --> 01:55:12,760](https://youtu.be/pz1MYpZ93UA?t=01h55m08s)

personal deadline of trying to have it


[01:55:09,909 --> 01:55:13,360](https://youtu.be/pz1MYpZ93UA?t=01h55m09s)

done within this next week but don't


[01:55:12,760 --> 01:55:15,699](https://youtu.be/pz1MYpZ93UA?t=01h55m12s)

hold me to that


[01:55:13,360 --> 01:55:19,899](https://youtu.be/pz1MYpZ93UA?t=01h55m13s)

that is just a personal deadline of my


[01:55:15,699 --> 01:55:23,260](https://youtu.be/pz1MYpZ93UA?t=01h55m15s)

own the other thing for people who are


[01:55:19,899 --> 01:55:26,590](https://youtu.be/pz1MYpZ93UA?t=01h55m19s)

interested I did start working on what I


[01:55:23,260 --> 01:55:32,619](https://youtu.be/pz1MYpZ93UA?t=01h55m23s)

think will be probably a quick series on


[01:55:26,590 --> 01:55:36,219](https://youtu.be/pz1MYpZ93UA?t=01h55m26s)

using snoop for WPF debugging it I find


[01:55:32,619 --> 01:55:40,919](https://youtu.be/pz1MYpZ93UA?t=01h55m32s)

that the the hardest skill to teach and


[01:55:36,219 --> 01:55:46,389](https://youtu.be/pz1MYpZ93UA?t=01h55m36s)

explain to people is actually debugging


[01:55:40,919 --> 01:55:48,940](https://youtu.be/pz1MYpZ93UA?t=01h55m40s)

technology and so I was figuring that a


[01:55:46,389 --> 01:55:51,489](https://youtu.be/pz1MYpZ93UA?t=01h55m46s)

a short video series on that would


[01:55:48,940 --> 01:55:55,389](https://youtu.be/pz1MYpZ93UA?t=01h55m48s)

probably be what go over well what I


[01:55:51,489 --> 01:55:58,780](https://youtu.be/pz1MYpZ93UA?t=01h55m51s)

will probably do is just live stream it


[01:55:55,389 --> 01:56:00,730](https://youtu.be/pz1MYpZ93UA?t=01h55m55s)

and send it through but then the videos


[01:55:58,780 --> 01:56:02,860](https://youtu.be/pz1MYpZ93UA?t=01h55m58s)

that actually go up to YouTube I will


[01:56:00,730 --> 01:56:05,020](https://youtu.be/pz1MYpZ93UA?t=01h56m00s)

probably spend the time and actually do


[01:56:02,860 --> 01:56:07,510](https://youtu.be/pz1MYpZ93UA?t=01h56m02s)

some editing normally right now on all


[01:56:05,020 --> 01:56:09,099](https://youtu.be/pz1MYpZ93UA?t=01h56m05s)

these videos because my free time is


[01:56:07,510 --> 01:56:10,840](https://youtu.be/pz1MYpZ93UA?t=01h56m07s)

very limited and I'd rather spend it


[01:56:09,099 --> 01:56:14,110](https://youtu.be/pz1MYpZ93UA?t=01h56m09s)

being productive rather than editing


[01:56:10,840 --> 01:56:19,320](https://youtu.be/pz1MYpZ93UA?t=01h56m10s)

videos I've just been blind uploading


[01:56:14,110 --> 01:56:23,380](https://youtu.be/pz1MYpZ93UA?t=01h56m14s)

all the videos straight so hopefully I


[01:56:19,320 --> 01:56:27,090](https://youtu.be/pz1MYpZ93UA?t=01h56m19s)

get to that is its some time I won't


[01:56:23,380 --> 01:56:31,630](https://youtu.be/pz1MYpZ93UA?t=01h56m23s)

promise but if people are interested in


[01:56:27,090 --> 01:56:33,820](https://youtu.be/pz1MYpZ93UA?t=01h56m27s)

please shoot me a message on git er or


[01:56:31,630 --> 01:56:35,199](https://youtu.be/pz1MYpZ93UA?t=01h56m31s)

you can get in contact with me I think


[01:56:33,820 --> 01:56:39,429](https://youtu.be/pz1MYpZ93UA?t=01h56m33s)

most people probably have found my


[01:56:35,199 --> 01:56:44,770](https://youtu.be/pz1MYpZ93UA?t=01h56m35s)

Twitter and got here from there if not I


[01:56:39,429 --> 01:56:49,480](https://youtu.be/pz1MYpZ93UA?t=01h56m39s)

will I don't actually have it here one


[01:56:44,770 --> 01:57:00,480](https://youtu.be/pz1MYpZ93UA?t=01h56m44s)

second we can grab this let's see here


[01:56:49,480 --> 01:57:10,570](https://youtu.be/pz1MYpZ93UA?t=01h56m49s)

so let's grab I do this and I can grab


[01:57:00,480 --> 01:57:13,199](https://youtu.be/pz1MYpZ93UA?t=01h57m00s)

this item and copy codeine and paste


[01:57:10,570 --> 01:57:13,199](https://youtu.be/pz1MYpZ93UA?t=01h57m10s)

duplicate


[01:57:17,350 --> 01:57:21,570](https://youtu.be/pz1MYpZ93UA?t=01h57m17s)

that is not what we were going for


[01:57:22,860 --> 01:57:30,100](https://youtu.be/pz1MYpZ93UA?t=01h57m22s)

remove I might have to play around with


[01:57:25,840 --> 01:57:32,860](https://youtu.be/pz1MYpZ93UA?t=01h57m25s)

this but for those people who are


[01:57:30,100 --> 01:57:39,700](https://youtu.be/pz1MYpZ93UA?t=01h57m30s)

looking for me you can find me on


[01:57:32,860 --> 01:57:43,600](https://youtu.be/pz1MYpZ93UA?t=01h57m32s)

twitter at ki t o ke b o o sweet looks


[01:57:39,700 --> 01:57:45,280](https://youtu.be/pz1MYpZ93UA?t=01h57m39s)

like most of these are passing OS X and


[01:57:43,600 --> 01:57:47,520](https://youtu.be/pz1MYpZ93UA?t=01h57m43s)

Ubuntu are done and it's just the


[01:57:45,280 --> 01:57:52,420](https://youtu.be/pz1MYpZ93UA?t=01h57m45s)

Windows builds that we're waiting on


[01:57:47,520 --> 01:57:56,770](https://youtu.be/pz1MYpZ93UA?t=01h57m47s)

just awesome Lee this guy all goes


[01:57:52,420 --> 01:57:58,900](https://youtu.be/pz1MYpZ93UA?t=01h57m52s)

through nicely I think with that I am


[01:57:56,770 --> 01:58:01,630](https://youtu.be/pz1MYpZ93UA?t=01h57m56s)

probably going to be signing off for the


[01:57:58,900 --> 01:58:03,220](https://youtu.be/pz1MYpZ93UA?t=01h57m58s)

night it is getting close to my two hour


[01:58:01,630 --> 01:58:07,440](https://youtu.be/pz1MYpZ93UA?t=01h58m01s)

mark where I usually try to call it


[01:58:03,220 --> 01:58:11,500](https://youtu.be/pz1MYpZ93UA?t=01h58m03s)

quits but I will I will get this this


[01:58:07,440 --> 01:58:14,890](https://youtu.be/pz1MYpZ93UA?t=01h58m07s)

guy merged in I don't know if it's going


[01:58:11,500 --> 01:58:16,390](https://youtu.be/pz1MYpZ93UA?t=01h58m11s)

to necessarily make the a live stream or


[01:58:14,890 --> 01:58:18,250](https://youtu.be/pz1MYpZ93UA?t=01h58m14s)

not unless people tell me that they're


[01:58:16,390 --> 01:58:21,700](https://youtu.be/pz1MYpZ93UA?t=01h58m16s)

interested in doing it but the actual


[01:58:18,250 --> 01:58:29,980](https://youtu.be/pz1MYpZ93UA?t=01h58m18s)

fix for this issue should now be


[01:58:21,700 --> 01:58:31,660](https://youtu.be/pz1MYpZ93UA?t=01h58m21s)

possible now that the async main it's no


[01:58:29,980 --> 01:58:33,400](https://youtu.be/pz1MYpZ93UA?t=01h58m29s)

longer going to be a requirement it


[01:58:31,660 --> 01:58:35,130](https://youtu.be/pz1MYpZ93UA?t=01h58m31s)

should be possible to go through and


[01:58:33,400 --> 01:58:37,300](https://youtu.be/pz1MYpZ93UA?t=01h58m33s)

generate up that targets file correctly


[01:58:35,130 --> 01:58:38,890](https://youtu.be/pz1MYpZ93UA?t=01h58m35s)

because the comment here could the


[01:58:37,300 --> 01:58:42,760](https://youtu.be/pz1MYpZ93UA?t=01h58m37s)

targets use a conditional that would


[01:58:38,890 --> 01:58:44,140](https://youtu.be/pz1MYpZ93UA?t=01h58m38s)

output a synchronous main and the answer


[01:58:42,760 --> 01:58:46,150](https://youtu.be/pz1MYpZ93UA?t=01h58m42s)

is yes that's a that's effectively


[01:58:44,140 --> 01:58:48,430](https://youtu.be/pz1MYpZ93UA?t=01h58m44s)

exactly what needs to happen the problem


[01:58:46,150 --> 01:58:53,230](https://youtu.be/pz1MYpZ93UA?t=01h58m46s)

before is generating a synchronous main


[01:58:48,430 --> 01:58:55,780](https://youtu.be/pz1MYpZ93UA?t=01h58m48s)

wasn't actually possible because the API


[01:58:53,230 --> 01:58:57,880](https://youtu.be/pz1MYpZ93UA?t=01h58m53s)

was a sink all the way down and we


[01:58:55,780 --> 01:59:03,010](https://youtu.be/pz1MYpZ93UA?t=01h58m55s)

didn't want to do the the cheater mode


[01:58:57,880 --> 01:59:05,080](https://youtu.be/pz1MYpZ93UA?t=01h58m57s)

for the sink over a sink at the root we


[01:59:03,010 --> 01:59:08,590](https://youtu.be/pz1MYpZ93UA?t=01h59m03s)

wanted to push it down as far as we


[01:59:05,080 --> 01:59:10,690](https://youtu.be/pz1MYpZ93UA?t=01h59m05s)

could through the library so for anybody


[01:59:08,590 --> 01:59:14,070](https://youtu.be/pz1MYpZ93UA?t=01h59m08s)

who finds these interesting once again


[01:59:10,690 --> 01:59:19,540](https://youtu.be/pz1MYpZ93UA?t=01h59m10s)

this is the the article that I was


[01:59:14,070 --> 01:59:21,610](https://youtu.be/pz1MYpZ93UA?t=01h59m14s)

relying very heavily on from Steven


[01:59:19,540 --> 01:59:24,100](https://youtu.be/pz1MYpZ93UA?t=01h59m19s)

again it's an old one but it's one of


[01:59:21,610 --> 01:59:25,990](https://youtu.be/pz1MYpZ93UA?t=01h59m21s)

those concepts that I find that a lot of


[01:59:24,100 --> 01:59:28,630](https://youtu.be/pz1MYpZ93UA?t=01h59m24s)

people don't necessarily spend the time


[01:59:25,990 --> 01:59:30,610](https://youtu.be/pz1MYpZ93UA?t=01h59m25s)

to dive deep into the task parallel


[01:59:28,630 --> 01:59:31,449](https://youtu.be/pz1MYpZ93UA?t=01h59m28s)

library for the async and await and I


[01:59:30,610 --> 01:59:34,719](https://youtu.be/pz1MYpZ93UA?t=01h59m30s)

think it is very


[01:59:31,449 --> 01:59:43,199](https://youtu.be/pz1MYpZ93UA?t=01h59m31s)

much a worthwhile endeavor to understand


[01:59:34,719 --> 01:59:47,440](https://youtu.be/pz1MYpZ93UA?t=01h59m34s)

it cool all of the platform builds past


[01:59:43,199 --> 01:59:50,170](https://youtu.be/pz1MYpZ93UA?t=01h59m43s)

so that all checks are done now we just


[01:59:47,440 --> 01:59:53,469](https://youtu.be/pz1MYpZ93UA?t=01h59m47s)

have to wait for a review which may take


[01:59:50,170 --> 01:59:56,199](https://youtu.be/pz1MYpZ93UA?t=01h59m50s)

a while I know that the John mentioned


[01:59:53,469 --> 01:59:58,329](https://youtu.be/pz1MYpZ93UA?t=01h59m53s)

that he was going to have to be on break


[01:59:56,199 --> 02:00:00,010](https://youtu.be/pz1MYpZ93UA?t=01h59m56s)

for a little bit from this so hopefully


[01:59:58,329 --> 02:00:02,409](https://youtu.be/pz1MYpZ93UA?t=01h59m58s)

when he gets back it doesn't take him


[02:00:00,010 --> 02:00:04,900](https://youtu.be/pz1MYpZ93UA?t=02h00m00s)

too long to get it reviewed and call out


[02:00:02,409 --> 02:00:07,719](https://youtu.be/pz1MYpZ93UA?t=02h00m02s)

all of the mistakes that I made so with


[02:00:04,900 --> 02:00:11,159](https://youtu.be/pz1MYpZ93UA?t=02h00m04s)

that I will sign off tell you all good


[02:00:07,719 --> 02:00:11,159](https://youtu.be/pz1MYpZ93UA?t=02h00m07s)

night and happy coding


[02:00:17,540 --> 02:00:19,600](https://youtu.be/pz1MYpZ93UA?t=02h00m17s)

you

