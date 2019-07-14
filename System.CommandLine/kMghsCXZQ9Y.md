[YouTube Video](https://youtu.be/kMghsCXZQ9Y)


[00:06:26,389 --> 00:06:30,139](https://youtu.be/kMghsCXZQ9Y?t=00h06m26s)

okay


[00:06:27,629 --> 00:06:34,590](https://youtu.be/kMghsCXZQ9Y?t=00h06m27s)

it looks like we are just about at


[00:06:30,139 --> 00:06:36,150](https://youtu.be/kMghsCXZQ9Y?t=00h06m30s)

starting time so today we are going to


[00:06:34,590 --> 00:06:38,909](https://youtu.be/kMghsCXZQ9Y?t=00h06m34s)

be going through and looking at the


[00:06:36,150 --> 00:06:42,289](https://youtu.be/kMghsCXZQ9Y?t=00h06m36s)

system command line library


[00:06:38,909 --> 00:06:45,930](https://youtu.be/kMghsCXZQ9Y?t=00h06m38s)

we've got John once again who has been


[00:06:42,289 --> 00:06:48,900](https://youtu.be/kMghsCXZQ9Y?t=00h06m42s)

one of the I'll say principal devs on


[00:06:45,930 --> 00:06:52,069](https://youtu.be/kMghsCXZQ9Y?t=00h06m45s)

the project building this out we're


[00:06:48,900 --> 00:06:54,870](https://youtu.be/kMghsCXZQ9Y?t=00h06m48s)

going to be looking at the sort of a


[00:06:52,069 --> 00:06:57,750](https://youtu.be/kMghsCXZQ9Y?t=00h06m52s)

dependent nougat package that's part of


[00:06:54,870 --> 00:07:01,050](https://youtu.be/kMghsCXZQ9Y?t=00h06m54s)

the same repository called system


[00:06:57,750 --> 00:07:04,190](https://youtu.be/kMghsCXZQ9Y?t=00h06m57s)

command line dot rendering it's sort of


[00:07:01,050 --> 00:07:08,250](https://youtu.be/kMghsCXZQ9Y?t=00h07m01s)

designed to go through and make


[00:07:04,190 --> 00:07:10,229](https://youtu.be/kMghsCXZQ9Y?t=00h07m04s)

outputting your CLI apps much easier so


[00:07:08,250 --> 00:07:12,930](https://youtu.be/kMghsCXZQ9Y?t=00h07m08s)

things like if you want to do some fancy


[00:07:10,229 --> 00:07:15,539](https://youtu.be/kMghsCXZQ9Y?t=00h07m10s)

layout with a grid or have automatic


[00:07:12,930 --> 00:07:17,550](https://youtu.be/kMghsCXZQ9Y?t=00h07m12s)

updating similar to what you'd get in a


[00:07:15,539 --> 00:07:21,120](https://youtu.be/kMghsCXZQ9Y?t=00h07m15s)

WPF framework with like a binding so


[00:07:17,550 --> 00:07:24,690](https://youtu.be/kMghsCXZQ9Y?t=00h07m17s)

that type of functionality only built


[00:07:21,120 --> 00:07:25,889](https://youtu.be/kMghsCXZQ9Y?t=00h07m21s)

into the CLI so John I don't know if you


[00:07:24,690 --> 00:07:30,180](https://youtu.be/kMghsCXZQ9Y?t=00h07m24s)

want to give a brief introduction to


[00:07:25,889 --> 00:07:32,069](https://youtu.be/kMghsCXZQ9Y?t=00h07m25s)

yourself and then we can dive into the


[00:07:30,180 --> 00:07:33,569](https://youtu.be/kMghsCXZQ9Y?t=00h07m30s)

library give me just one moment because


[00:07:32,069 --> 00:07:36,349](https://youtu.be/kMghsCXZQ9Y?t=00h07m32s)

I do have to unmute you and figure out


[00:07:33,569 --> 00:07:41,759](https://youtu.be/kMghsCXZQ9Y?t=00h07m33s)

where the heck your audio source right


[00:07:36,349 --> 00:07:48,539](https://youtu.be/kMghsCXZQ9Y?t=00h07m36s)

there you go now you're hot great cool


[00:07:41,759 --> 00:07:51,150](https://youtu.be/kMghsCXZQ9Y?t=00h07m41s)

so yeah um I am a developer on the


[00:07:48,539 --> 00:07:52,650](https://youtu.be/kMghsCXZQ9Y?t=00h07m48s)

dotnet team I've been working on the


[00:07:51,150 --> 00:07:54,330](https://youtu.be/kMghsCXZQ9Y?t=00h07m51s)

system command line thing for a bit over


[00:07:52,650 --> 00:07:56,610](https://youtu.be/kMghsCXZQ9Y?t=00h07m52s)

a year and then a little bit farther


[00:07:54,330 --> 00:08:02,909](https://youtu.be/kMghsCXZQ9Y?t=00h07m54s)

back it was if this was a new parser for


[00:07:56,610 --> 00:08:04,620](https://youtu.be/kMghsCXZQ9Y?t=00h07m56s)

the.net CLI which we kind of at some


[00:08:02,909 --> 00:08:06,300](https://youtu.be/kMghsCXZQ9Y?t=00h08m02s)

point to you know it'd be great to have


[00:08:04,620 --> 00:08:07,590](https://youtu.be/kMghsCXZQ9Y?t=00h08m04s)

some libraries that people can use for


[00:08:06,300 --> 00:08:11,130](https://youtu.be/kMghsCXZQ9Y?t=00h08m06s)

some of these broader ambitions that go


[00:08:07,590 --> 00:08:14,069](https://youtu.be/kMghsCXZQ9Y?t=00h08m07s)

beyond parsing yeah and completion Susan


[00:08:11,130 --> 00:08:16,650](https://youtu.be/kMghsCXZQ9Y?t=00h08m11s)

an app model that involves sort of an


[00:08:14,069 --> 00:08:18,449](https://youtu.be/kMghsCXZQ9Y?t=00h08m14s)

execution pipeline you know these are


[00:08:16,650 --> 00:08:20,669](https://youtu.be/kMghsCXZQ9Y?t=00h08m16s)

some of them that we sort of expanded


[00:08:18,449 --> 00:08:22,229](https://youtu.be/kMghsCXZQ9Y?t=00h08m18s)

beyond what it's typically available in


[00:08:20,669 --> 00:08:24,240](https://youtu.be/kMghsCXZQ9Y?t=00h08m20s)

in a lot of libraries and then the thing


[00:08:22,229 --> 00:08:27,800](https://youtu.be/kMghsCXZQ9Y?t=00h08m22s)

that we discovered from there was that


[00:08:24,240 --> 00:08:30,180](https://youtu.be/kMghsCXZQ9Y?t=00h08m24s)

rendering output was actually really a


[00:08:27,800 --> 00:08:32,940](https://youtu.be/kMghsCXZQ9Y?t=00h08m27s)

place where the older system dock


[00:08:30,180 --> 00:08:35,220](https://youtu.be/kMghsCXZQ9Y?t=00h08m30s)

console API is were not really


[00:08:32,940 --> 00:08:37,530](https://youtu.be/kMghsCXZQ9Y?t=00h08m32s)

as rich as we might like especially


[00:08:35,220 --> 00:08:43,200](https://youtu.be/kMghsCXZQ9Y?t=00h08m35s)

given this the new windows turn all has


[00:08:37,530 --> 00:08:44,370](https://youtu.be/kMghsCXZQ9Y?t=00h08m37s)

come out antsy terminals have become you


[00:08:43,200 --> 00:08:45,540](https://youtu.be/kMghsCXZQ9Y?t=00h08m43s)

know they've been available on windows


[00:08:44,370 --> 00:08:47,610](https://youtu.be/kMghsCXZQ9Y?t=00h08m44s)

for a little while but you have to do


[00:08:45,540 --> 00:08:49,410](https://youtu.be/kMghsCXZQ9Y?t=00h08m45s)

something special to enable it so the


[00:08:47,610 --> 00:08:51,480](https://youtu.be/kMghsCXZQ9Y?t=00h08m47s)

windows 32 API but you have to use to


[00:08:49,410 --> 00:08:53,790](https://youtu.be/kMghsCXZQ9Y?t=00h08m49s)

enable virtual terminal mode so what is


[00:08:51,480 --> 00:08:55,020](https://youtu.be/kMghsCXZQ9Y?t=00h08m51s)

an C output give you one of the


[00:08:53,790 --> 00:08:57,510](https://youtu.be/kMghsCXZQ9Y?t=00h08m53s)

different kinds of things you can render


[00:08:55,020 --> 00:08:59,100](https://youtu.be/kMghsCXZQ9Y?t=00h08m55s)

to the console these are all things that


[00:08:57,510 --> 00:09:02,670](https://youtu.be/kMghsCXZQ9Y?t=00h08m57s)

we looked at and said this is really


[00:08:59,100 --> 00:09:03,690](https://youtu.be/kMghsCXZQ9Y?t=00h08m59s)

hard for people to do well and maybe we


[00:09:02,670 --> 00:09:05,490](https://youtu.be/kMghsCXZQ9Y?t=00h09m02s)

should try and tackle some of that


[00:09:03,690 --> 00:09:09,570](https://youtu.be/kMghsCXZQ9Y?t=00h09m03s)

complexity and provide an API for doing


[00:09:05,490 --> 00:09:11,670](https://youtu.be/kMghsCXZQ9Y?t=00h09m05s)

it so that's that's the piece that it's


[00:09:09,570 --> 00:09:13,140](https://youtu.be/kMghsCXZQ9Y?t=00h09m09s)

a little bit less far along than the


[00:09:11,670 --> 00:09:15,000](https://youtu.be/kMghsCXZQ9Y?t=00h09m11s)

core system command line library that


[00:09:13,140 --> 00:09:17,910](https://youtu.be/kMghsCXZQ9Y?t=00h09m13s)

offers parsing communication on the


[00:09:15,000 --> 00:09:19,110](https://youtu.be/kMghsCXZQ9Y?t=00h09m15s)

model bindings but um we think that


[00:09:17,910 --> 00:09:25,230](https://youtu.be/kMghsCXZQ9Y?t=00h09m17s)

there's like a really interesting story


[00:09:19,110 --> 00:09:27,210](https://youtu.be/kMghsCXZQ9Y?t=00h09m19s)

here and so yeah at some point somehow


[00:09:25,230 --> 00:09:31,560](https://youtu.be/kMghsCXZQ9Y?t=00h09m25s)

convinced Kevin that he should become


[00:09:27,210 --> 00:09:35,130](https://youtu.be/kMghsCXZQ9Y?t=00h09m27s)

interested in this thing you can see his


[00:09:31,560 --> 00:09:37,380](https://youtu.be/kMghsCXZQ9Y?t=00h09m31s)

name in here even the source code your


[00:09:35,130 --> 00:09:43,920](https://youtu.be/kMghsCXZQ9Y?t=00h09m35s)

your cameras what's being shown that


[00:09:37,380 --> 00:09:45,540](https://youtu.be/kMghsCXZQ9Y?t=00h09m37s)

your screen but I see so yeah now this


[00:09:43,920 --> 00:09:47,070](https://youtu.be/kMghsCXZQ9Y?t=00h09m43s)

has been a collaborative effort but but


[00:09:45,540 --> 00:09:50,640](https://youtu.be/kMghsCXZQ9Y?t=00h09m45s)

Kevin you've been particularly involved


[00:09:47,070 --> 00:09:52,560](https://youtu.be/kMghsCXZQ9Y?t=00h09m47s)

in in every stage of it it's been open


[00:09:50,640 --> 00:09:54,780](https://youtu.be/kMghsCXZQ9Y?t=00h09m50s)

source almost from the beginning this


[00:09:52,560 --> 00:09:59,330](https://youtu.be/kMghsCXZQ9Y?t=00h09m52s)

isn't really the whole thing is very


[00:09:54,780 --> 00:09:59,330](https://youtu.be/kMghsCXZQ9Y?t=00h09m54s)

community driven is not being driven by


[00:10:00,200 --> 00:10:07,250](https://youtu.be/kMghsCXZQ9Y?t=00h10m00s)

I'm Microsoft top-down kind of effort


[00:10:03,900 --> 00:10:07,250](https://youtu.be/kMghsCXZQ9Y?t=00h10m03s)

this has really been very grassroots


[00:10:07,700 --> 00:10:14,190](https://youtu.be/kMghsCXZQ9Y?t=00h10m07s)

it's been fun - it's been fun to hack on


[00:10:10,920 --> 00:10:16,560](https://youtu.be/kMghsCXZQ9Y?t=00h10m10s)

and work on so I'm going to as much as I


[00:10:14,190 --> 00:10:20,400](https://youtu.be/kMghsCXZQ9Y?t=00h10m14s)

enjoy looking at your webcam I'm gonna


[00:10:16,560 --> 00:10:22,940](https://youtu.be/kMghsCXZQ9Y?t=00h10m16s)

flip you over here to your to your


[00:10:20,400 --> 00:10:22,940](https://youtu.be/kMghsCXZQ9Y?t=00h10m20s)

screen


[00:10:23,560 --> 00:10:30,980](https://youtu.be/kMghsCXZQ9Y?t=00h10m23s)

okay and we are up we've got our your


[00:10:27,260 --> 00:10:34,480](https://youtu.be/kMghsCXZQ9Y?t=00h10m27s)

visual studio and then a terminal on the


[00:10:30,980 --> 00:10:38,030](https://youtu.be/kMghsCXZQ9Y?t=00h10m30s)

right hand side the fancy little clock


[00:10:34,480 --> 00:10:41,030](https://youtu.be/kMghsCXZQ9Y?t=00h10m34s)

tiny itty bitty fought but fancy little


[00:10:38,030 --> 00:10:42,470](https://youtu.be/kMghsCXZQ9Y?t=00h10m38s)

clock it's pretty nasty um you know I


[00:10:41,030 --> 00:10:43,850](https://youtu.be/kMghsCXZQ9Y?t=00h10m41s)

don't have the new Windows terminal


[00:10:42,470 --> 00:10:46,880](https://youtu.be/kMghsCXZQ9Y?t=00h10m42s)

install this machine or else I could


[00:10:43,850 --> 00:10:51,440](https://youtu.be/kMghsCXZQ9Y?t=00h10m43s)

like zoom this thing with the scroll


[00:10:46,880 --> 00:10:53,720](https://youtu.be/kMghsCXZQ9Y?t=00h10m46s)

wheel but I can't um we can take a look


[00:10:51,440 --> 00:11:01,400](https://youtu.be/kMghsCXZQ9Y?t=00h10m51s)

at it and you do this in Visual Studio


[00:10:53,720 --> 00:11:06,700](https://youtu.be/kMghsCXZQ9Y?t=00h10m53s)

code which has a scaleable terminal so


[00:11:01,400 --> 00:11:06,700](https://youtu.be/kMghsCXZQ9Y?t=00h11m01s)

in the system command line github repo


[00:11:07,000 --> 00:11:12,920](https://youtu.be/kMghsCXZQ9Y?t=00h11m07s)

we have this samples directory and


[00:11:11,420 --> 00:11:15,950](https://youtu.be/kMghsCXZQ9Y?t=00h11m11s)

inside the sample of the threads there's


[00:11:12,920 --> 00:11:19,250](https://youtu.be/kMghsCXZQ9Y?t=00h11m12s)

a few things here one of them is this


[00:11:15,950 --> 00:11:20,480](https://youtu.be/kMghsCXZQ9Y?t=00h11m15s)

rendering playground and that's the


[00:11:19,250 --> 00:11:28,970](https://youtu.be/kMghsCXZQ9Y?t=00h11m19s)

thing that I was just showing the clock


[00:11:20,480 --> 00:11:33,160](https://youtu.be/kMghsCXZQ9Y?t=00h11m20s)

for so we can show that here - here grab


[00:11:28,970 --> 00:11:33,160](https://youtu.be/kMghsCXZQ9Y?t=00h11m28s)

this somewhat cryptic command line


[00:11:43,900 --> 00:11:52,930](https://youtu.be/kMghsCXZQ9Y?t=00h11m43s)

oh hey John yeah


[00:11:49,810 --> 00:11:55,150](https://youtu.be/kMghsCXZQ9Y?t=00h11m49s)

do you mind shifting your window up just


[00:11:52,930 --> 00:11:58,500](https://youtu.be/kMghsCXZQ9Y?t=00h11m52s)

a hair I think the very bottom of where


[00:11:55,150 --> 00:12:01,529](https://youtu.be/kMghsCXZQ9Y?t=00h11m55s)

you're typing is getting clipped


[00:11:58,500 --> 00:12:05,430](https://youtu.be/kMghsCXZQ9Y?t=00h11m58s)

it's not better that is perfect


[00:12:01,529 --> 00:12:08,170](https://youtu.be/kMghsCXZQ9Y?t=00h12m01s)

cool and the fonts a little bit more


[00:12:05,430 --> 00:12:20,230](https://youtu.be/kMghsCXZQ9Y?t=00h12m05s)

agreeable font is more agreeable thank


[00:12:08,170 --> 00:12:21,450](https://youtu.be/kMghsCXZQ9Y?t=00h12m08s)

you okay so what are we looking one of


[00:12:20,230 --> 00:12:23,500](https://youtu.be/kMghsCXZQ9Y?t=00h12m20s)

the there were a couple of things that


[00:12:21,450 --> 00:12:25,810](https://youtu.be/kMghsCXZQ9Y?t=00h12m21s)

we saw that were common things people


[00:12:23,500 --> 00:12:29,010](https://youtu.be/kMghsCXZQ9Y?t=00h12m23s)

like to do with with Richard console


[00:12:25,810 --> 00:12:32,380](https://youtu.be/kMghsCXZQ9Y?t=00h12m25s)

apps which are things like table layouts


[00:12:29,010 --> 00:12:33,610](https://youtu.be/kMghsCXZQ9Y?t=00h12m29s)

other kinds of you know multi-column


[00:12:32,380 --> 00:12:34,990](https://youtu.be/kMghsCXZQ9Y?t=00h12m32s)

layouts potentially they're different


[00:12:33,610 --> 00:12:37,510](https://youtu.be/kMghsCXZQ9Y?t=00h12m33s)

screen regions that kind of show


[00:12:34,990 --> 00:12:39,220](https://youtu.be/kMghsCXZQ9Y?t=00h12m34s)

different things and then within that


[00:12:37,510 --> 00:12:41,830](https://youtu.be/kMghsCXZQ9Y?t=00h12m37s)

sometimes things that are updating might


[00:12:39,220 --> 00:12:43,270](https://youtu.be/kMghsCXZQ9Y?t=00h12m39s)

be progress bars or it might be data


[00:12:41,830 --> 00:12:45,130](https://youtu.be/kMghsCXZQ9Y?t=00h12m41s)

that's updating within specific cells


[00:12:43,270 --> 00:12:46,779](https://youtu.be/kMghsCXZQ9Y?t=00h12m43s)

and those are and they're great


[00:12:45,130 --> 00:12:49,620](https://youtu.be/kMghsCXZQ9Y?t=00h12m45s)

experiences from a console perspective


[00:12:46,779 --> 00:12:54,820](https://youtu.be/kMghsCXZQ9Y?t=00h12m46s)

they're pretty hard to write given it


[00:12:49,620 --> 00:12:56,680](https://youtu.be/kMghsCXZQ9Y?t=00h12m49s)

you know the standard console api's are


[00:12:54,820 --> 00:12:59,770](https://youtu.be/kMghsCXZQ9Y?t=00h12m54s)

just standard in standard error standard


[00:12:56,680 --> 00:13:02,230](https://youtu.be/kMghsCXZQ9Y?t=00h12m56s)

out so you know you're just writing text


[00:12:59,770 --> 00:13:05,940](https://youtu.be/kMghsCXZQ9Y?t=00h12m59s)

in that text so sister doc console has


[00:13:02,230 --> 00:13:08,950](https://youtu.be/kMghsCXZQ9Y?t=00h13m02s)

month so yeah in a normal terminal right


[00:13:05,940 --> 00:13:10,240](https://youtu.be/kMghsCXZQ9Y?t=00h13m05s)

you you might have a virtual terminal


[00:13:08,950 --> 00:13:12,010](https://youtu.be/kMghsCXZQ9Y?t=00h13m08s)

that's sitting on top of those console


[00:13:10,240 --> 00:13:14,529](https://youtu.be/kMghsCXZQ9Y?t=00h13m10s)

screens and is able to render things in


[00:13:12,010 --> 00:13:20,170](https://youtu.be/kMghsCXZQ9Y?t=00h13m12s)

a way where you are able to see history


[00:13:14,529 --> 00:13:22,540](https://youtu.be/kMghsCXZQ9Y?t=00h13m14s)

right if I go when I'm gonna do the same


[00:13:20,170 --> 00:13:27,760](https://youtu.be/kMghsCXZQ9Y?t=00h13m20s)

thing over here just to give you an


[00:13:22,540 --> 00:13:30,300](https://youtu.be/kMghsCXZQ9Y?t=00h13m22s)

example if I think of it just as just as


[00:13:27,760 --> 00:13:30,300](https://youtu.be/kMghsCXZQ9Y?t=00h13m27s)

a file screen


[00:13:31,140 --> 00:13:34,010](https://youtu.be/kMghsCXZQ9Y?t=00h13m31s)

six works


[00:13:46,260 --> 00:13:48,800](https://youtu.be/kMghsCXZQ9Y?t=00h13m46s)

yep


[00:14:10,610 --> 00:14:13,089](https://youtu.be/kMghsCXZQ9Y?t=00h14m10s)

okay


[00:14:41,250 --> 00:14:48,410](https://youtu.be/kMghsCXZQ9Y?t=00h14m41s)

okay perfect I think we got that fix re


[00:14:44,670 --> 00:14:48,410](https://youtu.be/kMghsCXZQ9Y?t=00h14m44s)

doing doing this a little bit on the fly


[00:14:50,209 --> 00:14:55,530](https://youtu.be/kMghsCXZQ9Y?t=00h14m50s)

okay


[00:14:53,010 --> 00:14:57,030](https://youtu.be/kMghsCXZQ9Y?t=00h14m53s)

cool see you may want to go back to


[00:14:55,530 --> 00:14:59,310](https://youtu.be/kMghsCXZQ9Y?t=00h14m55s)

where you were kicking off this new


[00:14:57,030 --> 00:15:03,230](https://youtu.be/kMghsCXZQ9Y?t=00h14m57s)

terminal I think that bit got clipped


[00:14:59,310 --> 00:15:06,870](https://youtu.be/kMghsCXZQ9Y?t=00h14m59s)

out while I was shifting windows around


[00:15:03,230 --> 00:15:10,020](https://youtu.be/kMghsCXZQ9Y?t=00h15m03s)

sure but let me just explain what's


[00:15:06,870 --> 00:15:11,190](https://youtu.be/kMghsCXZQ9Y?t=00h15m06s)

going on on the screen right here and


[00:15:10,020 --> 00:15:16,440](https://youtu.be/kMghsCXZQ9Y?t=00h15m10s)

talked a little bit about Eternals


[00:15:11,190 --> 00:15:18,840](https://youtu.be/kMghsCXZQ9Y?t=00h15m11s)

versus consoles so system console


[00:15:16,440 --> 00:15:20,820](https://youtu.be/kMghsCXZQ9Y?t=00h15m16s)

completes two things that are usually


[00:15:18,840 --> 00:15:23,790](https://youtu.be/kMghsCXZQ9Y?t=00h15m18s)

separate contacts and command line


[00:15:20,820 --> 00:15:25,950](https://youtu.be/kMghsCXZQ9Y?t=00h15m20s)

applications being the console versus


[00:15:23,790 --> 00:15:28,260](https://youtu.be/kMghsCXZQ9Y?t=00h15m23s)

the temple so what are the difference


[00:15:25,950 --> 00:15:29,010](https://youtu.be/kMghsCXZQ9Y?t=00h15m25s)

between the two right and a lot of


[00:15:28,260 --> 00:15:32,730](https://youtu.be/kMghsCXZQ9Y?t=00h15m28s)

people use the terms interchangeably


[00:15:29,010 --> 00:15:34,560](https://youtu.be/kMghsCXZQ9Y?t=00h15m29s)

which can be analytic the console is


[00:15:32,730 --> 00:15:41,220](https://youtu.be/kMghsCXZQ9Y?t=00h15m32s)

just a set of strings right and this


[00:15:34,560 --> 00:15:43,590](https://youtu.be/kMghsCXZQ9Y?t=00h15m34s)

idea goes back to you know it


[00:15:41,220 --> 00:15:45,450](https://youtu.be/kMghsCXZQ9Y?t=00h15m41s)

effectively it goes back to actual


[00:15:43,590 --> 00:15:47,820](https://youtu.be/kMghsCXZQ9Y?t=00h15m43s)

hardware before it was a software


[00:15:45,450 --> 00:15:49,770](https://youtu.be/kMghsCXZQ9Y?t=00h15m45s)

abstraction right it was it was what is


[00:15:47,820 --> 00:15:52,110](https://youtu.be/kMghsCXZQ9Y?t=00h15m47s)

the input and output from a physical


[00:15:49,770 --> 00:15:53,640](https://youtu.be/kMghsCXZQ9Y?t=00h15m49s)

console and there was an additional


[00:15:52,110 --> 00:15:56,910](https://youtu.be/kMghsCXZQ9Y?t=00h15m52s)

output string which is in the standard


[00:15:53,640 --> 00:15:58,620](https://youtu.be/kMghsCXZQ9Y?t=00h15m53s)

error so you have standard alarmed and


[00:15:56,910 --> 00:16:00,750](https://youtu.be/kMghsCXZQ9Y?t=00h15m56s)

it's very important standard and these


[00:15:58,620 --> 00:16:01,950](https://youtu.be/kMghsCXZQ9Y?t=00h15m58s)

are typically at the you know going way


[00:16:00,750 --> 00:16:05,130](https://youtu.be/kMghsCXZQ9Y?t=00h16m00s)

back things were connected to actual


[00:16:01,950 --> 00:16:11,160](https://youtu.be/kMghsCXZQ9Y?t=00h16m01s)

physical devices and that physical


[00:16:05,130 --> 00:16:14,550](https://youtu.be/kMghsCXZQ9Y?t=00h16m05s)

device terminal and keyboard right so


[00:16:11,160 --> 00:16:15,870](https://youtu.be/kMghsCXZQ9Y?t=00h16m11s)

the console concept you have it when you


[00:16:14,550 --> 00:16:17,820](https://youtu.be/kMghsCXZQ9Y?t=00h16m14s)

have a terminal sitting on top of it the


[00:16:15,870 --> 00:16:20,610](https://youtu.be/kMghsCXZQ9Y?t=00h16m15s)

original terminal that sits on top of


[00:16:17,820 --> 00:16:23,220](https://youtu.be/kMghsCXZQ9Y?t=00h16m17s)

the console was a typewriter right or a


[00:16:20,610 --> 00:16:24,720](https://youtu.be/kMghsCXZQ9Y?t=00h16m20s)

printer and so the output for that


[00:16:23,220 --> 00:16:26,100](https://youtu.be/kMghsCXZQ9Y?t=00h16m23s)

printer that you know there's no way to


[00:16:24,720 --> 00:16:28,170](https://youtu.be/kMghsCXZQ9Y?t=00h16m24s)

go back and rewrite it it's just


[00:16:26,100 --> 00:16:30,330](https://youtu.be/kMghsCXZQ9Y?t=00h16m26s)

spooling out in front of you so what


[00:16:28,170 --> 00:16:32,420](https://youtu.be/kMghsCXZQ9Y?t=00h16m28s)

you're seeing on the right here is I'm


[00:16:30,330 --> 00:16:34,290](https://youtu.be/kMghsCXZQ9Y?t=00h16m30s)

thinking about the text stream and


[00:16:32,420 --> 00:16:36,810](https://youtu.be/kMghsCXZQ9Y?t=00h16m32s)

writing out the text stream in a way


[00:16:34,290 --> 00:16:39,030](https://youtu.be/kMghsCXZQ9Y?t=00h16m34s)

that's a pendulum and that's really the


[00:16:36,810 --> 00:16:40,560](https://youtu.be/kMghsCXZQ9Y?t=00h16m36s)

true console interface that you get when


[00:16:39,030 --> 00:16:43,340](https://youtu.be/kMghsCXZQ9Y?t=00h16m39s)

you spin up a process you connect to it


[00:16:40,560 --> 00:16:45,780](https://youtu.be/kMghsCXZQ9Y?t=00h16m40s)

it stand it in standard out and error


[00:16:43,340 --> 00:16:48,540](https://youtu.be/kMghsCXZQ9Y?t=00h16m43s)

it's up to you as the consumer of those


[00:16:45,780 --> 00:16:52,260](https://youtu.be/kMghsCXZQ9Y?t=00h16m45s)

strings to think about history if you


[00:16:48,540 --> 00:16:56,970](https://youtu.be/kMghsCXZQ9Y?t=00h16m48s)

want to so at some point the virtual


[00:16:52,260 --> 00:17:00,180](https://youtu.be/kMghsCXZQ9Y?t=00h16m52s)

terminal concept came along and it's a


[00:16:56,970 --> 00:17:01,710](https://youtu.be/kMghsCXZQ9Y?t=00h16m56s)

it's a fairly Universal concept in the


[00:17:00,180 --> 00:17:04,470](https://youtu.be/kMghsCXZQ9Y?t=00h17m00s)

form of virtual terminal


[00:17:01,710 --> 00:17:06,150](https://youtu.be/kMghsCXZQ9Y?t=00h17m01s)

is able to do things and what the


[00:17:04,470 --> 00:17:09,209](https://youtu.be/kMghsCXZQ9Y?t=00h17m04s)

windows constantly the window command


[00:17:06,150 --> 00:17:11,220](https://youtu.be/kMghsCXZQ9Y?t=00h17m06s)

line really combo study actually


[00:17:09,209 --> 00:17:13,620](https://youtu.be/kMghsCXZQ9Y?t=00h17m09s)

understand really is it ended in virtual


[00:17:11,220 --> 00:17:16,740](https://youtu.be/kMghsCXZQ9Y?t=00h17m11s)

terminal but it doesn't follow a common


[00:17:13,620 --> 00:17:19,260](https://youtu.be/kMghsCXZQ9Y?t=00h17m13s)

virtual terminal standard has been used


[00:17:16,740 --> 00:17:23,040](https://youtu.be/kMghsCXZQ9Y?t=00h17m16s)

in the x-term world i linux and mac for


[00:17:19,260 --> 00:17:25,140](https://youtu.be/kMghsCXZQ9Y?t=00h17m19s)

many many years and one of the things


[00:17:23,040 --> 00:17:26,910](https://youtu.be/kMghsCXZQ9Y?t=00h17m23s)

that we said here was i have a


[00:17:25,140 --> 00:17:28,860](https://youtu.be/kMghsCXZQ9Y?t=00h17m25s)

foundation for this approach we said


[00:17:26,910 --> 00:17:32,760](https://youtu.be/kMghsCXZQ9Y?t=00h17m26s)

let's actually separate the console in


[00:17:28,860 --> 00:17:34,170](https://youtu.be/kMghsCXZQ9Y?t=00h17m28s)

terminal abstraction from one more so on


[00:17:32,760 --> 00:17:36,390](https://youtu.be/kMghsCXZQ9Y?t=00h17m32s)

the right we're just writing output to a


[00:17:34,170 --> 00:17:39,900](https://youtu.be/kMghsCXZQ9Y?t=00h17m34s)

stream and we're just letting it render


[00:17:36,390 --> 00:17:41,580](https://youtu.be/kMghsCXZQ9Y?t=00h17m36s)

to it to the to the terminal right and


[00:17:39,900 --> 00:17:43,020](https://youtu.be/kMghsCXZQ9Y?t=00h17m39s)

the terminal has this you know it shows


[00:17:41,580 --> 00:17:44,400](https://youtu.be/kMghsCXZQ9Y?t=00h17m41s)

you all the past stuff that was in the


[00:17:43,020 --> 00:17:46,710](https://youtu.be/kMghsCXZQ9Y?t=00h17m43s)

stream depending on the settings


[00:17:44,400 --> 00:17:48,480](https://youtu.be/kMghsCXZQ9Y?t=00h17m44s)

goodnight in my terminal window i can


[00:17:46,710 --> 00:17:50,120](https://youtu.be/kMghsCXZQ9Y?t=00h17m46s)

scroll back a certain distance but maybe


[00:17:48,480 --> 00:17:53,340](https://youtu.be/kMghsCXZQ9Y?t=00h17m48s)

not forever


[00:17:50,120 --> 00:17:56,940](https://youtu.be/kMghsCXZQ9Y?t=00h17m50s)

all right determine or the console has a


[00:17:53,340 --> 00:17:58,440](https://youtu.be/kMghsCXZQ9Y?t=00h17m53s)

fixed buffer yep yeah and so that's


[00:17:56,940 --> 00:17:59,700](https://youtu.be/kMghsCXZQ9Y?t=00h17m56s)

really that's an implementation but I


[00:17:58,440 --> 00:18:02,040](https://youtu.be/kMghsCXZQ9Y?t=00h17m58s)

can go and I can adjust the buffer size


[00:17:59,700 --> 00:18:04,080](https://youtu.be/kMghsCXZQ9Y?t=00h17m59s)

right so that's just that that's just an


[00:18:02,040 --> 00:18:06,059](https://youtu.be/kMghsCXZQ9Y?t=00h18m02s)

implementation detail of my virtual


[00:18:04,080 --> 00:18:09,000](https://youtu.be/kMghsCXZQ9Y?t=00h18m04s)

terminal application it's not intrinsic


[00:18:06,059 --> 00:18:10,800](https://youtu.be/kMghsCXZQ9Y?t=00h18m06s)

to the console itself right


[00:18:09,000 --> 00:18:12,270](https://youtu.be/kMghsCXZQ9Y?t=00h18m09s)

it's not intrinsic to my the application


[00:18:10,800 --> 00:18:14,309](https://youtu.be/kMghsCXZQ9Y?t=00h18m10s)

that that I'm talking to you right now


[00:18:12,270 --> 00:18:20,880](https://youtu.be/kMghsCXZQ9Y?t=00h18m12s)

is standard out I'm seeing being


[00:18:14,309 --> 00:18:22,530](https://youtu.be/kMghsCXZQ9Y?t=00h18m14s)

rendered all right okay so on the Left


[00:18:20,880 --> 00:18:24,120](https://youtu.be/kMghsCXZQ9Y?t=00h18m20s)

we're doing something a little bit


[00:18:22,530 --> 00:18:25,830](https://youtu.be/kMghsCXZQ9Y?t=00h18m22s)

different right we're over writing


[00:18:24,120 --> 00:18:30,480](https://youtu.be/kMghsCXZQ9Y?t=00h18m24s)

sections of the screen over and over


[00:18:25,830 --> 00:18:34,190](https://youtu.be/kMghsCXZQ9Y?t=00h18m25s)

again to produce more of an animation in


[00:18:30,480 --> 00:18:39,390](https://youtu.be/kMghsCXZQ9Y?t=00h18m30s)

place rather than a continuously rolling


[00:18:34,190 --> 00:18:43,080](https://youtu.be/kMghsCXZQ9Y?t=00h18m34s)

output stream but the way that we're


[00:18:39,390 --> 00:18:44,550](https://youtu.be/kMghsCXZQ9Y?t=00h18m39s)

doing that is actually to produce a


[00:18:43,080 --> 00:18:46,290](https://youtu.be/kMghsCXZQ9Y?t=00h18m43s)

continuously rolling output stream


[00:18:44,550 --> 00:18:48,900](https://youtu.be/kMghsCXZQ9Y?t=00h18m44s)

because remember yes that's what the


[00:18:46,290 --> 00:18:53,250](https://youtu.be/kMghsCXZQ9Y?t=00h18m46s)

console is and just to just to have an


[00:18:48,900 --> 00:18:56,100](https://youtu.be/kMghsCXZQ9Y?t=00h18m48s)

example let's go and look at the console


[00:18:53,250 --> 00:19:00,120](https://youtu.be/kMghsCXZQ9Y?t=00h18m53s)

abstraction so this is in system command


[00:18:56,100 --> 00:19:01,140](https://youtu.be/kMghsCXZQ9Y?t=00h18m56s)

line and we have this eye console and it


[00:19:00,120 --> 00:19:03,240](https://youtu.be/kMghsCXZQ9Y?t=00h19m00s)

has standard out standard error and


[00:19:01,140 --> 00:19:05,250](https://youtu.be/kMghsCXZQ9Y?t=00h19m01s)

standard it it doesn't have things that


[00:19:03,240 --> 00:19:06,800](https://youtu.be/kMghsCXZQ9Y?t=00h19m03s)

let you you know do terminal stuff like


[00:19:05,250 --> 00:19:09,720](https://youtu.be/kMghsCXZQ9Y?t=00h19m05s)

reposition the cursor for making


[00:19:06,800 --> 00:19:11,070](https://youtu.be/kMghsCXZQ9Y?t=00h19m06s)

different colors and think of it that


[00:19:09,720 --> 00:19:12,179](https://youtu.be/kMghsCXZQ9Y?t=00h19m09s)

that's not part of this abstraction they


[00:19:11,070 --> 00:19:14,900](https://youtu.be/kMghsCXZQ9Y?t=00h19m11s)

have a different abstraction for that


[00:19:12,179 --> 00:19:14,900](https://youtu.be/kMghsCXZQ9Y?t=00h19m12s)

called I terminal


[00:19:15,360 --> 00:19:19,000](https://youtu.be/kMghsCXZQ9Y?t=00h19m15s)

and this is what I terminal looks like


[00:19:17,440 --> 00:19:21,640](https://youtu.be/kMghsCXZQ9Y?t=00h19m17s)

right now but it's very much a work in


[00:19:19,000 --> 00:19:24,190](https://youtu.be/kMghsCXZQ9Y?t=00h19m19s)

progress right so you can see that like


[00:19:21,640 --> 00:19:26,020](https://youtu.be/kMghsCXZQ9Y?t=00h19m21s)

both of these things are present in


[00:19:24,190 --> 00:19:28,450](https://youtu.be/kMghsCXZQ9Y?t=00h19m24s)

system console but they're conflated


[00:19:26,020 --> 00:19:30,010](https://youtu.be/kMghsCXZQ9Y?t=00h19m26s)

insect about if I if I go to system got


[00:19:28,450 --> 00:19:31,270](https://youtu.be/kMghsCXZQ9Y?t=00h19m28s)

console and I redirect my output to a


[00:19:30,010 --> 00:19:33,790](https://youtu.be/kMghsCXZQ9Y?t=00h19m30s)

file and then I try to set the


[00:19:31,270 --> 00:19:35,230](https://youtu.be/kMghsCXZQ9Y?t=00h19m31s)

foreground color I get an exception all


[00:19:33,790 --> 00:19:36,580](https://youtu.be/kMghsCXZQ9Y?t=00h19m33s)

right so that kind of tells you there's


[00:19:35,230 --> 00:19:38,440](https://youtu.be/kMghsCXZQ9Y?t=00h19m35s)

too many different responsibilities in


[00:19:36,580 --> 00:19:41,110](https://youtu.be/kMghsCXZQ9Y?t=00h19m36s)

system not console interface plus its


[00:19:38,440 --> 00:19:42,460](https://youtu.be/kMghsCXZQ9Y?t=00h19m38s)

global so you have state sharing


[00:19:41,110 --> 00:19:43,570](https://youtu.be/kMghsCXZQ9Y?t=00h19m41s)

problems which makes testing and if


[00:19:42,460 --> 00:19:44,650](https://youtu.be/kMghsCXZQ9Y?t=00h19m42s)

you've ever tried to write tests the


[00:19:43,570 --> 00:19:47,080](https://youtu.be/kMghsCXZQ9Y?t=00h19m43s)

things that need to writing on system


[00:19:44,650 --> 00:19:48,640](https://youtu.be/kMghsCXZQ9Y?t=00h19m44s)

console you probably quickly found that


[00:19:47,080 --> 00:19:49,900](https://youtu.be/kMghsCXZQ9Y?t=00h19m47s)

they couldn't be running parallel and if


[00:19:48,640 --> 00:19:53,220](https://youtu.be/kMghsCXZQ9Y?t=00h19m48s)

one of them fail and didn't clean up


[00:19:49,900 --> 00:19:53,220](https://youtu.be/kMghsCXZQ9Y?t=00h19m49s)

correctly all the others would say hello


[00:19:55,500 --> 00:19:59,680](https://youtu.be/kMghsCXZQ9Y?t=00h19m55s)

so yeah these abstractions here we're


[00:19:58,180 --> 00:20:00,880](https://youtu.be/kMghsCXZQ9Y?t=00h19m58s)

kind of in a work a work in progress and


[00:19:59,680 --> 00:20:02,050](https://youtu.be/kMghsCXZQ9Y?t=00h19m59s)

I think we'll probably end up in a


[00:20:00,880 --> 00:20:03,610](https://youtu.be/kMghsCXZQ9Y?t=00h20m00s)

different place for the screen readers


[00:20:02,050 --> 00:20:05,920](https://youtu.be/kMghsCXZQ9Y?t=00h20m02s)

and stream writers compared to what we


[00:20:03,610 --> 00:20:07,810](https://youtu.be/kMghsCXZQ9Y?t=00h20m03s)

have right now where we're using extreme


[00:20:05,920 --> 00:20:10,420](https://youtu.be/kMghsCXZQ9Y?t=00h20m05s)

abstractions we didn't go with sense of


[00:20:07,810 --> 00:20:11,860](https://youtu.be/kMghsCXZQ9Y?t=00h20m07s)

the i/o duck stream for various reasons


[00:20:10,420 --> 00:20:14,200](https://youtu.be/kMghsCXZQ9Y?t=00h20m10s)

one of them is that you can send it to


[00:20:11,860 --> 00:20:15,910](https://youtu.be/kMghsCXZQ9Y?t=00h20m11s)

objects you can just write any object


[00:20:14,200 --> 00:20:17,620](https://youtu.be/kMghsCXZQ9Y?t=00h20m14s)

you have all these interfaces overloads


[00:20:15,910 --> 00:20:19,660](https://youtu.be/kMghsCXZQ9Y?t=00h20m15s)

for write that let you pass in any


[00:20:17,620 --> 00:20:20,890](https://youtu.be/kMghsCXZQ9Y?t=00h20m17s)

object to it right which is up again


[00:20:19,660 --> 00:20:23,800](https://youtu.be/kMghsCXZQ9Y?t=00h20m19s)

it's a little bit of a not the right


[00:20:20,890 --> 00:20:25,120](https://youtu.be/kMghsCXZQ9Y?t=00h20m20s)

abstraction but as you'll see what


[00:20:23,800 --> 00:20:26,140](https://youtu.be/kMghsCXZQ9Y?t=00h20m23s)

system command-line rendering we


[00:20:25,120 --> 00:20:28,600](https://youtu.be/kMghsCXZQ9Y?t=00h20m25s)

actually do want to be able to render


[00:20:26,140 --> 00:20:31,630](https://youtu.be/kMghsCXZQ9Y?t=00h20m26s)

objects but we want to control the way


[00:20:28,600 --> 00:20:33,160](https://youtu.be/kMghsCXZQ9Y?t=00h20m28s)

they get written to output so it's not


[00:20:31,630 --> 00:20:34,690](https://youtu.be/kMghsCXZQ9Y?t=00h20m31s)

that interfaces problem to think about


[00:20:33,160 --> 00:20:37,510](https://youtu.be/kMghsCXZQ9Y?t=00h20m33s)

that so this is some of the reasons why


[00:20:34,690 --> 00:20:42,010](https://youtu.be/kMghsCXZQ9Y?t=00h20m34s)

we define a new console interface and an


[00:20:37,510 --> 00:20:44,980](https://youtu.be/kMghsCXZQ9Y?t=00h20m37s)

eternal interface so hopefully I don't


[00:20:42,010 --> 00:20:46,420](https://youtu.be/kMghsCXZQ9Y?t=00h20m42s)

that all make three little time makes


[00:20:44,980 --> 00:20:50,490](https://youtu.be/kMghsCXZQ9Y?t=00h20m44s)

sense to me but I've also been in the


[00:20:46,420 --> 00:20:50,490](https://youtu.be/kMghsCXZQ9Y?t=00h20m46s)

project working on it so yeah


[00:20:51,640 --> 00:21:13,280](https://youtu.be/kMghsCXZQ9Y?t=00h20m51s)

so let me show a different thing here


[00:20:57,790 --> 00:21:16,660](https://youtu.be/kMghsCXZQ9Y?t=00h20m57s)

let's do this work because I think such


[00:21:13,280 --> 00:21:16,660](https://youtu.be/kMghsCXZQ9Y?t=00h21m13s)

a switch sorry


[00:21:17,420 --> 00:21:26,400](https://youtu.be/kMghsCXZQ9Y?t=00h21m17s)

yeah what about wha diagonal lines


[00:21:23,760 --> 00:21:32,970](https://youtu.be/kMghsCXZQ9Y?t=00h21m23s)

gibberish I love it yeah what the heck


[00:21:26,400 --> 00:21:39,320](https://youtu.be/kMghsCXZQ9Y?t=00h21m26s)

is going on there so vt100 control


[00:21:32,970 --> 00:21:39,320](https://youtu.be/kMghsCXZQ9Y?t=00h21m32s)

characters just off yeah exactly


[00:21:41,180 --> 00:21:51,960](https://youtu.be/kMghsCXZQ9Y?t=00h21m41s)

really feels like something that should


[00:21:42,930 --> 00:21:53,090](https://youtu.be/kMghsCXZQ9Y?t=00h21m42s)

be turned into a screen saver yeah so so


[00:21:51,960 --> 00:21:56,970](https://youtu.be/kMghsCXZQ9Y?t=00h21m51s)

what you're seeing there that you know


[00:21:53,090 --> 00:21:58,830](https://youtu.be/kMghsCXZQ9Y?t=00h21m53s)

even when I'm using vt100 output rather


[00:21:56,970 --> 00:21:59,820](https://youtu.be/kMghsCXZQ9Y?t=00h21m56s)

than just plain text output right before


[00:21:58,830 --> 00:22:00,840](https://youtu.be/kMghsCXZQ9Y?t=00h21m58s)

it was just plain text output when


[00:21:59,820 --> 00:22:02,640](https://youtu.be/kMghsCXZQ9Y?t=00h21m59s)

you're seeing the time being upended


[00:22:00,840 --> 00:22:03,990](https://youtu.be/kMghsCXZQ9Y?t=00h22m00s)

again and again and again that's what


[00:22:02,640 --> 00:22:05,340](https://youtu.be/kMghsCXZQ9Y?t=00h22m02s)

you're seeing here - except it's also


[00:22:03,990 --> 00:22:06,510](https://youtu.be/kMghsCXZQ9Y?t=00h22m03s)

got all these control characters in the


[00:22:05,340 --> 00:22:13,530](https://youtu.be/kMghsCXZQ9Y?t=00h22m05s)

limit so if we scroll back through a


[00:22:06,510 --> 00:22:14,730](https://youtu.be/kMghsCXZQ9Y?t=00h22m06s)

little bit of time here but it's


[00:22:13,530 --> 00:22:16,050](https://youtu.be/kMghsCXZQ9Y?t=00h22m13s)

embedded in all these control characters


[00:22:14,730 --> 00:22:18,240](https://youtu.be/kMghsCXZQ9Y?t=00h22m14s)

what those control characters are doing


[00:22:16,050 --> 00:22:22,860](https://youtu.be/kMghsCXZQ9Y?t=00h22m16s)

is updating sections of the screen so


[00:22:18,240 --> 00:22:24,450](https://youtu.be/kMghsCXZQ9Y?t=00h22m18s)

that you get that effect that you saw in


[00:22:22,860 --> 00:22:27,510](https://youtu.be/kMghsCXZQ9Y?t=00h22m22s)

Digital Studio codes terminal window


[00:22:24,450 --> 00:22:30,450](https://youtu.be/kMghsCXZQ9Y?t=00h22m24s)

here right that is literally the same


[00:22:27,510 --> 00:22:34,200](https://youtu.be/kMghsCXZQ9Y?t=00h22m27s)

output except on the right we've set the


[00:22:30,450 --> 00:22:37,020](https://youtu.be/kMghsCXZQ9Y?t=00h22m30s)

terminal to virtual terminal mode using


[00:22:34,200 --> 00:22:37,620](https://youtu.be/kMghsCXZQ9Y?t=00h22m34s)

those meant this a win32 api that i


[00:22:37,020 --> 00:22:39,810](https://youtu.be/kMghsCXZQ9Y?t=00h22m37s)

mentioned before


[00:22:37,620 --> 00:22:41,880](https://youtu.be/kMghsCXZQ9Y?t=00h22m37s)

and that will also detect terminal modes


[00:22:39,810 --> 00:22:43,710](https://youtu.be/kMghsCXZQ9Y?t=00h22m39s)

correctly on Linux and Mac because vt100


[00:22:41,880 --> 00:22:49,220](https://youtu.be/kMghsCXZQ9Y?t=00h22m41s)

is just supported automatically on


[00:22:43,710 --> 00:22:53,160](https://youtu.be/kMghsCXZQ9Y?t=00h22m43s)

externals yeah and you get this instead


[00:22:49,220 --> 00:22:55,020](https://youtu.be/kMghsCXZQ9Y?t=00h22m49s)

so this is it's a what we t100 is doing


[00:22:53,160 --> 00:22:57,960](https://youtu.be/kMghsCXZQ9Y?t=00h22m53s)

is it's sending signals over the


[00:22:55,020 --> 00:22:59,430](https://youtu.be/kMghsCXZQ9Y?t=00h22m55s)

standard output or standard error right


[00:22:57,960 --> 00:23:00,660](https://youtu.be/kMghsCXZQ9Y?t=00h22m57s)

and can be used on standard n as well


[00:22:59,430 --> 00:23:03,000](https://youtu.be/kMghsCXZQ9Y?t=00h22m59s)

and enabled separate them centered and


[00:23:00,660 --> 00:23:04,740](https://youtu.be/kMghsCXZQ9Y?t=00h23m00s)

it's sending signals that say hey move


[00:23:03,000 --> 00:23:05,970](https://youtu.be/kMghsCXZQ9Y?t=00h23m03s)

the cursor hey set this color all these


[00:23:04,740 --> 00:23:08,070](https://youtu.be/kMghsCXZQ9Y?t=00h23m04s)

kinds of things are encoded into the


[00:23:05,970 --> 00:23:09,210](https://youtu.be/kMghsCXZQ9Y?t=00h23m05s)

vt100 but it's just still just the text


[00:23:08,070 --> 00:23:11,190](https://youtu.be/kMghsCXZQ9Y?t=00h23m08s)

extreme so you need to have a virtual


[00:23:09,210 --> 00:23:13,380](https://youtu.be/kMghsCXZQ9Y?t=00h23m09s)

terminal that knows how to render this


[00:23:11,190 --> 00:23:15,240](https://youtu.be/kMghsCXZQ9Y?t=00h23m11s)

dock correctly the upcoming Windows


[00:23:13,380 --> 00:23:18,120](https://youtu.be/kMghsCXZQ9Y?t=00h23m13s)

terminal does that automatically as well


[00:23:15,240 --> 00:23:20,340](https://youtu.be/kMghsCXZQ9Y?t=00h23m15s)

but the future is leaking 100 even


[00:23:18,120 --> 00:23:22,620](https://youtu.be/kMghsCXZQ9Y?t=00h23m18s)

though it's a technology than 40 years


[00:23:20,340 --> 00:23:25,010](https://youtu.be/kMghsCXZQ9Y?t=00h23m20s)

old right so real quick there's a


[00:23:22,620 --> 00:23:27,330](https://youtu.be/kMghsCXZQ9Y?t=00h23m22s)

question here


[00:23:25,010 --> 00:23:29,330](https://youtu.be/kMghsCXZQ9Y?t=00h23m25s)

Xavier I thought you said last time that


[00:23:27,330 --> 00:23:33,160](https://youtu.be/kMghsCXZQ9Y?t=00h23m27s)

can only be one directive but you used


[00:23:29,330 --> 00:23:35,470](https://youtu.be/kMghsCXZQ9Y?t=00h23m29s)

this time so you want to go back to that


[00:23:33,160 --> 00:23:39,650](https://youtu.be/kMghsCXZQ9Y?t=00h23m33s)

invocation and look at that real quick


[00:23:35,470 --> 00:23:42,740](https://youtu.be/kMghsCXZQ9Y?t=00h23m35s)

yeah yeah so I'll do that here little


[00:23:39,650 --> 00:23:46,040](https://youtu.be/kMghsCXZQ9Y?t=00h23m39s)

easier to read so here


[00:23:42,740 --> 00:23:50,780](https://youtu.be/kMghsCXZQ9Y?t=00h23m42s)

here's what I did to enable the clock in


[00:23:46,040 --> 00:23:52,310](https://youtu.be/kMghsCXZQ9Y?t=00h23m46s)

in place rerender shifted all the way to


[00:23:50,780 --> 00:23:54,710](https://youtu.be/kMghsCXZQ9Y?t=00h23m50s)

the left room my video sits in the


[00:23:52,310 --> 00:23:58,340](https://youtu.be/kMghsCXZQ9Y?t=00h23m52s)

bottom right corner so anything in the


[00:23:54,710 --> 00:23:59,540](https://youtu.be/kMghsCXZQ9Y?t=00h23m54s)

bottom right gets yeah I've got that


[00:23:58,340 --> 00:24:02,030](https://youtu.be/kMghsCXZQ9Y?t=00h23m58s)

I've got the stream on my other machine


[00:23:59,540 --> 00:24:05,410](https://youtu.be/kMghsCXZQ9Y?t=00h23m59s)

over here so perfect I can I can kind of


[00:24:02,030 --> 00:24:05,410](https://youtu.be/kMghsCXZQ9Y?t=00h24m02s)

see it in position accordingly


[00:24:05,590 --> 00:24:12,710](https://youtu.be/kMghsCXZQ9Y?t=00h24m05s)

technology okay


[00:24:08,210 --> 00:24:14,000](https://youtu.be/kMghsCXZQ9Y?t=00h24m08s)

so save your questions you know I


[00:24:12,710 --> 00:24:18,830](https://youtu.be/kMghsCXZQ9Y?t=00h24m12s)

you thought that you can only use one


[00:24:14,000 --> 00:24:20,300](https://youtu.be/kMghsCXZQ9Y?t=00h24m14s)

directive that's not true you can only


[00:24:18,830 --> 00:24:22,010](https://youtu.be/kMghsCXZQ9Y?t=00h24m18s)

have directives at the beginning of the


[00:24:20,300 --> 00:24:24,160](https://youtu.be/kMghsCXZQ9Y?t=00h24m20s)

command line so right this is not neck


[00:24:22,010 --> 00:24:27,530](https://youtu.be/kMghsCXZQ9Y?t=00h24m22s)

run this little thing here says


[00:24:24,160 --> 00:24:29,030](https://youtu.be/kMghsCXZQ9Y?t=00h24m24s)

everything after it should be sent to my


[00:24:27,530 --> 00:24:30,890](https://youtu.be/kMghsCXZQ9Y?t=00h24m27s)

program so all these are you know these


[00:24:29,030 --> 00:24:34,210](https://youtu.be/kMghsCXZQ9Y?t=00h24m29s)

are all of the arguments that are being


[00:24:30,890 --> 00:24:36,590](https://youtu.be/kMghsCXZQ9Y?t=00h24m30s)

sent to the rendering playground program


[00:24:34,210 --> 00:24:39,110](https://youtu.be/kMghsCXZQ9Y?t=00h24m34s)

there could be as many directives as you


[00:24:36,590 --> 00:24:40,280](https://youtu.be/kMghsCXZQ9Y?t=00h24m36s)

want it's just that once you stop having


[00:24:39,110 --> 00:24:42,890](https://youtu.be/kMghsCXZQ9Y?t=00h24m39s)

directives at the front of the command


[00:24:40,280 --> 00:24:44,360](https://youtu.be/kMghsCXZQ9Y?t=00h24m40s)

line everything else becomes the options


[00:24:42,890 --> 00:24:46,490](https://youtu.be/kMghsCXZQ9Y?t=00h24m42s)

that are defined inside of your program


[00:24:44,360 --> 00:24:49,100](https://youtu.be/kMghsCXZQ9Y?t=00h24m44s)

itself so we had talked about dragon


[00:24:46,490 --> 00:24:54,080](https://youtu.be/kMghsCXZQ9Y?t=00h24m46s)

fruit before the rendering playground


[00:24:49,100 --> 00:24:57,350](https://youtu.be/kMghsCXZQ9Y?t=00h24m49s)

program CS is a dragon fruit program


[00:24:54,080 --> 00:25:00,320](https://youtu.be/kMghsCXZQ9Y?t=00h24m54s)

right so it's rather than the string


[00:24:57,350 --> 00:25:03,680](https://youtu.be/kMghsCXZQ9Y?t=00h24m57s)

args for main it has a bunch of strongly


[00:25:00,320 --> 00:25:06,500](https://youtu.be/kMghsCXZQ9Y?t=00h25m00s)

type named specific arguments so this is


[00:25:03,680 --> 00:25:08,330](https://youtu.be/kMghsCXZQ9Y?t=00h25m03s)

the thing that defines the input to the


[00:25:06,500 --> 00:25:10,340](https://youtu.be/kMghsCXZQ9Y?t=00h25m06s)

program directives are always orthogonal


[00:25:08,330 --> 00:25:11,840](https://youtu.be/kMghsCXZQ9Y?t=00h25m08s)

to this so directives are things you


[00:25:10,340 --> 00:25:13,010](https://youtu.be/kMghsCXZQ9Y?t=00h25m10s)

know tends to drive cross-cutting


[00:25:11,840 --> 00:25:14,150](https://youtu.be/kMghsCXZQ9Y?t=00h25m11s)

functionality and a lot of its


[00:25:13,010 --> 00:25:17,630](https://youtu.be/kMghsCXZQ9Y?t=00h25m13s)

functionality that's just built into


[00:25:14,150 --> 00:25:19,760](https://youtu.be/kMghsCXZQ9Y?t=00h25m14s)

system command line so what these two


[00:25:17,630 --> 00:25:22,250](https://youtu.be/kMghsCXZQ9Y?t=00h25m17s)

are doing ultimately the story is that


[00:25:19,760 --> 00:25:24,500](https://youtu.be/kMghsCXZQ9Y?t=00h25m19s)

you want to be able to specify them but


[00:25:22,250 --> 00:25:26,210](https://youtu.be/kMghsCXZQ9Y?t=00h25m22s)

in most cases you want them to just have


[00:25:24,500 --> 00:25:27,560](https://youtu.be/kMghsCXZQ9Y?t=00h25m24s)

reasonable defaults which we call you


[00:25:26,210 --> 00:25:29,090](https://youtu.be/kMghsCXZQ9Y?t=00h25m26s)

know detective basically word we're


[00:25:27,560 --> 00:25:31,220](https://youtu.be/kMghsCXZQ9Y?t=00h25m27s)

talking about detecting terminal


[00:25:29,090 --> 00:25:32,720](https://youtu.be/kMghsCXZQ9Y?t=00h25m29s)

capabilities and just doing the right


[00:25:31,220 --> 00:25:35,150](https://youtu.be/kMghsCXZQ9Y?t=00h25m31s)

thing so that on Windows will say oh can


[00:25:32,720 --> 00:25:37,460](https://youtu.be/kMghsCXZQ9Y?t=00h25m32s)

we elevate it to vt100 yes then we can


[00:25:35,150 --> 00:25:39,860](https://youtu.be/kMghsCXZQ9Y?t=00h25m35s)

render in vt100 mode if not we're on


[00:25:37,460 --> 00:25:41,330](https://youtu.be/kMghsCXZQ9Y?t=00h25m37s)

against a system console API is which do


[00:25:39,860 --> 00:25:43,159](https://youtu.be/kMghsCXZQ9Y?t=00h25m39s)

work for a lot of terminal type


[00:25:41,330 --> 00:25:45,080](https://youtu.be/kMghsCXZQ9Y?t=00h25m41s)

they're not remote Abel in the same way


[00:25:43,159 --> 00:25:48,080](https://youtu.be/kMghsCXZQ9Y?t=00h25m43s)

that bt100 is right if you send a bt100


[00:25:45,080 --> 00:25:49,639](https://youtu.be/kMghsCXZQ9Y?t=00h25m45s)

stream across an SSH connection


[00:25:48,080 --> 00:25:50,929](https://youtu.be/kMghsCXZQ9Y?t=00h25m48s)

it still renders correctly on the remote


[00:25:49,639 --> 00:25:52,549](https://youtu.be/kMghsCXZQ9Y?t=00h25m49s)

terminal which is one of the reasons why


[00:25:50,929 --> 00:25:54,739](https://youtu.be/kMghsCXZQ9Y?t=00h25m50s)

it's really nice system that console is


[00:25:52,549 --> 00:25:56,119](https://youtu.be/kMghsCXZQ9Y?t=00h25m52s)

not very good at that kind of thing or


[00:25:54,739 --> 00:25:58,460](https://youtu.be/kMghsCXZQ9Y?t=00h25m54s)

if you are starting up a child process


[00:25:56,119 --> 00:26:00,049](https://youtu.be/kMghsCXZQ9Y?t=00h25m56s)

and your parent process is redirecting


[00:25:58,460 --> 00:26:03,110](https://youtu.be/kMghsCXZQ9Y?t=00h25m58s)

output and you want the child process to


[00:26:00,049 --> 00:26:05,989](https://youtu.be/kMghsCXZQ9Y?t=00h26m00s)

not emit scuffling bt100 into your log


[00:26:03,110 --> 00:26:07,519](https://youtu.be/kMghsCXZQ9Y?t=00h26m03s)

file right then the directives become


[00:26:05,989 --> 00:26:09,200](https://youtu.be/kMghsCXZQ9Y?t=00h26m05s)

handy for telling it here here's the


[00:26:07,519 --> 00:26:10,700](https://youtu.be/kMghsCXZQ9Y?t=00h26m07s)

rendering mode I want so that's kind of


[00:26:09,200 --> 00:26:12,440](https://youtu.be/kMghsCXZQ9Y?t=00h26m09s)

what you're seeing here is like the


[00:26:10,700 --> 00:26:15,379](https://youtu.be/kMghsCXZQ9Y?t=00h26m10s)

ability to specify but hopefully also


[00:26:12,440 --> 00:26:16,489](https://youtu.be/kMghsCXZQ9Y?t=00h26m12s)

that you don't need to if you don't if


[00:26:15,379 --> 00:26:21,950](https://youtu.be/kMghsCXZQ9Y?t=00h26m15s)

you're not in one of these kind of


[00:26:16,489 --> 00:26:23,929](https://youtu.be/kMghsCXZQ9Y?t=00h26m16s)

hybrid scenarios so what this directive


[00:26:21,950 --> 00:26:26,119](https://youtu.be/kMghsCXZQ9Y?t=00h26m21s)

is enabling VT but if you don't specify


[00:26:23,929 --> 00:26:27,950](https://youtu.be/kMghsCXZQ9Y?t=00h26m23s)

it we try to detect it what this one is


[00:26:26,119 --> 00:26:29,090](https://youtu.be/kMghsCXZQ9Y?t=00h26m26s)

here is what's the output mode there are


[00:26:27,950 --> 00:26:30,859](https://youtu.be/kMghsCXZQ9Y?t=00h26m27s)

three different output modes that we


[00:26:29,090 --> 00:26:32,899](https://youtu.be/kMghsCXZQ9Y?t=00h26m29s)

support one is pantsy which is the thing


[00:26:30,859 --> 00:26:34,789](https://youtu.be/kMghsCXZQ9Y?t=00h26m30s)

you see on the right with all the you


[00:26:32,899 --> 00:26:38,809](https://youtu.be/kMghsCXZQ9Y?t=00h26m32s)

know the BT 100 codes are also known as


[00:26:34,789 --> 00:26:40,700](https://youtu.be/kMghsCXZQ9Y?t=00h26m34s)

ansi escape sequences non ANSI which


[00:26:38,809 --> 00:26:42,580](https://youtu.be/kMghsCXZQ9Y?t=00h26m38s)

means render as if you are writing to


[00:26:40,700 --> 00:26:45,739](https://youtu.be/kMghsCXZQ9Y?t=00h26m40s)

system console which basically means


[00:26:42,580 --> 00:26:47,059](https://youtu.be/kMghsCXZQ9Y?t=00h26m42s)

plain text but we also will try to


[00:26:45,739 --> 00:26:50,090](https://youtu.be/kMghsCXZQ9Y?t=00h26m45s)

position the cursor using system gun


[00:26:47,059 --> 00:26:54,350](https://youtu.be/kMghsCXZQ9Y?t=00h26m47s)

it's just a console API and the third


[00:26:50,090 --> 00:26:56,509](https://youtu.be/kMghsCXZQ9Y?t=00h26m50s)

option is file which no attempt is made


[00:26:54,350 --> 00:26:58,609](https://youtu.be/kMghsCXZQ9Y?t=00h26m54s)

to reposition cursors ever we said okay


[00:26:56,509 --> 00:27:00,289](https://youtu.be/kMghsCXZQ9Y?t=00h26m56s)

we're just writing to a file but you can


[00:26:58,609 --> 00:27:01,850](https://youtu.be/kMghsCXZQ9Y?t=00h26m58s)

force me T 100 to the file for example


[00:27:00,289 --> 00:27:03,019](https://youtu.be/kMghsCXZQ9Y?t=00h27m00s)

so the be using these two directives


[00:27:01,850 --> 00:27:08,989](https://youtu.be/kMghsCXZQ9Y?t=00h27m01s)

together you can have various


[00:27:03,019 --> 00:27:10,549](https://youtu.be/kMghsCXZQ9Y?t=00h27m03s)

combinations about them so given all


[00:27:08,989 --> 00:27:12,109](https://youtu.be/kMghsCXZQ9Y?t=00h27m08s)

that stuff what we wanted to then do is


[00:27:10,549 --> 00:27:15,049](https://youtu.be/kMghsCXZQ9Y?t=00h27m10s)

say oK we've got the capabilities that


[00:27:12,109 --> 00:27:17,059](https://youtu.be/kMghsCXZQ9Y?t=00h27m12s)

take a single block of code and render


[00:27:15,049 --> 00:27:18,259](https://youtu.be/kMghsCXZQ9Y?t=00h27m15s)

it in all these different ways so what


[00:27:17,059 --> 00:27:20,840](https://youtu.be/kMghsCXZQ9Y?t=00h27m17s)

does that code look like right what's


[00:27:18,259 --> 00:27:23,659](https://youtu.be/kMghsCXZQ9Y?t=00h27m18s)

the API that that we could write we


[00:27:20,840 --> 00:27:25,999](https://youtu.be/kMghsCXZQ9Y?t=00h27m20s)

thought about you know asp.net MVC views


[00:27:23,659 --> 00:27:27,289](https://youtu.be/kMghsCXZQ9Y?t=00h27m23s)

and we thought a bit about WPF and what


[00:27:25,999 --> 00:27:29,749](https://youtu.be/kMghsCXZQ9Y?t=00h27m25s)

are the view abstractions there that


[00:27:27,289 --> 00:27:32,239](https://youtu.be/kMghsCXZQ9Y?t=00h27m27s)

kind of let you think about layouts and


[00:27:29,749 --> 00:27:34,820](https://youtu.be/kMghsCXZQ9Y?t=00h27m29s)

content first and foremost rather than


[00:27:32,239 --> 00:27:36,679](https://youtu.be/kMghsCXZQ9Y?t=00h27m32s)

text extremes all right and then we can


[00:27:34,820 --> 00:27:41,450](https://youtu.be/kMghsCXZQ9Y?t=00h27m34s)

use that API to target all of these


[00:27:36,679 --> 00:27:44,330](https://youtu.be/kMghsCXZQ9Y?t=00h27m36s)

different kinds of output so let's take


[00:27:41,450 --> 00:27:49,539](https://youtu.be/kMghsCXZQ9Y?t=00h27m41s)

a look at the clock how does this thing


[00:27:44,330 --> 00:27:49,539](https://youtu.be/kMghsCXZQ9Y?t=00h27m44s)

work magic


[00:27:51,120 --> 00:27:56,110](https://youtu.be/kMghsCXZQ9Y?t=00h27m51s)

do you want to explain this one Kevin I


[00:27:53,800 --> 00:27:57,610](https://youtu.be/kMghsCXZQ9Y?t=00h27m53s)

think you've got more context into the


[00:27:56,110 --> 00:28:00,910](https://youtu.be/kMghsCXZQ9Y?t=00h27m56s)

AP in the API detail than I do


[00:27:57,610 --> 00:28:02,530](https://youtu.be/kMghsCXZQ9Y?t=00h27m57s)

well I will I will do my best and you


[00:28:00,910 --> 00:28:04,900](https://youtu.be/kMghsCXZQ9Y?t=00h28m00s)

can correct me where I steer all right


[00:28:02,530 --> 00:28:08,910](https://youtu.be/kMghsCXZQ9Y?t=00h28m02s)

so I have done a bunch of work on these


[00:28:04,900 --> 00:28:13,210](https://youtu.be/kMghsCXZQ9Y?t=00h28m04s)

things so inside of the system rendering


[00:28:08,910 --> 00:28:15,570](https://youtu.be/kMghsCXZQ9Y?t=00h28m08s)

project there's a a cause starting at


[00:28:13,210 --> 00:28:19,450](https://youtu.be/kMghsCXZQ9Y?t=00h28m13s)

the top the highest level object is


[00:28:15,570 --> 00:28:24,670](https://youtu.be/kMghsCXZQ9Y?t=00h28m15s)

views for people who are familiar with


[00:28:19,450 --> 00:28:26,020](https://youtu.be/kMghsCXZQ9Y?t=00h28m19s)

like thick client like sam'l types setup


[00:28:24,670 --> 00:28:27,940](https://youtu.be/kMghsCXZQ9Y?t=00h28m24s)

you can think of these as roughly


[00:28:26,020 --> 00:28:29,380](https://youtu.be/kMghsCXZQ9Y?t=00h28m26s)

equivalent to like your the various


[00:28:27,940 --> 00:28:31,240](https://youtu.be/kMghsCXZQ9Y?t=00h28m27s)

elements that you might layout people


[00:28:29,380 --> 00:28:33,190](https://youtu.be/kMghsCXZQ9Y?t=00h28m29s)

who've done wind forms or windows forms


[00:28:31,240 --> 00:28:36,790](https://youtu.be/kMghsCXZQ9Y?t=00h28m31s)

might also be familiar with this type of


[00:28:33,190 --> 00:28:40,750](https://youtu.be/kMghsCXZQ9Y?t=00h28m33s)

setup at the top level we have a screen


[00:28:36,790 --> 00:28:42,940](https://youtu.be/kMghsCXZQ9Y?t=00h28m36s)

view and the screen view is somewhat


[00:28:40,750 --> 00:28:45,640](https://youtu.be/kMghsCXZQ9Y?t=00h28m40s)

misleading in its name but it basically


[00:28:42,940 --> 00:28:48,820](https://youtu.be/kMghsCXZQ9Y?t=00h28m42s)

represents the view of your terminal


[00:28:45,640 --> 00:28:52,210](https://youtu.be/kMghsCXZQ9Y?t=00h28m45s)

that's that's visible so from like a


[00:28:48,820 --> 00:28:55,270](https://youtu.be/kMghsCXZQ9Y?t=00h28m48s)

system console API perspective you can


[00:28:52,210 --> 00:29:00,070](https://youtu.be/kMghsCXZQ9Y?t=00h28m52s)

think of this as the actual height and


[00:28:55,270 --> 00:29:02,050](https://youtu.be/kMghsCXZQ9Y?t=00h28m55s)

width that you have available with this


[00:29:00,070 --> 00:29:04,750](https://youtu.be/kMghsCXZQ9Y?t=00h29m00s)

clock perspective inside of the views


[00:29:02,050 --> 00:29:06,340](https://youtu.be/kMghsCXZQ9Y?t=00h29m02s)

most things boiled down into one of two


[00:29:04,750 --> 00:29:08,530](https://youtu.be/kMghsCXZQ9Y?t=00h29m04s)

types you've got sort of your layout


[00:29:06,340 --> 00:29:10,540](https://youtu.be/kMghsCXZQ9Y?t=00h29m06s)

views for if you want to do things like


[00:29:08,530 --> 00:29:12,640](https://youtu.be/kMghsCXZQ9Y?t=00h29m08s)

tables or grids or that kind of thing


[00:29:10,540 --> 00:29:15,730](https://youtu.be/kMghsCXZQ9Y?t=00h29m10s)

and you can compose those things


[00:29:12,640 --> 00:29:18,700](https://youtu.be/kMghsCXZQ9Y?t=00h29m12s)

together however you want and then with


[00:29:15,730 --> 00:29:21,310](https://youtu.be/kMghsCXZQ9Y?t=00h29m15s)

inside of those layout views you usually


[00:29:18,700 --> 00:29:24,540](https://youtu.be/kMghsCXZQ9Y?t=00h29m18s)

get down to a Content view whose purpose


[00:29:21,310 --> 00:29:27,250](https://youtu.be/kMghsCXZQ9Y?t=00h29m21s)

is really just to output some sort of


[00:29:24,540 --> 00:29:29,050](https://youtu.be/kMghsCXZQ9Y?t=00h29m24s)

content if you dig a little deeper in


[00:29:27,250 --> 00:29:32,830](https://youtu.be/kMghsCXZQ9Y?t=00h29m27s)

the API inside of the content view


[00:29:29,050 --> 00:29:34,330](https://youtu.be/kMghsCXZQ9Y?t=00h29m29s)

there's things called spans similar to


[00:29:32,830 --> 00:29:37,510](https://youtu.be/kMghsCXZQ9Y?t=00h29m32s)

what you might be familiar with with


[00:29:34,330 --> 00:29:39,610](https://youtu.be/kMghsCXZQ9Y?t=00h29m34s)

like HTML for a span object for being


[00:29:37,510 --> 00:29:41,290](https://youtu.be/kMghsCXZQ9Y?t=00h29m37s)

able to say adjust the color of


[00:29:39,610 --> 00:29:45,790](https://youtu.be/kMghsCXZQ9Y?t=00h29m39s)

something so that part of your text is


[00:29:41,290 --> 00:29:48,850](https://youtu.be/kMghsCXZQ9Y?t=00h29m41s)

red for example and so in this example


[00:29:45,790 --> 00:29:53,020](https://youtu.be/kMghsCXZQ9Y?t=00h29m45s)

what we have here is a screen view at


[00:29:48,850 --> 00:29:57,550](https://youtu.be/kMghsCXZQ9Y?t=00h29m48s)

the root and inside of the screen view


[00:29:53,020 --> 00:29:59,470](https://youtu.be/kMghsCXZQ9Y?t=00h29m53s)

we're going to put a Content view which


[00:29:57,550 --> 00:30:01,000](https://youtu.be/kMghsCXZQ9Y?t=00h29m57s)

is just that o'clock that you see there


[00:29:59,470 --> 00:30:03,010](https://youtu.be/kMghsCXZQ9Y?t=00h29m59s)

and then we're going to start rendering


[00:30:01,000 --> 00:30:05,680](https://youtu.be/kMghsCXZQ9Y?t=00h30m01s)

it the


[00:30:03,010 --> 00:30:08,940](https://youtu.be/kMghsCXZQ9Y?t=00h30m03s)

while loop at the bottom is just there


[00:30:05,680 --> 00:30:12,370](https://youtu.be/kMghsCXZQ9Y?t=00h30m05s)

looking for a key press four to indicate


[00:30:08,940 --> 00:30:13,810](https://youtu.be/kMghsCXZQ9Y?t=00h30m08s)

basically stop the demo and after that


[00:30:12,370 --> 00:30:16,600](https://youtu.be/kMghsCXZQ9Y?t=00h30m12s)

it's just going to sit there and spin


[00:30:13,810 --> 00:30:19,450](https://youtu.be/kMghsCXZQ9Y?t=00h30m13s)

and every time the the clock has changed


[00:30:16,600 --> 00:30:23,860](https://youtu.be/kMghsCXZQ9Y?t=00h30m16s)

its just going to update that observable


[00:30:19,450 --> 00:30:25,690](https://youtu.be/kMghsCXZQ9Y?t=00h30m19s)

so not to dive too deep into the eye


[00:30:23,860 --> 00:30:28,870](https://youtu.be/kMghsCXZQ9Y?t=00h30m23s)

observable interface but it basically


[00:30:25,690 --> 00:30:32,470](https://youtu.be/kMghsCXZQ9Y?t=00h30m25s)

has a published subscribe type pattern


[00:30:28,870 --> 00:30:34,150](https://youtu.be/kMghsCXZQ9Y?t=00h30m28s)

to it for people with mvvm backgrounds


[00:30:32,470 --> 00:30:36,010](https://youtu.be/kMghsCXZQ9Y?t=00h30m32s)

you can think of it almost as the


[00:30:34,150 --> 00:30:39,070](https://youtu.be/kMghsCXZQ9Y?t=00h30m34s)

equivalent of like and inotify property


[00:30:36,010 --> 00:30:40,630](https://youtu.be/kMghsCXZQ9Y?t=00h30m36s)

changed please no one throw stuff at me


[00:30:39,070 --> 00:30:43,690](https://youtu.be/kMghsCXZQ9Y?t=00h30m39s)

I realize they are very different in a


[00:30:40,630 --> 00:30:47,650](https://youtu.be/kMghsCXZQ9Y?t=00h30m40s)

lot of fundamental ways but that content


[00:30:43,690 --> 00:30:52,360](https://youtu.be/kMghsCXZQ9Y?t=00h30m43s)

view from observable registers up


[00:30:47,650 --> 00:30:54,160](https://youtu.be/kMghsCXZQ9Y?t=00h30m47s)

looking for changes to that observable


[00:30:52,360 --> 00:30:57,100](https://youtu.be/kMghsCXZQ9Y?t=00h30m52s)

object and then will automatically


[00:30:54,160 --> 00:30:59,070](https://youtu.be/kMghsCXZQ9Y?t=00h30m54s)

update the UI contents as those change


[00:30:57,100 --> 00:31:01,240](https://youtu.be/kMghsCXZQ9Y?t=00h30m57s)

which is how you're seeing that clock


[00:30:59,070 --> 00:31:03,970](https://youtu.be/kMghsCXZQ9Y?t=00h30m59s)

essentially tick every time there's a


[00:31:01,240 --> 00:31:07,830](https://youtu.be/kMghsCXZQ9Y?t=00h31m01s)

new second so that's a very long


[00:31:03,970 --> 00:31:07,830](https://youtu.be/kMghsCXZQ9Y?t=00h31m03s)

explanation for a very few lines of code


[00:31:08,340 --> 00:31:15,750](https://youtu.be/kMghsCXZQ9Y?t=00h31m08s)

but ultimately it leads to a ticking


[00:31:11,290 --> 00:31:15,750](https://youtu.be/kMghsCXZQ9Y?t=00h31m11s)

clock like what you see right there


[00:31:18,340 --> 00:31:22,000](https://youtu.be/kMghsCXZQ9Y?t=00h31m18s)

another thing that I would that I would


[00:31:20,350 --> 00:31:23,110](https://youtu.be/kMghsCXZQ9Y?t=00h31m20s)

add in as a sort of a demonstration of a


[00:31:22,000 --> 00:31:28,059](https://youtu.be/kMghsCXZQ9Y?t=00h31m22s)

different set of capabilities that you


[00:31:23,110 --> 00:31:29,710](https://youtu.be/kMghsCXZQ9Y?t=00h31m23s)

eluded to just them is this I don't know


[00:31:28,059 --> 00:31:32,230](https://youtu.be/kMghsCXZQ9Y?t=00h31m28s)

if we added directives for height and


[00:31:29,710 --> 00:31:33,340](https://youtu.be/kMghsCXZQ9Y?t=00h31m29s)

width and so on and there may be some


[00:31:32,230 --> 00:31:35,490](https://youtu.be/kMghsCXZQ9Y?t=00h31m32s)

collisions here between some of the


[00:31:33,340 --> 00:31:41,039](https://youtu.be/kMghsCXZQ9Y?t=00h31m33s)

concepts but we have this other sample


[00:31:35,490 --> 00:31:43,809](https://youtu.be/kMghsCXZQ9Y?t=00h31m35s)

you have mentioned this this sample here


[00:31:41,039 --> 00:31:45,840](https://youtu.be/kMghsCXZQ9Y?t=00h31m41s)

is this sure this is positioned in a way


[00:31:43,809 --> 00:31:48,610](https://youtu.be/kMghsCXZQ9Y?t=00h31m43s)

that it will make sense when I render it


[00:31:45,840 --> 00:31:50,529](https://youtu.be/kMghsCXZQ9Y?t=00h31m45s)

okay so we have this mobi sample which


[00:31:48,610 --> 00:31:53,350](https://youtu.be/kMghsCXZQ9Y?t=00h31m48s)

is it's like the first paragraph of


[00:31:50,529 --> 00:31:55,720](https://youtu.be/kMghsCXZQ9Y?t=00h31m50s)

moby-dick with some formatting inside of


[00:31:53,350 --> 00:31:58,779](https://youtu.be/kMghsCXZQ9Y?t=00h31m53s)

it and the rendering playground has


[00:31:55,720 --> 00:32:05,440](https://youtu.be/kMghsCXZQ9Y?t=00h31m55s)

height top-left width parameters you can


[00:31:58,779 --> 00:32:09,220](https://youtu.be/kMghsCXZQ9Y?t=00h31m58s)

pass in alright so you can see here some


[00:32:05,440 --> 00:32:10,510](https://youtu.be/kMghsCXZQ9Y?t=00h32m05s)

underlining some text colors the text


[00:32:09,220 --> 00:32:21,130](https://youtu.be/kMghsCXZQ9Y?t=00h32m09s)

colors are actually quite interesting


[00:32:10,510 --> 00:32:22,210](https://youtu.be/kMghsCXZQ9Y?t=00h32m10s)

because doing this yeah there we go and


[00:32:21,130 --> 00:32:25,210](https://youtu.be/kMghsCXZQ9Y?t=00h32m21s)

you'll see the word wrapping is


[00:32:22,210 --> 00:32:31,590](https://youtu.be/kMghsCXZQ9Y?t=00h32m22s)

supported within that area right so even


[00:32:25,210 --> 00:32:33,669](https://youtu.be/kMghsCXZQ9Y?t=00h32m25s)

though I rendered to a let's do


[00:32:31,590 --> 00:32:35,850](https://youtu.be/kMghsCXZQ9Y?t=00h32m31s)

something like that see what it looks


[00:32:33,669 --> 00:32:35,850](https://youtu.be/kMghsCXZQ9Y?t=00h32m33s)

like


[00:32:39,170 --> 00:32:42,980](https://youtu.be/kMghsCXZQ9Y?t=00h32m39s)

shrink it down to almost


[00:32:44,970 --> 00:32:49,240](https://youtu.be/kMghsCXZQ9Y?t=00h32m44s)

understand yeah and I am aware I was


[00:32:47,860 --> 00:32:50,830](https://youtu.be/kMghsCXZQ9Y?t=00h32m47s)

playing around with some of the


[00:32:49,240 --> 00:32:52,749](https://youtu.be/kMghsCXZQ9Y?t=00h32m49s)

rendering stuff earlier this week and I


[00:32:50,830 --> 00:32:56,740](https://youtu.be/kMghsCXZQ9Y?t=00h32m50s)

did run into a couple bugs in different


[00:32:52,749 --> 00:32:58,929](https://youtu.be/kMghsCXZQ9Y?t=00h32m52s)

areas so the this like John said at the


[00:32:56,740 --> 00:33:02,769](https://youtu.be/kMghsCXZQ9Y?t=00h32m56s)

beginning this this rendering stuff is


[00:32:58,929 --> 00:33:04,690](https://youtu.be/kMghsCXZQ9Y?t=00h32m58s)

very much in a lot more flux and not


[00:33:02,769 --> 00:33:06,730](https://youtu.be/kMghsCXZQ9Y?t=00h33m02s)

quite as stable as the base system


[00:33:04,690 --> 00:33:11,440](https://youtu.be/kMghsCXZQ9Y?t=00h33m04s)

command-line parser that it's built on


[00:33:06,730 --> 00:33:14,679](https://youtu.be/kMghsCXZQ9Y?t=00h33m06s)

top of so we definitely would enjoy


[00:33:11,440 --> 00:33:16,720](https://youtu.be/kMghsCXZQ9Y?t=00h33m11s)

feedback on issues bug reports or if


[00:33:14,679 --> 00:33:23,169](https://youtu.be/kMghsCXZQ9Y?t=00h33m14s)

people want to dive in and help and fix


[00:33:16,720 --> 00:33:24,429](https://youtu.be/kMghsCXZQ9Y?t=00h33m16s)

stuff there is yeah yep but putting


[00:33:23,169 --> 00:33:26,740](https://youtu.be/kMghsCXZQ9Y?t=00h33m23s)

these two things together you can


[00:33:24,429 --> 00:33:29,289](https://youtu.be/kMghsCXZQ9Y?t=00h33m24s)

imagine that once you have you know you


[00:33:26,740 --> 00:33:31,179](https://youtu.be/kMghsCXZQ9Y?t=00h33m26s)

if you define regions of your screen and


[00:33:29,289 --> 00:33:33,220](https://youtu.be/kMghsCXZQ9Y?t=00h33m29s)

think of them at the table layout right


[00:33:31,179 --> 00:33:34,840](https://youtu.be/kMghsCXZQ9Y?t=00h33m31s)

this this API that I'm showing here can


[00:33:33,220 --> 00:33:36,759](https://youtu.be/kMghsCXZQ9Y?t=00h33m33s)

can show you how you can create a bunch


[00:33:34,840 --> 00:33:38,379](https://youtu.be/kMghsCXZQ9Y?t=00h33m34s)

of different cells within it and you can


[00:33:36,759 --> 00:33:40,090](https://youtu.be/kMghsCXZQ9Y?t=00h33m36s)

do the updating in place with the clock


[00:33:38,379 --> 00:33:41,169](https://youtu.be/kMghsCXZQ9Y?t=00h33m38s)

approach and by combining those two


[00:33:40,090 --> 00:33:45,960](https://youtu.be/kMghsCXZQ9Y?t=00h33m40s)

things we'll get some really interesting


[00:33:41,169 --> 00:33:48,700](https://youtu.be/kMghsCXZQ9Y?t=00h33m41s)

rich animated stats a polite kind of a


[00:33:45,960 --> 00:33:51,279](https://youtu.be/kMghsCXZQ9Y?t=00h33m45s)

one of our ideal goals for this piece


[00:33:48,700 --> 00:33:52,690](https://youtu.be/kMghsCXZQ9Y?t=00h33m48s)

right you want to jump back to that


[00:33:51,279 --> 00:33:54,639](https://youtu.be/kMghsCXZQ9Y?t=00h33m51s)

clock output because there was one thing


[00:33:52,690 --> 00:33:58,720](https://youtu.be/kMghsCXZQ9Y?t=00h33m52s)

that we didn't quite touch on that I


[00:33:54,639 --> 00:34:00,700](https://youtu.be/kMghsCXZQ9Y?t=00h33m54s)

don't know if it's horribly intuitive so


[00:33:58,720 --> 00:34:02,230](https://youtu.be/kMghsCXZQ9Y?t=00h33m58s)

in the clock output where we have it


[00:34:00,700 --> 00:34:04,059](https://youtu.be/kMghsCXZQ9Y?t=00h34m00s)

updating if you want to just jump back


[00:34:02,230 --> 00:34:09,220](https://youtu.be/kMghsCXZQ9Y?t=00h34m02s)

to the code real quick there was that


[00:34:04,059 --> 00:34:11,169](https://youtu.be/kMghsCXZQ9Y?t=00h34m04s)

content view from observable so one day


[00:34:09,220 --> 00:34:14,349](https://youtu.be/kMghsCXZQ9Y?t=00h34m09s)

John comes to me and says hey I've got


[00:34:11,169 --> 00:34:17,619](https://youtu.be/kMghsCXZQ9Y?t=00h34m11s)

this great cool awesome idea of how to


[00:34:14,349 --> 00:34:19,030](https://youtu.be/kMghsCXZQ9Y?t=00h34m14s)

actually effectively do this binding


[00:34:17,619 --> 00:34:23,500](https://youtu.be/kMghsCXZQ9Y?t=00h34m17s)

because we had tossed around different


[00:34:19,030 --> 00:34:26,319](https://youtu.be/kMghsCXZQ9Y?t=00h34m19s)

ideas my WPF background I'm very partial


[00:34:23,500 --> 00:34:30,250](https://youtu.be/kMghsCXZQ9Y?t=00h34m23s)

to the binding of I want to just update


[00:34:26,319 --> 00:34:32,950](https://youtu.be/kMghsCXZQ9Y?t=00h34m26s)

my data and have my view magically be


[00:34:30,250 --> 00:34:34,540](https://youtu.be/kMghsCXZQ9Y?t=00h34m30s)

pulled in sync John can you move it so


[00:34:32,950 --> 00:34:38,799](https://youtu.be/kMghsCXZQ9Y?t=00h34m32s)

we can see that full from observable


[00:34:34,540 --> 00:34:40,950](https://youtu.be/kMghsCXZQ9Y?t=00h34m34s)

line 107 I think there we go so you'll


[00:34:38,799 --> 00:34:43,599](https://youtu.be/kMghsCXZQ9Y?t=00h34m38s)

notice that content view from observable


[00:34:40,950 --> 00:34:45,190](https://youtu.be/kMghsCXZQ9Y?t=00h34m40s)

that second parameter that's going in


[00:34:43,599 --> 00:34:47,139](https://youtu.be/kMghsCXZQ9Y?t=00h34m43s)

there so the first parameter is just any


[00:34:45,190 --> 00:34:50,200](https://youtu.be/kMghsCXZQ9Y?t=00h34m45s)

object that implements I observable and


[00:34:47,139 --> 00:34:53,139](https://youtu.be/kMghsCXZQ9Y?t=00h34m47s)

the second one goes into that X lambda


[00:34:50,200 --> 00:34:56,640](https://youtu.be/kMghsCXZQ9Y?t=00h34m50s)

and what looks like an interpolated


[00:34:53,139 --> 00:34:58,510](https://youtu.be/kMghsCXZQ9Y?t=00h34m53s)

string there but this is kind of a


[00:34:56,640 --> 00:35:00,400](https://youtu.be/kMghsCXZQ9Y?t=00h34m56s)

obscure area


[00:34:58,510 --> 00:35:02,440](https://youtu.be/kMghsCXZQ9Y?t=00h34m58s)

c-sharp that got added one string


[00:35:00,400 --> 00:35:06,430](https://youtu.be/kMghsCXZQ9Y?t=00h35m00s)

interpolation came into play in that


[00:35:02,440 --> 00:35:10,359](https://youtu.be/kMghsCXZQ9Y?t=00h35m02s)

that dollar sign in front of the string


[00:35:06,430 --> 00:35:12,180](https://youtu.be/kMghsCXZQ9Y?t=00h35m06s)

doesn't always return a string and so in


[00:35:10,359 --> 00:35:15,280](https://youtu.be/kMghsCXZQ9Y?t=00h35m10s)

this case it's actually returning a


[00:35:12,180 --> 00:35:19,150](https://youtu.be/kMghsCXZQ9Y?t=00h35m12s)

formattable string which you can sort of


[00:35:15,280 --> 00:35:21,960](https://youtu.be/kMghsCXZQ9Y?t=00h35m15s)

think about it as the equivalent of what


[00:35:19,150 --> 00:35:24,220](https://youtu.be/kMghsCXZQ9Y?t=00h35m19s)

a link expression is to a link query


[00:35:21,960 --> 00:35:27,070](https://youtu.be/kMghsCXZQ9Y?t=00h35m21s)

where the link expression contains the


[00:35:24,220 --> 00:35:29,800](https://youtu.be/kMghsCXZQ9Y?t=00h35m24s)

metadata of the actual query and the


[00:35:27,070 --> 00:35:34,090](https://youtu.be/kMghsCXZQ9Y?t=00h35m27s)

link query itself is just effectively


[00:35:29,800 --> 00:35:36,040](https://youtu.be/kMghsCXZQ9Y?t=00h35m29s)

the delegate so this is the formattable


[00:35:34,090 --> 00:35:39,760](https://youtu.be/kMghsCXZQ9Y?t=00h35m34s)

string basically gives you all of the


[00:35:36,040 --> 00:35:41,619](https://youtu.be/kMghsCXZQ9Y?t=00h35m36s)

metadata about the string that could be


[00:35:39,760 --> 00:35:43,180](https://youtu.be/kMghsCXZQ9Y?t=00h35m39s)

formatted so that you can then act on it


[00:35:41,619 --> 00:35:44,800](https://youtu.be/kMghsCXZQ9Y?t=00h35m41s)

and do something different which is how


[00:35:43,180 --> 00:35:47,109](https://youtu.be/kMghsCXZQ9Y?t=00h35m43s)

we're getting our automatic updating


[00:35:44,800 --> 00:35:48,940](https://youtu.be/kMghsCXZQ9Y?t=00h35m44s)

we're basically parsing out those


[00:35:47,109 --> 00:35:51,190](https://youtu.be/kMghsCXZQ9Y?t=00h35m47s)

elements and saying ah I see that that's


[00:35:48,940 --> 00:35:53,080](https://youtu.be/kMghsCXZQ9Y?t=00h35m48s)

an observable object let me wire up to


[00:35:51,190 --> 00:35:55,240](https://youtu.be/kMghsCXZQ9Y?t=00h35m51s)

the appropriate events and then update


[00:35:53,080 --> 00:35:57,940](https://youtu.be/kMghsCXZQ9Y?t=00h35m53s)

my UI when those things come through so


[00:35:55,240 --> 00:35:59,680](https://youtu.be/kMghsCXZQ9Y?t=00h35m55s)

you can actually it's quite powerful in


[00:35:57,940 --> 00:36:02,560](https://youtu.be/kMghsCXZQ9Y?t=00h35m57s)

that if you wanted to say prefix the


[00:35:59,680 --> 00:36:04,390](https://youtu.be/kMghsCXZQ9Y?t=00h35m59s)

time with the time is or something you


[00:36:02,560 --> 00:36:19,720](https://youtu.be/kMghsCXZQ9Y?t=00h36m02s)

could just type that string in there and


[00:36:04,390 --> 00:36:21,820](https://youtu.be/kMghsCXZQ9Y?t=00h36m04s)

it automatically works and so it's smart


[00:36:19,720 --> 00:36:23,470](https://youtu.be/kMghsCXZQ9Y?t=00h36m19s)

enough to realize and when it's parsing


[00:36:21,820 --> 00:36:25,270](https://youtu.be/kMghsCXZQ9Y?t=00h36m21s)

that string to know okay here's where


[00:36:23,470 --> 00:36:26,859](https://youtu.be/kMghsCXZQ9Y?t=00h36m23s)

the I observable goes here's the content


[00:36:25,270 --> 00:36:30,369](https://youtu.be/kMghsCXZQ9Y?t=00h36m25s)

that needs to update and do all of that


[00:36:26,859 --> 00:36:33,600](https://youtu.be/kMghsCXZQ9Y?t=00h36m26s)

updating in place so just something to


[00:36:30,369 --> 00:36:36,160](https://youtu.be/kMghsCXZQ9Y?t=00h36m30s)

be aware of so this this content view


[00:36:33,600 --> 00:36:38,710](https://youtu.be/kMghsCXZQ9Y?t=00h36m33s)

from observable I I think is probably


[00:36:36,160 --> 00:36:40,630](https://youtu.be/kMghsCXZQ9Y?t=00h36m36s)

one of the most powerful ways of being


[00:36:38,710 --> 00:36:42,869](https://youtu.be/kMghsCXZQ9Y?t=00h36m38s)

able to use this rendering library just


[00:36:40,630 --> 00:36:45,490](https://youtu.be/kMghsCXZQ9Y?t=00h36m40s)

because of how easy it is to get a


[00:36:42,869 --> 00:36:47,410](https://youtu.be/kMghsCXZQ9Y?t=00h36m42s)

region effectively in your output that


[00:36:45,490 --> 00:36:49,650](https://youtu.be/kMghsCXZQ9Y?t=00h36m45s)

just automatically updates as things go


[00:36:47,410 --> 00:36:49,650](https://youtu.be/kMghsCXZQ9Y?t=00h36m47s)

through


[00:36:51,660 --> 00:37:01,089](https://youtu.be/kMghsCXZQ9Y?t=00h36m51s)

and here is another example of that same


[00:36:57,309 --> 00:37:03,519](https://youtu.be/kMghsCXZQ9Y?t=00h36m57s)

approach which were the moby-dick output


[00:37:01,089 --> 00:37:05,170](https://youtu.be/kMghsCXZQ9Y?t=00h37m01s)

that we were showing before you know


[00:37:03,519 --> 00:37:17,700](https://youtu.be/kMghsCXZQ9Y?t=00h37m03s)

that's that's isn't the code for that


[00:37:05,170 --> 00:37:17,700](https://youtu.be/kMghsCXZQ9Y?t=00h37m05s)

you can look at that there's a code here


[00:37:28,980 --> 00:37:37,990](https://youtu.be/kMghsCXZQ9Y?t=00h37m28s)

here I do think that looks like a bug


[00:37:36,670 --> 00:37:41,950](https://youtu.be/kMghsCXZQ9Y?t=00h37m36s)

there because it seems like call me


[00:37:37,990 --> 00:37:42,880](https://youtu.be/kMghsCXZQ9Y?t=00h37m37s)

appears to be bold what appeared people


[00:37:41,950 --> 00:37:44,380](https://youtu.be/kMghsCXZQ9Y?t=00h37m41s)

all right yeah


[00:37:42,880 --> 00:37:48,900](https://youtu.be/kMghsCXZQ9Y?t=00h37m42s)

call me right at the beginning whereas


[00:37:44,380 --> 00:37:52,329](https://youtu.be/kMghsCXZQ9Y?t=00h37m44s)

you're bold on starts at the end of that


[00:37:48,900 --> 00:37:53,769](https://youtu.be/kMghsCXZQ9Y?t=00h37m48s)

yeah so like we said there's there's


[00:37:52,329 --> 00:37:55,390](https://youtu.be/kMghsCXZQ9Y?t=00h37m52s)

there's bugs like this it doesn't take


[00:37:53,769 --> 00:37:57,369](https://youtu.be/kMghsCXZQ9Y?t=00h37m53s)

too long playing with this rendering


[00:37:55,390 --> 00:38:02,250](https://youtu.be/kMghsCXZQ9Y?t=00h37m55s)

playground app to start to find some of


[00:37:57,369 --> 00:38:05,019](https://youtu.be/kMghsCXZQ9Y?t=00h37m57s)

the rough edges and bugs in this area


[00:38:02,250 --> 00:38:07,180](https://youtu.be/kMghsCXZQ9Y?t=00h38m02s)

yeah this was definitely you know the


[00:38:05,019 --> 00:38:09,640](https://youtu.be/kMghsCXZQ9Y?t=00h38m05s)

goal of the rendering playground was to


[00:38:07,180 --> 00:38:13,690](https://youtu.be/kMghsCXZQ9Y?t=00h38m07s)

make it easier to really interact with


[00:38:09,640 --> 00:38:15,220](https://youtu.be/kMghsCXZQ9Y?t=00h38m09s)

through this functionality and see what


[00:38:13,690 --> 00:38:22,960](https://youtu.be/kMghsCXZQ9Y?t=00h38m13s)

it's doing on the screen which is really


[00:38:15,220 --> 00:38:24,579](https://youtu.be/kMghsCXZQ9Y?t=00h38m15s)

very helpful there's another year yeah


[00:38:22,960 --> 00:38:25,690](https://youtu.be/kMghsCXZQ9Y?t=00h38m22s)

so we have this kind of approach here


[00:38:24,579 --> 00:38:27,250](https://youtu.be/kMghsCXZQ9Y?t=00h38m24s)

but then you can also because it's all


[00:38:25,690 --> 00:38:29,230](https://youtu.be/kMghsCXZQ9Y?t=00h38m25s)

just strings you could imagine extension


[00:38:27,250 --> 00:38:30,420](https://youtu.be/kMghsCXZQ9Y?t=00h38m27s)

methods that do the wrapping in the


[00:38:29,230 --> 00:38:32,650](https://youtu.be/kMghsCXZQ9Y?t=00h38m29s)

eighth to the vt100


[00:38:30,420 --> 00:38:34,470](https://youtu.be/kMghsCXZQ9Y?t=00h38m30s)

so what is this thing do you want to


[00:38:32,650 --> 00:38:38,309](https://youtu.be/kMghsCXZQ9Y?t=00h38m32s)

look at the output of this sir what's a


[00:38:34,470 --> 00:38:38,309](https://youtu.be/kMghsCXZQ9Y?t=00h38m34s)

the bt100 output


[00:38:42,640 --> 00:38:45,810](https://youtu.be/kMghsCXZQ9Y?t=00h38m42s)

[Music]


[00:38:47,060 --> 00:38:52,200](https://youtu.be/kMghsCXZQ9Y?t=00h38m47s)

but without fail if you play around with


[00:38:50,280 --> 00:38:53,640](https://youtu.be/kMghsCXZQ9Y?t=00h38m50s)

some of this VT stuff you will


[00:38:52,200 --> 00:39:03,290](https://youtu.be/kMghsCXZQ9Y?t=00h38m52s)

inevitably get yourself into the


[00:38:53,640 --> 00:39:03,290](https://youtu.be/kMghsCXZQ9Y?t=00h38m53s)

settings where you break Oh interesting


[00:39:06,120 --> 00:39:08,750](https://youtu.be/kMghsCXZQ9Y?t=00h39m06s)

well


[00:39:09,060 --> 00:39:16,050](https://youtu.be/kMghsCXZQ9Y?t=00h39m09s)

I'd have to look at what those control


[00:39:10,920 --> 00:39:19,230](https://youtu.be/kMghsCXZQ9Y?t=00h39m10s)

characters are but there's definitely do


[00:39:16,050 --> 00:39:26,400](https://youtu.be/kMghsCXZQ9Y?t=00h39m16s)

that one could be that yeah I'm seeing


[00:39:19,230 --> 00:39:30,740](https://youtu.be/kMghsCXZQ9Y?t=00h39m19s)

stuff before so I think the first one is


[00:39:26,400 --> 00:39:34,170](https://youtu.be/kMghsCXZQ9Y?t=00h39m26s)

to clear the screen well that could be


[00:39:30,740 --> 00:39:35,130](https://youtu.be/kMghsCXZQ9Y?t=00h39m30s)

you know if we had a good VP parser we


[00:39:34,170 --> 00:39:38,060](https://youtu.be/kMghsCXZQ9Y?t=00h39m34s)

could group we could create a much


[00:39:35,130 --> 00:39:40,290](https://youtu.be/kMghsCXZQ9Y?t=00h39m35s)

better than the bugging experience here


[00:39:38,060 --> 00:39:46,470](https://youtu.be/kMghsCXZQ9Y?t=00h39m38s)

if anyone would like to write one or


[00:39:40,290 --> 00:39:49,440](https://youtu.be/kMghsCXZQ9Y?t=00h39m40s)

recommend one please let us know I'll


[00:39:46,470 --> 00:39:50,340](https://youtu.be/kMghsCXZQ9Y?t=00h39m46s)

let you know what I can do there so the


[00:39:49,440 --> 00:39:51,720](https://youtu.be/kMghsCXZQ9Y?t=00h39m49s)

other thing we can do is we can search


[00:39:50,340 --> 00:39:56,300](https://youtu.be/kMghsCXZQ9Y?t=00h39m50s)

for it right we can go okay we've got


[00:39:51,720 --> 00:39:59,730](https://youtu.be/kMghsCXZQ9Y?t=00h39m51s)

this thing typically typically it's your


[00:39:56,300 --> 00:40:02,160](https://youtu.be/kMghsCXZQ9Y?t=00h39m56s)

the the question mark square brace and


[00:39:59,730 --> 00:40:06,360](https://youtu.be/kMghsCXZQ9Y?t=00h39m59s)

then the numeric is what's important I


[00:40:02,160 --> 00:40:10,380](https://youtu.be/kMghsCXZQ9Y?t=00h40m02s)

think that I think the semicolon is what


[00:40:06,360 --> 00:40:15,630](https://youtu.be/kMghsCXZQ9Y?t=00h40m06s)

precedes parameters yeah I think so


[00:40:10,380 --> 00:40:17,310](https://youtu.be/kMghsCXZQ9Y?t=00h40m10s)

try that the nice part about vt100 is


[00:40:15,630 --> 00:40:20,670](https://youtu.be/kMghsCXZQ9Y?t=00h40m15s)

it's been around for so many decades


[00:40:17,310 --> 00:40:22,350](https://youtu.be/kMghsCXZQ9Y?t=00h40m17s)

that there's lots of documentation it


[00:40:20,670 --> 00:40:25,020](https://youtu.be/kMghsCXZQ9Y?t=00h40m20s)

just usually shows up on webpages that


[00:40:22,350 --> 00:40:28,650](https://youtu.be/kMghsCXZQ9Y?t=00h40m22s)

look like they were created and 20 years


[00:40:25,020 --> 00:40:39,480](https://youtu.be/kMghsCXZQ9Y?t=00h40m25s)

ago yeah I'm curious as to why we're not


[00:40:28,650 --> 00:40:41,160](https://youtu.be/kMghsCXZQ9Y?t=00h40m28s)

finding this well this this is the I


[00:40:39,480 --> 00:40:41,820](https://youtu.be/kMghsCXZQ9Y?t=00h40m39s)

guess you were just doing straight text


[00:40:41,160 --> 00:40:47,190](https://youtu.be/kMghsCXZQ9Y?t=00h40m41s)

search on it


[00:40:41,820 --> 00:40:50,790](https://youtu.be/kMghsCXZQ9Y?t=00h40m41s)

Oh probably because you have in the ANSI


[00:40:47,190 --> 00:40:53,850](https://youtu.be/kMghsCXZQ9Y?t=00h40m47s)

control character class there the I


[00:40:50,790 --> 00:40:56,190](https://youtu.be/kMghsCXZQ9Y?t=00h40m50s)

think the square brace is part of that


[00:40:53,850 --> 00:40:59,100](https://youtu.be/kMghsCXZQ9Y?t=00h40m53s)

starting


[00:40:56,190 --> 00:41:02,820](https://youtu.be/kMghsCXZQ9Y?t=00h40m56s)

yeah which is so I think it's actually


[00:40:59,100 --> 00:41:04,710](https://youtu.be/kMghsCXZQ9Y?t=00h40m59s)

separate strings oh right yeah so if we


[00:41:02,820 --> 00:41:06,360](https://youtu.be/kMghsCXZQ9Y?t=00h41m02s)

look at this we've got 88 references to


[00:41:04,710 --> 00:41:09,120](https://youtu.be/kMghsCXZQ9Y?t=00h41m04s)

this class we can find a place where we


[00:41:06,360 --> 00:41:14,150](https://youtu.be/kMghsCXZQ9Y?t=00h41m06s)

define these also entity control code no


[00:41:09,120 --> 00:41:14,150](https://youtu.be/kMghsCXZQ9Y?t=00h41m09s)

not that one we're looking for


[00:41:16,100 --> 00:41:20,450](https://youtu.be/kMghsCXZQ9Y?t=00h41m16s)

I'm just looking where that says ansi


[00:41:18,420 --> 00:41:20,450](https://youtu.be/kMghsCXZQ9Y?t=00h41m18s)

escape


[00:41:28,190 --> 00:41:35,870](https://youtu.be/kMghsCXZQ9Y?t=00h41m28s)

look we've got a class that has like a


[00:41:31,760 --> 00:41:38,360](https://youtu.be/kMghsCXZQ9Y?t=00h41m31s)

whole yeah the one right above it and


[00:41:35,870 --> 00:41:49,430](https://youtu.be/kMghsCXZQ9Y?t=00h41m35s)

that's that's why we're not finding it


[00:41:38,360 --> 00:42:00,470](https://youtu.be/kMghsCXZQ9Y?t=00h41m38s)

when we search yeah yeah so let's go


[00:41:49,430 --> 00:42:03,890](https://youtu.be/kMghsCXZQ9Y?t=00h41m49s)

back here we could bold on with the


[00:42:00,470 --> 00:42:09,670](https://youtu.be/kMghsCXZQ9Y?t=00h42m00s)

first one when I go to bold on that's


[00:42:03,890 --> 00:42:09,670](https://youtu.be/kMghsCXZQ9Y?t=00h42m03s)

the first one we know of and that one


[00:42:14,160 --> 00:42:17,160](https://youtu.be/kMghsCXZQ9Y?t=00h42m14s)

Brenda


[00:42:20,400 --> 00:42:26,880](https://youtu.be/kMghsCXZQ9Y?t=00h42m20s)

who's calling me so bold on has got to


[00:42:23,190 --> 00:42:30,680](https://youtu.be/kMghsCXZQ9Y?t=00h42m23s)

be either that one M or four M guy right


[00:42:26,880 --> 00:42:30,680](https://youtu.be/kMghsCXZQ9Y?t=00h42m26s)

there guessing


[00:42:38,460 --> 00:42:48,030](https://youtu.be/kMghsCXZQ9Y?t=00h42m38s)

so yeah what these are doing is they're


[00:42:39,839 --> 00:42:49,829](https://youtu.be/kMghsCXZQ9Y?t=00h42m39s)

just wrapping that oddly hard didn't


[00:42:48,030 --> 00:42:52,109](https://youtu.be/kMghsCXZQ9Y?t=00h42m48s)

have it be able to well if I remember


[00:42:49,829 --> 00:42:54,000](https://youtu.be/kMghsCXZQ9Y?t=00h42m49s)

right the style span there's a bit of a


[00:42:52,109 --> 00:42:57,150](https://youtu.be/kMghsCXZQ9Y?t=00h42m52s)

visitor pattern there where it then


[00:42:54,000 --> 00:43:00,809](https://youtu.be/kMghsCXZQ9Y?t=00h42m54s)

translates it into these ANSI codes


[00:42:57,150 --> 00:43:02,040](https://youtu.be/kMghsCXZQ9Y?t=00h42m57s)

because the yeah the span because we


[00:43:00,809 --> 00:43:06,869](https://youtu.be/kMghsCXZQ9Y?t=00h43m00s)

don't know whether it's going to be


[00:43:02,040 --> 00:43:08,520](https://youtu.be/kMghsCXZQ9Y?t=00h43m02s)

written out with an C or not yep there's


[00:43:06,869 --> 00:43:12,300](https://youtu.be/kMghsCXZQ9Y?t=00h43m06s)

different visitors when it's parsing


[00:43:08,520 --> 00:43:19,440](https://youtu.be/kMghsCXZQ9Y?t=00h43m08s)

that formattable string into it so bold


[00:43:12,300 --> 00:43:21,240](https://youtu.be/kMghsCXZQ9Y?t=00h43m12s)

on one M so there it is that's in the


[00:43:19,440 --> 00:43:25,880](https://youtu.be/kMghsCXZQ9Y?t=00h43m19s)

correct place but the other thing over


[00:43:21,240 --> 00:43:32,630](https://youtu.be/kMghsCXZQ9Y?t=00h43m21s)

here seems to be yeah whatever that


[00:43:25,880 --> 00:43:32,630](https://youtu.be/kMghsCXZQ9Y?t=00h43m25s)

whatever six is seems to be confusing it


[00:43:39,690 --> 00:43:46,079](https://youtu.be/kMghsCXZQ9Y?t=00h43m39s)

I feel like we are not ripening backs I


[00:43:43,980 --> 00:43:48,030](https://youtu.be/kMghsCXZQ9Y?t=00h43m43s)

couldn't find it but maybe I'm it maybe


[00:43:46,079 --> 00:43:49,559](https://youtu.be/kMghsCXZQ9Y?t=00h43m46s)

it's in one of these things so if you


[00:43:48,030 --> 00:43:59,539](https://youtu.be/kMghsCXZQ9Y?t=00h43m48s)

had a thing that we can always do of


[00:43:49,559 --> 00:43:59,539](https://youtu.be/kMghsCXZQ9Y?t=00h43m49s)

course is we can search for it


[00:44:05,730 --> 00:44:12,540](https://youtu.be/kMghsCXZQ9Y?t=00h44m05s)

so if this escape character here that's


[00:44:09,090 --> 00:44:17,160](https://youtu.be/kMghsCXZQ9Y?t=00h44m09s)

this then we have the defined we have a


[00:44:12,540 --> 00:44:19,530](https://youtu.be/kMghsCXZQ9Y?t=00h44m12s)

constant for them to escape okay it's


[00:44:17,160 --> 00:44:21,510](https://youtu.be/kMghsCXZQ9Y?t=00h44m17s)

apparently in the vs code terminal


[00:44:19,530 --> 00:44:23,010](https://youtu.be/kMghsCXZQ9Y?t=00h44m19s)

renders is a question mark I think your


[00:44:21,510 --> 00:44:27,890](https://youtu.be/kMghsCXZQ9Y?t=00h44m21s)

debt when it rendered it is a weird box


[00:44:23,010 --> 00:44:27,890](https://youtu.be/kMghsCXZQ9Y?t=00h44m23s)

for Unicode something or another yeah


[00:44:35,700 --> 00:44:40,150](https://youtu.be/kMghsCXZQ9Y?t=00h44m35s)

and there's all these different


[00:44:37,030 --> 00:44:42,360](https://youtu.be/kMghsCXZQ9Y?t=00h44m37s)

categories as well you can find it in


[00:44:40,150 --> 00:44:42,360](https://youtu.be/kMghsCXZQ9Y?t=00h44m40s)

here


[00:44:45,270 --> 00:44:48,470](https://youtu.be/kMghsCXZQ9Y?t=00h44m45s)

rapid lungs


[00:44:49,400 --> 00:44:52,329](https://youtu.be/kMghsCXZQ9Y?t=00h44m49s)

because that


[00:45:12,819 --> 00:45:17,339](https://youtu.be/kMghsCXZQ9Y?t=00h45m12s)

the other thing is it's sometimes


[00:45:14,650 --> 00:45:19,510](https://youtu.be/kMghsCXZQ9Y?t=00h45m14s)

possible for things like this to be


[00:45:17,339 --> 00:45:21,369](https://youtu.be/kMghsCXZQ9Y?t=00h45m17s)

let's see I think we just I think during


[00:45:19,510 --> 00:45:23,049](https://youtu.be/kMghsCXZQ9Y?t=00h45m19s)

render we render something else to


[00:45:21,369 --> 00:45:33,670](https://youtu.be/kMghsCXZQ9Y?t=00h45m21s)

prepare the screen right we clear the


[00:45:23,049 --> 00:45:36,930](https://youtu.be/kMghsCXZQ9Y?t=00h45m23s)

screen you're clear second segment was


[00:45:33,670 --> 00:45:38,910](https://youtu.be/kMghsCXZQ9Y?t=00h45m33s)

at the bottom it could also be a move oh


[00:45:36,930 --> 00:45:42,400](https://youtu.be/kMghsCXZQ9Y?t=00h45m36s)

that could be it


[00:45:38,910 --> 00:45:47,079](https://youtu.be/kMghsCXZQ9Y?t=00h45m38s)

I'm looking at how like the the move or


[00:45:42,400 --> 00:45:49,809](https://youtu.be/kMghsCXZQ9Y?t=00h45m42s)

the clear where it's parameterised after


[00:45:47,079 --> 00:45:56,160](https://youtu.be/kMghsCXZQ9Y?t=00h45m47s)

the square brace so that six maybe


[00:45:49,809 --> 00:45:59,470](https://youtu.be/kMghsCXZQ9Y?t=00h45m49s)

something else actually it's not there


[00:45:56,160 --> 00:46:02,520](https://youtu.be/kMghsCXZQ9Y?t=00h45m56s)

look at the cursor one I think it's the


[00:45:59,470 --> 00:46:02,520](https://youtu.be/kMghsCXZQ9Y?t=00h45m59s)

next one up


[00:46:16,830 --> 00:46:22,570](https://youtu.be/kMghsCXZQ9Y?t=00h46m16s)

yeah I'm wondering it was something like


[00:46:19,090 --> 00:46:28,660](https://youtu.be/kMghsCXZQ9Y?t=00h46m19s)

this here it it it's moving that's so


[00:46:22,570 --> 00:46:30,730](https://youtu.be/kMghsCXZQ9Y?t=00h46m22s)

move got it that's what it is that's why


[00:46:28,660 --> 00:46:34,440](https://youtu.be/kMghsCXZQ9Y?t=00h46m28s)

we couldn't search for it yep


[00:46:30,730 --> 00:46:34,440](https://youtu.be/kMghsCXZQ9Y?t=00h46m30s)

the H should have been a dead giveaway


[00:46:35,220 --> 00:46:39,580](https://youtu.be/kMghsCXZQ9Y?t=00h46m35s)

yeah so that H is the one that's kind of


[00:46:37,870 --> 00:46:41,770](https://youtu.be/kMghsCXZQ9Y?t=00h46m37s)

interesting so yeah it has many


[00:46:39,580 --> 00:46:43,750](https://youtu.be/kMghsCXZQ9Y?t=00h46m39s)

different parameters we've you can even


[00:46:41,770 --> 00:46:45,640](https://youtu.be/kMghsCXZQ9Y?t=00h46m41s)

get a flavor here for the API that we


[00:46:43,750 --> 00:46:47,440](https://youtu.be/kMghsCXZQ9Y?t=00h46m43s)

have a below level API that we have for


[00:46:45,640 --> 00:46:48,760](https://youtu.be/kMghsCXZQ9Y?t=00h46m45s)

ante output which is what you know for


[00:46:47,440 --> 00:46:52,780](https://youtu.be/kMghsCXZQ9Y?t=00h46m47s)

the ones that take inputs we've created


[00:46:48,760 --> 00:46:55,120](https://youtu.be/kMghsCXZQ9Y?t=00h46m48s)

functions for them here's another one


[00:46:52,780 --> 00:46:58,420](https://youtu.be/kMghsCXZQ9Y?t=00h46m52s)

for sending that RGB colors one of the


[00:46:55,120 --> 00:47:01,330](https://youtu.be/kMghsCXZQ9Y?t=00h46m55s)

things that it was probably not super


[00:46:58,420 --> 00:47:04,870](https://youtu.be/kMghsCXZQ9Y?t=00h46m58s)

noticeable but the hard to be colors for


[00:47:01,330 --> 00:47:07,480](https://youtu.be/kMghsCXZQ9Y?t=00h47m01s)

the mobi sample are specified they're


[00:47:04,870 --> 00:47:10,690](https://youtu.be/kMghsCXZQ9Y?t=00h47m04s)

not just your standard sort of 1615


[00:47:07,480 --> 00:47:12,730](https://youtu.be/kMghsCXZQ9Y?t=00h47m07s)

console colors and it is worth noting


[00:47:10,690 --> 00:47:15,460](https://youtu.be/kMghsCXZQ9Y?t=00h47m10s)

too that we have seen slight differences


[00:47:12,730 --> 00:47:18,940](https://youtu.be/kMghsCXZQ9Y?t=00h47m12s)

between the windows and NICs terminals


[00:47:15,460 --> 00:47:21,870](https://youtu.be/kMghsCXZQ9Y?t=00h47m15s)

which is really unfortunate it's getting


[00:47:18,940 --> 00:47:24,550](https://youtu.be/kMghsCXZQ9Y?t=00h47m18s)

a lot better especially with the new


[00:47:21,870 --> 00:47:26,170](https://youtu.be/kMghsCXZQ9Y?t=00h47m21s)

terminal stuff on the latest version of


[00:47:24,550 --> 00:47:28,120](https://youtu.be/kMghsCXZQ9Y?t=00h47m24s)

Windows 10 so if you're on like the


[00:47:26,170 --> 00:47:30,130](https://youtu.be/kMghsCXZQ9Y?t=00h47m26s)

insider previews of Windows you're


[00:47:28,120 --> 00:47:32,830](https://youtu.be/kMghsCXZQ9Y?t=00h47m28s)

probably going to have a much better


[00:47:30,130 --> 00:47:37,420](https://youtu.be/kMghsCXZQ9Y?t=00h47m30s)

experience than if you're on say an old


[00:47:32,830 --> 00:47:40,150](https://youtu.be/kMghsCXZQ9Y?t=00h47m32s)

version of Windows 10 so just keep that


[00:47:37,420 --> 00:47:41,650](https://youtu.be/kMghsCXZQ9Y?t=00h47m37s)

in mind yeah yeah and the new Windows


[00:47:40,150 --> 00:47:49,830](https://youtu.be/kMghsCXZQ9Y?t=00h47m40s)

terminal won't standardize this even


[00:47:41,650 --> 00:47:49,830](https://youtu.be/kMghsCXZQ9Y?t=00h47m41s)

further right which would be excellent


[00:47:53,530 --> 00:47:56,160](https://youtu.be/kMghsCXZQ9Y?t=00h47m53s)

cool


[00:47:59,660 --> 00:48:02,650](https://youtu.be/kMghsCXZQ9Y?t=00h47m59s)

sweet


[00:48:02,690 --> 00:48:07,250](https://youtu.be/kMghsCXZQ9Y?t=00h48m02s)

what not well I was gonna say what do


[00:48:05,809 --> 00:48:11,329](https://youtu.be/kMghsCXZQ9Y?t=00h48m05s)

you want what do you want to go after we


[00:48:07,250 --> 00:48:15,410](https://youtu.be/kMghsCXZQ9Y?t=00h48m07s)

can we can you could run down trying to


[00:48:11,329 --> 00:48:17,569](https://youtu.be/kMghsCXZQ9Y?t=00h48m11s)

fix one of these bugs we could go


[00:48:15,410 --> 00:48:23,619](https://youtu.be/kMghsCXZQ9Y?t=00h48m15s)

through and do a demo of actually using


[00:48:17,569 --> 00:48:23,619](https://youtu.be/kMghsCXZQ9Y?t=00h48m17s)

this to build something if we wanted to


[00:48:26,040 --> 00:48:36,030](https://youtu.be/kMghsCXZQ9Y?t=00h48m26s)

I'm happy in the right um fix the puck


[00:48:32,760 --> 00:48:37,650](https://youtu.be/kMghsCXZQ9Y?t=00h48m32s)

says Xavier okay well let let's continue


[00:48:36,030 --> 00:48:40,350](https://youtu.be/kMghsCXZQ9Y?t=00h48m36s)

down this path in and see if we can


[00:48:37,650 --> 00:48:45,390](https://youtu.be/kMghsCXZQ9Y?t=00h48m37s)

actually fix this demo so that it works


[00:48:40,350 --> 00:48:46,710](https://youtu.be/kMghsCXZQ9Y?t=00h48m40s)

the way we expect so real quick can you


[00:48:45,390 --> 00:48:50,190](https://youtu.be/kMghsCXZQ9Y?t=00h48m45s)

run this one more time


[00:48:46,710 --> 00:48:53,190](https://youtu.be/kMghsCXZQ9Y?t=00h48m46s)

I'm curious run it in your PowerShell


[00:48:50,190 --> 00:48:54,840](https://youtu.be/kMghsCXZQ9Y?t=00h48m50s)

terminal all right I don't know what I


[00:48:53,190 --> 00:48:57,210](https://youtu.be/kMghsCXZQ9Y?t=00h48m53s)

don't know what the terminal technology


[00:48:54,840 --> 00:49:00,840](https://youtu.be/kMghsCXZQ9Y?t=00h48m54s)

is that's I realized the terminal is


[00:48:57,210 --> 00:49:05,369](https://youtu.be/kMghsCXZQ9Y?t=00h48m57s)

listed there as powershell vs code but i


[00:49:00,840 --> 00:49:08,000](https://youtu.be/kMghsCXZQ9Y?t=00h49m00s)

am curious if we see a different


[00:49:05,369 --> 00:49:08,000](https://youtu.be/kMghsCXZQ9Y?t=00h49m05s)

behavior there


[00:49:15,350 --> 00:49:21,500](https://youtu.be/kMghsCXZQ9Y?t=00h49m15s)

so here's that the output vt100 won't


[00:49:19,970 --> 00:49:22,640](https://youtu.be/kMghsCXZQ9Y?t=00h49m19s)

look the same and it starts with a


[00:49:21,500 --> 00:49:30,530](https://youtu.be/kMghsCXZQ9Y?t=00h49m21s)

positioning thing and then the bold


[00:49:22,640 --> 00:49:33,770](https://youtu.be/kMghsCXZQ9Y?t=00h49m22s)

thing happens later it looks correct and


[00:49:30,530 --> 00:49:36,020](https://youtu.be/kMghsCXZQ9Y?t=00h49m30s)

I'm going to enable VT so this defaults


[00:49:33,770 --> 00:49:44,510](https://youtu.be/kMghsCXZQ9Y?t=00h49m33s)

to true but I call the Senate route of


[00:49:36,020 --> 00:49:46,010](https://youtu.be/kMghsCXZQ9Y?t=00h49m36s)

the line interesting so the other thing


[00:49:44,510 --> 00:49:48,020](https://youtu.be/kMghsCXZQ9Y?t=00h49m44s)

that it could be that's that's also


[00:49:46,010 --> 00:49:51,560](https://youtu.be/kMghsCXZQ9Y?t=00h49m46s)

worth noting is we may not actually have


[00:49:48,020 --> 00:49:52,880](https://youtu.be/kMghsCXZQ9Y?t=00h49m48s)

a bug here per se or at least a bug may


[00:49:51,560 --> 00:49:55,280](https://youtu.be/kMghsCXZQ9Y?t=00h49m51s)

not necessarily be with this demo


[00:49:52,880 --> 00:49:57,980](https://youtu.be/kMghsCXZQ9Y?t=00h49m52s)

because when you're doing the VT control


[00:49:55,280 --> 00:50:01,220](https://youtu.be/kMghsCXZQ9Y?t=00h49m55s)

character stuff it it's very possible


[00:49:57,980 --> 00:50:04,310](https://youtu.be/kMghsCXZQ9Y?t=00h49m57s)

that you can get your terminal into bad


[00:50:01,220 --> 00:50:06,980](https://youtu.be/kMghsCXZQ9Y?t=00h50m01s)

states or inconsistent states where if


[00:50:04,310 --> 00:50:10,010](https://youtu.be/kMghsCXZQ9Y?t=00h50m04s)

one app doesn't properly clean itself up


[00:50:06,980 --> 00:50:12,020](https://youtu.be/kMghsCXZQ9Y?t=00h50m06s)

yeah next app running ends up picking up


[00:50:10,010 --> 00:50:13,430](https://youtu.be/kMghsCXZQ9Y?t=00h50m10s)

some of the the formatting or whatever


[00:50:12,020 --> 00:50:15,560](https://youtu.be/kMghsCXZQ9Y?t=00h50m12s)

the leftover settings were that weren't


[00:50:13,430 --> 00:50:18,260](https://youtu.be/kMghsCXZQ9Y?t=00h50m13s)

properly undone so it's very possible


[00:50:15,560 --> 00:50:21,710](https://youtu.be/kMghsCXZQ9Y?t=00h50m15s)

especially if like one of these apps


[00:50:18,260 --> 00:50:24,170](https://youtu.be/kMghsCXZQ9Y?t=00h50m18s)

crashes mid run that it hasn't properly


[00:50:21,710 --> 00:50:26,270](https://youtu.be/kMghsCXZQ9Y?t=00h50m21s)

reset some of the state that it was in


[00:50:24,170 --> 00:50:28,010](https://youtu.be/kMghsCXZQ9Y?t=00h50m24s)

so you end up with you know your


[00:50:26,270 --> 00:50:29,600](https://youtu.be/kMghsCXZQ9Y?t=00h50m26s)

terminal running and you see this in a


[00:50:28,010 --> 00:50:31,700](https://youtu.be/kMghsCXZQ9Y?t=00h50m28s)

lot of different terminal apps that even


[00:50:29,600 --> 00:50:33,470](https://youtu.be/kMghsCXZQ9Y?t=00h50m29s)

do things with like colors if they get


[00:50:31,700 --> 00:50:35,480](https://youtu.be/kMghsCXZQ9Y?t=00h50m31s)

into errors a lot of times they don't


[00:50:33,470 --> 00:50:37,340](https://youtu.be/kMghsCXZQ9Y?t=00h50m33s)

necessarily undo say the foreground


[00:50:35,480 --> 00:50:39,170](https://youtu.be/kMghsCXZQ9Y?t=00h50m35s)

color that they set and so then your


[00:50:37,340 --> 00:50:42,260](https://youtu.be/kMghsCXZQ9Y?t=00h50m37s)

terminals stuck in a weird foreground


[00:50:39,170 --> 00:50:43,910](https://youtu.be/kMghsCXZQ9Y?t=00h50m39s)

color until you reset it yeah


[00:50:42,260 --> 00:50:45,530](https://youtu.be/kMghsCXZQ9Y?t=00h50m42s)

which could have been the case that we


[00:50:43,910 --> 00:50:48,859](https://youtu.be/kMghsCXZQ9Y?t=00h50m43s)

have here which might mean that there is


[00:50:45,530 --> 00:50:57,790](https://youtu.be/kMghsCXZQ9Y?t=00h50m45s)

no bug well so let's try to us


[00:50:48,859 --> 00:50:57,790](https://youtu.be/kMghsCXZQ9Y?t=00h50m48s)

let's close video code and reopen it


[00:51:06,220 --> 00:51:18,790](https://youtu.be/kMghsCXZQ9Y?t=00h51m06s)

whoa oh right so what I'm doing here


[00:51:16,960 --> 00:51:20,980](https://youtu.be/kMghsCXZQ9Y?t=00h51m16s)

arkaid of the build system that we use


[00:51:18,790 --> 00:51:23,410](https://youtu.be/kMghsCXZQ9Y?t=00h51m18s)

about that got a lot of great stuff for


[00:51:20,980 --> 00:51:25,060](https://youtu.be/kMghsCXZQ9Y?t=00h51m20s)

us you know manage assign build multiple


[00:51:23,410 --> 00:51:27,910](https://youtu.be/kMghsCXZQ9Y?t=00h51m23s)

operating system tasks and things like


[00:51:25,060 --> 00:51:29,020](https://youtu.be/kMghsCXZQ9Y?t=00h51m25s)

this um but because we're we're


[00:51:27,910 --> 00:51:31,300](https://youtu.be/kMghsCXZQ9Y?t=00h51m27s)

replacing a bunch of them as build


[00:51:29,020 --> 00:51:33,700](https://youtu.be/kMghsCXZQ9Y?t=00h51m29s)

targets with RK which isn't always ideal


[00:51:31,300 --> 00:51:35,260](https://youtu.be/kMghsCXZQ9Y?t=00h51m31s)

on a local dev environment like it'll


[00:51:33,700 --> 00:51:37,720](https://youtu.be/kMghsCXZQ9Y?t=00h51m33s)

it'll pull down a very specific version


[00:51:35,260 --> 00:51:39,250](https://youtu.be/kMghsCXZQ9Y?t=00h51m35s)

of a Java SDK for example do a bunch of


[00:51:37,720 --> 00:51:41,380](https://youtu.be/kMghsCXZQ9Y?t=00h51m37s)

other stuff that maybe you know what you


[00:51:39,250 --> 00:51:44,490](https://youtu.be/kMghsCXZQ9Y?t=00h51m39s)

want for just a quick inner loop out of


[00:51:41,380 --> 00:51:49,210](https://youtu.be/kMghsCXZQ9Y?t=00h51m41s)

that so we have this flag to disable


[00:51:44,490 --> 00:51:51,640](https://youtu.be/kMghsCXZQ9Y?t=00h51m44s)

that is a very good you know my


[00:51:49,210 --> 00:51:54,070](https://youtu.be/kMghsCXZQ9Y?t=00h51m49s)

PowerShell windows I was forget it there


[00:51:51,640 --> 00:51:56,320](https://youtu.be/kMghsCXZQ9Y?t=00h51m51s)

because for PowerShell like the


[00:51:54,070 --> 00:51:59,680](https://youtu.be/kMghsCXZQ9Y?t=00h51m54s)

standalone PowerShell which uses a


[00:51:56,320 --> 00:52:01,600](https://youtu.be/kMghsCXZQ9Y?t=00h51m56s)

different profile than the PowerShell


[00:51:59,680 --> 00:52:03,190](https://youtu.be/kMghsCXZQ9Y?t=00h51m59s)

that's embedded in vs code I just have


[00:52:01,600 --> 00:52:08,830](https://youtu.be/kMghsCXZQ9Y?t=00h52m01s)

this set up in my profile so it's always


[00:52:03,190 --> 00:52:11,830](https://youtu.be/kMghsCXZQ9Y?t=00h52m03s)

there I guess I should do the same thing


[00:52:08,830 --> 00:52:14,100](https://youtu.be/kMghsCXZQ9Y?t=00h52m08s)

from if we don't have this document it's


[00:52:11,830 --> 00:52:16,810](https://youtu.be/kMghsCXZQ9Y?t=00h52m11s)

somewhere unlike our readme we might


[00:52:14,100 --> 00:52:19,150](https://youtu.be/kMghsCXZQ9Y?t=00h52m14s)

might consider adding that because I


[00:52:16,810 --> 00:52:21,160](https://youtu.be/kMghsCXZQ9Y?t=00h52m16s)

could see that I know we got bit by this


[00:52:19,150 --> 00:52:24,820](https://youtu.be/kMghsCXZQ9Y?t=00h52m19s)

we've done a couple hackathons on this


[00:52:21,160 --> 00:52:26,860](https://youtu.be/kMghsCXZQ9Y?t=00h52m21s)

project yeah and I think without fail


[00:52:24,820 --> 00:52:28,350](https://youtu.be/kMghsCXZQ9Y?t=00h52m24s)

every single person in the hackathon has


[00:52:26,860 --> 00:52:33,310](https://youtu.be/kMghsCXZQ9Y?t=00h52m26s)

gotten bit by it


[00:52:28,350 --> 00:52:37,480](https://youtu.be/kMghsCXZQ9Y?t=00h52m28s)

aha so there we are so it so I'm gonna


[00:52:33,310 --> 00:52:42,280](https://youtu.be/kMghsCXZQ9Y?t=00h52m33s)

guess that we ran something that left us


[00:52:37,480 --> 00:52:44,680](https://youtu.be/kMghsCXZQ9Y?t=00h52m37s)

in a bad state and I don't remember I'd


[00:52:42,280 --> 00:52:46,240](https://youtu.be/kMghsCXZQ9Y?t=00h52m42s)

probably have to go back over the stream


[00:52:44,680 --> 00:52:47,950](https://youtu.be/kMghsCXZQ9Y?t=00h52m44s)

to try and figure out what the heck the


[00:52:46,240 --> 00:52:50,140](https://youtu.be/kMghsCXZQ9Y?t=00h52m46s)

order was that we ran that's a beauty of


[00:52:47,950 --> 00:52:54,190](https://youtu.be/kMghsCXZQ9Y?t=00h52m47s)

this stream John now we can actually go


[00:52:50,140 --> 00:52:56,080](https://youtu.be/kMghsCXZQ9Y?t=00h52m50s)

back and re-watch the the first 50


[00:52:54,190 --> 00:52:57,820](https://youtu.be/kMghsCXZQ9Y?t=00h52m54s)

minutes to see what was the order of


[00:52:56,080 --> 00:53:00,400](https://youtu.be/kMghsCXZQ9Y?t=00h52m56s)

things that we ran in that window oh


[00:52:57,820 --> 00:53:02,680](https://youtu.be/kMghsCXZQ9Y?t=00h52m57s)

yeah I think I think you've identified


[00:53:00,400 --> 00:53:04,240](https://youtu.be/kMghsCXZQ9Y?t=00h53m00s)

the the basic problem though it's kind


[00:53:02,680 --> 00:53:06,820](https://youtu.be/kMghsCXZQ9Y?t=00h53m02s)

of hard to actually we do have a hook in


[00:53:04,240 --> 00:53:09,460](https://youtu.be/kMghsCXZQ9Y?t=00h53m04s)

place that was a community contribution


[00:53:06,820 --> 00:53:12,700](https://youtu.be/kMghsCXZQ9Y?t=00h53m06s)

to allow you to hook your program such


[00:53:09,460 --> 00:53:14,950](https://youtu.be/kMghsCXZQ9Y?t=00h53m09s)

that when what cancels is sent you can


[00:53:12,700 --> 00:53:15,490](https://youtu.be/kMghsCXZQ9Y?t=00h53m12s)

block a cancel and runs on clean up code


[00:53:14,950 --> 00:53:18,369](https://youtu.be/kMghsCXZQ9Y?t=00h53m14s)

before shell


[00:53:15,490 --> 00:53:20,710](https://youtu.be/kMghsCXZQ9Y?t=00h53m15s)

down right so please be good citizens


[00:53:18,369 --> 00:53:23,560](https://youtu.be/kMghsCXZQ9Y?t=00h53m18s)

and clean up any formatting or whatnot


[00:53:20,710 --> 00:53:26,830](https://youtu.be/kMghsCXZQ9Y?t=00h53m20s)

that you've set for the most part the


[00:53:23,560 --> 00:53:29,200](https://youtu.be/kMghsCXZQ9Y?t=00h53m23s)

the rendering stuff in the system


[00:53:26,830 --> 00:53:31,570](https://youtu.be/kMghsCXZQ9Y?t=00h53m26s)

command-line rendering does try to


[00:53:29,200 --> 00:53:33,010](https://youtu.be/kMghsCXZQ9Y?t=00h53m29s)

handle that as much for you as possible


[00:53:31,570 --> 00:53:35,560](https://youtu.be/kMghsCXZQ9Y?t=00h53m31s)

so if you're if you're laying out a


[00:53:33,010 --> 00:53:37,540](https://youtu.be/kMghsCXZQ9Y?t=00h53m33s)

bunch of views it will go through and


[00:53:35,560 --> 00:53:38,619](https://youtu.be/kMghsCXZQ9Y?t=00h53m35s)

you know toggle it on and off but


[00:53:37,540 --> 00:53:41,800](https://youtu.be/kMghsCXZQ9Y?t=00h53m37s)

something like this where you've got


[00:53:38,619 --> 00:53:44,110](https://youtu.be/kMghsCXZQ9Y?t=00h53m38s)

bold on bold off if you don't properly


[00:53:41,800 --> 00:53:48,810](https://youtu.be/kMghsCXZQ9Y?t=00h53m41s)

match those tags there's nothing in


[00:53:44,110 --> 00:53:48,810](https://youtu.be/kMghsCXZQ9Y?t=00h53m44s)

there to to verify that you've done that


[00:53:51,990 --> 00:53:56,170](https://youtu.be/kMghsCXZQ9Y?t=00h53m51s)

the other thing is like nesting tags


[00:53:54,550 --> 00:53:57,700](https://youtu.be/kMghsCXZQ9Y?t=00h53m54s)

doesn't always work and that's kind of


[00:53:56,170 --> 00:54:03,910](https://youtu.be/kMghsCXZQ9Y?t=00h53m56s)

Terminal specific so there's also stuff


[00:53:57,700 --> 00:54:05,740](https://youtu.be/kMghsCXZQ9Y?t=00h53m57s)

like that that see you actually hold on


[00:54:03,910 --> 00:54:10,480](https://youtu.be/kMghsCXZQ9Y?t=00h54m03s)

John Oh John I think you may have just


[00:54:05,740 --> 00:54:12,720](https://youtu.be/kMghsCXZQ9Y?t=00h54m05s)

hit it look at that call me Ishmael is


[00:54:10,480 --> 00:54:14,860](https://youtu.be/kMghsCXZQ9Y?t=00h54m10s)

now bolded again I'm wondering so


[00:54:12,720 --> 00:54:16,690](https://youtu.be/kMghsCXZQ9Y?t=00h54m12s)

speculative don't know this for a fact


[00:54:14,860 --> 00:54:18,369](https://youtu.be/kMghsCXZQ9Y?t=00h54m14s)

but note the size of the window that


[00:54:16,690 --> 00:54:20,320](https://youtu.be/kMghsCXZQ9Y?t=00h54m16s)

you're running I'm wondering if what's


[00:54:18,369 --> 00:54:22,960](https://youtu.be/kMghsCXZQ9Y?t=00h54m18s)

happening is it's is at the end of that


[00:54:20,320 --> 00:54:27,040](https://youtu.be/kMghsCXZQ9Y?t=00h54m20s)

output it's got the bull Don Flag it


[00:54:22,960 --> 00:54:29,920](https://youtu.be/kMghsCXZQ9Y?t=00h54m22s)

runs out of space and never outputs the


[00:54:27,040 --> 00:54:36,850](https://youtu.be/kMghsCXZQ9Y?t=00h54m27s)

bold off tag so it leaves the terminal


[00:54:29,920 --> 00:54:38,140](https://youtu.be/kMghsCXZQ9Y?t=00h54m29s)

output bolded maybe maybe this is


[00:54:36,850 --> 00:54:39,730](https://youtu.be/kMghsCXZQ9Y?t=00h54m36s)

something that you can actually see if


[00:54:38,140 --> 00:54:42,040](https://youtu.be/kMghsCXZQ9Y?t=00h54m38s)

we go back to this window now and run


[00:54:39,730 --> 00:54:43,630](https://youtu.be/kMghsCXZQ9Y?t=00h54m39s)

this again I did I took out the code


[00:54:42,040 --> 00:54:45,910](https://youtu.be/kMghsCXZQ9Y?t=00h54m42s)

that was underlining and you can see


[00:54:43,630 --> 00:54:51,490](https://youtu.be/kMghsCXZQ9Y?t=00h54m43s)

here it actually looked looks like it's


[00:54:45,910 --> 00:54:54,810](https://youtu.be/kMghsCXZQ9Y?t=00h54m45s)

bolded through call here as well kind of


[00:54:51,490 --> 00:54:54,810](https://youtu.be/kMghsCXZQ9Y?t=00h54m51s)

hard to tell I mean let me increase the


[00:54:54,990 --> 00:55:04,560](https://youtu.be/kMghsCXZQ9Y?t=00h54m54s)

size of this terminal what about Xavier


[00:54:58,780 --> 00:55:04,560](https://youtu.be/kMghsCXZQ9Y?t=00h54m58s)

the answer is bold working yes I think


[00:55:05,920 --> 00:55:11,150](https://youtu.be/kMghsCXZQ9Y?t=00h55m05s)

I'm a hard to tell ya in the PowerShell


[00:55:09,380 --> 00:55:16,760](https://youtu.be/kMghsCXZQ9Y?t=00h55m09s)

into it I don't I don't I don't know but


[00:55:11,150 --> 00:55:20,420](https://youtu.be/kMghsCXZQ9Y?t=00h55m11s)

doing bold at all this is those weird


[00:55:16,760 --> 00:55:22,100](https://youtu.be/kMghsCXZQ9Y?t=00h55m16s)

bits of the vt100 is you're the terminal


[00:55:20,420 --> 00:55:24,050](https://youtu.be/kMghsCXZQ9Y?t=00h55m20s)

that you're running you can send the


[00:55:22,100 --> 00:55:29,390](https://youtu.be/kMghsCXZQ9Y?t=00h55m22s)

commands and your terminal can say thank


[00:55:24,050 --> 00:55:32,090](https://youtu.be/kMghsCXZQ9Y?t=00h55m24s)

you very much and choose how much of the


[00:55:29,390 --> 00:55:34,070](https://youtu.be/kMghsCXZQ9Y?t=00h55m29s)

the spec it's gonna follow I mean it


[00:55:32,090 --> 00:55:36,860](https://youtu.be/kMghsCXZQ9Y?t=00h55m32s)

could even be font related to like if


[00:55:34,070 --> 00:55:42,410](https://youtu.be/kMghsCXZQ9Y?t=00h55m34s)

the if the output font doesn't support


[00:55:36,860 --> 00:55:44,120](https://youtu.be/kMghsCXZQ9Y?t=00h55m36s)

bold it wouldn't matter what vt100 code


[00:55:42,410 --> 00:55:46,490](https://youtu.be/kMghsCXZQ9Y?t=00h55m42s)

you sent if the font that it goes to


[00:55:44,120 --> 00:55:50,240](https://youtu.be/kMghsCXZQ9Y?t=00h55m44s)

render doesn't actually support bold as


[00:55:46,490 --> 00:55:52,040](https://youtu.be/kMghsCXZQ9Y?t=00h55m46s)

well but yeah exactly a lot of variables


[00:55:50,240 --> 00:55:53,350](https://youtu.be/kMghsCXZQ9Y?t=00h55m50s)

here that looks like it bolded but again


[00:55:52,040 --> 00:55:56,900](https://youtu.be/kMghsCXZQ9Y?t=00h55m52s)

it will be in bolded the whole sentence


[00:55:53,350 --> 00:55:59,360](https://youtu.be/kMghsCXZQ9Y?t=00h55m53s)

yes as far as I can tell let's try it


[00:55:56,900 --> 00:56:00,290](https://youtu.be/kMghsCXZQ9Y?t=00h55m56s)

with something that's more obvious it


[00:55:59,360 --> 00:56:04,160](https://youtu.be/kMghsCXZQ9Y?t=00h55m59s)

don't look like there's some kind of


[00:56:00,290 --> 00:56:07,010](https://youtu.be/kMghsCXZQ9Y?t=00h56m00s)

issue there yeah and I do wonder do you


[00:56:04,160 --> 00:56:12,040](https://youtu.be/kMghsCXZQ9Y?t=00h56m04s)

have any more bold it's interesting that


[00:56:07,010 --> 00:56:17,500](https://youtu.be/kMghsCXZQ9Y?t=00h56m07s)

it's because we only have that one bold


[00:56:12,040 --> 00:56:17,500](https://youtu.be/kMghsCXZQ9Y?t=00h56m12s)

style in this thing yeah


[00:56:30,650 --> 00:56:37,509](https://youtu.be/kMghsCXZQ9Y?t=00h56m30s)

hmmm that appeared to do nothing


[00:56:43,530 --> 00:56:51,390](https://youtu.be/kMghsCXZQ9Y?t=00h56m43s)

okay what the heck yeah hold on


[00:56:49,020 --> 00:56:56,430](https://youtu.be/kMghsCXZQ9Y?t=00h56m49s)

methodically knocking people's hats off


[00:56:51,390 --> 00:56:59,580](https://youtu.be/kMghsCXZQ9Y?t=00h56m51s)

then it's interesting that I wonder


[00:56:56,430 --> 00:57:01,050](https://youtu.be/kMghsCXZQ9Y?t=00h56m56s)

because we have those that reset I


[00:56:59,580 --> 00:57:06,450](https://youtu.be/kMghsCXZQ9Y?t=00h56m59s)

wonder if that reset doesn't behave the


[00:57:01,050 --> 00:57:08,490](https://youtu.be/kMghsCXZQ9Y?t=00h57m01s)

way we expect yeah so a good portion of


[00:57:06,450 --> 00:57:10,890](https://youtu.be/kMghsCXZQ9Y?t=00h57m06s)

this work is figuring out how is vt100


[00:57:08,490 --> 00:57:12,540](https://youtu.be/kMghsCXZQ9Y?t=00h57m08s)

supposed to work and then figuring out


[00:57:10,890 --> 00:57:14,040](https://youtu.be/kMghsCXZQ9Y?t=00h57m10s)

you know are there differences between


[00:57:12,540 --> 00:57:16,260](https://youtu.be/kMghsCXZQ9Y?t=00h57m12s)

different terminals and so some of these


[00:57:14,040 --> 00:57:18,000](https://youtu.be/kMghsCXZQ9Y?t=00h57m14s)

bugs will fall into this category of


[00:57:16,260 --> 00:57:23,930](https://youtu.be/kMghsCXZQ9Y?t=00h57m16s)

differences between terminals now in the


[00:57:18,000 --> 00:57:25,860](https://youtu.be/kMghsCXZQ9Y?t=00h57m18s)

linux world there's n curses which uses


[00:57:23,930 --> 00:57:27,420](https://youtu.be/kMghsCXZQ9Y?t=00h57m23s)

basically a database of all these


[00:57:25,860 --> 00:57:29,700](https://youtu.be/kMghsCXZQ9Y?t=00h57m25s)

terminal capabilities to solve this


[00:57:27,420 --> 00:57:32,310](https://youtu.be/kMghsCXZQ9Y?t=00h57m27s)

problem across a wide variety of


[00:57:29,700 --> 00:57:34,800](https://youtu.be/kMghsCXZQ9Y?t=00h57m29s)

terminals you can imagine this project


[00:57:32,310 --> 00:57:36,300](https://youtu.be/kMghsCXZQ9Y?t=00h57m32s)

eventually gaining that kind of a


[00:57:34,800 --> 00:57:37,560](https://youtu.be/kMghsCXZQ9Y?t=00h57m34s)

knowledge base the thing is there's no


[00:57:36,300 --> 00:57:40,260](https://youtu.be/kMghsCXZQ9Y?t=00h57m36s)

there's no equivalent for Windows


[00:57:37,560 --> 00:57:42,660](https://youtu.be/kMghsCXZQ9Y?t=00h57m37s)

hopefully we don't need one and then n


[00:57:40,260 --> 00:57:44,760](https://youtu.be/kMghsCXZQ9Y?t=00h57m40s)

curses as well as not it doesn't really


[00:57:42,660 --> 00:57:48,180](https://youtu.be/kMghsCXZQ9Y?t=00h57m42s)

work great for redirecting output it's


[00:57:44,760 --> 00:57:50,100](https://youtu.be/kMghsCXZQ9Y?t=00h57m44s)

really a you know a vt100 only kind of


[00:57:48,180 --> 00:57:51,420](https://youtu.be/kMghsCXZQ9Y?t=00h57m48s)

programming environment so right it's


[00:57:50,100 --> 00:57:53,520](https://youtu.be/kMghsCXZQ9Y?t=00h57m50s)

meant for pretty output and there is


[00:57:51,420 --> 00:57:55,020](https://youtu.be/kMghsCXZQ9Y?t=00h57m51s)

nothing stopping you like if if what


[00:57:53,520 --> 00:57:57,270](https://youtu.be/kMghsCXZQ9Y?t=00h57m53s)

you're looking for is like pretty


[00:57:55,020 --> 00:57:58,860](https://youtu.be/kMghsCXZQ9Y?t=00h57m55s)

windowing type stuff inside of your CLI


[00:57:57,270 --> 00:58:01,050](https://youtu.be/kMghsCXZQ9Y?t=00h57m57s)

there's nothing stopping you from using


[00:57:58,860 --> 00:58:02,160](https://youtu.be/kMghsCXZQ9Y?t=00h57m58s)

end curses rather than the system


[00:58:01,050 --> 00:58:03,930](https://youtu.be/kMghsCXZQ9Y?t=00h58m01s)

command line rendering like there's


[00:58:02,160 --> 00:58:05,970](https://youtu.be/kMghsCXZQ9Y?t=00h58m02s)

there's some things that I suspect n


[00:58:03,930 --> 00:58:08,640](https://youtu.be/kMghsCXZQ9Y?t=00h58m03s)

curses will still be the the better


[00:58:05,970 --> 00:58:10,170](https://youtu.be/kMghsCXZQ9Y?t=00h58m05s)

answer for oh yeah like if you're if


[00:58:08,640 --> 00:58:12,300](https://youtu.be/kMghsCXZQ9Y?t=00h58m08s)

you're looking to build you know some


[00:58:10,170 --> 00:58:14,940](https://youtu.be/kMghsCXZQ9Y?t=00h58m10s)

sort of Emacs type equivalent with all


[00:58:12,300 --> 00:58:17,970](https://youtu.be/kMghsCXZQ9Y?t=00h58m12s)

kinds of fancy and I in quotes here


[00:58:14,940 --> 00:58:20,700](https://youtu.be/kMghsCXZQ9Y?t=00h58m14s)

gooey bits on your CLI that it's


[00:58:17,970 --> 00:58:22,890](https://youtu.be/kMghsCXZQ9Y?t=00h58m17s)

probably the better answer it is


[00:58:20,700 --> 00:58:26,550](https://youtu.be/kMghsCXZQ9Y?t=00h58m20s)

interesting to I'll point out so in this


[00:58:22,890 --> 00:58:28,200](https://youtu.be/kMghsCXZQ9Y?t=00h58m22s)

demo you'll notice that the methodically


[00:58:26,550 --> 00:58:30,000](https://youtu.be/kMghsCXZQ9Y?t=00h58m26s)

knocking people's hats off that sentence


[00:58:28,200 --> 00:58:33,870](https://youtu.be/kMghsCXZQ9Y?t=00h58m28s)

is theoretically going darker and darker


[00:58:30,000 --> 00:58:35,880](https://youtu.be/kMghsCXZQ9Y?t=00h58m30s)

red according to the RGB values yeah but


[00:58:33,870 --> 00:58:39,510](https://youtu.be/kMghsCXZQ9Y?t=00h58m33s)

you'll notice in your rendering it only


[00:58:35,880 --> 00:58:41,910](https://youtu.be/kMghsCXZQ9Y?t=00h58m35s)

picks one whereas over in your


[00:58:39,510 --> 00:58:43,620](https://youtu.be/kMghsCXZQ9Y?t=00h58m39s)

PowerShell you can or I guess it's going


[00:58:41,910 --> 00:58:47,460](https://youtu.be/kMghsCXZQ9Y?t=00h58m41s)

lighter and lighter red not darker and


[00:58:43,620 --> 00:58:50,940](https://youtu.be/kMghsCXZQ9Y?t=00h58m43s)

darker but regardless more red as it


[00:58:47,460 --> 00:58:52,440](https://youtu.be/kMghsCXZQ9Y?t=00h58m47s)

works its way through there is on that


[00:58:50,940 --> 00:58:54,690](https://youtu.be/kMghsCXZQ9Y?t=00h58m50s)

Wikipedia page that you pulled up


[00:58:52,440 --> 00:58:57,270](https://youtu.be/kMghsCXZQ9Y?t=00h58m52s)

there's a great kind of write-up about


[00:58:54,690 --> 00:58:59,370](https://youtu.be/kMghsCXZQ9Y?t=00h58m54s)

the the colors that are supported


[00:58:57,270 --> 00:59:02,580](https://youtu.be/kMghsCXZQ9Y?t=00h58m57s)

across different terminals because


[00:58:59,370 --> 00:59:08,010](https://youtu.be/kMghsCXZQ9Y?t=00h58m59s)

there's I think a set of like 24


[00:59:02,580 --> 00:59:10,140](https://youtu.be/kMghsCXZQ9Y?t=00h59m02s)

different call safe consul colors like


[00:59:08,010 --> 00:59:12,990](https://youtu.be/kMghsCXZQ9Y?t=00h59m08s)

if you you if you look in the what is it


[00:59:10,140 --> 00:59:15,540](https://youtu.be/kMghsCXZQ9Y?t=00h59m10s)

I think that I think it's just the


[00:59:12,990 --> 00:59:18,240](https://youtu.be/kMghsCXZQ9Y?t=00h59m12s)

system duck consul color is the the


[00:59:15,540 --> 00:59:21,380](https://youtu.be/kMghsCXZQ9Y?t=00h59m15s)

built-in class that contains the list of


[00:59:18,240 --> 00:59:24,180](https://youtu.be/kMghsCXZQ9Y?t=00h59m18s)

the the reduced list of these are the


[00:59:21,380 --> 00:59:25,890](https://youtu.be/kMghsCXZQ9Y?t=00h59m21s)

absolutely the only safe colors you can


[00:59:24,180 --> 00:59:27,660](https://youtu.be/kMghsCXZQ9Y?t=00h59m24s)

use and I believe in our foreground


[00:59:25,890 --> 00:59:30,540](https://youtu.be/kMghsCXZQ9Y?t=00h59m25s)

color span rather than that arbitrary


[00:59:27,660 --> 00:59:32,700](https://youtu.be/kMghsCXZQ9Y?t=00h59m27s)

RGB we actually have static properties


[00:59:30,540 --> 00:59:34,140](https://youtu.be/kMghsCXZQ9Y?t=00h59m30s)

for all of the safe colors if you're


[00:59:32,700 --> 00:59:36,150](https://youtu.be/kMghsCXZQ9Y?t=00h59m32s)

worried about making sure that you pick


[00:59:34,140 --> 00:59:38,100](https://youtu.be/kMghsCXZQ9Y?t=00h59m34s)

a good one but if you know you're gonna


[00:59:36,150 --> 00:59:40,320](https://youtu.be/kMghsCXZQ9Y?t=00h59m36s)

be running in terminals where yeah


[00:59:38,100 --> 00:59:43,350](https://youtu.be/kMghsCXZQ9Y?t=00h59m38s)

so there's your a list of all of the the


[00:59:40,320 --> 00:59:44,670](https://youtu.be/kMghsCXZQ9Y?t=00h59m40s)

safe colors but obviously that list is


[00:59:43,350 --> 00:59:45,900](https://youtu.be/kMghsCXZQ9Y?t=00h59m43s)

very limited and if you know you're


[00:59:44,670 --> 00:59:47,310](https://youtu.be/kMghsCXZQ9Y?t=00h59m44s)

going to be running in terminals that


[00:59:45,900 --> 00:59:55,140](https://youtu.be/kMghsCXZQ9Y?t=00h59m45s)

support it well you can take advantage


[00:59:47,310 --> 00:59:56,220](https://youtu.be/kMghsCXZQ9Y?t=00h59m47s)

and use a wider palette yeah so I'm


[00:59:55,140 --> 00:59:59,340](https://youtu.be/kMghsCXZQ9Y?t=00h59m55s)

gonna put some of this down to just


[00:59:56,220 --> 01:00:00,720](https://youtu.be/kMghsCXZQ9Y?t=00h59m56s)

different terminal behaviors right cuz I


[00:59:59,340 --> 01:00:03,450](https://youtu.be/kMghsCXZQ9Y?t=00h59m59s)

mean we can at least see the difference


[01:00:00,720 --> 01:00:05,610](https://youtu.be/kMghsCXZQ9Y?t=01h00m00s)

in the the foreground color there the


[01:00:03,450 --> 01:00:09,000](https://youtu.be/kMghsCXZQ9Y?t=01h00m03s)

the part that does really interest me is


[01:00:05,610 --> 01:00:11,220](https://youtu.be/kMghsCXZQ9Y?t=01h00m05s)

why why it seems to be picking up that


[01:00:09,000 --> 01:00:16,550](https://youtu.be/kMghsCXZQ9Y?t=01h00m09s)

bold but yeah there is


[01:00:11,220 --> 01:00:16,550](https://youtu.be/kMghsCXZQ9Y?t=01h00m11s)

whatever terminal is being run


[01:00:20,410 --> 01:00:24,580](https://youtu.be/kMghsCXZQ9Y?t=01h00m20s)

you've got something else still running


[01:00:35,200 --> 01:00:43,390](https://youtu.be/kMghsCXZQ9Y?t=01h00m35s)

something else is holding on to that


[01:00:38,950 --> 01:00:43,390](https://youtu.be/kMghsCXZQ9Y?t=01h00m38s)

we've got too many terminal windows open


[01:00:50,430 --> 01:01:03,150](https://youtu.be/kMghsCXZQ9Y?t=01h00m50s)

now everything's bold I am noticing


[01:00:58,529 --> 01:01:06,059](https://youtu.be/kMghsCXZQ9Y?t=01h00m58s)

something the the output that from


[01:01:03,150 --> 01:01:11,910](https://youtu.be/kMghsCXZQ9Y?t=01h01m03s)

msbuild does appear to also set some


[01:01:06,059 --> 01:01:17,369](https://youtu.be/kMghsCXZQ9Y?t=01h01m06s)

formatting I'm wondering if we might new


[01:01:11,910 --> 01:01:20,970](https://youtu.be/kMghsCXZQ9Y?t=01h01m11s)

terminal yeah does you'll notice like


[01:01:17,369 --> 01:01:23,430](https://youtu.be/kMghsCXZQ9Y?t=01h01m17s)

even your command line API on the other


[01:01:20,970 --> 01:01:27,119](https://youtu.be/kMghsCXZQ9Y?t=01h01m20s)

terminal went bold as well which means


[01:01:23,430 --> 01:01:30,720](https://youtu.be/kMghsCXZQ9Y?t=01h01m23s)

something left formatting or something


[01:01:27,119 --> 01:01:35,339](https://youtu.be/kMghsCXZQ9Y?t=01h01m27s)

set the flag and then never unset it so


[01:01:30,720 --> 01:01:36,569](https://youtu.be/kMghsCXZQ9Y?t=01h01m30s)

let's do this let's do let's not go


[01:01:35,339 --> 01:01:40,859](https://youtu.be/kMghsCXZQ9Y?t=01h01m35s)

through them I spilled every single time


[01:01:36,569 --> 01:01:50,000](https://youtu.be/kMghsCXZQ9Y?t=01h01m36s)

we run this thing right so we'll do go


[01:01:40,859 --> 01:01:53,720](https://youtu.be/kMghsCXZQ9Y?t=01h01m40s)

in here I'll do it dot that publish when


[01:01:50,000 --> 01:01:53,720](https://youtu.be/kMghsCXZQ9Y?t=01h01m50s)

x64 is that right


[01:01:59,720 --> 01:02:04,099](https://youtu.be/kMghsCXZQ9Y?t=01h01m59s)

so this will produce an executable and


[01:02:01,630 --> 01:02:05,329](https://youtu.be/kMghsCXZQ9Y?t=01h02m01s)

then we can run that directly we're not


[01:02:04,099 --> 01:02:08,319](https://youtu.be/kMghsCXZQ9Y?t=01h02m04s)

going through dotnet run every time


[01:02:05,329 --> 01:02:08,319](https://youtu.be/kMghsCXZQ9Y?t=01h02m05s)

right


[01:02:12,310 --> 01:02:25,360](https://youtu.be/kMghsCXZQ9Y?t=01h02m12s)

so I think project


[01:02:19,840 --> 01:02:28,980](https://youtu.be/kMghsCXZQ9Y?t=01h02m19s)

oh sorry Xavier I think my my nightbot


[01:02:25,360 --> 01:02:28,980](https://youtu.be/kMghsCXZQ9Y?t=01h02m25s)

setup might be a little restrictive


[01:02:33,859 --> 01:02:44,650](https://youtu.be/kMghsCXZQ9Y?t=01h02m33s)

yeah Savior has a great link in the the


[01:02:37,489 --> 01:02:47,989](https://youtu.be/kMghsCXZQ9Y?t=01h02m37s)

chat as well about testing testing VT


[01:02:44,650 --> 01:02:53,690](https://youtu.be/kMghsCXZQ9Y?t=01h02m44s)

109 and the compatibility or more


[01:02:47,989 --> 01:02:57,859](https://youtu.be/kMghsCXZQ9Y?t=01h02m47s)

accurately to lack thereof yep yeah this


[01:02:53,690 --> 01:03:00,380](https://youtu.be/kMghsCXZQ9Y?t=01h02m53s)

is this is an excellent one and I think


[01:02:57,859 --> 01:03:06,920](https://youtu.be/kMghsCXZQ9Y?t=01h02m57s)

you you mentioned it earlier there as


[01:03:00,380 --> 01:03:08,569](https://youtu.be/kMghsCXZQ9Y?t=01h03m00s)

well how n curses goes - it handles it


[01:03:06,920 --> 01:03:15,200](https://youtu.be/kMghsCXZQ9Y?t=01h03m06s)

because despite there being these nice


[01:03:08,569 --> 01:03:16,999](https://youtu.be/kMghsCXZQ9Y?t=01h03m08s)

posted standards there is a there's a


[01:03:15,200 --> 01:03:19,910](https://youtu.be/kMghsCXZQ9Y?t=01h03m15s)

constant problem across various


[01:03:16,999 --> 01:03:22,190](https://youtu.be/kMghsCXZQ9Y?t=01h03m16s)

terminals of with varying levels of


[01:03:19,910 --> 01:03:25,759](https://youtu.be/kMghsCXZQ9Y?t=01h03m19s)

support there's there's unfortunately


[01:03:22,190 --> 01:03:30,999](https://youtu.be/kMghsCXZQ9Y?t=01h03m22s)

not a good standardized way of handling


[01:03:25,759 --> 01:03:30,999](https://youtu.be/kMghsCXZQ9Y?t=01h03m25s)

it yet but we're getting better


[01:03:40,050 --> 01:03:51,210](https://youtu.be/kMghsCXZQ9Y?t=01h03m40s)

so now we can we can do this directly


[01:03:42,540 --> 01:03:53,460](https://youtu.be/kMghsCXZQ9Y?t=01h03m42s)

against the executable so we know I must


[01:03:51,210 --> 01:03:55,320](https://youtu.be/kMghsCXZQ9Y?t=01h03m51s)

build if not in the picture well


[01:03:53,460 --> 01:03:57,710](https://youtu.be/kMghsCXZQ9Y?t=01h03m53s)

actually let's even go start a new


[01:03:55,320 --> 01:03:57,710](https://youtu.be/kMghsCXZQ9Y?t=01h03m55s)

terminal


[01:04:11,839 --> 01:04:14,839](https://youtu.be/kMghsCXZQ9Y?t=01h04m11s)

oops


[01:04:25,140 --> 01:04:28,760](https://youtu.be/kMghsCXZQ9Y?t=01h04m25s)

good news you have no viruses


[01:04:29,730 --> 01:04:32,510](https://youtu.be/kMghsCXZQ9Y?t=01h04m29s)

okay


[01:04:33,210 --> 01:04:36,289](https://youtu.be/kMghsCXZQ9Y?t=01h04m33s)

[Music]


[01:04:37,220 --> 01:04:42,349](https://youtu.be/kMghsCXZQ9Y?t=01h04m37s)

I've removed the bowl now let's put the


[01:04:39,380 --> 01:04:46,000](https://youtu.be/kMghsCXZQ9Y?t=01h04m39s)

bowl back we'll start yet another


[01:04:42,349 --> 01:04:46,000](https://youtu.be/kMghsCXZQ9Y?t=01h04m42s)

terminal so we don't pollute that one


[01:04:54,880 --> 01:05:00,760](https://youtu.be/kMghsCXZQ9Y?t=01h04m54s)

so we'll do our publish again here and


[01:04:57,700 --> 01:05:06,540](https://youtu.be/kMghsCXZQ9Y?t=01h04m57s)

then this turn a little our program


[01:05:00,760 --> 01:05:06,540](https://youtu.be/kMghsCXZQ9Y?t=01h05m00s)

again hard to tell


[01:05:12,090 --> 01:05:20,790](https://youtu.be/kMghsCXZQ9Y?t=01h05m12s)

try it from let's try it from here


[01:05:28,540 --> 01:05:31,350](https://youtu.be/kMghsCXZQ9Y?t=01h05m28s)

hold up


[01:05:33,059 --> 01:05:36,900](https://youtu.be/kMghsCXZQ9Y?t=01h05m33s)

yeah I was gonna say right before you


[01:05:34,919 --> 01:05:39,380](https://youtu.be/kMghsCXZQ9Y?t=01h05m34s)

ran that your publish seemed to go bold


[01:05:36,900 --> 01:05:39,380](https://youtu.be/kMghsCXZQ9Y?t=01h05m36s)

already


[01:05:45,220 --> 01:05:56,369](https://youtu.be/kMghsCXZQ9Y?t=01h05m45s)

interesting


[01:05:47,430 --> 01:05:58,230](https://youtu.be/kMghsCXZQ9Y?t=01h05m47s)

it's weird it's hard to tell it does


[01:05:56,369 --> 01:06:04,670](https://youtu.be/kMghsCXZQ9Y?t=01h05m56s)

feel like whatever terminals inside of


[01:05:58,230 --> 01:06:04,670](https://youtu.be/kMghsCXZQ9Y?t=01h05m58s)

es code might be yeah yep lying to us


[01:06:13,849 --> 01:06:21,569](https://youtu.be/kMghsCXZQ9Y?t=01h06m13s)

well anyway yeah so that's a that's a


[01:06:19,319 --> 01:06:24,779](https://youtu.be/kMghsCXZQ9Y?t=01h06m19s)

great example of having to run through


[01:06:21,569 --> 01:06:27,200](https://youtu.be/kMghsCXZQ9Y?t=01h06m21s)

some of this stuff just to get very lost


[01:06:24,779 --> 01:06:31,519](https://youtu.be/kMghsCXZQ9Y?t=01h06m24s)

and confused and to have issues being


[01:06:27,200 --> 01:06:31,519](https://youtu.be/kMghsCXZQ9Y?t=01h06m27s)

terminal related and not necessarily


[01:06:31,700 --> 01:06:36,420](https://youtu.be/kMghsCXZQ9Y?t=01h06m31s)

console related let's go through John


[01:06:34,499 --> 01:06:38,369](https://youtu.be/kMghsCXZQ9Y?t=01h06m34s)

real quick I think we have a sample in


[01:06:36,420 --> 01:06:44,970](https://youtu.be/kMghsCXZQ9Y?t=01h06m36s)

here that does like the grid or the


[01:06:38,369 --> 01:06:47,700](https://youtu.be/kMghsCXZQ9Y?t=01h06m38s)

table layout yeah it's like a top


[01:06:44,970 --> 01:06:51,210](https://youtu.be/kMghsCXZQ9Y?t=01h06m44s)

equivalent yeah fire that one off if you


[01:06:47,700 --> 01:06:56,279](https://youtu.be/kMghsCXZQ9Y?t=01h06m47s)

don't mind it's that one that one's


[01:06:51,210 --> 01:06:57,900](https://youtu.be/kMghsCXZQ9Y?t=01h06m51s)

probably worth while taking a look at we


[01:06:56,279 --> 01:07:01,319](https://youtu.be/kMghsCXZQ9Y?t=01h06m56s)

can do here now that we actually publish


[01:06:57,900 --> 01:07:07,829](https://youtu.be/kMghsCXZQ9Y?t=01h06m57s)

this thing I can't do this


[01:07:01,319 --> 01:07:09,920](https://youtu.be/kMghsCXZQ9Y?t=01h07m01s)

from dotnet run Oh can't do it from here


[01:07:07,829 --> 01:07:09,920](https://youtu.be/kMghsCXZQ9Y?t=01h07m07s)

either


[01:07:19,690 --> 01:07:23,640](https://youtu.be/kMghsCXZQ9Y?t=01h07m19s)

interesting honestly let's try


[01:07:28,230 --> 01:07:31,650](https://youtu.be/kMghsCXZQ9Y?t=01h07m28s)

completions are not working


[01:07:42,450 --> 01:07:54,100](https://youtu.be/kMghsCXZQ9Y?t=01h07m42s)

okay so that's the scrolling output go


[01:07:46,540 --> 01:07:57,130](https://youtu.be/kMghsCXZQ9Y?t=01h07m46s)

back unable of et you will never get a


[01:07:54,100 --> 01:08:00,359](https://youtu.be/kMghsCXZQ9Y?t=01h07m54s)

parse error from direct specifying a


[01:07:57,130 --> 01:08:00,359](https://youtu.be/kMghsCXZQ9Y?t=01h07m57s)

directive that doesn't actually exist


[01:08:02,670 --> 01:08:09,190](https://youtu.be/kMghsCXZQ9Y?t=01h08m02s)

did I do that right yeah and they will -


[01:08:06,580 --> 01:08:12,960](https://youtu.be/kMghsCXZQ9Y?t=01h08m06s)

VT so we also want to set the output to


[01:08:09,190 --> 01:08:12,960](https://youtu.be/kMghsCXZQ9Y?t=01h08m09s)

answer it's not Auto detecting correctly


[01:08:22,020 --> 01:08:28,140](https://youtu.be/kMghsCXZQ9Y?t=01h08m22s)

it'd be nice if this filtered down to


[01:08:23,700 --> 01:08:30,029](https://youtu.be/kMghsCXZQ9Y?t=01h08m23s)

the you know it was sort of them in some


[01:08:28,140 --> 01:08:33,930](https://youtu.be/kMghsCXZQ9Y?t=01h08m28s)

way according to which at the highest


[01:08:30,029 --> 01:08:37,049](https://youtu.be/kMghsCXZQ9Y?t=01h08m30s)

GPU that would be nice have it bounce


[01:08:33,930 --> 01:08:39,089](https://youtu.be/kMghsCXZQ9Y?t=01h08m33s)

around a little bit I just think that's


[01:08:37,049 --> 01:08:41,819](https://youtu.be/kMghsCXZQ9Y?t=01h08m37s)

yeah so basically this guy is just


[01:08:39,089 --> 01:08:44,520](https://youtu.be/kMghsCXZQ9Y?t=01h08m39s)

grabbing forget how it picks the the


[01:08:41,819 --> 01:08:49,020](https://youtu.be/kMghsCXZQ9Y?t=01h08m41s)

processes but it grabs the top X number


[01:08:44,520 --> 01:08:50,279](https://youtu.be/kMghsCXZQ9Y?t=01h08m44s)

and then goes through and you can see it


[01:08:49,020 --> 01:08:56,160](https://youtu.be/kMghsCXZQ9Y?t=01h08m49s)

outputting the one thing that would be


[01:08:50,279 --> 01:08:57,630](https://youtu.be/kMghsCXZQ9Y?t=01h08m50s)

nice for it to do is also deal with that


[01:08:56,160 --> 01:08:59,640](https://youtu.be/kMghsCXZQ9Y?t=01h08m56s)

because you see the blinking cursor


[01:08:57,630 --> 01:09:01,380](https://youtu.be/kMghsCXZQ9Y?t=01h08m57s)

every time it's effective effectively


[01:08:59,640 --> 01:09:03,989](https://youtu.be/kMghsCXZQ9Y?t=01h08m59s)

going and repainting the screen on an


[01:09:01,380 --> 01:09:08,460](https://youtu.be/kMghsCXZQ9Y?t=01h09m01s)

update yeah because it has to move the


[01:09:03,989 --> 01:09:12,029](https://youtu.be/kMghsCXZQ9Y?t=01h09m03s)

cursor around redraw those areas there


[01:09:08,460 --> 01:09:14,279](https://youtu.be/kMghsCXZQ9Y?t=01h09m08s)

are ansi codes for hiding the cursor and


[01:09:12,029 --> 01:09:16,950](https://youtu.be/kMghsCXZQ9Y?t=01h09m12s)

i think one really nice improvement


[01:09:14,279 --> 01:09:19,410](https://youtu.be/kMghsCXZQ9Y?t=01h09m14s)

would be turning the cursor off do the


[01:09:16,950 --> 01:09:24,839](https://youtu.be/kMghsCXZQ9Y?t=01h09m16s)

redraw turning it back on if it was on


[01:09:19,410 --> 01:09:32,279](https://youtu.be/kMghsCXZQ9Y?t=01h09m19s)

previously yeah yep that's something we


[01:09:24,839 --> 01:09:36,469](https://youtu.be/kMghsCXZQ9Y?t=01h09m24s)

could we could probably do yeah let's


[01:09:32,279 --> 01:09:36,469](https://youtu.be/kMghsCXZQ9Y?t=01h09m32s)

take a crack at it why not all right


[01:09:37,069 --> 01:09:44,690](https://youtu.be/kMghsCXZQ9Y?t=01h09m37s)

let's see so this is the this is the


[01:09:40,980 --> 01:09:49,730](https://youtu.be/kMghsCXZQ9Y?t=01h09m40s)

code here like we also want you


[01:09:44,690 --> 01:09:49,730](https://youtu.be/kMghsCXZQ9Y?t=01h09m44s)

underlined so this is


[01:09:53,079 --> 01:10:00,039](https://youtu.be/kMghsCXZQ9Y?t=01h09m53s)

anyway so weird yeah so where we go here


[01:09:56,000 --> 01:10:02,510](https://youtu.be/kMghsCXZQ9Y?t=01h09m56s)

we want to go into the screen view um


[01:10:00,039 --> 01:10:07,579](https://youtu.be/kMghsCXZQ9Y?t=01h10m00s)

this is you you're testing my memory


[01:10:02,510 --> 01:10:10,130](https://youtu.be/kMghsCXZQ9Y?t=01h10m02s)

it's been so long since I wrote this or


[01:10:07,579 --> 01:10:15,739](https://youtu.be/kMghsCXZQ9Y?t=01h10m07s)

one of these visitors but probably the


[01:10:10,130 --> 01:10:17,030](https://youtu.be/kMghsCXZQ9Y?t=01h10m10s)

auntie visitor right well so let's let's


[01:10:15,739 --> 01:10:18,500](https://youtu.be/kMghsCXZQ9Y?t=01h10m15s)

start at the screen view because I think


[01:10:17,030 --> 01:10:20,300](https://youtu.be/kMghsCXZQ9Y?t=01h10m17s)

that was a good place to start because


[01:10:18,500 --> 01:10:25,699](https://youtu.be/kMghsCXZQ9Y?t=01h10m18s)

that's ultimately what's triggering so


[01:10:20,300 --> 01:10:28,969](https://youtu.be/kMghsCXZQ9Y?t=01h10m20s)

these views they end up working very


[01:10:25,699 --> 01:10:33,170](https://youtu.be/kMghsCXZQ9Y?t=01h10m25s)

similar to the way like a windows form


[01:10:28,969 --> 01:10:37,760](https://youtu.be/kMghsCXZQ9Y?t=01h10m28s)

or a WPF kind of rendering stack works


[01:10:33,170 --> 01:10:39,559](https://youtu.be/kMghsCXZQ9Y?t=01h10m33s)

in that when content changes there's an


[01:10:37,760 --> 01:10:41,630](https://youtu.be/kMghsCXZQ9Y?t=01h10m37s)

invalidation notification that


[01:10:39,559 --> 01:10:44,030](https://youtu.be/kMghsCXZQ9Y?t=01h10m39s)

propagates its way up to the view


[01:10:41,630 --> 01:10:47,420](https://youtu.be/kMghsCXZQ9Y?t=01h10m41s)

hierarchy until it reaches a point where


[01:10:44,030 --> 01:10:49,730](https://youtu.be/kMghsCXZQ9Y?t=01h10m44s)

it knows the the size that it needs to


[01:10:47,420 --> 01:10:51,139](https://youtu.be/kMghsCXZQ9Y?t=01h10m47s)

deal with and usually in most cases it


[01:10:49,730 --> 01:10:54,400](https://youtu.be/kMghsCXZQ9Y?t=01h10m49s)

properly it's just all the way up to the


[01:10:51,139 --> 01:10:57,139](https://youtu.be/kMghsCXZQ9Y?t=01h10m51s)

screen view so you'll notice that that


[01:10:54,400 --> 01:11:00,130](https://youtu.be/kMghsCXZQ9Y?t=01h10m54s)

updated event down there I believe so


[01:10:57,139 --> 01:11:03,139](https://youtu.be/kMghsCXZQ9Y?t=01h10m57s)

jump to the the child updated method


[01:11:00,130 --> 01:11:05,389](https://youtu.be/kMghsCXZQ9Y?t=01h11m00s)

yeah and so this this goes through and


[01:11:03,139 --> 01:11:08,030](https://youtu.be/kMghsCXZQ9Y?t=01h11m03s)

so the same exact problem that you run


[01:11:05,389 --> 01:11:11,119](https://youtu.be/kMghsCXZQ9Y?t=01h11m05s)

into on GUI applications where you can


[01:11:08,030 --> 01:11:13,460](https://youtu.be/kMghsCXZQ9Y?t=01h11m08s)

only have a single thread mucking with


[01:11:11,119 --> 01:11:16,219](https://youtu.be/kMghsCXZQ9Y?t=01h11m11s)

your UI elements at a time this


[01:11:13,460 --> 01:11:18,920](https://youtu.be/kMghsCXZQ9Y?t=01h11m13s)

effectively does the same thing where it


[01:11:16,219 --> 01:11:22,639](https://youtu.be/kMghsCXZQ9Y?t=01h11m16s)

uses the context to switch back to the


[01:11:18,920 --> 01:11:23,869](https://youtu.be/kMghsCXZQ9Y?t=01h11m18s)

UI thread it'll batch up if it gets a


[01:11:22,639 --> 01:11:25,520](https://youtu.be/kMghsCXZQ9Y?t=01h11m22s)

bunch of these updates that comes


[01:11:23,869 --> 01:11:27,590](https://youtu.be/kMghsCXZQ9Y?t=01h11m23s)

through at once so that it only posts a


[01:11:25,520 --> 01:11:30,409](https://youtu.be/kMghsCXZQ9Y?t=01h11m25s)

single render pass and then it calls


[01:11:27,590 --> 01:11:33,469](https://youtu.be/kMghsCXZQ9Y?t=01h11m27s)

render and works its way going back down


[01:11:30,409 --> 01:11:36,320](https://youtu.be/kMghsCXZQ9Y?t=01h11m30s)

the UI stack relaying out the views so I


[01:11:33,469 --> 01:11:41,139](https://youtu.be/kMghsCXZQ9Y?t=01h11m33s)

guess the question comes in where we


[01:11:36,320 --> 01:11:41,139](https://youtu.be/kMghsCXZQ9Y?t=01h11m36s)

want to go about doing this so


[01:11:41,550 --> 01:11:44,820](https://youtu.be/kMghsCXZQ9Y?t=01h11m41s)

because go ahead and jump to like that


[01:11:43,080 --> 01:11:53,330](https://youtu.be/kMghsCXZQ9Y?t=01h11m43s)

child render method that's probably the


[01:11:44,820 --> 01:11:53,330](https://youtu.be/kMghsCXZQ9Y?t=01h11m44s)

closest so like 68 yep there


[01:11:55,239 --> 01:11:58,699](https://youtu.be/kMghsCXZQ9Y?t=01h11m55s)

and this is where it's going to get


[01:11:57,140 --> 01:12:05,500](https://youtu.be/kMghsCXZQ9Y?t=01h11m57s)

interesting because I don't know if we


[01:11:58,699 --> 01:12:10,090](https://youtu.be/kMghsCXZQ9Y?t=01h11m58s)

necessarily have a consistent area well


[01:12:05,500 --> 01:12:10,090](https://youtu.be/kMghsCXZQ9Y?t=01h12m05s)

go ahead and jump into like content view


[01:12:10,870 --> 01:12:15,949](https://youtu.be/kMghsCXZQ9Y?t=01h12m10s)

because we could theoretically I just


[01:12:14,420 --> 01:12:19,699](https://youtu.be/kMghsCXZQ9Y?t=01h12m14s)

wonder if we're gonna get the blinky it


[01:12:15,949 --> 01:12:21,980](https://youtu.be/kMghsCXZQ9Y?t=01h12m15s)

like in that render to region etheric


[01:12:19,699 --> 01:12:25,880](https://youtu.be/kMghsCXZQ9Y?t=01h12m19s)

Lee theoretically wrap that turning the


[01:12:21,980 --> 01:12:27,500](https://youtu.be/kMghsCXZQ9Y?t=01h12m21s)

cursor on and off yep because here we


[01:12:25,880 --> 01:12:34,160](https://youtu.be/kMghsCXZQ9Y?t=01h12m25s)

have all the information that we need as


[01:12:27,500 --> 01:12:36,260](https://youtu.be/kMghsCXZQ9Y?t=01h12m27s)

far as output mode and C etc etc so we


[01:12:34,160 --> 01:12:37,820](https://youtu.be/kMghsCXZQ9Y?t=01h12m34s)

could do it here I just worry that if we


[01:12:36,260 --> 01:12:41,660](https://youtu.be/kMghsCXZQ9Y?t=01h12m36s)

do it here we're effectively turning it


[01:12:37,820 --> 01:12:44,989](https://youtu.be/kMghsCXZQ9Y?t=01h12m37s)

on and off at each of the content views


[01:12:41,660 --> 01:12:46,880](https://youtu.be/kMghsCXZQ9Y?t=01h12m41s)

and so like in that process view there


[01:12:44,989 --> 01:12:49,210](https://youtu.be/kMghsCXZQ9Y?t=01h12m44s)

there's a Content view for each one of


[01:12:46,880 --> 01:12:56,239](https://youtu.be/kMghsCXZQ9Y?t=01h12m46s)

those effectively cells in that table


[01:12:49,210 --> 01:13:01,489](https://youtu.be/kMghsCXZQ9Y?t=01h12m49s)

yeah yeah so I I feel like the the


[01:12:56,239 --> 01:13:03,949](https://youtu.be/kMghsCXZQ9Y?t=01h12m56s)

visitor might be up a place where we can


[01:13:01,489 --> 01:13:06,679](https://youtu.be/kMghsCXZQ9Y?t=01h13m01s)

control this as well so this is where we


[01:13:03,949 --> 01:13:10,489](https://youtu.be/kMghsCXZQ9Y?t=01h13m03s)

you know we sent the cursor to a


[01:13:06,679 --> 01:13:15,670](https://youtu.be/kMghsCXZQ9Y?t=01h13m06s)

specific position first and I think


[01:13:10,489 --> 01:13:18,310](https://youtu.be/kMghsCXZQ9Y?t=01h13m10s)

there's a stop operation on it gotcha


[01:13:15,670 --> 01:13:20,929](https://youtu.be/kMghsCXZQ9Y?t=01h13m15s)

so basically hide it before the set


[01:13:18,310 --> 01:13:26,150](https://youtu.be/kMghsCXZQ9Y?t=01h13m18s)

position and then re-enable it after


[01:13:20,929 --> 01:13:28,100](https://youtu.be/kMghsCXZQ9Y?t=01h13m20s)

we're done maybe yeah although that


[01:13:26,150 --> 01:13:29,540](https://youtu.be/kMghsCXZQ9Y?t=01h13m26s)

would probably enable it yeah that still


[01:13:28,100 --> 01:13:30,949](https://youtu.be/kMghsCXZQ9Y?t=01h13m28s)

doesn't actually capturing the complete


[01:13:29,540 --> 01:13:33,290](https://youtu.be/kMghsCXZQ9Y?t=01h13m29s)

render operation from start to finish


[01:13:30,949 --> 01:13:37,179](https://youtu.be/kMghsCXZQ9Y?t=01h13m30s)

but that that's actually fine though


[01:13:33,290 --> 01:13:40,610](https://youtu.be/kMghsCXZQ9Y?t=01h13m33s)

like if we hide it before we move it


[01:13:37,179 --> 01:13:43,280](https://youtu.be/kMghsCXZQ9Y?t=01h13m37s)

well but if we reenable it after the


[01:13:40,610 --> 01:13:45,260](https://youtu.be/kMghsCXZQ9Y?t=01h13m40s)

right because it won't be back to its


[01:13:43,280 --> 01:13:47,360](https://youtu.be/kMghsCXZQ9Y?t=01h13m43s)

original position yet I suspect we'll


[01:13:45,260 --> 01:13:49,670](https://youtu.be/kMghsCXZQ9Y?t=01h13m45s)

still see the flashing at the end of the


[01:13:47,360 --> 01:13:52,670](https://youtu.be/kMghsCXZQ9Y?t=01h13m47s)

content views so we don't necessarily


[01:13:49,670 --> 01:13:55,989](https://youtu.be/kMghsCXZQ9Y?t=01h13m49s)

see the cursor jump to the beginning but


[01:13:52,670 --> 01:13:55,989](https://youtu.be/kMghsCXZQ9Y?t=01h13m52s)

we might see it at the very end


[01:13:56,780 --> 01:14:04,060](https://youtu.be/kMghsCXZQ9Y?t=01h13m56s)

we could try it let's do it so because


[01:14:02,420 --> 01:14:07,970](https://youtu.be/kMghsCXZQ9Y?t=01h14m02s)

this is just a text output stream


[01:14:04,060 --> 01:14:10,760](https://youtu.be/kMghsCXZQ9Y?t=01h14m04s)

alright we're just writing text out so


[01:14:07,970 --> 01:14:19,400](https://youtu.be/kMghsCXZQ9Y?t=01h14m07s)

this is what the API looks like and all


[01:14:10,760 --> 01:14:22,430](https://youtu.be/kMghsCXZQ9Y?t=01h14m10s)

these cursor things right cursor hide so


[01:14:19,400 --> 01:14:25,430](https://youtu.be/kMghsCXZQ9Y?t=01h14m19s)

you'll see here right the writer it


[01:14:22,430 --> 01:14:27,530](https://youtu.be/kMghsCXZQ9Y?t=01h14m22s)

wants a string cursor hide is an ansi


[01:14:25,430 --> 01:14:30,230](https://youtu.be/kMghsCXZQ9Y?t=01h14m25s)

control code the thing that's


[01:14:27,530 --> 01:14:32,090](https://youtu.be/kMghsCXZQ9Y?t=01h14m27s)

interesting about empty control codes is


[01:14:30,230 --> 01:14:35,870](https://youtu.be/kMghsCXZQ9Y?t=01h14m30s)

that if you to string them I believe


[01:14:32,090 --> 01:14:37,160](https://youtu.be/kMghsCXZQ9Y?t=01h14m32s)

they're just empty and that is one of


[01:14:35,870 --> 01:14:40,160](https://youtu.be/kMghsCXZQ9Y?t=01h14m35s)

the things that enables you to embed


[01:14:37,160 --> 01:14:41,120](https://youtu.be/kMghsCXZQ9Y?t=01h14m37s)

them inside of a interpolated string and


[01:14:40,160 --> 01:14:42,590](https://youtu.be/kMghsCXZQ9Y?t=01h14m40s)

render that string on and they're


[01:14:41,120 --> 01:14:44,540](https://youtu.be/kMghsCXZQ9Y?t=01h14m41s)

actually they're hidden right you


[01:14:42,590 --> 01:14:46,010](https://youtu.be/kMghsCXZQ9Y?t=01h14m42s)

actually need the right renderer to like


[01:14:44,540 --> 01:14:49,520](https://youtu.be/kMghsCXZQ9Y?t=01h14m44s)

what Kevin was saying before is like


[01:14:46,010 --> 01:14:50,870](https://youtu.be/kMghsCXZQ9Y?t=01h14m46s)

tear them apart find the control code


[01:14:49,520 --> 01:14:53,330](https://youtu.be/kMghsCXZQ9Y?t=01h14m49s)

objects that were passed into the


[01:14:50,870 --> 01:14:57,800](https://youtu.be/kMghsCXZQ9Y?t=01h14m50s)

interpolated string and render them on


[01:14:53,330 --> 01:14:59,840](https://youtu.be/kMghsCXZQ9Y?t=01h14m53s)

condition of you know whether you


[01:14:57,800 --> 01:15:01,010](https://youtu.be/kMghsCXZQ9Y?t=01h14m57s)

actually want to render them okay so


[01:14:59,840 --> 01:15:05,510](https://youtu.be/kMghsCXZQ9Y?t=01h14m59s)

that just broke a whole bunch of tests


[01:15:01,010 --> 01:15:08,330](https://youtu.be/kMghsCXZQ9Y?t=01h15m01s)

but that's okay the real questions we do


[01:15:05,510 --> 01:15:11,510](https://youtu.be/kMghsCXZQ9Y?t=01h15m05s)

that and I think I will go back to


[01:15:08,330 --> 01:15:14,360](https://youtu.be/kMghsCXZQ9Y?t=01h15m08s)

dotnet running this thing it's usually a


[01:15:11,510 --> 01:15:29,920](https://youtu.be/kMghsCXZQ9Y?t=01h15m11s)

good idea to do to clean up the publish


[01:15:14,360 --> 01:15:29,920](https://youtu.be/kMghsCXZQ9Y?t=01h15m14s)

folder you got a build error interesting


[01:15:30,130 --> 01:15:36,920](https://youtu.be/kMghsCXZQ9Y?t=01h15m30s)

yeah strange trivia anyway


[01:15:34,390 --> 01:15:38,990](https://youtu.be/kMghsCXZQ9Y?t=01h15m34s)

so what was that command we were doing


[01:15:36,920 --> 01:15:40,250](https://youtu.be/kMghsCXZQ9Y?t=01h15m36s)

along this right but we're going back to


[01:15:38,990 --> 01:15:42,560](https://youtu.be/kMghsCXZQ9Y?t=01h15m38s)

down there Ronna mode so we can make


[01:15:40,250 --> 01:15:44,920](https://youtu.be/kMghsCXZQ9Y?t=01h15m40s)

changes to the code and not to publish


[01:15:42,560 --> 01:15:44,920](https://youtu.be/kMghsCXZQ9Y?t=01h15m42s)

each other


[01:15:55,349 --> 01:16:02,250](https://youtu.be/kMghsCXZQ9Y?t=01h15m55s)

okay so the cursor is the resolution you


[01:16:00,780 --> 01:16:02,760](https://youtu.be/kMghsCXZQ9Y?t=01h16m00s)

know the frame resolution coming through


[01:16:02,250 --> 01:16:05,340](https://youtu.be/kMghsCXZQ9Y?t=01h16m02s)

okay


[01:16:02,760 --> 01:16:06,540](https://youtu.be/kMghsCXZQ9Y?t=01h16m02s)

hey look this looks okay like this it's


[01:16:05,340 --> 01:16:10,710](https://youtu.be/kMghsCXZQ9Y?t=01h16m05s)

still blinking but I don't see it


[01:16:06,540 --> 01:16:12,210](https://youtu.be/kMghsCXZQ9Y?t=01h16m06s)

jumping around as much all right I mean


[01:16:10,710 --> 01:16:14,579](https://youtu.be/kMghsCXZQ9Y?t=01h16m10s)

yeah I'm seeing it at different places


[01:16:12,210 --> 01:16:16,590](https://youtu.be/kMghsCXZQ9Y?t=01h16m12s)

but it is the the places where I'll see


[01:16:14,579 --> 01:16:20,659](https://youtu.be/kMghsCXZQ9Y?t=01h16m14s)

it flash well no there's a couple at the


[01:16:16,590 --> 01:16:20,659](https://youtu.be/kMghsCXZQ9Y?t=01h16m16s)

beginning that didn't solve the problem


[01:16:26,520 --> 01:16:32,340](https://youtu.be/kMghsCXZQ9Y?t=01h16m26s)

interesting because we really don't have


[01:16:30,550 --> 01:16:34,840](https://youtu.be/kMghsCXZQ9Y?t=01h16m30s)

a car


[01:16:32,340 --> 01:16:40,469](https://youtu.be/kMghsCXZQ9Y?t=01h16m32s)

we don't necessarily have a good concept


[01:16:34,840 --> 01:16:53,230](https://youtu.be/kMghsCXZQ9Y?t=01h16m34s)

of where we are in the rendering of this


[01:16:40,469 --> 01:16:54,820](https://youtu.be/kMghsCXZQ9Y?t=01h16m40s)

yeah and the cobble yeah I mean we can


[01:16:53,230 --> 01:16:59,820](https://youtu.be/kMghsCXZQ9Y?t=01h16m53s)

go to the screen view level that'll work


[01:16:54,820 --> 01:17:04,590](https://youtu.be/kMghsCXZQ9Y?t=01h16m54s)

it has it has the new knowledge I guess


[01:16:59,820 --> 01:17:04,590](https://youtu.be/kMghsCXZQ9Y?t=01h16m59s)

because you could wrap that render call


[01:17:06,000 --> 01:17:09,910](https://youtu.be/kMghsCXZQ9Y?t=01h17m06s)

yeah we could do it right here right


[01:17:08,199 --> 01:17:13,210](https://youtu.be/kMghsCXZQ9Y?t=01h17m08s)

through the whole lit the whole


[01:17:09,910 --> 01:17:18,540](https://youtu.be/kMghsCXZQ9Y?t=01h17m09s)

operation or is this one in here no you


[01:17:13,210 --> 01:17:18,540](https://youtu.be/kMghsCXZQ9Y?t=01h17m13s)

want to do it up on the 68 okay


[01:17:28,929 --> 01:17:32,920](https://youtu.be/kMghsCXZQ9Y?t=01h17m28s)

and this is where it gets interesting


[01:17:30,219 --> 01:17:35,340](https://youtu.be/kMghsCXZQ9Y?t=01h17m30s)

because you have to do the render to


[01:17:32,920 --> 01:17:35,340](https://youtu.be/kMghsCXZQ9Y?t=01h17m32s)

region


[01:17:37,730 --> 01:17:45,930](https://youtu.be/kMghsCXZQ9Y?t=01h17m37s)

we can we can do it this way so matter


[01:17:44,580 --> 01:17:48,780](https://youtu.be/kMghsCXZQ9Y?t=01h17m44s)

parse this band


[01:17:45,930 --> 01:17:50,870](https://youtu.be/kMghsCXZQ9Y?t=01h17m45s)

let's return this band we render that to


[01:17:48,780 --> 01:17:50,870](https://youtu.be/kMghsCXZQ9Y?t=01h17m48s)

up


[01:17:59,540 --> 01:18:02,710](https://youtu.be/kMghsCXZQ9Y?t=01h17m59s)

[Music]


[01:18:07,660 --> 01:18:10,819](https://youtu.be/kMghsCXZQ9Y?t=01h18m07s)

[Applause]


[01:18:12,099 --> 01:18:20,290](https://youtu.be/kMghsCXZQ9Y?t=01h18m12s)

can we just go straight to the writer do


[01:18:17,920 --> 01:18:23,199](https://youtu.be/kMghsCXZQ9Y?t=01h18m17s)

we do we have a writer here so inside of


[01:18:20,290 --> 01:18:25,719](https://youtu.be/kMghsCXZQ9Y?t=01h18m20s)

a console renderer there's the icons on


[01:18:23,199 --> 01:18:28,840](https://youtu.be/kMghsCXZQ9Y?t=01h18m23s)

soul I don't think it's exposed anywhere


[01:18:25,719 --> 01:18:33,130](https://youtu.be/kMghsCXZQ9Y?t=01h18m25s)

though I mean you could do render to


[01:18:28,840 --> 01:18:35,280](https://youtu.be/kMghsCXZQ9Y?t=01h18m28s)

region you know this also does a bunch


[01:18:33,130 --> 01:18:35,280](https://youtu.be/kMghsCXZQ9Y?t=01h18m33s)

of stuff


[01:18:37,289 --> 01:18:43,199](https://youtu.be/kMghsCXZQ9Y?t=01h18m37s)

yeah that does do a bunch of stuff I


[01:18:40,550 --> 01:18:45,690](https://youtu.be/kMghsCXZQ9Y?t=01h18m40s)

kinda want to I think the cleanest thing


[01:18:43,199 --> 01:18:49,039](https://youtu.be/kMghsCXZQ9Y?t=01h18m43s)

we can do just as an experiment is just


[01:18:45,690 --> 01:18:49,039](https://youtu.be/kMghsCXZQ9Y?t=01h18m45s)

render it straight to a console


[01:18:54,500 --> 01:18:58,610](https://youtu.be/kMghsCXZQ9Y?t=01h18m54s)

we can I mean as an experiment right now


[01:18:56,660 --> 01:19:02,480](https://youtu.be/kMghsCXZQ9Y?t=01h18m56s)

we can certainly just expose the console


[01:18:58,610 --> 01:19:04,810](https://youtu.be/kMghsCXZQ9Y?t=01h18m58s)

here because we do have it that is let's


[01:19:02,480 --> 01:19:04,810](https://youtu.be/kMghsCXZQ9Y?t=01h19m02s)

just do that


[01:19:10,650 --> 01:19:15,800](https://youtu.be/kMghsCXZQ9Y?t=01h19m10s)

and maybe just for as an API thought


[01:19:16,619 --> 01:19:21,659](https://youtu.be/kMghsCXZQ9Y?t=01h19m16s)

there it does seem that there's kind of


[01:19:18,989 --> 01:19:26,670](https://youtu.be/kMghsCXZQ9Y?t=01h19m18s)

this like I realized NC 100 does it with


[01:19:21,659 --> 01:19:31,099](https://youtu.be/kMghsCXZQ9Y?t=01h19m21s)

control code outputs but perhaps we


[01:19:26,670 --> 01:19:34,679](https://youtu.be/kMghsCXZQ9Y?t=01h19m26s)

don't necessarily expose it the same way


[01:19:31,099 --> 01:19:36,210](https://youtu.be/kMghsCXZQ9Y?t=01h19m31s)

yeah because it feels like if I wanted


[01:19:34,679 --> 01:19:38,340](https://youtu.be/kMghsCXZQ9Y?t=01h19m34s)

to code against this what I really want


[01:19:36,210 --> 01:19:41,429](https://youtu.be/kMghsCXZQ9Y?t=01h19m36s)

to do is have something where you know


[01:19:38,340 --> 01:19:43,530](https://youtu.be/kMghsCXZQ9Y?t=01h19m38s)

hide cursor show cursor or better yet


[01:19:41,429 --> 01:19:52,800](https://youtu.be/kMghsCXZQ9Y?t=01h19m41s)

something that gives me an idol that I


[01:19:43,530 --> 01:19:54,150](https://youtu.be/kMghsCXZQ9Y?t=01h19m43s)

can act on yeah so here so now we just


[01:19:52,800 --> 01:19:58,710](https://youtu.be/kMghsCXZQ9Y?t=01h19m52s)

back the string value right so we just


[01:19:54,150 --> 01:20:04,219](https://youtu.be/kMghsCXZQ9Y?t=01h19m54s)

go grab the cursor hide directly and


[01:19:58,710 --> 01:20:07,660](https://youtu.be/kMghsCXZQ9Y?t=01h19m58s)

right escape sequence see what that good


[01:20:04,219 --> 01:20:10,760](https://youtu.be/kMghsCXZQ9Y?t=01h20m04s)

let's rename it at the end


[01:20:07,660 --> 01:20:10,760](https://youtu.be/kMghsCXZQ9Y?t=01h20m07s)

[Music]


[01:20:13,419 --> 01:20:17,530](https://youtu.be/kMghsCXZQ9Y?t=01h20m13s)

because that I would still expect to see


[01:20:15,729 --> 01:20:19,239](https://youtu.be/kMghsCXZQ9Y?t=01h20m15s)

a flash if we reenable it but I would


[01:20:17,530 --> 01:20:22,260](https://youtu.be/kMghsCXZQ9Y?t=01h20m17s)

expect the flash to remain in the Bott


[01:20:19,239 --> 01:20:22,260](https://youtu.be/kMghsCXZQ9Y?t=01h20m19s)

bottom right-hand corner


[01:20:27,390 --> 01:20:30,969](https://youtu.be/kMghsCXZQ9Y?t=01h20m27s)

because it is worth noting that when you


[01:20:29,530 --> 01:20:39,070](https://youtu.be/kMghsCXZQ9Y?t=01h20m29s)

use the screen view it does effectively


[01:20:30,969 --> 01:20:40,750](https://youtu.be/kMghsCXZQ9Y?t=01h20m30s)

clear the screen yeah hey oh yeah that


[01:20:39,070 --> 01:20:42,460](https://youtu.be/kMghsCXZQ9Y?t=01h20m39s)

blooming better it's also showing that


[01:20:40,750 --> 01:20:43,780](https://youtu.be/kMghsCXZQ9Y?t=01h20m40s)

we didn't break any tests which means


[01:20:42,460 --> 01:20:50,890](https://youtu.be/kMghsCXZQ9Y?t=01h20m42s)

that we don't have tests for the screen


[01:20:43,780 --> 01:20:52,180](https://youtu.be/kMghsCXZQ9Y?t=01h20m43s)

view I'm guessing there are technically


[01:20:50,890 --> 01:20:58,630](https://youtu.be/kMghsCXZQ9Y?t=01h20m50s)

tests for the screen view but they


[01:20:52,180 --> 01:21:00,070](https://youtu.be/kMghsCXZQ9Y?t=01h20m52s)

clearly are not that specific yeah well


[01:20:58,630 --> 01:21:01,450](https://youtu.be/kMghsCXZQ9Y?t=01h20m58s)

if we I think it's an area where if we


[01:21:00,070 --> 01:21:02,469](https://youtu.be/kMghsCXZQ9Y?t=01h21m00s)

don't know what's the right day a lot of


[01:21:01,450 --> 01:21:04,420](https://youtu.be/kMghsCXZQ9Y?t=01h21m01s)

times with the rendering steps you kind


[01:21:02,469 --> 01:21:07,750](https://youtu.be/kMghsCXZQ9Y?t=01h21m02s)

of have to experiment figure out what


[01:21:04,420 --> 01:21:09,489](https://youtu.be/kMghsCXZQ9Y?t=01h21m04s)

gives you the right effect and then


[01:21:07,750 --> 01:21:10,870](https://youtu.be/kMghsCXZQ9Y?t=01h21m07s)

encode that into a task to pin the page


[01:21:09,489 --> 01:21:13,660](https://youtu.be/kMghsCXZQ9Y?t=01h21m09s)

that the behavior in place you know


[01:21:10,870 --> 01:21:15,400](https://youtu.be/kMghsCXZQ9Y?t=01h21m10s)

right so it's fair that we don't have


[01:21:13,660 --> 01:21:17,680](https://youtu.be/kMghsCXZQ9Y?t=01h21m13s)

tasks here who we're figuring out what's


[01:21:15,400 --> 01:21:19,480](https://youtu.be/kMghsCXZQ9Y?t=01h21m15s)

the right way to do this right well and


[01:21:17,680 --> 01:21:22,780](https://youtu.be/kMghsCXZQ9Y?t=01h21m17s)

I think the tests that are on there are


[01:21:19,480 --> 01:21:24,250](https://youtu.be/kMghsCXZQ9Y?t=01h21m19s)

more about does it call child render


[01:21:22,780 --> 01:21:27,580](https://youtu.be/kMghsCXZQ9Y?t=01h21m22s)

with the right stuff I don't think it's


[01:21:24,250 --> 01:21:29,410](https://youtu.be/kMghsCXZQ9Y?t=01h21m24s)

actually testing any sort of output yes


[01:21:27,580 --> 01:21:31,210](https://youtu.be/kMghsCXZQ9Y?t=01h21m27s)

I don't think the unit tests that you go


[01:21:29,410 --> 01:21:34,210](https://youtu.be/kMghsCXZQ9Y?t=01h21m29s)

through screen view actually get all the


[01:21:31,210 --> 01:21:38,560](https://youtu.be/kMghsCXZQ9Y?t=01h21m31s)

way down to doing any sort of rendering


[01:21:34,210 --> 01:21:41,790](https://youtu.be/kMghsCXZQ9Y?t=01h21m34s)

I think it's more less just pinning the


[01:21:38,560 --> 01:21:41,790](https://youtu.be/kMghsCXZQ9Y?t=01h21m38s)

interaction between the objects


[01:21:46,989 --> 01:21:52,870](https://youtu.be/kMghsCXZQ9Y?t=01h21m46s)

so now I moved the restoring of the


[01:21:50,530 --> 01:21:54,280](https://youtu.be/kMghsCXZQ9Y?t=01h21m50s)

cursor to the disposal of the screen


[01:21:52,870 --> 01:21:55,630](https://youtu.be/kMghsCXZQ9Y?t=01h21m52s)

view so now it's hidden for the entire


[01:21:54,280 --> 01:21:57,660](https://youtu.be/kMghsCXZQ9Y?t=01h21m54s)

life of the screen because in the screen


[01:21:55,630 --> 01:21:59,800](https://youtu.be/kMghsCXZQ9Y?t=01h21m55s)

you takes over the screen


[01:21:57,660 --> 01:22:01,420](https://youtu.be/kMghsCXZQ9Y?t=01h21m57s)

maybe we just maybe there's no point in


[01:21:59,800 --> 01:22:05,860](https://youtu.be/kMghsCXZQ9Y?t=01h21m59s)

ever showing a cursor until we kill them


[01:22:01,420 --> 01:22:09,040](https://youtu.be/kMghsCXZQ9Y?t=01h22m01s)

kill the screen view then it so I kind


[01:22:05,860 --> 01:22:13,780](https://youtu.be/kMghsCXZQ9Y?t=01h22m05s)

of agree with that but that only makes


[01:22:09,040 --> 01:22:15,100](https://youtu.be/kMghsCXZQ9Y?t=01h22m09s)

so because it only makes sense if the


[01:22:13,780 --> 01:22:17,440](https://youtu.be/kMghsCXZQ9Y?t=01h22m13s)

screen view is going to be doing


[01:22:15,100 --> 01:22:21,610](https://youtu.be/kMghsCXZQ9Y?t=01h22m15s)

updating and the screen view doesn't


[01:22:17,440 --> 01:22:23,950](https://youtu.be/kMghsCXZQ9Y?t=01h22m17s)

know if it's doing updating until a


[01:22:21,610 --> 01:22:25,930](https://youtu.be/kMghsCXZQ9Y?t=01h22m21s)

child view raises that update event


[01:22:23,950 --> 01:22:27,760](https://youtu.be/kMghsCXZQ9Y?t=01h22m23s)

because it could be that somebody uses a


[01:22:25,930 --> 01:22:29,260](https://youtu.be/kMghsCXZQ9Y?t=01h22m25s)

screen view to just lay it out and then


[01:22:27,760 --> 01:22:32,620](https://youtu.be/kMghsCXZQ9Y?t=01h22m27s)

they expect you know the user to type


[01:22:29,260 --> 01:22:36,670](https://youtu.be/kMghsCXZQ9Y?t=01h22m29s)

something in even we don't have an info


[01:22:32,620 --> 01:22:38,440](https://youtu.be/kMghsCXZQ9Y?t=01h22m32s)

mode right now but yeah assuming that we


[01:22:36,670 --> 01:22:40,030](https://youtu.be/kMghsCXZQ9Y?t=01h22m36s)

that's sort of a different thing is


[01:22:38,440 --> 01:22:41,920](https://youtu.be/kMghsCXZQ9Y?t=01h22m38s)

coordinating the screen view based on


[01:22:40,030 --> 01:22:44,050](https://youtu.be/kMghsCXZQ9Y?t=01h22m40s)

input but right now with the screen do


[01:22:41,920 --> 01:22:47,880](https://youtu.be/kMghsCXZQ9Y?t=01h22m41s)

screen me does it really renders a non


[01:22:44,050 --> 01:22:50,350](https://youtu.be/kMghsCXZQ9Y?t=01h22m44s)

interactive view that is true


[01:22:47,880 --> 01:22:51,910](https://youtu.be/kMghsCXZQ9Y?t=01h22m47s)

interactivity is a bit more complex and


[01:22:50,350 --> 01:22:58,120](https://youtu.be/kMghsCXZQ9Y?t=01h22m50s)

we we kind of left it out of scope for


[01:22:51,910 --> 01:22:59,440](https://youtu.be/kMghsCXZQ9Y?t=01h22m51s)

the moment right because we figured you


[01:22:58,120 --> 01:23:00,370](https://youtu.be/kMghsCXZQ9Y?t=01h22m58s)

know before you can have interactivity


[01:22:59,440 --> 01:23:05,880](https://youtu.be/kMghsCXZQ9Y?t=01h22m59s)

you've got to have a good rendering


[01:23:00,370 --> 01:23:08,590](https://youtu.be/kMghsCXZQ9Y?t=01h23m00s)

experience in any case that is true I


[01:23:05,880 --> 01:23:10,840](https://youtu.be/kMghsCXZQ9Y?t=01h23m05s)

think that's a fair thing is like this


[01:23:08,590 --> 01:23:15,010](https://youtu.be/kMghsCXZQ9Y?t=01h23m08s)

definitely won't work for interactive


[01:23:10,840 --> 01:23:22,380](https://youtu.be/kMghsCXZQ9Y?t=01h23m10s)

mode and also my cursor there my cursor


[01:23:15,010 --> 01:23:22,380](https://youtu.be/kMghsCXZQ9Y?t=01h23m15s)

okay I thought it was gone forever


[01:23:25,020 --> 01:23:30,280](https://youtu.be/kMghsCXZQ9Y?t=01h23m25s)

yeah I mean if we want to go through


[01:23:27,190 --> 01:23:32,620](https://youtu.be/kMghsCXZQ9Y?t=01h23m27s)

okay so I think that's probably a fair


[01:23:30,280 --> 01:23:35,860](https://youtu.be/kMghsCXZQ9Y?t=01h23m30s)

assertion to have it hide the cursor for


[01:23:32,620 --> 01:23:37,690](https://youtu.be/kMghsCXZQ9Y?t=01h23m32s)

now yep I think then the question


[01:23:35,860 --> 01:23:39,610](https://youtu.be/kMghsCXZQ9Y?t=01h23m35s)

becomes how should the screen view get


[01:23:37,690 --> 01:23:41,950](https://youtu.be/kMghsCXZQ9Y?t=01h23m37s)

access to that console because exposing


[01:23:39,610 --> 01:23:42,600](https://youtu.be/kMghsCXZQ9Y?t=01h23m39s)

it via the render is not the right


[01:23:41,950 --> 01:23:45,460](https://youtu.be/kMghsCXZQ9Y?t=01h23m41s)

answer


[01:23:42,600 --> 01:23:47,110](https://youtu.be/kMghsCXZQ9Y?t=01h23m42s)

well we gotta pass it indirectly if the


[01:23:45,460 --> 01:23:50,969](https://youtu.be/kMghsCXZQ9Y?t=01h23m45s)

screen view needs back up to the console


[01:23:47,110 --> 01:23:56,250](https://youtu.be/kMghsCXZQ9Y?t=01h23m47s)

that you just have a console sure


[01:23:50,969 --> 01:23:56,250](https://youtu.be/kMghsCXZQ9Y?t=01h23m50s)

probably simpler yeah let's do that


[01:24:03,480 --> 01:24:07,170](https://youtu.be/kMghsCXZQ9Y?t=01h24m03s)

this will break test


[01:24:27,380 --> 01:24:31,849](https://youtu.be/kMghsCXZQ9Y?t=01h24m27s)

this will break compilation first I


[01:24:34,010 --> 01:24:42,079](https://youtu.be/kMghsCXZQ9Y?t=01h24m34s)

think in every single case we're going


[01:24:36,090 --> 01:24:42,079](https://youtu.be/kMghsCXZQ9Y?t=01h24m36s)

to have a console near at hand I hope


[01:24:42,280 --> 01:24:46,840](https://youtu.be/kMghsCXZQ9Y?t=01h24m42s)

the test terminal which we can test


[01:24:44,740 --> 01:24:49,090](https://youtu.be/kMghsCXZQ9Y?t=01h24m44s)

terminal so test terminal implements I


[01:24:46,840 --> 01:24:52,020](https://youtu.be/kMghsCXZQ9Y?t=01h24m46s)

console because terminal implements I


[01:24:49,090 --> 01:24:52,020](https://youtu.be/kMghsCXZQ9Y?t=01h24m49s)

console


[01:24:53,050 --> 01:24:57,320](https://youtu.be/kMghsCXZQ9Y?t=01h24m53s)

[Applause]


[01:24:56,590 --> 01:24:59,820](https://youtu.be/kMghsCXZQ9Y?t=01h24m56s)

[Music]


[01:24:57,320 --> 01:25:02,740](https://youtu.be/kMghsCXZQ9Y?t=01h24m57s)

[Applause]


[01:24:59,820 --> 01:25:04,330](https://youtu.be/kMghsCXZQ9Y?t=01h24m59s)

we shouldn't smoke


[01:25:02,740 --> 01:25:08,330](https://youtu.be/kMghsCXZQ9Y?t=01h25m02s)

[Music]


[01:25:04,330 --> 01:25:13,680](https://youtu.be/kMghsCXZQ9Y?t=01h25m04s)

[Applause]


[01:25:08,330 --> 01:25:19,359](https://youtu.be/kMghsCXZQ9Y?t=01h25m08s)

why was there a second complaint nothing


[01:25:13,680 --> 01:25:19,359](https://youtu.be/kMghsCXZQ9Y?t=01h25m13s)

[Applause]


[01:25:22,650 --> 01:25:25,860](https://youtu.be/kMghsCXZQ9Y?t=01h25m22s)

[Applause]


[01:25:26,670 --> 01:25:30,820](https://youtu.be/kMghsCXZQ9Y?t=01h25m26s)

hey John are the fans on your computer


[01:25:29,199 --> 01:25:34,000](https://youtu.be/kMghsCXZQ9Y?t=01h25m29s)

firing up right now by any chance oh


[01:25:30,820 --> 01:25:36,810](https://youtu.be/kMghsCXZQ9Y?t=01h25m30s)

yeah that's the back feeding noise that


[01:25:34,000 --> 01:25:36,810](https://youtu.be/kMghsCXZQ9Y?t=01h25m34s)

I'm getting on your mic


[01:26:05,320 --> 01:26:09,630](https://youtu.be/kMghsCXZQ9Y?t=01h26m05s)

see there are tests on screen view


[01:26:17,719 --> 01:26:28,579](https://youtu.be/kMghsCXZQ9Y?t=01h26m17s)

the thing that I often like to bring up


[01:26:21,709 --> 01:26:31,939](https://youtu.be/kMghsCXZQ9Y?t=01h26m21s)

here I'll see ya see these builders that


[01:26:28,579 --> 01:26:34,360](https://youtu.be/kMghsCXZQ9Y?t=01h26m28s)

could publish thing before I think I


[01:26:31,939 --> 01:26:34,360](https://youtu.be/kMghsCXZQ9Y?t=01h26m31s)

need to clear up


[01:26:57,630 --> 01:27:05,390](https://youtu.be/kMghsCXZQ9Y?t=01h26m57s)

oh well this one's pretty simple it's


[01:27:01,410 --> 01:27:05,390](https://youtu.be/kMghsCXZQ9Y?t=01h27m01s)

just invocation context console


[01:27:07,760 --> 01:27:11,630](https://youtu.be/kMghsCXZQ9Y?t=01h27m07s)

yep so the invocation context was passed


[01:27:10,070 --> 01:27:14,500](https://youtu.be/kMghsCXZQ9Y?t=01h27m10s)

into the dragon for entry point here


[01:27:11,630 --> 01:27:16,820](https://youtu.be/kMghsCXZQ9Y?t=01h27m11s)

because we asked for it to be kind of a


[01:27:14,500 --> 01:27:20,810](https://youtu.be/kMghsCXZQ9Y?t=01h27m14s)

you know system console system about


[01:27:16,820 --> 01:27:22,790](https://youtu.be/kMghsCXZQ9Y?t=01h27m16s)

command line types are available yeah in


[01:27:20,810 --> 01:27:25,510](https://youtu.be/kMghsCXZQ9Y?t=01h27m20s)

your command handlers that was one thing


[01:27:22,790 --> 01:27:29,239](https://youtu.be/kMghsCXZQ9Y?t=01h27m22s)

that I ran into at work the other day is


[01:27:25,510 --> 01:27:31,190](https://youtu.be/kMghsCXZQ9Y?t=01h27m25s)

we don't have a good list of what all


[01:27:29,239 --> 01:27:34,190](https://youtu.be/kMghsCXZQ9Y?t=01h27m29s)

the magical types are that you can ask


[01:27:31,190 --> 01:27:35,720](https://youtu.be/kMghsCXZQ9Y?t=01h27m31s)

for your command handler outside of the


[01:27:34,190 --> 01:27:37,660](https://youtu.be/kMghsCXZQ9Y?t=01h27m34s)

unit test that was the closest place


[01:27:35,720 --> 01:27:43,310](https://youtu.be/kMghsCXZQ9Y?t=01h27m35s)

where I could find a reasonable list


[01:27:37,660 --> 01:27:45,380](https://youtu.be/kMghsCXZQ9Y?t=01h27m37s)

yeah yeah I kind of started that a


[01:27:43,310 --> 01:27:47,120](https://youtu.be/kMghsCXZQ9Y?t=01h27m43s)

little bit with the interactive tutorial


[01:27:45,380 --> 01:27:50,390](https://youtu.be/kMghsCXZQ9Y?t=01h27m45s)

that I've pushed the other day that's


[01:27:47,120 --> 01:27:51,830](https://youtu.be/kMghsCXZQ9Y?t=01h27m47s)

true I did not look there but it still


[01:27:50,390 --> 01:27:53,450](https://youtu.be/kMghsCXZQ9Y?t=01h27m50s)

it's not like a it's not a good


[01:27:51,830 --> 01:27:56,600](https://youtu.be/kMghsCXZQ9Y?t=01h27m51s)

reference material you know it's more of


[01:27:53,450 --> 01:27:58,640](https://youtu.be/kMghsCXZQ9Y?t=01h27m53s)

a tutorial right I was thinking


[01:27:56,600 --> 01:28:00,670](https://youtu.be/kMghsCXZQ9Y?t=01h27m56s)

somewhere where we list out like the the


[01:27:58,640 --> 01:28:04,820](https://youtu.be/kMghsCXZQ9Y?t=01h27m58s)

dragonfruit command handlers or


[01:28:00,670 --> 01:28:06,770](https://youtu.be/kMghsCXZQ9Y?t=01h28m00s)

something just to call out of hey by the


[01:28:04,820 --> 01:28:08,360](https://youtu.be/kMghsCXZQ9Y?t=01h28m04s)

way here's the extra magical parameter


[01:28:06,770 --> 01:28:10,660](https://youtu.be/kMghsCXZQ9Y?t=01h28m06s)

types you can ask for and we'll pass


[01:28:08,360 --> 01:28:10,660](https://youtu.be/kMghsCXZQ9Y?t=01h28m08s)

them in


[01:28:13,790 --> 01:28:20,850](https://youtu.be/kMghsCXZQ9Y?t=01h28m13s)

okay I see it gotta go all the way over


[01:28:15,900 --> 01:28:27,450](https://youtu.be/kMghsCXZQ9Y?t=01h28m15s)

here and this is this build error is the


[01:28:20,850 --> 01:28:30,830](https://youtu.be/kMghsCXZQ9Y?t=01h28m20s)

one that's because I published it you'll


[01:28:27,450 --> 01:28:34,710](https://youtu.be/kMghsCXZQ9Y?t=01h28m27s)

always see this it's because of the


[01:28:30,830 --> 01:28:36,810](https://youtu.be/kMghsCXZQ9Y?t=01h28m30s)

dotnet core and puts it after so


[01:28:34,710 --> 01:28:40,340](https://youtu.be/kMghsCXZQ9Y?t=01h28m34s)

implicit at the implicit SDK burring


[01:28:36,810 --> 01:28:40,340](https://youtu.be/kMghsCXZQ9Y?t=01h28m36s)

it's locked in place when you publish


[01:28:44,120 --> 01:28:47,580](https://youtu.be/kMghsCXZQ9Y?t=01h28m44s)

and on that clean apparently does not


[01:28:46,500 --> 01:28:55,020](https://youtu.be/kMghsCXZQ9Y?t=01h28m46s)

wipe it out


[01:28:47,580 --> 01:28:57,170](https://youtu.be/kMghsCXZQ9Y?t=01h28m47s)

how's it look this is aggressive when in


[01:28:55,020 --> 01:28:57,170](https://youtu.be/kMghsCXZQ9Y?t=01h28m55s)

doubt


[01:29:06,079 --> 01:29:11,750](https://youtu.be/kMghsCXZQ9Y?t=01h29m06s)

and the reason I'm starting just a


[01:29:09,320 --> 01:29:13,460](https://youtu.be/kMghsCXZQ9Y?t=01h29m09s)

command-line solution from the terminal


[01:29:11,750 --> 01:29:17,059](https://youtu.be/kMghsCXZQ9Y?t=01h29m11s)

again is because of that power shot


[01:29:13,460 --> 01:29:18,469](https://youtu.be/kMghsCXZQ9Y?t=01h29m13s)

environment variable so that you can


[01:29:17,059 --> 01:29:22,400](https://youtu.be/kMghsCXZQ9Y?t=01h29m17s)

make sure that you pick it up inside of


[01:29:18,469 --> 01:29:23,809](https://youtu.be/kMghsCXZQ9Y?t=01h29m18s)

this session cool everything should work


[01:29:22,400 --> 01:29:25,579](https://youtu.be/kMghsCXZQ9Y?t=01h29m22s)

fine like if you're use if you don't


[01:29:23,809 --> 01:29:28,010](https://youtu.be/kMghsCXZQ9Y?t=01h29m23s)

disable arcade everything will work fine


[01:29:25,579 --> 01:29:30,230](https://youtu.be/kMghsCXZQ9Y?t=01h29m25s)

the certain tooling might be broken a


[01:29:28,010 --> 01:29:34,750](https://youtu.be/kMghsCXZQ9Y?t=01h29m28s)

specific tool in this case that it will


[01:29:30,230 --> 01:29:37,520](https://youtu.be/kMghsCXZQ9Y?t=01h29m30s)

interfere with and then crunch and


[01:29:34,750 --> 01:29:39,050](https://youtu.be/kMghsCXZQ9Y?t=01h29m34s)

crunch does not like the arcade redirect


[01:29:37,520 --> 01:29:41,659](https://youtu.be/kMghsCXZQ9Y?t=01h29m37s)

all of the build outputs into an


[01:29:39,050 --> 01:29:43,340](https://youtu.be/kMghsCXZQ9Y?t=01h29m39s)

artifact folder and end crunch does not


[01:29:41,659 --> 01:29:46,699](https://youtu.be/kMghsCXZQ9Y?t=01h29m41s)

seem to know how to follow it over there


[01:29:43,340 --> 01:29:48,710](https://youtu.be/kMghsCXZQ9Y?t=01h29m43s)

so if you like your build outputs to be


[01:29:46,699 --> 01:29:59,590](https://youtu.be/kMghsCXZQ9Y?t=01h29m46s)

in the normal bin and object olders


[01:29:48,710 --> 01:29:59,590](https://youtu.be/kMghsCXZQ9Y?t=01h29m48s)

underneath each project disabling ok now


[01:30:00,340 --> 01:30:05,030](https://youtu.be/kMghsCXZQ9Y?t=01h30m00s)

the other thing that happened of course


[01:30:02,239 --> 01:30:08,420](https://youtu.be/kMghsCXZQ9Y?t=01h30m02s)

is that unconcious not disabled because


[01:30:05,030 --> 01:30:14,559](https://youtu.be/kMghsCXZQ9Y?t=01h30m05s)

i wiped out n crunch file line to get


[01:30:08,420 --> 01:30:14,559](https://youtu.be/kMghsCXZQ9Y?t=01h30m08s)

clean build looks good


[01:30:34,280 --> 01:30:39,670](https://youtu.be/kMghsCXZQ9Y?t=01h30m34s)

with the top of benchmarks


[01:30:37,540 --> 01:30:42,960](https://youtu.be/kMghsCXZQ9Y?t=01h30m37s)

oh that's right we did get those that it


[01:30:39,670 --> 01:30:42,960](https://youtu.be/kMghsCXZQ9Y?t=01h30m39s)

didn't work yeah


[01:30:43,869 --> 01:30:49,229](https://youtu.be/kMghsCXZQ9Y?t=01h30m43s)

and second crunch love the benchmark


[01:30:46,449 --> 01:30:49,229](https://youtu.be/kMghsCXZQ9Y?t=01h30m46s)

projects very much


[01:30:49,510 --> 01:30:52,669](https://youtu.be/kMghsCXZQ9Y?t=01h30m49s)

[Applause]


[01:30:59,180 --> 01:31:02,270](https://youtu.be/kMghsCXZQ9Y?t=01h30m59s)

[Applause]


[01:31:06,020 --> 01:31:09,969](https://youtu.be/kMghsCXZQ9Y?t=01h31m06s)

disable attachments


[01:31:35,539 --> 01:31:39,579](https://youtu.be/kMghsCXZQ9Y?t=01h31m35s)

yeah absolutely they're little tips and


[01:31:37,489 --> 01:31:39,579](https://youtu.be/kMghsCXZQ9Y?t=01h31m37s)

tricks


[01:32:04,419 --> 01:32:09,219](https://youtu.be/kMghsCXZQ9Y?t=01h32m04s)

did you maybe I missed it did you stash


[01:32:07,570 --> 01:32:11,739](https://youtu.be/kMghsCXZQ9Y?t=01h32m07s)

the current work before you did the Klan


[01:32:09,219 --> 01:32:16,769](https://youtu.be/kMghsCXZQ9Y?t=01h32m09s)

or did you just clean what FDX


[01:32:11,739 --> 01:32:16,769](https://youtu.be/kMghsCXZQ9Y?t=01h32m11s)

there were no added file so got it


[01:32:22,389 --> 01:32:29,679](https://youtu.be/kMghsCXZQ9Y?t=01h32m22s)

oh it always one get statics before


[01:32:25,090 --> 01:32:32,020](https://youtu.be/kMghsCXZQ9Y?t=01h32m25s)

letting get clean I've got a couple


[01:32:29,679 --> 01:32:33,880](https://youtu.be/kMghsCXZQ9Y?t=01h32m29s)

projects where we've got like developer


[01:32:32,020 --> 01:32:37,300](https://youtu.be/kMghsCXZQ9Y?t=01h32m32s)

config files that aren't checked in and


[01:32:33,880 --> 01:32:39,190](https://youtu.be/kMghsCXZQ9Y?t=01h32m33s)

yeah get clean always wipes them out and


[01:32:37,300 --> 01:32:42,480](https://youtu.be/kMghsCXZQ9Y?t=01h32m37s)

so I've learned I just need to keep a


[01:32:39,190 --> 01:32:47,619](https://youtu.be/kMghsCXZQ9Y?t=01h32m39s)

backup copy sitting off outside the repo


[01:32:42,480 --> 01:32:49,060](https://youtu.be/kMghsCXZQ9Y?t=01h32m42s)

yeah I actually did recover a bunch of


[01:32:47,619 --> 01:32:55,090](https://youtu.be/kMghsCXZQ9Y?t=01h32m47s)

stuff that I wiped out you then get


[01:32:49,060 --> 01:32:56,830](https://youtu.be/kMghsCXZQ9Y?t=01h32m49s)

clean recently it came there are there


[01:32:55,090 --> 01:33:00,369](https://youtu.be/kMghsCXZQ9Y?t=01h32m55s)

cases in which you can recover stuff


[01:32:56,830 --> 01:33:03,610](https://youtu.be/kMghsCXZQ9Y?t=01h32m56s)

that was wiped that would get clean ever


[01:33:00,369 --> 01:33:07,060](https://youtu.be/kMghsCXZQ9Y?t=01h33m00s)

from what just like a file deletion


[01:33:03,610 --> 01:33:09,460](https://youtu.be/kMghsCXZQ9Y?t=01h33m03s)

utility or no like the act if you've


[01:33:07,060 --> 01:33:12,460](https://youtu.be/kMghsCXZQ9Y?t=01h33m07s)

ever committed them at all then you can


[01:33:09,460 --> 01:33:17,199](https://youtu.be/kMghsCXZQ9Y?t=01h33m09s)

find references to them in your github


[01:33:12,460 --> 01:33:18,580](https://youtu.be/kMghsCXZQ9Y?t=01h33m12s)

repository or git repository it's a pain


[01:33:17,199 --> 01:33:21,040](https://youtu.be/kMghsCXZQ9Y?t=01h33m17s)

in the butt you basically dep don't like


[01:33:18,580 --> 01:33:28,210](https://youtu.be/kMghsCXZQ9Y?t=01h33m18s)

to go and you know plug through history


[01:33:21,040 --> 01:33:29,679](https://youtu.be/kMghsCXZQ9Y?t=01h33m21s)

for find files yeah yeah just give you


[01:33:28,210 --> 01:33:31,300](https://youtu.be/kMghsCXZQ9Y?t=01h33m28s)

like a list of goods and then you have


[01:33:29,679 --> 01:33:32,949](https://youtu.be/kMghsCXZQ9Y?t=01h33m29s)

to ask it for each one of those goods to


[01:33:31,300 --> 01:33:34,630](https://youtu.be/kMghsCXZQ9Y?t=01h33m31s)

show what the dips are and then you need


[01:33:32,949 --> 01:33:36,179](https://youtu.be/kMghsCXZQ9Y?t=01h33m32s)

to extract the dips out and manually and


[01:33:34,630 --> 01:33:38,139](https://youtu.be/kMghsCXZQ9Y?t=01h33m34s)

apply them back to your files but


[01:33:36,179 --> 01:33:39,429](https://youtu.be/kMghsCXZQ9Y?t=01h33m36s)

sometimes that's quicker than rewriting


[01:33:38,139 --> 01:33:41,940](https://youtu.be/kMghsCXZQ9Y?t=01h33m38s)

everything that you just blew away


[01:33:39,429 --> 01:33:47,280](https://youtu.be/kMghsCXZQ9Y?t=01h33m39s)

because you're being stupid that's true


[01:33:41,940 --> 01:33:51,840](https://youtu.be/kMghsCXZQ9Y?t=01h33m41s)

and more importantly demo works yep cool


[01:33:47,280 --> 01:33:56,409](https://youtu.be/kMghsCXZQ9Y?t=01h33m47s)

do we break any tests doing this no


[01:33:51,840 --> 01:33:58,239](https://youtu.be/kMghsCXZQ9Y?t=01h33m51s)

that's a problem well we're just not


[01:33:56,409 --> 01:33:59,830](https://youtu.be/kMghsCXZQ9Y?t=01h33m56s)

what we clearly don't have any tests


[01:33:58,239 --> 01:34:01,929](https://youtu.be/kMghsCXZQ9Y?t=01h33m58s)

that are checking those that like outer


[01:33:59,830 --> 01:34:06,820](https://youtu.be/kMghsCXZQ9Y?t=01h33m59s)

most render operation in the


[01:34:01,929 --> 01:34:08,800](https://youtu.be/kMghsCXZQ9Y?t=01h34m01s)

screenreader should we write some tests


[01:34:06,820 --> 01:34:14,969](https://youtu.be/kMghsCXZQ9Y?t=01h34m06s)

before we do something crazy like commit


[01:34:08,800 --> 01:34:19,570](https://youtu.be/kMghsCXZQ9Y?t=01h34m08s)

this yeah one of them got pretty beat up


[01:34:14,969 --> 01:34:20,920](https://youtu.be/kMghsCXZQ9Y?t=01h34m14s)

yeah there are some tests here I mean


[01:34:19,570 --> 01:34:23,170](https://youtu.be/kMghsCXZQ9Y?t=01h34m19s)

the first thing I'm seeing right out the


[01:34:20,920 --> 01:34:27,070](https://youtu.be/kMghsCXZQ9Y?t=01h34m20s)

gate is like do we care to write the the


[01:34:23,170 --> 01:34:28,829](https://youtu.be/kMghsCXZQ9Y?t=01h34m23s)

quick one real quick on the no reference


[01:34:27,070 --> 01:34:31,650](https://youtu.be/kMghsCXZQ9Y?t=01h34m27s)

on the


[01:34:28,829 --> 01:34:33,630](https://youtu.be/kMghsCXZQ9Y?t=01h34m28s)

yep structure perimeter so I mean you


[01:34:31,650 --> 01:34:35,960](https://youtu.be/kMghsCXZQ9Y?t=01h34m31s)

can basically duplicate that same test


[01:34:33,630 --> 01:34:35,960](https://youtu.be/kMghsCXZQ9Y?t=01h34m33s)

right there


[01:34:42,560 --> 01:34:49,360](https://youtu.be/kMghsCXZQ9Y?t=01h34m42s)

what do you want to cut screen view


[01:34:45,440 --> 01:34:49,360](https://youtu.be/kMghsCXZQ9Y?t=01h34m45s)

requires a console


[01:35:07,760 --> 01:35:10,939](https://youtu.be/kMghsCXZQ9Y?t=01h35m07s)

[Music]


[01:35:13,969 --> 01:35:20,969](https://youtu.be/kMghsCXZQ9Y?t=01h35m13s)

okay and if I mean really pedantic


[01:35:17,449 --> 01:35:22,590](https://youtu.be/kMghsCXZQ9Y?t=01h35m17s)

rather than the camp location on your


[01:35:20,969 --> 01:35:25,050](https://youtu.be/kMghsCXZQ9Y?t=01h35m20s)

screen view we might want to match the


[01:35:22,590 --> 01:35:26,460](https://youtu.be/kMghsCXZQ9Y?t=01h35m22s)

other naming where the moron who wrote


[01:35:25,050 --> 01:35:30,480](https://youtu.be/kMghsCXZQ9Y?t=01h35m25s)

them the first time but it an underscore


[01:35:26,460 --> 01:35:34,940](https://youtu.be/kMghsCXZQ9Y?t=01h35m26s)

between them oh here we won't mention


[01:35:30,480 --> 01:35:36,840](https://youtu.be/kMghsCXZQ9Y?t=01h35m30s)

his name you probably find out find out


[01:35:34,940 --> 01:35:39,000](https://youtu.be/kMghsCXZQ9Y?t=01h35m34s)

this is the part where we need to


[01:35:36,840 --> 01:35:45,540](https://youtu.be/kMghsCXZQ9Y?t=01h35m36s)

rewrite git history


[01:35:39,000 --> 01:35:48,060](https://youtu.be/kMghsCXZQ9Y?t=01h35m39s)

oh so something you should show off real


[01:35:45,540 --> 01:35:49,920](https://youtu.be/kMghsCXZQ9Y?t=01h35m45s)

quick John because I mentioned this to a


[01:35:48,060 --> 01:35:54,020](https://youtu.be/kMghsCXZQ9Y?t=01h35m48s)

co-worker and I want to show this to


[01:35:49,920 --> 01:35:59,159](https://youtu.be/kMghsCXZQ9Y?t=01h35m49s)

them your your fancy edit and vyas code


[01:35:54,020 --> 01:36:00,989](https://youtu.be/kMghsCXZQ9Y?t=01h35m54s)

command do you mind showing that because


[01:35:59,159 --> 01:36:03,030](https://youtu.be/kMghsCXZQ9Y?t=01h35m59s)

I believe that's just open it in


[01:36:00,989 --> 01:36:06,420](https://youtu.be/kMghsCXZQ9Y?t=01h36m00s)

external tool with the correct


[01:36:03,030 --> 01:36:08,010](https://youtu.be/kMghsCXZQ9Y?t=01h36m03s)

parameters yeah so what I just did you


[01:36:06,420 --> 01:36:10,170](https://youtu.be/kMghsCXZQ9Y?t=01h36m06s)

know because I like to use the multiple


[01:36:08,010 --> 01:36:11,760](https://youtu.be/kMghsCXZQ9Y?t=01h36m08s)

cursors functionality and Visual Studio


[01:36:10,170 --> 01:36:13,350](https://youtu.be/kMghsCXZQ9Y?t=01h36m10s)

code because it's awesome and very


[01:36:11,760 --> 01:36:15,360](https://youtu.be/kMghsCXZQ9Y?t=01h36m11s)

another thing sometimes if you want to


[01:36:13,350 --> 01:36:16,560](https://youtu.be/kMghsCXZQ9Y?t=01h36m13s)

have a text editor that's not quite


[01:36:15,360 --> 01:36:20,070](https://youtu.be/kMghsCXZQ9Y?t=01h36m15s)

opinionated about the thing you're


[01:36:16,560 --> 01:36:22,380](https://youtu.be/kMghsCXZQ9Y?t=01h36m16s)

editing I have a keystroke that I set up


[01:36:20,070 --> 01:36:24,239](https://youtu.be/kMghsCXZQ9Y?t=01h36m20s)

so it's a tool you go into so what it


[01:36:22,380 --> 01:36:26,429](https://youtu.be/kMghsCXZQ9Y?t=01h36m22s)

does I'll show it I'll show the tool


[01:36:24,239 --> 01:36:30,870](https://youtu.be/kMghsCXZQ9Y?t=01h36m24s)

entry here it's just under external


[01:36:26,429 --> 01:36:32,280](https://youtu.be/kMghsCXZQ9Y?t=01h36m26s)

tools bf code so it's just a path aliyev


[01:36:30,870 --> 01:36:35,190](https://youtu.be/kMghsCXZQ9Y?t=01h36m30s)

codec t and then this little thing here


[01:36:32,280 --> 01:36:36,630](https://youtu.be/kMghsCXZQ9Y?t=01h36m32s)

that tells it what arguments to pass the


[01:36:35,190 --> 01:36:39,090](https://youtu.be/kMghsCXZQ9Y?t=01h36m35s)

via code which is pulling from your


[01:36:36,630 --> 01:36:41,730](https://youtu.be/kMghsCXZQ9Y?t=01h36m36s)

current cursor position Chrome file so


[01:36:39,090 --> 01:36:43,949](https://youtu.be/kMghsCXZQ9Y?t=01h36m39s)

the idea is that I can if I want to be I


[01:36:41,730 --> 01:36:48,780](https://youtu.be/kMghsCXZQ9Y?t=01h36m41s)

want to edit this thing right here and


[01:36:43,949 --> 01:36:50,159](https://youtu.be/kMghsCXZQ9Y?t=01h36m43s)

BS code I of this hip-hop chef C and now


[01:36:48,780 --> 01:36:52,590](https://youtu.be/kMghsCXZQ9Y?t=01h36m48s)

I'm in Visual Studio code in that same


[01:36:50,159 --> 01:36:56,489](https://youtu.be/kMghsCXZQ9Y?t=01h36m50s)

position and I can do stuff like move


[01:36:52,590 --> 01:37:01,119](https://youtu.be/kMghsCXZQ9Y?t=01h36m52s)

lines around or maybe I want to cursor


[01:36:56,489 --> 01:37:07,570](https://youtu.be/kMghsCXZQ9Y?t=01h36m56s)

is because I would do something strange


[01:37:01,119 --> 01:37:09,940](https://youtu.be/kMghsCXZQ9Y?t=01h37m01s)

right yeah yeah okay then you save it


[01:37:07,570 --> 01:37:12,040](https://youtu.be/kMghsCXZQ9Y?t=01h37m07s)

here and as the other setting that's key


[01:37:09,940 --> 01:37:13,929](https://youtu.be/kMghsCXZQ9Y?t=01h37m09s)

to turn on in Visual Studio is the


[01:37:12,040 --> 01:37:16,389](https://youtu.be/kMghsCXZQ9Y?t=01h37m12s)

automatic reloading of your files when


[01:37:13,929 --> 01:37:18,460](https://youtu.be/kMghsCXZQ9Y?t=01h37m13s)

they change from external source that


[01:37:16,389 --> 01:37:26,010](https://youtu.be/kMghsCXZQ9Y?t=01h37m16s)

when you hit save in vs code visual


[01:37:18,460 --> 01:37:26,010](https://youtu.be/kMghsCXZQ9Y?t=01h37m18s)

studio reloads it so cool


[01:37:27,659 --> 01:37:36,530](https://youtu.be/kMghsCXZQ9Y?t=01h37m27s)

okay so that test passes let's do


[01:37:32,909 --> 01:37:42,510](https://youtu.be/kMghsCXZQ9Y?t=01h37m32s)

another test then we should probably


[01:37:36,530 --> 01:37:47,210](https://youtu.be/kMghsCXZQ9Y?t=01h37m36s)

what did I call it probably render hides


[01:37:42,510 --> 01:37:47,210](https://youtu.be/kMghsCXZQ9Y?t=01h37m42s)

cursor something to that effect


[01:37:50,210 --> 01:37:58,590](https://youtu.be/kMghsCXZQ9Y?t=01h37m50s)

okay so let's go up and new up a new


[01:37:55,760 --> 01:38:01,110](https://youtu.be/kMghsCXZQ9Y?t=01h37m55s)

screen view can you go back down I'm


[01:37:58,590 --> 01:38:04,920](https://youtu.be/kMghsCXZQ9Y?t=01h37m58s)

wondering if or I'm sorry scroll down


[01:38:01,110 --> 01:38:10,190](https://youtu.be/kMghsCXZQ9Y?t=01h38m01s)

your left view to the screen view where


[01:38:04,920 --> 01:38:10,190](https://youtu.be/kMghsCXZQ9Y?t=01h38m04s)

we actually did the work because we


[01:38:14,679 --> 01:38:19,540](https://youtu.be/kMghsCXZQ9Y?t=01h38m14s)

yeah so we should probably do two tests


[01:38:17,050 --> 01:38:22,750](https://youtu.be/kMghsCXZQ9Y?t=01h38m17s)

this one we're render hides the cursor


[01:38:19,540 --> 01:38:39,370](https://youtu.be/kMghsCXZQ9Y?t=01h38m19s)

and then one more we're disposed shows


[01:38:22,750 --> 01:38:43,030](https://youtu.be/kMghsCXZQ9Y?t=01h38m22s)

it okay on the hide the cursor I like


[01:38:39,370 --> 01:38:44,710](https://youtu.be/kMghsCXZQ9Y?t=01h38m39s)

show it matches the ANSI command the


[01:38:43,030 --> 01:38:47,560](https://youtu.be/kMghsCXZQ9Y?t=01h38m43s)

other thing that that is clearly missing


[01:38:44,710 --> 01:38:49,390](https://youtu.be/kMghsCXZQ9Y?t=01h38m44s)

from this is the like this code is


[01:38:47,560 --> 01:38:51,550](https://youtu.be/kMghsCXZQ9Y?t=01h38m47s)

clearly making massive assumptions about


[01:38:49,390 --> 01:38:54,840](https://youtu.be/kMghsCXZQ9Y?t=01h38m49s)

the output because we're just randomly


[01:38:51,550 --> 01:38:57,190](https://youtu.be/kMghsCXZQ9Y?t=01h38m51s)

spewing ANSI characters out which is


[01:38:54,840 --> 01:38:59,199](https://youtu.be/kMghsCXZQ9Y?t=01h38m54s)

almost surely not what you want like


[01:38:57,190 --> 01:39:00,969](https://youtu.be/kMghsCXZQ9Y?t=01h38m57s)

these to write lines we clearly need


[01:38:59,199 --> 01:39:04,630](https://youtu.be/kMghsCXZQ9Y?t=01h38m59s)

more checks around them for output modes


[01:39:00,969 --> 01:39:09,699](https://youtu.be/kMghsCXZQ9Y?t=01h39m00s)

and that sort of thing right that will


[01:39:04,630 --> 01:39:12,760](https://youtu.be/kMghsCXZQ9Y?t=01h39m04s)

be a different test so so yeah so let's


[01:39:09,699 --> 01:39:13,870](https://youtu.be/kMghsCXZQ9Y?t=01h39m09s)

do screen gets new screen view you can


[01:39:12,760 --> 01:39:18,340](https://youtu.be/kMghsCXZQ9Y?t=01h39m12s)

basically do the same type of


[01:39:13,870 --> 01:39:22,650](https://youtu.be/kMghsCXZQ9Y?t=01h39m13s)

instantiation as what's on 62 so it'll


[01:39:18,340 --> 01:39:22,650](https://youtu.be/kMghsCXZQ9Y?t=01h39m18s)

take ya all that jazz


[01:39:23,239 --> 01:39:30,020](https://youtu.be/kMghsCXZQ9Y?t=01h39m23s)

and the thing is we don't actually need


[01:39:25,010 --> 01:39:31,850](https://youtu.be/kMghsCXZQ9Y?t=01h39m25s)

a view because like we've got the no


[01:39:30,020 --> 01:39:34,880](https://youtu.be/kMghsCXZQ9Y?t=01h39m30s)

prop operator on child right there and I


[01:39:31,850 --> 01:39:37,010](https://youtu.be/kMghsCXZQ9Y?t=01h39m31s)

know I saw another test about if there's


[01:39:34,880 --> 01:39:41,060](https://youtu.be/kMghsCXZQ9Y?t=01h39m34s)

no child that doesn't air it's just you


[01:39:37,010 --> 01:39:42,500](https://youtu.be/kMghsCXZQ9Y?t=01h39m37s)

know no ops basically okay so it does


[01:39:41,060 --> 01:39:45,170](https://youtu.be/kMghsCXZQ9Y?t=01h39m41s)

beg the question should we be writing


[01:39:42,500 --> 01:39:46,700](https://youtu.be/kMghsCXZQ9Y?t=01h39m42s)

out this ansi escape character if there


[01:39:45,170 --> 01:39:52,219](https://youtu.be/kMghsCXZQ9Y?t=01h39m45s)

is no child but that's a different


[01:39:46,700 --> 01:39:53,930](https://youtu.be/kMghsCXZQ9Y?t=01h39m46s)

discussion so yeah so screen render okay


[01:39:52,219 --> 01:39:57,980](https://youtu.be/kMghsCXZQ9Y?t=01h39m52s)

you should should it what's the scenario


[01:39:53,930 --> 01:40:01,219](https://youtu.be/kMghsCXZQ9Y?t=01h39m53s)

for not having a child programmer hasn't


[01:39:57,980 --> 01:40:05,150](https://youtu.be/kMghsCXZQ9Y?t=01h39m57s)

set one up yet it seems it's it's


[01:40:01,219 --> 01:40:06,739](https://youtu.be/kMghsCXZQ9Y?t=01h40m01s)

potentially programmer air because i


[01:40:05,150 --> 01:40:13,850](https://youtu.be/kMghsCXZQ9Y?t=01h40m05s)

don't know how else you get into this


[01:40:06,739 --> 01:40:18,830](https://youtu.be/kMghsCXZQ9Y?t=01h40m06s)

situation where the child is unset and


[01:40:13,850 --> 01:40:21,350](https://youtu.be/kMghsCXZQ9Y?t=01h40m13s)

so we can we can even just leave it at


[01:40:18,830 --> 01:40:24,590](https://youtu.be/kMghsCXZQ9Y?t=01h40m18s)

that and be done screen dot render


[01:40:21,350 --> 01:40:27,380](https://youtu.be/kMghsCXZQ9Y?t=01h40m21s)

because that'll i mean do we call into


[01:40:24,590 --> 01:40:30,160](https://youtu.be/kMghsCXZQ9Y?t=01h40m24s)

the overload directly that feels a


[01:40:27,380 --> 01:40:30,160](https://youtu.be/kMghsCXZQ9Y?t=01h40m27s)

little bit more like


[01:40:32,130 --> 01:40:36,030](https://youtu.be/kMghsCXZQ9Y?t=01h40m32s)

now the basic overload is probably fine


[01:40:34,260 --> 01:40:37,790](https://youtu.be/kMghsCXZQ9Y?t=01h40m34s)

because we've got another test that


[01:40:36,030 --> 01:40:40,290](https://youtu.be/kMghsCXZQ9Y?t=01h40m36s)

asserts that if you go into the


[01:40:37,790 --> 01:40:45,230](https://youtu.be/kMghsCXZQ9Y?t=01h40m37s)

parameter list overload it calls the


[01:40:40,290 --> 01:40:56,040](https://youtu.be/kMghsCXZQ9Y?t=01h40m40s)

other one okay so that seems reasonable


[01:40:45,230 --> 01:40:57,450](https://youtu.be/kMghsCXZQ9Y?t=01h40m45s)

and so then we need to do might be a


[01:40:56,040 --> 01:41:01,020](https://youtu.be/kMghsCXZQ9Y?t=01h40m56s)

little aggressive but that's probably


[01:40:57,450 --> 01:41:10,680](https://youtu.be/kMghsCXZQ9Y?t=01h40m57s)

currently correct right now right for


[01:41:01,020 --> 01:41:16,950](https://youtu.be/kMghsCXZQ9Y?t=01h41m01s)

now it is correct hide escape sequence


[01:41:10,680 --> 01:41:20,160](https://youtu.be/kMghsCXZQ9Y?t=01h41m10s)

oh good call I was moving on to the next


[01:41:16,950 --> 01:41:24,290](https://youtu.be/kMghsCXZQ9Y?t=01h41m16s)

test already okay that's cool


[01:41:20,160 --> 01:41:24,290](https://youtu.be/kMghsCXZQ9Y?t=01h41m20s)

so yeah here's mine


[01:41:37,179 --> 01:41:40,449](https://youtu.be/kMghsCXZQ9Y?t=01h41m37s)

very nice


[01:41:42,590 --> 01:41:49,170](https://youtu.be/kMghsCXZQ9Y?t=01h41m42s)

okay so next one I guess is similar to


[01:41:46,320 --> 01:41:53,100](https://youtu.be/kMghsCXZQ9Y?t=01h41m46s)

this right yep pretty much


[01:41:49,170 --> 01:41:56,550](https://youtu.be/kMghsCXZQ9Y?t=01h41m49s)

well we technically don't even need to


[01:41:53,100 --> 01:42:07,830](https://youtu.be/kMghsCXZQ9Y?t=01h41m53s)

call render dress we can just do screen


[01:41:56,550 --> 01:42:09,840](https://youtu.be/kMghsCXZQ9Y?t=01h41m56s)

dot dispose right and I would say ends


[01:42:07,830 --> 01:42:16,340](https://youtu.be/kMghsCXZQ9Y?t=01h42m07s)

with not starts with and then you need


[01:42:09,840 --> 01:42:16,340](https://youtu.be/kMghsCXZQ9Y?t=01h42m09s)

to change your escape sequence oh no


[01:42:22,030 --> 01:42:24,780](https://youtu.be/kMghsCXZQ9Y?t=01h42m22s)

cool


[01:42:24,919 --> 01:42:30,229](https://youtu.be/kMghsCXZQ9Y?t=01h42m24s)

and that's roughly what I would expect


[01:42:27,219 --> 01:42:32,360](https://youtu.be/kMghsCXZQ9Y?t=01h42m27s)

yeah so here's the only thing that


[01:42:30,229 --> 01:42:33,769](https://youtu.be/kMghsCXZQ9Y?t=01h42m30s)

that's kind of bothering me a little bit


[01:42:32,360 --> 01:42:35,209](https://youtu.be/kMghsCXZQ9Y?t=01h42m32s)

about this and maybe we do need to


[01:42:33,769 --> 01:42:37,429](https://youtu.be/kMghsCXZQ9Y?t=01h42m33s)

expose something via the renderer


[01:42:35,209 --> 01:42:39,739](https://youtu.be/kMghsCXZQ9Y?t=01h42m35s)

because right now the renderer has all


[01:42:37,429 --> 01:42:43,329](https://youtu.be/kMghsCXZQ9Y?t=01h42m37s)

of that logic in render to region for


[01:42:39,739 --> 01:42:45,229](https://youtu.be/kMghsCXZQ9Y?t=01h42m39s)

handling the various output modes and


[01:42:43,329 --> 01:42:48,829](https://youtu.be/kMghsCXZQ9Y?t=01h42m43s)

determining whether it should display


[01:42:45,229 --> 01:42:54,949](https://youtu.be/kMghsCXZQ9Y?t=01h42m45s)

ANSI characters or not yeah it makes me


[01:42:48,829 --> 01:42:56,899](https://youtu.be/kMghsCXZQ9Y?t=01h42m48s)

wonder if render needs another overload


[01:42:54,949 --> 01:42:58,669](https://youtu.be/kMghsCXZQ9Y?t=01h42m54s)

to support this kind of thing because


[01:42:56,899 --> 01:43:00,800](https://youtu.be/kMghsCXZQ9Y?t=01h42m56s)

ideally rather than having the console


[01:42:58,669 --> 01:43:04,219](https://youtu.be/kMghsCXZQ9Y?t=01h42m58s)

to act on right here I think what would


[01:43:00,800 --> 01:43:11,209](https://youtu.be/kMghsCXZQ9Y?t=01h43m00s)

be cleaner is if in screen view we could


[01:43:04,219 --> 01:43:14,689](https://youtu.be/kMghsCXZQ9Y?t=01h43m04s)

just do renderer dot render control code


[01:43:11,209 --> 01:43:16,999](https://youtu.be/kMghsCXZQ9Y?t=01h43m11s)

or yeah we even talked about doing that


[01:43:14,689 --> 01:43:18,349](https://youtu.be/kMghsCXZQ9Y?t=01h43m14s)

via the terminal itself that maybe we


[01:43:16,999 --> 01:43:21,139](https://youtu.be/kMghsCXZQ9Y?t=01h43m16s)

want different implementations of


[01:43:18,349 --> 01:43:24,050](https://youtu.be/kMghsCXZQ9Y?t=01h43m18s)

terminal for ANSI versus non empty


[01:43:21,139 --> 01:43:26,239](https://youtu.be/kMghsCXZQ9Y?t=01h43m21s)

terminals right does this this kind of


[01:43:24,050 --> 01:43:28,070](https://youtu.be/kMghsCXZQ9Y?t=01h43m24s)

raw writing out of these things we


[01:43:26,239 --> 01:43:30,499](https://youtu.be/kMghsCXZQ9Y?t=01h43m26s)

either have to duplicate all the logic


[01:43:28,070 --> 01:43:33,110](https://youtu.be/kMghsCXZQ9Y?t=01h43m28s)

for our modes to know whether it's okay


[01:43:30,499 --> 01:43:34,789](https://youtu.be/kMghsCXZQ9Y?t=01h43m30s)

to write these things out yeah I mean I


[01:43:33,110 --> 01:43:37,639](https://youtu.be/kMghsCXZQ9Y?t=01h43m33s)

guess it really is only an if check


[01:43:34,789 --> 01:43:39,469](https://youtu.be/kMghsCXZQ9Y?t=01h43m34s)

isn't it well but right now we already


[01:43:37,639 --> 01:43:41,119](https://youtu.be/kMghsCXZQ9Y?t=01h43m37s)

have that responsibility by you know


[01:43:39,469 --> 01:43:46,130](https://youtu.be/kMghsCXZQ9Y?t=01h43m39s)

because we have two different visitor


[01:43:41,119 --> 01:43:47,599](https://youtu.be/kMghsCXZQ9Y?t=01h43m41s)

classes we have these we have the you


[01:43:46,130 --> 01:43:50,030](https://youtu.be/kMghsCXZQ9Y?t=01h43m46s)

know the anti rendering spam visit or


[01:43:47,599 --> 01:43:51,800](https://youtu.be/kMghsCXZQ9Y?t=01h43m47s)

the file rendering spam visitor I think


[01:43:50,030 --> 01:43:54,800](https://youtu.be/kMghsCXZQ9Y?t=01h43m50s)

and the monana empties fan rendering the


[01:43:51,800 --> 01:43:56,300](https://youtu.be/kMghsCXZQ9Y?t=01h43m51s)

content remembers yeah it's the


[01:43:54,800 --> 01:44:02,090](https://youtu.be/kMghsCXZQ9Y?t=01h43m54s)

different ones that implement that


[01:43:56,300 --> 01:44:03,829](https://youtu.be/kMghsCXZQ9Y?t=01h43m56s)

implement this these let's take in these


[01:44:02,090 --> 01:44:05,479](https://youtu.be/kMghsCXZQ9Y?t=01h44m02s)

are the ones where right now that


[01:44:03,829 --> 01:44:08,059](https://youtu.be/kMghsCXZQ9Y?t=01h44m03s)

decision about how to render is made


[01:44:05,479 --> 01:44:09,919](https://youtu.be/kMghsCXZQ9Y?t=01h44m05s)

right well but the decision about which


[01:44:08,059 --> 01:44:13,760](https://youtu.be/kMghsCXZQ9Y?t=01h44m08s)

one of these visitors gets used is


[01:44:09,919 --> 01:44:15,199](https://youtu.be/kMghsCXZQ9Y?t=01h44m09s)

handled in the renderer let's jump to


[01:44:13,760 --> 01:44:17,899](https://youtu.be/kMghsCXZQ9Y?t=01h44m13s)

that let's jump to console render a


[01:44:15,199 --> 01:44:19,519](https://youtu.be/kMghsCXZQ9Y?t=01h44m15s)

render to region there's a switch


[01:44:17,899 --> 01:44:21,939](https://youtu.be/kMghsCXZQ9Y?t=01h44m17s)

statement in there for my members


[01:44:19,519 --> 01:44:21,939](https://youtu.be/kMghsCXZQ9Y?t=01h44m19s)

correct


[01:44:23,770 --> 01:44:31,850](https://youtu.be/kMghsCXZQ9Y?t=01h44m23s)

so yeah so on that mode of what it does


[01:44:29,810 --> 01:44:35,090](https://youtu.be/kMghsCXZQ9Y?t=01h44m29s)

because that that's that auto-detect


[01:44:31,850 --> 01:44:37,430](https://youtu.be/kMghsCXZQ9Y?t=01h44m31s)

that you were mentioning online 71 we're


[01:44:35,090 --> 01:44:39,860](https://youtu.be/kMghsCXZQ9Y?t=01h44m35s)

where if the mode is set to auto which I


[01:44:37,430 --> 01:44:41,960](https://youtu.be/kMghsCXZQ9Y?t=01h44m37s)

believe is the default it falls back and


[01:44:39,860 --> 01:44:43,880](https://youtu.be/kMghsCXZQ9Y?t=01h44m39s)

says okay try to detect otherwise you


[01:44:41,960 --> 01:44:49,160](https://youtu.be/kMghsCXZQ9Y?t=01h44m41s)

know we're just gonna go conservative


[01:44:43,880 --> 01:44:54,080](https://youtu.be/kMghsCXZQ9Y?t=01h44m43s)

and go plain text and then it shells out


[01:44:49,160 --> 01:44:57,760](https://youtu.be/kMghsCXZQ9Y?t=01h44m49s)

to the various visitors text i've been


[01:44:54,080 --> 01:44:57,760](https://youtu.be/kMghsCXZQ9Y?t=01h44m54s)

calling a file on the command line


[01:44:58,270 --> 01:45:06,230](https://youtu.be/kMghsCXZQ9Y?t=01h44m58s)

that's the problem I'm surprised that


[01:45:02,180 --> 01:45:10,060](https://youtu.be/kMghsCXZQ9Y?t=01h45m02s)

doesn't give you for the parameters on


[01:45:06,230 --> 01:45:10,060](https://youtu.be/kMghsCXZQ9Y?t=01h45m06s)

directives shouldn't that be a parse air


[01:45:11,020 --> 01:45:15,110](https://youtu.be/kMghsCXZQ9Y?t=01h45m11s)

yeah that one probably should if the


[01:45:13,610 --> 01:45:16,550](https://youtu.be/kMghsCXZQ9Y?t=01h45m13s)

directive is opinionated about what


[01:45:15,110 --> 01:45:18,260](https://youtu.be/kMghsCXZQ9Y?t=01h45m15s)

values can be in their directives are


[01:45:16,550 --> 01:45:19,940](https://youtu.be/kMghsCXZQ9Y?t=01h45m16s)

kind of a special special world right


[01:45:18,260 --> 01:45:21,740](https://youtu.be/kMghsCXZQ9Y?t=01h45m18s)

now because we we don't have the notion


[01:45:19,940 --> 01:45:24,680](https://youtu.be/kMghsCXZQ9Y?t=01h45m19s)

of discovering what directives are


[01:45:21,740 --> 01:45:25,730](https://youtu.be/kMghsCXZQ9Y?t=01h45m21s)

available right and so what we do is we


[01:45:24,680 --> 01:45:30,140](https://youtu.be/kMghsCXZQ9Y?t=01h45m24s)

just say you know if you pass in


[01:45:25,730 --> 01:45:34,430](https://youtu.be/kMghsCXZQ9Y?t=01h45m25s)

directives we we can act on them right


[01:45:30,140 --> 01:45:38,600](https://youtu.be/kMghsCXZQ9Y?t=01h45m30s)

but we won't validate them right kind of


[01:45:34,430 --> 01:45:40,700](https://youtu.be/kMghsCXZQ9Y?t=01h45m34s)

like HTTP headers in as well yeah I can


[01:45:38,600 --> 01:45:43,130](https://youtu.be/kMghsCXZQ9Y?t=01h45m38s)

understand that and be in being very


[01:45:40,700 --> 01:45:45,020](https://youtu.be/kMghsCXZQ9Y?t=01h45m40s)

loose on the directives themselves but


[01:45:43,130 --> 01:45:48,560](https://youtu.be/kMghsCXZQ9Y?t=01h45m43s)

once somebody has specified a directive


[01:45:45,020 --> 01:45:50,630](https://youtu.be/kMghsCXZQ9Y?t=01h45m45s)

named him like output mode it feels like


[01:45:48,560 --> 01:45:52,610](https://youtu.be/kMghsCXZQ9Y?t=01h45m48s)

the directive itself could be very


[01:45:50,630 --> 01:45:56,000](https://youtu.be/kMghsCXZQ9Y?t=01h45m50s)

opinionated about what values it would


[01:45:52,610 --> 01:45:59,570](https://youtu.be/kMghsCXZQ9Y?t=01h45m52s)

allow and err so you know if you tie a


[01:45:56,000 --> 01:46:03,140](https://youtu.be/kMghsCXZQ9Y?t=01h45m56s)

fat finger your output mode from you


[01:45:59,570 --> 01:46:05,960](https://youtu.be/kMghsCXZQ9Y?t=01h45m59s)

know Auto to be ATO yeah it probably


[01:46:03,140 --> 01:46:07,730](https://youtu.be/kMghsCXZQ9Y?t=01h46m03s)

should blow up in your face to say yeah


[01:46:05,960 --> 01:46:09,890](https://youtu.be/kMghsCXZQ9Y?t=01h46m05s)

I think that's a good idea


[01:46:07,730 --> 01:46:11,570](https://youtu.be/kMghsCXZQ9Y?t=01h46m07s)

yeah at least for the directive


[01:46:09,890 --> 01:46:12,920](https://youtu.be/kMghsCXZQ9Y?t=01h46m09s)

parameters I understand being a little


[01:46:11,570 --> 01:46:17,870](https://youtu.be/kMghsCXZQ9Y?t=01h46m11s)

bit more loose on the directives


[01:46:12,920 --> 01:46:20,090](https://youtu.be/kMghsCXZQ9Y?t=01h46m12s)

themselves anyway


[01:46:17,870 --> 01:46:24,080](https://youtu.be/kMghsCXZQ9Y?t=01h46m17s)

so my thought though is we've already


[01:46:20,090 --> 01:46:27,850](https://youtu.be/kMghsCXZQ9Y?t=01h46m20s)

got sort of this switch of what we're


[01:46:24,080 --> 01:46:30,950](https://youtu.be/kMghsCXZQ9Y?t=01h46m24s)

going to render out yep


[01:46:27,850 --> 01:46:32,420](https://youtu.be/kMghsCXZQ9Y?t=01h46m27s)

and these visitors because I am


[01:46:30,950 --> 01:46:35,840](https://youtu.be/kMghsCXZQ9Y?t=01h46m30s)

wondering if we could take advantage of


[01:46:32,420 --> 01:46:36,950](https://youtu.be/kMghsCXZQ9Y?t=01h46m32s)

this render to region because what


[01:46:35,840 --> 01:46:39,680](https://youtu.be/kMghsCXZQ9Y?t=01h46m35s)

exactly does it you


[01:46:36,950 --> 01:46:41,660](https://youtu.be/kMghsCXZQ9Y?t=01h46m36s)

the region for anyway because in our


[01:46:39,680 --> 01:46:50,060](https://youtu.be/kMghsCXZQ9Y?t=01h46m39s)

case we really could give it a zero


[01:46:41,660 --> 01:46:53,000](https://youtu.be/kMghsCXZQ9Y?t=01h46m41s)

region for turning the the cursor on and


[01:46:50,060 --> 01:46:58,990](https://youtu.be/kMghsCXZQ9Y?t=01h46m50s)

off right yeah doesn't need to be a


[01:46:53,000 --> 01:47:03,020](https://youtu.be/kMghsCXZQ9Y?t=01h46m53s)

region really right just render it now


[01:46:58,990 --> 01:47:06,260](https://youtu.be/kMghsCXZQ9Y?t=01h46m58s)

yeah and every stream yeah exactly


[01:47:03,020 --> 01:47:10,420](https://youtu.be/kMghsCXZQ9Y?t=01h47m03s)

because we we allow the span itself to


[01:47:06,260 --> 01:47:10,420](https://youtu.be/kMghsCXZQ9Y?t=01h47m06s)

be no but we don't allow the region


[01:47:10,510 --> 01:47:15,110](https://youtu.be/kMghsCXZQ9Y?t=01h47m10s)

I'm wonder if we just lacks that


[01:47:12,800 --> 01:47:17,090](https://youtu.be/kMghsCXZQ9Y?t=01h47m12s)

restriction or maybe it's just a


[01:47:15,110 --> 01:47:19,640](https://youtu.be/kMghsCXZQ9Y?t=01h47m15s)

separate method render to region fields


[01:47:17,090 --> 01:47:24,860](https://youtu.be/kMghsCXZQ9Y?t=01h47m17s)

oh yeah you're like like it really


[01:47:19,640 --> 01:47:26,090](https://youtu.be/kMghsCXZQ9Y?t=01h47m19s)

should be but we can we can factor this


[01:47:24,860 --> 01:47:28,790](https://youtu.be/kMghsCXZQ9Y?t=01h47m24s)

into two different methods where one


[01:47:26,090 --> 01:47:42,740](https://youtu.be/kMghsCXZQ9Y?t=01h47m26s)

doesn't take a region does the span


[01:47:28,790 --> 01:47:44,180](https://youtu.be/kMghsCXZQ9Y?t=01h47m28s)

visitor visit there currently it's


[01:47:42,740 --> 01:47:46,070](https://youtu.be/kMghsCXZQ9Y?t=01h47m42s)

tricky because when you're in a nancy


[01:47:44,180 --> 01:47:47,930](https://youtu.be/kMghsCXZQ9Y?t=01h47m44s)

mode you really do want the render


[01:47:46,070 --> 01:47:50,590](https://youtu.be/kMghsCXZQ9Y?t=01h47m46s)

operation to be region specific because


[01:47:47,930 --> 01:47:53,390](https://youtu.be/kMghsCXZQ9Y?t=01h47m47s)

it also need to clean up that region


[01:47:50,590 --> 01:47:56,450](https://youtu.be/kMghsCXZQ9Y?t=01h47m50s)

true but that's also why I'm wondering


[01:47:53,390 --> 01:48:01,010](https://youtu.be/kMghsCXZQ9Y?t=01h47m53s)

if maybe we just give it like a zero


[01:47:56,450 --> 01:48:02,720](https://youtu.be/kMghsCXZQ9Y?t=01h47m56s)

sized region mm-hmm like it would it


[01:48:01,010 --> 01:48:05,240](https://youtu.be/kMghsCXZQ9Y?t=01h48m01s)

would be nice if there was a nice easy


[01:48:02,720 --> 01:48:07,040](https://youtu.be/kMghsCXZQ9Y?t=01h48m02s)

because we've got the the screen view


[01:48:05,240 --> 01:48:08,720](https://youtu.be/kMghsCXZQ9Y?t=01h48m05s)

builds a region that represents the


[01:48:07,040 --> 01:48:12,560](https://youtu.be/kMghsCXZQ9Y?t=01h48m07s)

whole screen by basically looking at the


[01:48:08,720 --> 01:48:16,430](https://youtu.be/kMghsCXZQ9Y?t=01h48m08s)

console sighs I almost want to get one


[01:48:12,560 --> 01:48:20,090](https://youtu.be/kMghsCXZQ9Y?t=01h48m12s)

that's similar that's basically you know


[01:48:16,430 --> 01:48:23,660](https://youtu.be/kMghsCXZQ9Y?t=01h48m16s)

region dot zero where it looks at the


[01:48:20,090 --> 01:48:26,420](https://youtu.be/kMghsCXZQ9Y?t=01h48m20s)

current cursor position for its X Y


[01:48:23,660 --> 01:48:28,130](https://youtu.be/kMghsCXZQ9Y?t=01h48m23s)

position but then same height width to


[01:48:26,420 --> 01:48:29,810](https://youtu.be/kMghsCXZQ9Y?t=01h48m26s)

either one or zero I don't know if we'd


[01:48:28,130 --> 01:48:32,180](https://youtu.be/kMghsCXZQ9Y?t=01h48m28s)

be tolerant of 0 I feel like that's an


[01:48:29,810 --> 01:48:36,650](https://youtu.be/kMghsCXZQ9Y?t=01h48m29s)

off by one error waiting to happen yeah


[01:48:32,180 --> 01:48:38,120](https://youtu.be/kMghsCXZQ9Y?t=01h48m32s)

yeah it feels like I wouldn't want to


[01:48:36,650 --> 01:48:43,160](https://youtu.be/kMghsCXZQ9Y?t=01h48m36s)

explode that implementation detail in


[01:48:38,120 --> 01:48:47,930](https://youtu.be/kMghsCXZQ9Y?t=01h48m38s)

the API no I agree with that but I'm


[01:48:43,160 --> 01:48:50,000](https://youtu.be/kMghsCXZQ9Y?t=01h48m43s)

just thinking for the if we had a second


[01:48:47,930 --> 01:48:50,780](https://youtu.be/kMghsCXZQ9Y?t=01h48m47s)

one of these methods that that didn't


[01:48:50,000 --> 01:48:52,490](https://youtu.be/kMghsCXZQ9Y?t=01h48m50s)

take a region


[01:48:50,780 --> 01:48:59,290](https://youtu.be/kMghsCXZQ9Y?t=01h48m50s)

that's how we could get around the


[01:48:52,490 --> 01:48:59,290](https://youtu.be/kMghsCXZQ9Y?t=01h48m52s)

visitors requiring a region yeah yeah


[01:49:06,239 --> 01:49:11,010](https://youtu.be/kMghsCXZQ9Y?t=01h49m06s)

or maybe the visitors should not require


[01:49:08,560 --> 01:49:11,010](https://youtu.be/kMghsCXZQ9Y?t=01h49m08s)

a reason


[01:49:23,740 --> 01:49:30,340](https://youtu.be/kMghsCXZQ9Y?t=01h49m23s)

I mean that is a possibility I mean


[01:49:29,230 --> 01:49:32,170](https://youtu.be/kMghsCXZQ9Y?t=01h49m29s)

another way I'm thinking about it I


[01:49:30,340 --> 01:49:35,310](https://youtu.be/kMghsCXZQ9Y?t=01h49m30s)

guess if you have it is that we're not


[01:49:32,170 --> 01:49:36,870](https://youtu.be/kMghsCXZQ9Y?t=01h49m32s)

really rendering a text expand anymore


[01:49:35,310 --> 01:49:39,460](https://youtu.be/kMghsCXZQ9Y?t=01h49m35s)

all right


[01:49:36,870 --> 01:49:41,470](https://youtu.be/kMghsCXZQ9Y?t=01h49m36s)

or we're not it's not a content span


[01:49:39,460 --> 01:49:43,120](https://youtu.be/kMghsCXZQ9Y?t=01h49m39s)

maybe right it's just what are the


[01:49:41,470 --> 01:49:45,730](https://youtu.be/kMghsCXZQ9Y?t=01h49m41s)

different spam types we have it's I


[01:49:43,120 --> 01:49:47,830](https://youtu.be/kMghsCXZQ9Y?t=01h49m43s)

think the red wreath render without a


[01:49:45,730 --> 01:49:52,510](https://youtu.be/kMghsCXZQ9Y?t=01h49m45s)

region maybe should only be used for


[01:49:47,830 --> 01:49:54,460](https://youtu.be/kMghsCXZQ9Y?t=01h49m47s)

rendering control signals agree which


[01:49:52,510 --> 01:49:56,380](https://youtu.be/kMghsCXZQ9Y?t=01h49m52s)

means it's a very different kind of


[01:49:54,460 --> 01:50:01,180](https://youtu.be/kMghsCXZQ9Y?t=01h49m54s)

overload than what we have right now for


[01:49:56,380 --> 01:50:05,130](https://youtu.be/kMghsCXZQ9Y?t=01h49m56s)

render to region right it maybe take


[01:50:01,180 --> 01:50:08,560](https://youtu.be/kMghsCXZQ9Y?t=01h50m01s)

something less general than a spam I


[01:50:05,130 --> 01:50:10,780](https://youtu.be/kMghsCXZQ9Y?t=01h50m05s)

could see that though we don't currently


[01:50:08,560 --> 01:50:16,570](https://youtu.be/kMghsCXZQ9Y?t=01h50m08s)

have anything to separate out those


[01:50:10,780 --> 01:50:18,190](https://youtu.be/kMghsCXZQ9Y?t=01h50m10s)

control codes well maybe it just takes


[01:50:16,570 --> 01:50:20,560](https://youtu.be/kMghsCXZQ9Y?t=01h50m16s)

the control maybe it just takes an ansi


[01:50:18,190 --> 01:50:29,050](https://youtu.be/kMghsCXZQ9Y?t=01h50m18s)

escape sequence directly or an anticodon


[01:50:20,560 --> 01:50:31,810](https://youtu.be/kMghsCXZQ9Y?t=01h50m20s)

whatever the type was so maybe we're


[01:50:29,050 --> 01:50:34,300](https://youtu.be/kMghsCXZQ9Y?t=01h50m29s)

entering an ansi control code maybe it


[01:50:31,810 --> 01:50:40,180](https://youtu.be/kMghsCXZQ9Y?t=01h50m31s)

maybe it's render an T control code no


[01:50:34,300 --> 01:50:43,990](https://youtu.be/kMghsCXZQ9Y?t=01h50m34s)

Rita I could see that because the


[01:50:40,180 --> 01:50:47,410](https://youtu.be/kMghsCXZQ9Y?t=01h50m40s)

control codes I can't say don't take up


[01:50:43,990 --> 01:50:50,980](https://youtu.be/kMghsCXZQ9Y?t=01h50m43s)

any space because there's ones in there


[01:50:47,410 --> 01:50:53,650](https://youtu.be/kMghsCXZQ9Y?t=01h50m47s)

too that are like clear screen which


[01:50:50,980 --> 01:50:56,470](https://youtu.be/kMghsCXZQ9Y?t=01h50m50s)

clearly take up the whole screens worth


[01:50:53,650 --> 01:50:58,960](https://youtu.be/kMghsCXZQ9Y?t=01h50m53s)

of space yeah yeah but I think that


[01:50:56,470 --> 01:51:01,440](https://youtu.be/kMghsCXZQ9Y?t=01h50m56s)

overload is still clear in that it's no


[01:50:58,960 --> 01:51:01,440](https://youtu.be/kMghsCXZQ9Y?t=01h50m58s)

longer just


[01:51:04,040 --> 01:51:09,620](https://youtu.be/kMghsCXZQ9Y?t=01h51m04s)

just rendering content it's actually


[01:51:06,470 --> 01:51:11,930](https://youtu.be/kMghsCXZQ9Y?t=01h51m06s)

saying no go go perform this action and


[01:51:09,620 --> 01:51:13,340](https://youtu.be/kMghsCXZQ9Y?t=01h51m09s)

it's up to you to do it yeah it's a


[01:51:11,930 --> 01:51:15,530](https://youtu.be/kMghsCXZQ9Y?t=01h51m11s)

little bit interesting cuz actually what


[01:51:13,340 --> 01:51:16,850](https://youtu.be/kMghsCXZQ9Y?t=01h51m13s)

we what we actually want everything that


[01:51:15,530 --> 01:51:18,380](https://youtu.be/kMghsCXZQ9Y?t=01h51m15s)

you're saying makes perfect sense I I


[01:51:16,850 --> 01:51:19,010](https://youtu.be/kMghsCXZQ9Y?t=01h51m16s)

want to revise what I said though is


[01:51:18,380 --> 01:51:20,750](https://youtu.be/kMghsCXZQ9Y?t=01h51m18s)

it's not


[01:51:19,010 --> 01:51:23,420](https://youtu.be/kMghsCXZQ9Y?t=01h51m19s)

Nancy escape sequence it's some other


[01:51:20,750 --> 01:51:30,440](https://youtu.be/kMghsCXZQ9Y?t=01h51m20s)

thing that can be generalised across


[01:51:23,420 --> 01:51:34,910](https://youtu.be/kMghsCXZQ9Y?t=01h51m23s)

empty and non ANSI terminals oh so you


[01:51:30,440 --> 01:51:39,920](https://youtu.be/kMghsCXZQ9Y?t=01h51m30s)

not necessarily a nancy control what


[01:51:34,910 --> 01:51:42,070](https://youtu.be/kMghsCXZQ9Y?t=01h51m34s)

you're saying yeah I guess what would


[01:51:39,920 --> 01:51:44,480](https://youtu.be/kMghsCXZQ9Y?t=01h51m39s)

you propose that argument to be though


[01:51:42,070 --> 01:51:46,190](https://youtu.be/kMghsCXZQ9Y?t=01h51m42s)

it's kind of like these right here oh


[01:51:44,480 --> 01:51:49,850](https://youtu.be/kMghsCXZQ9Y?t=01h51m44s)

wait is this why the bulb thing wasn't


[01:51:46,190 --> 01:51:55,480](https://youtu.be/kMghsCXZQ9Y?t=01h51m46s)

working correctly no Stiles man all


[01:51:49,850 --> 01:51:55,480](https://youtu.be/kMghsCXZQ9Y?t=01h51m49s)

right so these we have these here right


[01:51:56,230 --> 01:52:01,040](https://youtu.be/kMghsCXZQ9Y?t=01h51m56s)

and this was the thing that we started


[01:51:59,180 --> 01:52:06,890](https://youtu.be/kMghsCXZQ9Y?t=01h51m59s)

looking at the beginning which is you


[01:52:01,040 --> 01:52:08,750](https://youtu.be/kMghsCXZQ9Y?t=01h52m01s)

know this is a generalization across you


[01:52:06,890 --> 01:52:11,060](https://youtu.be/kMghsCXZQ9Y?t=01h52m06s)

know generates a an abstraction that


[01:52:08,750 --> 01:52:13,989](https://youtu.be/kMghsCXZQ9Y?t=01h52m08s)

lets us do formatting stuff independent


[01:52:11,060 --> 01:52:13,989](https://youtu.be/kMghsCXZQ9Y?t=01h52m11s)

of the type of terminal


[01:52:16,729 --> 01:52:29,409](https://youtu.be/kMghsCXZQ9Y?t=01h52m16s)

alright so the ANSI renderings ban


[01:52:18,979 --> 01:52:31,969](https://youtu.be/kMghsCXZQ9Y?t=01h52m18s)

visitor maps them to antico's right


[01:52:29,409 --> 01:52:36,440](https://youtu.be/kMghsCXZQ9Y?t=01h52m29s)

right this is a mapping of those spans


[01:52:31,969 --> 01:52:42,860](https://youtu.be/kMghsCXZQ9Y?t=01h52m31s)

two specific ANSI codes and then if you


[01:52:36,440 --> 01:52:45,979](https://youtu.be/kMghsCXZQ9Y?t=01h52m36s)

look at the non ANSI one it does


[01:52:42,860 --> 01:52:49,699](https://youtu.be/kMghsCXZQ9Y?t=01h52m42s)

something rather different it maps onto


[01:52:45,979 --> 01:52:53,449](https://youtu.be/kMghsCXZQ9Y?t=01h52m45s)

console colors for example and it maps


[01:52:49,699 --> 01:52:54,679](https://youtu.be/kMghsCXZQ9Y?t=01h52m49s)

them to ya foreground color mappings


[01:52:53,449 --> 01:52:59,869](https://youtu.be/kMghsCXZQ9Y?t=01h52m53s)

background color mappings


[01:52:54,679 --> 01:53:01,369](https://youtu.be/kMghsCXZQ9Y?t=01h52m54s)

I just wanted to visit the color span so


[01:52:59,869 --> 01:53:02,869](https://youtu.be/kMghsCXZQ9Y?t=01h52m59s)

I've got this color span what should I


[01:53:01,369 --> 01:53:06,849](https://youtu.be/kMghsCXZQ9Y?t=01h53m01s)

do it gets the mapping out and then it


[01:53:02,869 --> 01:53:11,479](https://youtu.be/kMghsCXZQ9Y?t=01h53m02s)

sets the background color it sort of


[01:53:06,849 --> 01:53:12,889](https://youtu.be/kMghsCXZQ9Y?t=01h53m06s)

whereas this one here just can be a lot


[01:53:11,479 --> 01:53:17,449](https://youtu.be/kMghsCXZQ9Y?t=01h53m11s)

simpler it just writes out the escape


[01:53:12,889 --> 01:53:21,159](https://youtu.be/kMghsCXZQ9Y?t=01h53m12s)

sequence I guess we should look at the


[01:53:17,449 --> 01:53:24,489](https://youtu.be/kMghsCXZQ9Y?t=01h53m17s)

yeah background color span compare


[01:53:21,159 --> 01:53:24,489](https://youtu.be/kMghsCXZQ9Y?t=01h53m21s)

apples to apples


[01:53:30,409 --> 01:53:34,440](https://youtu.be/kMghsCXZQ9Y?t=01h53m30s)

so we could do something similar for


[01:53:32,670 --> 01:53:38,550](https://youtu.be/kMghsCXZQ9Y?t=01h53m32s)

this for you know cursor control and


[01:53:34,440 --> 01:53:39,989](https://youtu.be/kMghsCXZQ9Y?t=01h53m34s)

screen clearing and things like that and


[01:53:38,550 --> 01:53:43,340](https://youtu.be/kMghsCXZQ9Y?t=01h53m38s)

then we just add another method to the


[01:53:39,989 --> 01:53:47,150](https://youtu.be/kMghsCXZQ9Y?t=01h53m39s)

visitor and have the two different


[01:53:43,340 --> 01:53:47,150](https://youtu.be/kMghsCXZQ9Y?t=01h53m43s)

implementations of it


[01:53:52,720 --> 01:54:04,030](https://youtu.be/kMghsCXZQ9Y?t=01h53m52s)

are you proposing something that


[01:53:54,730 --> 01:54:07,930](https://youtu.be/kMghsCXZQ9Y?t=01h53m54s)

ultimately derives from span yep so the


[01:54:04,030 --> 01:54:09,190](https://youtu.be/kMghsCXZQ9Y?t=01h54m04s)

ANSI class we notice that forwards all


[01:54:07,930 --> 01:54:11,890](https://youtu.be/kMghsCXZQ9Y?t=01h54m07s)

these different categories and usually


[01:54:09,190 --> 01:54:13,540](https://youtu.be/kMghsCXZQ9Y?t=01h54m09s)

that you know the color category the


[01:54:11,890 --> 01:54:15,160](https://youtu.be/kMghsCXZQ9Y?t=01h54m11s)

cursor category is not represented by


[01:54:13,540 --> 01:54:18,660](https://youtu.be/kMghsCXZQ9Y?t=01h54m13s)

spans right now when you can use them


[01:54:15,160 --> 01:54:22,660](https://youtu.be/kMghsCXZQ9Y?t=01h54m15s)

inside of other stands but like scroll


[01:54:18,660 --> 01:54:25,210](https://youtu.be/kMghsCXZQ9Y?t=01h54m18s)

cursor hide show save position all this


[01:54:22,660 --> 01:54:29,680](https://youtu.be/kMghsCXZQ9Y?t=01h54m22s)

stuff here inside of cursor we don't


[01:54:25,210 --> 01:54:30,640](https://youtu.be/kMghsCXZQ9Y?t=01h54m25s)

have a dedicated span class the way that


[01:54:29,680 --> 01:54:35,620](https://youtu.be/kMghsCXZQ9Y?t=01h54m29s)

we do for the foreground and background


[01:54:30,640 --> 01:54:37,900](https://youtu.be/kMghsCXZQ9Y?t=01h54m30s)

color spans and stylus bands right but


[01:54:35,620 --> 01:54:40,780](https://youtu.be/kMghsCXZQ9Y?t=01h54m35s)

we could have a cursor control span I


[01:54:37,900 --> 01:54:42,490](https://youtu.be/kMghsCXZQ9Y?t=01h54m37s)

guess right it's a little bit weird for


[01:54:40,780 --> 01:54:45,430](https://youtu.be/kMghsCXZQ9Y?t=01h54m40s)

the system console stuff but I guess it


[01:54:42,490 --> 01:54:47,500](https://youtu.be/kMghsCXZQ9Y?t=01h54m42s)

works right and then that thing each of


[01:54:45,430 --> 01:54:49,060](https://youtu.be/kMghsCXZQ9Y?t=01h54m45s)

the visitors can act accordingly to


[01:54:47,500 --> 01:54:50,560](https://youtu.be/kMghsCXZQ9Y?t=01h54m47s)

translate that into something that works


[01:54:49,060 --> 01:54:56,590](https://youtu.be/kMghsCXZQ9Y?t=01h54m49s)

for the specific terminal that it's


[01:54:50,560 --> 01:55:01,180](https://youtu.be/kMghsCXZQ9Y?t=01h54m50s)

working what would you put a data on


[01:54:56,590 --> 01:55:03,430](https://youtu.be/kMghsCXZQ9Y?t=01h54m56s)

that span I guess it'd have to be an


[01:55:01,180 --> 01:55:06,130](https://youtu.be/kMghsCXZQ9Y?t=01h55m01s)

ansi control code wouldn't it no or


[01:55:03,430 --> 01:55:10,210](https://youtu.be/kMghsCXZQ9Y?t=01h55m03s)

would you actually effectively duplicate


[01:55:06,130 --> 01:55:12,400](https://youtu.be/kMghsCXZQ9Y?t=01h55m06s)

this data exposed I mean that's what we


[01:55:10,210 --> 01:55:16,480](https://youtu.be/kMghsCXZQ9Y?t=01h55m10s)

did for the files ban for example right


[01:55:12,400 --> 01:55:21,760](https://youtu.be/kMghsCXZQ9Y?t=01h55m12s)

that is true and we did it in a compiler


[01:55:16,480 --> 01:55:23,560](https://youtu.be/kMghsCXZQ9Y?t=01h55m16s)

size way by using name of we actively


[01:55:21,760 --> 01:55:26,770](https://youtu.be/kMghsCXZQ9Y?t=01h55m21s)

act upon them by name we index them by


[01:55:23,560 --> 01:55:28,780](https://youtu.be/kMghsCXZQ9Y?t=01h55m23s)

name so it's a you know it's it's a


[01:55:26,770 --> 01:55:33,220](https://youtu.be/kMghsCXZQ9Y?t=01h55m26s)

glorified string it's a string but with


[01:55:28,780 --> 01:55:37,900](https://youtu.be/kMghsCXZQ9Y?t=01h55m28s)

some compiler you know differentiated by


[01:55:33,220 --> 01:55:39,640](https://youtu.be/kMghsCXZQ9Y?t=01h55m33s)

type so the compiler can help us out but


[01:55:37,900 --> 01:55:42,670](https://youtu.be/kMghsCXZQ9Y?t=01h55m37s)

the thing that matters about at the


[01:55:39,640 --> 01:55:44,680](https://youtu.be/kMghsCXZQ9Y?t=01h55m39s)

bottom of that into the string got it so


[01:55:42,670 --> 01:55:47,740](https://youtu.be/kMghsCXZQ9Y?t=01h55m42s)

we end up with a cursor span with a


[01:55:44,680 --> 01:55:54,150](https://youtu.be/kMghsCXZQ9Y?t=01h55m44s)

bunch of statics on it for you know move


[01:55:47,740 --> 01:55:54,150](https://youtu.be/kMghsCXZQ9Y?t=01h55m47s)

position or show/hide etc yeah


[01:55:55,480 --> 01:56:00,679](https://youtu.be/kMghsCXZQ9Y?t=01h55m55s)

it's not a bad idea you know I think I


[01:55:59,690 --> 01:56:02,059](https://youtu.be/kMghsCXZQ9Y?t=01h55m59s)

think we had considered that these


[01:56:00,679 --> 01:56:04,130](https://youtu.be/kMghsCXZQ9Y?t=01h56m00s)

things could also just they could just


[01:56:02,059 --> 01:56:05,960](https://youtu.be/kMghsCXZQ9Y?t=01h56m02s)

as easily be methods but the thing is


[01:56:04,130 --> 01:56:08,329](https://youtu.be/kMghsCXZQ9Y?t=01h56m04s)

that you know if their methods then


[01:56:05,960 --> 01:56:10,159](https://youtu.be/kMghsCXZQ9Y?t=01h56m05s)

you'd imagine a method a class that


[01:56:08,329 --> 01:56:11,239](https://youtu.be/kMghsCXZQ9Y?t=01h56m08s)

grows over time whereas this is a little


[01:56:10,159 --> 01:56:12,650](https://youtu.be/kMghsCXZQ9Y?t=01h56m10s)

bit easier to come in and say you know


[01:56:11,239 --> 01:56:17,900](https://youtu.be/kMghsCXZQ9Y?t=01h56m11s)

what I would actually like to implement


[01:56:12,650 --> 01:56:19,039](https://youtu.be/kMghsCXZQ9Y?t=01h56m12s)

this obscure additional escape code so


[01:56:17,900 --> 01:56:21,110](https://youtu.be/kMghsCXZQ9Y?t=01h56m17s)

this kind of lets people bring in


[01:56:19,039 --> 01:56:25,880](https://youtu.be/kMghsCXZQ9Y?t=01h56m19s)

additional functionality without having


[01:56:21,110 --> 01:56:31,730](https://youtu.be/kMghsCXZQ9Y?t=01h56m21s)

to go on extend classes or River but it


[01:56:25,880 --> 01:56:36,380](https://youtu.be/kMghsCXZQ9Y?t=01h56m25s)

is very kind of close to the middle that


[01:56:31,730 --> 01:56:38,659](https://youtu.be/kMghsCXZQ9Y?t=01h56m31s)

is true okay well I think we have two


[01:56:36,380 --> 01:56:44,150](https://youtu.be/kMghsCXZQ9Y?t=01h56m36s)

options we go and implement it now or we


[01:56:38,659 --> 01:56:45,860](https://youtu.be/kMghsCXZQ9Y?t=01h56m38s)

document it for later uh I think I would


[01:56:44,150 --> 01:56:47,539](https://youtu.be/kMghsCXZQ9Y?t=01h56m44s)

vote for the documented for later part I


[01:56:45,860 --> 01:56:52,699](https://youtu.be/kMghsCXZQ9Y?t=01h56m45s)

don't know how long you want to spend on


[01:56:47,539 --> 01:56:55,969](https://youtu.be/kMghsCXZQ9Y?t=01h56m47s)

this tonight but I think well probably


[01:56:52,699 --> 01:56:57,730](https://youtu.be/kMghsCXZQ9Y?t=01h56m52s)

not too much longer we're getting close


[01:56:55,969 --> 01:57:03,980](https://youtu.be/kMghsCXZQ9Y?t=01h56m55s)

to that two-hour mark and I


[01:56:57,730 --> 01:57:05,389](https://youtu.be/kMghsCXZQ9Y?t=01h56m57s)

unfortunately have to get up for the my


[01:57:03,980 --> 01:57:09,110](https://youtu.be/kMghsCXZQ9Y?t=01h57m03s)

son's hospital room tomorrow


[01:57:05,389 --> 01:57:13,179](https://youtu.be/kMghsCXZQ9Y?t=01h57m05s)

yeah yeah it works I've got it yeah I've


[01:57:09,110 --> 01:57:13,179](https://youtu.be/kMghsCXZQ9Y?t=01h57m09s)

got a I've got a day tomorrow as well um


[01:57:13,659 --> 01:57:18,860](https://youtu.be/kMghsCXZQ9Y?t=01h57m13s)

so we can we can open an issue for it


[01:57:16,280 --> 01:57:21,710](https://youtu.be/kMghsCXZQ9Y?t=01h57m16s)

yeah let's document this or then real


[01:57:18,860 --> 01:57:24,019](https://youtu.be/kMghsCXZQ9Y?t=01h57m18s)

quick and we'll go through and have it


[01:57:21,710 --> 01:57:25,340](https://youtu.be/kMghsCXZQ9Y?t=01h57m21s)

for later maybe we'll get lucky somebody


[01:57:24,019 --> 01:57:27,320](https://youtu.be/kMghsCXZQ9Y?t=01h57m24s)

on the stream wants to go and pick this


[01:57:25,340 --> 01:57:31,360](https://youtu.be/kMghsCXZQ9Y?t=01h57m25s)

up and get it knocked out tonight you


[01:57:27,320 --> 01:57:31,360](https://youtu.be/kMghsCXZQ9Y?t=01h57m27s)

could have a poor request by morning Hey


[01:57:34,119 --> 01:57:37,119](https://youtu.be/kMghsCXZQ9Y?t=01h57m34s)

okay


[01:57:38,030 --> 01:57:48,320](https://youtu.be/kMghsCXZQ9Y?t=01h57m38s)

so let's open on an issue here I want to


[01:57:44,999 --> 01:57:50,909](https://youtu.be/kMghsCXZQ9Y?t=01h57m44s)

put the rendering label on it


[01:57:48,320 --> 01:57:55,380](https://youtu.be/kMghsCXZQ9Y?t=01h57m48s)

input Help Wanted who knows if it's a


[01:57:50,909 --> 01:57:59,749](https://youtu.be/kMghsCXZQ9Y?t=01h57m50s)

good first issue sure how much at the


[01:57:55,380 --> 01:57:59,749](https://youtu.be/kMghsCXZQ9Y?t=01h57m55s)

stream the person's been watching yeah


[01:58:00,630 --> 01:58:07,380](https://youtu.be/kMghsCXZQ9Y?t=01h58m00s)

good first issue though the the the


[01:58:04,469 --> 01:58:10,289](https://youtu.be/kMghsCXZQ9Y?t=01h58m04s)

convention and you know across the


[01:58:07,380 --> 01:58:13,219](https://youtu.be/kMghsCXZQ9Y?t=01h58m07s)

dotnet open source projects is that when


[01:58:10,289 --> 01:58:16,380](https://youtu.be/kMghsCXZQ9Y?t=01h58m10s)

I put you know for me as a you know


[01:58:13,219 --> 01:58:17,909](https://youtu.be/kMghsCXZQ9Y?t=01h58m13s)

contributor on the project if I hook


[01:58:16,380 --> 01:58:19,439](https://youtu.be/kMghsCXZQ9Y?t=01h58m16s)

good first issue on something I


[01:58:17,909 --> 01:58:22,979](https://youtu.be/kMghsCXZQ9Y?t=01h58m17s)

basically signed myself up to help


[01:58:19,439 --> 01:58:27,389](https://youtu.be/kMghsCXZQ9Y?t=01h58m19s)

somebody move a PR to completion on that


[01:58:22,979 --> 01:58:28,920](https://youtu.be/kMghsCXZQ9Y?t=01h58m22s)

issue so I'm I'm you know I can I can


[01:58:27,389 --> 01:58:36,749](https://youtu.be/kMghsCXZQ9Y?t=01h58m27s)

provide how about provide code reviews


[01:58:28,920 --> 01:58:38,010](https://youtu.be/kMghsCXZQ9Y?t=01h58m28s)

etc so for anybody watching this keep


[01:58:36,749 --> 01:58:40,769](https://youtu.be/kMghsCXZQ9Y?t=01h58m36s)

that in mind if you want to contribute


[01:58:38,010 --> 01:58:42,900](https://youtu.be/kMghsCXZQ9Y?t=01h58m38s)

to this how do you all of the issues


[01:58:40,769 --> 01:58:44,670](https://youtu.be/kMghsCXZQ9Y?t=01h58m40s)

labeled with good first issue especially


[01:58:42,900 --> 01:58:47,309](https://youtu.be/kMghsCXZQ9Y?t=01h58m42s)

if John's put it on there you can see


[01:58:44,670 --> 01:58:49,729](https://youtu.be/kMghsCXZQ9Y?t=01h58m44s)

these clearly a helpful individual who's


[01:58:47,309 --> 01:58:49,729](https://youtu.be/kMghsCXZQ9Y?t=01h58m47s)

good at this


[01:58:54,410 --> 01:59:03,710](https://youtu.be/kMghsCXZQ9Y?t=01h58m54s)

kind of hard one to explain yeah well I


[01:59:00,290 --> 01:59:05,660](https://youtu.be/kMghsCXZQ9Y?t=01h59m00s)

think so I think for a first cut without


[01:59:03,710 --> 01:59:06,710](https://youtu.be/kMghsCXZQ9Y?t=01h59m03s)

and I don't necessarily I wouldn't


[01:59:05,660 --> 01:59:10,130](https://youtu.be/kMghsCXZQ9Y?t=01h59m05s)

expect somebody to go through an


[01:59:06,710 --> 01:59:12,320](https://youtu.be/kMghsCXZQ9Y?t=01h59m06s)

implement it but I would expect the the


[01:59:10,130 --> 01:59:14,390](https://youtu.be/kMghsCXZQ9Y?t=01h59m10s)

spans to be there and then the


[01:59:12,320 --> 01:59:16,400](https://youtu.be/kMghsCXZQ9Y?t=01h59m12s)

corresponding visitor methods to be


[01:59:14,390 --> 01:59:19,280](https://youtu.be/kMghsCXZQ9Y?t=01h59m14s)

created yeah


[01:59:16,400 --> 01:59:21,260](https://youtu.be/kMghsCXZQ9Y?t=01h59m16s)

and obviously corresponding unit tests


[01:59:19,280 --> 01:59:24,220](https://youtu.be/kMghsCXZQ9Y?t=01h59m19s)

because those visitors I believe are


[01:59:21,260 --> 01:59:24,220](https://youtu.be/kMghsCXZQ9Y?t=01h59m21s)

fairly well tested


[02:00:26,400 --> 02:00:30,429](https://youtu.be/kMghsCXZQ9Y?t=02h00m26s)

so while you're typing that I'll just go


[02:00:29,199 --> 02:00:33,340](https://youtu.be/kMghsCXZQ9Y?t=02h00m29s)

back through and make sure that I'm


[02:00:30,429 --> 02:00:36,810](https://youtu.be/kMghsCXZQ9Y?t=02h00m30s)

clear on exactly what we said we were


[02:00:33,340 --> 02:00:43,060](https://youtu.be/kMghsCXZQ9Y?t=02h00m33s)

going to do is we'll have effectively a


[02:00:36,810 --> 02:00:45,790](https://youtu.be/kMghsCXZQ9Y?t=02h00m36s)

cursor span class that mimics what we


[02:00:43,060 --> 02:00:48,989](https://youtu.be/kMghsCXZQ9Y?t=02h00m43s)

have for the was a format span I think


[02:00:45,790 --> 02:00:53,260](https://youtu.be/kMghsCXZQ9Y?t=02h00m45s)

that had the various blink bold etc


[02:00:48,989 --> 02:00:56,909](https://youtu.be/kMghsCXZQ9Y?t=02h00m48s)

methods on there yep not format stance


[02:00:53,260 --> 02:00:56,909](https://youtu.be/kMghsCXZQ9Y?t=02h00m53s)

span style span


[02:00:57,409 --> 02:01:05,840](https://youtu.be/kMghsCXZQ9Y?t=02h00m57s)

I think and then on the each of the


[02:01:04,070 --> 02:01:10,699](https://youtu.be/kMghsCXZQ9Y?t=02h01m04s)

visitors they should watch for this


[02:01:05,840 --> 02:01:12,590](https://youtu.be/kMghsCXZQ9Y?t=02h01m05s)

given span type and the the ANSI visitor


[02:01:10,699 --> 02:01:15,230](https://youtu.be/kMghsCXZQ9Y?t=02h01m10s)

should obviously convert it into the


[02:01:12,590 --> 02:01:17,560](https://youtu.be/kMghsCXZQ9Y?t=02h01m12s)

corresponding ANSI control codes or


[02:01:15,230 --> 02:01:22,400](https://youtu.be/kMghsCXZQ9Y?t=02h01m15s)

escape sequences yep


[02:01:17,560 --> 02:01:25,610](https://youtu.be/kMghsCXZQ9Y?t=02h01m17s)

the the non ANSI visitor should convert


[02:01:22,400 --> 02:01:28,100](https://youtu.be/kMghsCXZQ9Y?t=02h01m22s)

it into system console calls because at


[02:01:25,610 --> 02:01:34,520](https://youtu.be/kMghsCXZQ9Y?t=02h01m25s)

least the cursor positioning stuff


[02:01:28,100 --> 02:01:41,420](https://youtu.be/kMghsCXZQ9Y?t=02h01m28s)

system console does support and then for


[02:01:34,520 --> 02:01:43,070](https://youtu.be/kMghsCXZQ9Y?t=02h01m34s)

the for the plain text visitor I think


[02:01:41,420 --> 02:01:45,380](https://youtu.be/kMghsCXZQ9Y?t=02h01m41s)

it's just straight-up ignore them


[02:01:43,070 --> 02:01:48,320](https://youtu.be/kMghsCXZQ9Y?t=02h01m43s)

yeah that's almost always the case the


[02:01:45,380 --> 02:01:50,780](https://youtu.be/kMghsCXZQ9Y?t=02h01m45s)

plain text visitor is it ignores


[02:01:48,320 --> 02:01:52,000](https://youtu.be/kMghsCXZQ9Y?t=02h01m48s)

everything but content basically yeah


[02:01:50,780 --> 02:01:54,920](https://youtu.be/kMghsCXZQ9Y?t=02h01m50s)

exactly


[02:01:52,000 --> 02:01:58,250](https://youtu.be/kMghsCXZQ9Y?t=02h01m52s)

so that one's simple don't add a method


[02:01:54,920 --> 02:02:00,080](https://youtu.be/kMghsCXZQ9Y?t=02h01m54s)

to it yes I think the base visitor


[02:01:58,250 --> 02:02:05,540](https://youtu.be/kMghsCXZQ9Y?t=02h01m58s)

implementation is just empty for


[02:02:00,080 --> 02:02:09,110](https://youtu.be/kMghsCXZQ9Y?t=02h02m00s)

everything so this is what is this one


[02:02:05,540 --> 02:02:11,500](https://youtu.be/kMghsCXZQ9Y?t=02h02m05s)

called the non ANSI rendering span


[02:02:09,110 --> 02:02:11,500](https://youtu.be/kMghsCXZQ9Y?t=02h02m09s)

visitor


[02:02:26,239 --> 02:02:30,449](https://youtu.be/kMghsCXZQ9Y?t=02h02m26s)

this is one thing that I would love


[02:02:28,619 --> 02:02:32,670](https://youtu.be/kMghsCXZQ9Y?t=02h02m28s)

github implemented is some way to


[02:02:30,449 --> 02:02:37,880](https://youtu.be/kMghsCXZQ9Y?t=02h02m30s)

effectively link stuff in your comments


[02:02:32,670 --> 02:02:39,900](https://youtu.be/kMghsCXZQ9Y?t=02h02m32s)

to at least with like tool to or


[02:02:37,880 --> 02:02:45,679](https://youtu.be/kMghsCXZQ9Y?t=02h02m37s)

autocomplete to link to files in your


[02:02:39,900 --> 02:02:45,679](https://youtu.be/kMghsCXZQ9Y?t=02h02m39s)

repo yeah which would be awesome


[02:02:45,860 --> 02:02:49,889](https://youtu.be/kMghsCXZQ9Y?t=02h02m45s)

especially if it was smart enough if the


[02:02:47,909 --> 02:02:52,199](https://youtu.be/kMghsCXZQ9Y?t=02h02m47s)

file got renamed or whatever to update


[02:02:49,889 --> 02:02:55,010](https://youtu.be/kMghsCXZQ9Y?t=02h02m49s)

the comment on the issue so that it


[02:02:52,199 --> 02:02:55,010](https://youtu.be/kMghsCXZQ9Y?t=02h02m52s)

could follow it around


[02:02:58,200 --> 02:03:03,320](https://youtu.be/kMghsCXZQ9Y?t=02h02m58s)

I'll keep wishing someday I'll get it


[02:03:04,700 --> 02:03:12,810](https://youtu.be/kMghsCXZQ9Y?t=02h03m04s)

maybe that's not the best name for this


[02:03:06,780 --> 02:03:14,850](https://youtu.be/kMghsCXZQ9Y?t=02h03m06s)

time yeah because I think that output


[02:03:12,810 --> 02:03:16,410](https://youtu.be/kMghsCXZQ9Y?t=02h03m12s)

mode used to be called file at one point


[02:03:14,850 --> 02:03:18,510](https://youtu.be/kMghsCXZQ9Y?t=02h03m14s)

and then it got renamed down to


[02:03:16,410 --> 02:03:20,310](https://youtu.be/kMghsCXZQ9Y?t=02h03m16s)

plaintext you don't think the span


[02:03:18,510 --> 02:03:23,840](https://youtu.be/kMghsCXZQ9Y?t=02h03m18s)

visitor just got left behind in the


[02:03:20,310 --> 02:03:23,840](https://youtu.be/kMghsCXZQ9Y?t=02h03m20s)

refactor yeah


[02:03:35,880 --> 02:03:49,500](https://youtu.be/kMghsCXZQ9Y?t=02h03m35s)

a parenthetical cool something like that


[02:03:42,390 --> 02:03:52,200](https://youtu.be/kMghsCXZQ9Y?t=02h03m42s)

sweet cool so if anybody is interested


[02:03:49,500 --> 02:03:54,900](https://youtu.be/kMghsCXZQ9Y?t=02h03m49s)

in picking up an issue and working on


[02:03:52,200 --> 02:03:58,140](https://youtu.be/kMghsCXZQ9Y?t=02h03m52s)

rendering stuff here's a good one


[02:03:54,900 --> 02:04:00,690](https://youtu.be/kMghsCXZQ9Y?t=02h03m54s)

yeah if if you want to add a link to


[02:03:58,140 --> 02:04:03,330](https://youtu.be/kMghsCXZQ9Y?t=02h03m58s)

this recording when it's available into


[02:04:00,690 --> 02:04:06,210](https://youtu.be/kMghsCXZQ9Y?t=02h04m00s)

this it'll provide more context than


[02:04:03,330 --> 02:04:08,940](https://youtu.be/kMghsCXZQ9Y?t=02h04m03s)

anyone could possibly need that is true


[02:04:06,210 --> 02:04:11,340](https://youtu.be/kMghsCXZQ9Y?t=02h04m06s)

once I get it I usually export them to


[02:04:08,940 --> 02:04:13,710](https://youtu.be/kMghsCXZQ9Y?t=02h04m08s)

YouTube and so I'll just I'll try and be


[02:04:11,340 --> 02:04:15,660](https://youtu.be/kMghsCXZQ9Y?t=02h04m11s)

convenient and also pass in the the


[02:04:13,710 --> 02:04:17,160](https://youtu.be/kMghsCXZQ9Y?t=02h04m13s)

timestamp for it so that somebody


[02:04:15,660 --> 02:04:18,390](https://youtu.be/kMghsCXZQ9Y?t=02h04m15s)

doesn't have to scroll through two hours


[02:04:17,160 --> 02:04:26,280](https://youtu.be/kMghsCXZQ9Y?t=02h04m17s)

of video to figure out whether the


[02:04:18,390 --> 02:04:28,230](https://youtu.be/kMghsCXZQ9Y?t=02h04m18s)

useful bits start yeah cool sweet well


[02:04:26,280 --> 02:04:33,360](https://youtu.be/kMghsCXZQ9Y?t=02h04m26s)

anything else you wanted to look at or


[02:04:28,230 --> 02:04:36,000](https://youtu.be/kMghsCXZQ9Y?t=02h04m28s)

any closing thoughts no not really I


[02:04:33,360 --> 02:04:38,160](https://youtu.be/kMghsCXZQ9Y?t=02h04m33s)

mean this was this was good very kind of


[02:04:36,000 --> 02:04:39,630](https://youtu.be/kMghsCXZQ9Y?t=02h04m36s)

make it up as we go so I didn't really


[02:04:38,160 --> 02:04:43,080](https://youtu.be/kMghsCXZQ9Y?t=02h04m38s)

have an agenda so I don't really have


[02:04:39,630 --> 02:04:44,760](https://youtu.be/kMghsCXZQ9Y?t=02h04m39s)

clothing boss perfect and I was relying


[02:04:43,080 --> 02:04:47,760](https://youtu.be/kMghsCXZQ9Y?t=02h04m43s)

on you for the agenda so that means I


[02:04:44,760 --> 02:04:50,100](https://youtu.be/kMghsCXZQ9Y?t=02h04m44s)

don't have much of one either so unless


[02:04:47,760 --> 02:04:52,110](https://youtu.be/kMghsCXZQ9Y?t=02h04m47s)

anyone on chat has any final questions


[02:04:50,100 --> 02:04:53,940](https://youtu.be/kMghsCXZQ9Y?t=02h04m50s)

the thoughts will probably wrap it up


[02:04:52,110 --> 02:04:56,130](https://youtu.be/kMghsCXZQ9Y?t=02h04m52s)

here but thank you John once again for


[02:04:53,940 --> 02:04:57,330](https://youtu.be/kMghsCXZQ9Y?t=02h04m53s)

coming on this is always fun I enjoy


[02:04:56,130 --> 02:04:59,790](https://youtu.be/kMghsCXZQ9Y?t=02h04m56s)

pairing with you especially going


[02:04:57,330 --> 02:05:03,270](https://youtu.be/kMghsCXZQ9Y?t=02h04m57s)

through this project it's been exciting


[02:04:59,790 --> 02:05:07,620](https://youtu.be/kMghsCXZQ9Y?t=02h04m59s)

and fun to work on so yeah likewise it's


[02:05:03,270 --> 02:05:09,090](https://youtu.be/kMghsCXZQ9Y?t=02h05m03s)

been great and this is the flashing part


[02:05:07,620 --> 02:05:13,230](https://youtu.be/kMghsCXZQ9Y?t=02h05m07s)

so people who want to get involved you


[02:05:09,090 --> 02:05:15,690](https://youtu.be/kMghsCXZQ9Y?t=02h05m09s)

know it's good almost like UI for those


[02:05:13,230 --> 02:05:19,290](https://youtu.be/kMghsCXZQ9Y?t=02h05m13s)

of us who like our WPF it does feel a


[02:05:15,690 --> 02:05:21,720](https://youtu.be/kMghsCXZQ9Y?t=02h05m15s)

little more friendly yeah though it's


[02:05:19,290 --> 02:05:30,420](https://youtu.be/kMghsCXZQ9Y?t=02h05m19s)

WPF where you have to deal with vt100


[02:05:21,720 --> 02:05:34,250](https://youtu.be/kMghsCXZQ9Y?t=02h05m21s)

so it's a weird blend so yeah the


[02:05:30,420 --> 02:05:36,570](https://youtu.be/kMghsCXZQ9Y?t=02h05m30s)

technology of future path exactly


[02:05:34,250 --> 02:05:39,360](https://youtu.be/kMghsCXZQ9Y?t=02h05m34s)

awesome and thank you Savior for hanging


[02:05:36,570 --> 02:05:40,950](https://youtu.be/kMghsCXZQ9Y?t=02h05m36s)

out we appreciate it we will probably


[02:05:39,360 --> 02:05:42,810](https://youtu.be/kMghsCXZQ9Y?t=02h05m39s)

end up doing more of these I'm sure at


[02:05:40,950 --> 02:05:45,900](https://youtu.be/kMghsCXZQ9Y?t=02h05m40s)

some point John I'll be pinging you for


[02:05:42,810 --> 02:05:47,550](https://youtu.be/kMghsCXZQ9Y?t=02h05m42s)

schedule and steal more of your time to


[02:05:45,900 --> 02:05:49,079](https://youtu.be/kMghsCXZQ9Y?t=02h05m45s)

do this stuff on the live stream it


[02:05:47,550 --> 02:05:51,869](https://youtu.be/kMghsCXZQ9Y?t=02h05m47s)

seems like this is a


[02:05:49,079 --> 02:05:56,880](https://youtu.be/kMghsCXZQ9Y?t=02h05m49s)

fairly useful if nothing else he gets me


[02:05:51,869 --> 02:05:59,369](https://youtu.be/kMghsCXZQ9Y?t=02h05m51s)

a little more involved on the project so


[02:05:56,880 --> 02:06:02,130](https://youtu.be/kMghsCXZQ9Y?t=02h05m56s)

miss I miss our weekly stand-ups on it


[02:05:59,369 --> 02:06:07,400](https://youtu.be/kMghsCXZQ9Y?t=02h05m59s)

at times so oh yeah I think this is a


[02:06:02,130 --> 02:06:11,010](https://youtu.be/kMghsCXZQ9Y?t=02h06m02s)

good format horrible yeah works well


[02:06:07,400 --> 02:06:12,239](https://youtu.be/kMghsCXZQ9Y?t=02h06m07s)

well with that I'm going to kill the


[02:06:11,010 --> 02:06:16,079](https://youtu.be/kMghsCXZQ9Y?t=02h06m11s)

stream and I will get some stuff


[02:06:12,239 --> 02:06:18,889](https://youtu.be/kMghsCXZQ9Y?t=02h06m12s)

uploading thanks guys for hanging out by


[02:06:16,079 --> 02:06:18,889](https://youtu.be/kMghsCXZQ9Y?t=02h06m16s)

fuck okay

