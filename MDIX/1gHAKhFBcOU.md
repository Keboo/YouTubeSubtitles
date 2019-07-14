[YouTube Video](https://youtu.be/1gHAKhFBcOU)


[00:01:26,280 --> 00:01:32,979](https://youtu.be/1gHAKhFBcOU?t=00h01m26s)

okay sorry for my tardiness tonight I


[00:01:30,490 --> 00:01:35,259](https://youtu.be/1gHAKhFBcOU?t=00h01m30s)

was running a little behind getting kids


[00:01:32,979 --> 00:01:38,170](https://youtu.be/1gHAKhFBcOU?t=00h01m32s)

down and my computer system set up I'm


[00:01:35,259 --> 00:01:40,030](https://youtu.be/1gHAKhFBcOU?t=00h01m35s)

playing with some new Mouse new hardware


[00:01:38,170 --> 00:01:43,180](https://youtu.be/1gHAKhFBcOU?t=00h01m38s)

and was having fun getting things set up


[00:01:40,030 --> 00:01:45,190](https://youtu.be/1gHAKhFBcOU?t=00h01m40s)

and configured so good evening tide I


[00:01:43,180 --> 00:01:47,200](https://youtu.be/1gHAKhFBcOU?t=00h01m43s)

never know how to trust my viewercount


[00:01:45,190 --> 00:01:51,750](https://youtu.be/1gHAKhFBcOU?t=00h01m45s)

because it's showing me zero right now


[00:01:47,200 --> 00:01:54,460](https://youtu.be/1gHAKhFBcOU?t=00h01m47s)

which clearly isn't completely right so


[00:01:51,750 --> 00:01:58,060](https://youtu.be/1gHAKhFBcOU?t=00h01m51s)

tonight I was going to start off going


[00:01:54,460 --> 00:02:00,789](https://youtu.be/1gHAKhFBcOU?t=00h01m54s)

through taking one of my sample apps


[00:01:58,060 --> 00:02:03,490](https://youtu.be/1gHAKhFBcOU?t=00h01m58s)

I'll grab the the repo link here for


[00:02:00,789 --> 00:02:06,570](https://youtu.be/1gHAKhFBcOU?t=00h02m00s)

anybody who wants to follow along but I


[00:02:03,490 --> 00:02:11,680](https://youtu.be/1gHAKhFBcOU?t=00h02m03s)

was going to go through and show


[00:02:06,570 --> 00:02:16,120](https://youtu.be/1gHAKhFBcOU?t=00h02m06s)

upgrading this app over to the new to


[00:02:11,680 --> 00:02:19,120](https://youtu.be/1gHAKhFBcOU?t=00h02m11s)

600 PI's and what that looks like and


[00:02:16,120 --> 00:02:21,430](https://youtu.be/1gHAKhFBcOU?t=00h02m16s)

how much code it can theoretically save


[00:02:19,120 --> 00:02:25,480](https://youtu.be/1gHAKhFBcOU?t=00h02m19s)

you now I did technically cheat ahead of


[00:02:21,430 --> 00:02:29,739](https://youtu.be/1gHAKhFBcOU?t=00h02m21s)

time and I went through and tested this


[00:02:25,480 --> 00:02:32,440](https://youtu.be/1gHAKhFBcOU?t=00h02m25s)

so spoiler alert I know ahead of time


[00:02:29,739 --> 00:02:33,790](https://youtu.be/1gHAKhFBcOU?t=00h02m29s)

that it should be working though I did


[00:02:32,440 --> 00:02:36,040](https://youtu.be/1gHAKhFBcOU?t=00h02m32s)

push some changes and we're gonna try a


[00:02:33,790 --> 00:02:39,040](https://youtu.be/1gHAKhFBcOU?t=00h02m33s)

new nougat package what could possibly


[00:02:36,040 --> 00:02:41,200](https://youtu.be/1gHAKhFBcOU?t=00h02m36s)

go wrong with trying stuff with the


[00:02:39,040 --> 00:02:44,140](https://youtu.be/1gHAKhFBcOU?t=00h02m39s)

latest and greatest so there's the repo


[00:02:41,200 --> 00:02:48,299](https://youtu.be/1gHAKhFBcOU?t=00h02m41s)

link for anybody who wants to actually


[00:02:44,140 --> 00:02:53,739](https://youtu.be/1gHAKhFBcOU?t=00h02m44s)

follow along and look let me switch here


[00:02:48,299 --> 00:02:56,769](https://youtu.be/1gHAKhFBcOU?t=00h02m48s)

okay so let's dive here and I will just


[00:02:53,739 --> 00:03:03,090](https://youtu.be/1gHAKhFBcOU?t=00h02m53s)

fire this up and show off what this app


[00:02:56,769 --> 00:03:07,870](https://youtu.be/1gHAKhFBcOU?t=00h02m56s)

does so I initially wrote this as a


[00:03:03,090 --> 00:03:11,950](https://youtu.be/1gHAKhFBcOU?t=00h03m03s)

proof of concept on the the old to 5x


[00:03:07,870 --> 00:03:13,989](https://youtu.be/1gHAKhFBcOU?t=00h03m07s)

interface or API for what it takes to do


[00:03:11,950 --> 00:03:16,780](https://youtu.be/1gHAKhFBcOU?t=00h03m11s)

custom theming so a lot of this stuff is


[00:03:13,989 --> 00:03:19,420](https://youtu.be/1gHAKhFBcOU?t=00h03m13s)

based heavily in law around what you see


[00:03:16,780 --> 00:03:20,920](https://youtu.be/1gHAKhFBcOU?t=00h03m16s)

in the demo app but you'll notice


[00:03:19,420 --> 00:03:23,290](https://youtu.be/1gHAKhFBcOU?t=00h03m19s)

there's a couple interesting bits in


[00:03:20,920 --> 00:03:25,900](https://youtu.be/1gHAKhFBcOU?t=00h03m20s)

that this is actually my apps in


[00:03:23,290 --> 00:03:28,780](https://youtu.be/1gHAKhFBcOU?t=00h03m23s)

addition to the normal material design


[00:03:25,900 --> 00:03:33,220](https://youtu.be/1gHAKhFBcOU?t=00h03m25s)

and zamel so we've got the normal


[00:03:28,780 --> 00:03:34,569](https://youtu.be/1gHAKhFBcOU?t=00h03m28s)

material design built in palettes at


[00:03:33,220 --> 00:03:36,849](https://youtu.be/1gHAKhFBcOU?t=00h03m33s)

least as they were called in the


[00:03:34,569 --> 00:03:38,650](https://youtu.be/1gHAKhFBcOU?t=00h03m34s)

two-five oh we've got light theme dark


[00:03:36,849 --> 00:03:40,840](https://youtu.be/1gHAKhFBcOU?t=00h03m36s)

theme you can


[00:03:38,650 --> 00:03:43,870](https://youtu.be/1gHAKhFBcOU?t=00h03m38s)

your tab stuff there but the interesting


[00:03:40,840 --> 00:03:45,129](https://youtu.be/1gHAKhFBcOU?t=00h03m40s)

one are these final two themes that


[00:03:43,870 --> 00:03:47,049](https://youtu.be/1gHAKhFBcOU?t=00h03m43s)

we've got down here so you can see


[00:03:45,129 --> 00:03:49,239](https://youtu.be/1gHAKhFBcOU?t=00h03m45s)

they've got special colors for their


[00:03:47,049 --> 00:03:53,730](https://youtu.be/1gHAKhFBcOU?t=00h03m47s)

primary mid and light the accent colors


[00:03:49,239 --> 00:03:56,950](https://youtu.be/1gHAKhFBcOU?t=00h03m49s)

are a little odd they change out here


[00:03:53,730 --> 00:03:59,079](https://youtu.be/1gHAKhFBcOU?t=00h03m53s)

and these two are both custom themes and


[00:03:56,950 --> 00:04:03,010](https://youtu.be/1gHAKhFBcOU?t=00h03m56s)

this is the area that was really painful


[00:03:59,079 --> 00:04:05,370](https://youtu.be/1gHAKhFBcOU?t=00h03m59s)

on the old API going through and saying


[00:04:03,010 --> 00:04:08,230](https://youtu.be/1gHAKhFBcOU?t=00h04m03s)

oh I want something beyond the normal


[00:04:05,370 --> 00:04:10,810](https://youtu.be/1gHAKhFBcOU?t=00h04m05s)

built-in color schemes and also I want


[00:04:08,230 --> 00:04:13,030](https://youtu.be/1gHAKhFBcOU?t=00h04m08s)

to let my users toggle between my custom


[00:04:10,810 --> 00:04:15,129](https://youtu.be/1gHAKhFBcOU?t=00h04m10s)

themes and the built-in themes was not


[00:04:13,030 --> 00:04:18,190](https://youtu.be/1gHAKhFBcOU?t=00h04m13s)

necessarily trivial and this is this


[00:04:15,129 --> 00:04:21,280](https://youtu.be/1gHAKhFBcOU?t=00h04m15s)

whole app is sort of a testament to how


[00:04:18,190 --> 00:04:22,900](https://youtu.be/1gHAKhFBcOU?t=00h04m18s)

complex it was so I'm just going to walk


[00:04:21,280 --> 00:04:24,190](https://youtu.be/1gHAKhFBcOU?t=00h04m21s)

through a little bit of this code and


[00:04:22,900 --> 00:04:26,560](https://youtu.be/1gHAKhFBcOU?t=00h04m22s)

then we're gonna throw a lot of it away


[00:04:24,190 --> 00:04:29,860](https://youtu.be/1gHAKhFBcOU?t=00h04m24s)

as we update to the new one this writing


[00:04:26,560 --> 00:04:31,240](https://youtu.be/1gHAKhFBcOU?t=00h04m26s)

this was kind of proof that I needed to


[00:04:29,860 --> 00:04:36,190](https://youtu.be/1gHAKhFBcOU?t=00h04m29s)

jump in and actually do something about


[00:04:31,240 --> 00:04:38,860](https://youtu.be/1gHAKhFBcOU?t=00h04m31s)

the API so there's got so well let's


[00:04:36,190 --> 00:04:41,320](https://youtu.be/1gHAKhFBcOU?t=00h04m36s)

let's start with the sam'l that's


[00:04:38,860 --> 00:04:43,840](https://youtu.be/1gHAKhFBcOU?t=00h04m38s)

probably the easier one so it's a fairly


[00:04:41,320 --> 00:04:46,840](https://youtu.be/1gHAKhFBcOU?t=00h04m41s)

simple layout there is an item's control


[00:04:43,840 --> 00:04:50,590](https://youtu.be/1gHAKhFBcOU?t=00h04m43s)

which is bound to the theme colors this


[00:04:46,840 --> 00:04:53,530](https://youtu.be/1gHAKhFBcOU?t=00h04m46s)

uses a theme color view model as its


[00:04:50,590 --> 00:04:55,510](https://youtu.be/1gHAKhFBcOU?t=00h04m50s)

data template and this data template is


[00:04:53,530 --> 00:04:58,440](https://youtu.be/1gHAKhFBcOU?t=00h04m53s)

really just a fancy button with that


[00:04:55,510 --> 00:05:01,289](https://youtu.be/1gHAKhFBcOU?t=00h04m55s)

ellipse and text box inside of it so


[00:04:58,440 --> 00:05:04,210](https://youtu.be/1gHAKhFBcOU?t=00h04m58s)

this kind of look that you see here


[00:05:01,289 --> 00:05:06,190](https://youtu.be/1gHAKhFBcOU?t=00h05m01s)

obviously I spent a not a whole lot on


[00:05:04,210 --> 00:05:08,830](https://youtu.be/1gHAKhFBcOU?t=00h05m04s)

the design of this but got it just


[00:05:06,190 --> 00:05:11,320](https://youtu.be/1gHAKhFBcOU?t=00h05m06s)

laying out as much as I needed to


[00:05:08,830 --> 00:05:13,750](https://youtu.be/1gHAKhFBcOU?t=00h05m08s)

and then then down underneath there is


[00:05:11,320 --> 00:05:16,720](https://youtu.be/1gHAKhFBcOU?t=00h05m11s)

some color zones because these are


[00:05:13,750 --> 00:05:19,510](https://youtu.be/1gHAKhFBcOU?t=00h05m13s)

really easy to show off the color themes


[00:05:16,720 --> 00:05:22,389](https://youtu.be/1gHAKhFBcOU?t=00h05m16s)

for the primary mid light as well as the


[00:05:19,510 --> 00:05:25,090](https://youtu.be/1gHAKhFBcOU?t=00h05m19s)

inverted colors and then a tab control


[00:05:22,389 --> 00:05:27,760](https://youtu.be/1gHAKhFBcOU?t=00h05m22s)

because it's one of the MA apps themes


[00:05:25,090 --> 00:05:29,530](https://youtu.be/1gHAKhFBcOU?t=00h05m25s)

that styles and uses quite a few of the


[00:05:27,760 --> 00:05:30,789](https://youtu.be/1gHAKhFBcOU?t=00h05m27s)

brushes so it makes it easy to kind of


[00:05:29,530 --> 00:05:33,820](https://youtu.be/1gHAKhFBcOU?t=00h05m29s)

just show off especially with like the


[00:05:30,789 --> 00:05:35,620](https://youtu.be/1gHAKhFBcOU?t=00h05m30s)

the press color the hover color and all


[00:05:33,820 --> 00:05:40,120](https://youtu.be/1gHAKhFBcOU?t=00h05m33s)

of that going through and showing that


[00:05:35,620 --> 00:05:44,530](https://youtu.be/1gHAKhFBcOU?t=00h05m35s)

off the view model itself it pulls from


[00:05:40,120 --> 00:05:47,469](https://youtu.be/1gHAKhFBcOU?t=00h05m40s)

the old swatch provider not all of the


[00:05:44,530 --> 00:05:50,500](https://youtu.be/1gHAKhFBcOU?t=00h05m44s)

swatches in the to five Oh actually have


[00:05:47,469 --> 00:05:52,449](https://youtu.be/1gHAKhFBcOU?t=00h05m47s)

accent colors as well so it limits


[00:05:50,500 --> 00:05:56,949](https://youtu.be/1gHAKhFBcOU?t=00h05m50s)

itself down to just the swatches


[00:05:52,449 --> 00:06:00,909](https://youtu.be/1gHAKhFBcOU?t=00h05m52s)

that actually have accents and then goes


[00:05:56,949 --> 00:06:03,249](https://youtu.be/1gHAKhFBcOU?t=00h05m56s)

and creates these this theme object and


[00:06:00,909 --> 00:06:07,990](https://youtu.be/1gHAKhFBcOU?t=00h06m00s)

puts that into with a view model so this


[00:06:03,249 --> 00:06:10,749](https://youtu.be/1gHAKhFBcOU?t=00h06m03s)

theme object itself looks a lot like the


[00:06:07,990 --> 00:06:14,020](https://youtu.be/1gHAKhFBcOU?t=00h06m07s)

old API in that it keeps a list of hues


[00:06:10,749 --> 00:06:15,669](https://youtu.be/1gHAKhFBcOU?t=00h06m10s)

it's got some indexes into that list as


[00:06:14,020 --> 00:06:18,639](https://youtu.be/1gHAKhFBcOU?t=00h06m14s)

far as which one's the light mid and


[00:06:15,669 --> 00:06:21,759](https://youtu.be/1gHAKhFBcOU?t=00h06m15s)

dark and then it's also got a secondary


[00:06:18,639 --> 00:06:23,469](https://youtu.be/1gHAKhFBcOU?t=00h06m18s)

accent hue and then it has the ability


[00:06:21,759 --> 00:06:25,710](https://youtu.be/1gHAKhFBcOU?t=00h06m21s)

to go through and generate a palette


[00:06:23,469 --> 00:06:29,520](https://youtu.be/1gHAKhFBcOU?t=00h06m23s)

which in the to 500 interface was the


[00:06:25,710 --> 00:06:32,830](https://youtu.be/1gHAKhFBcOU?t=00h06m25s)

effectively complete color theme so


[00:06:29,520 --> 00:06:34,749](https://youtu.be/1gHAKhFBcOU?t=00h06m29s)

every time you build up one of these


[00:06:32,830 --> 00:06:38,379](https://youtu.be/1gHAKhFBcOU?t=00h06m32s)

little colors its building up one of


[00:06:34,749 --> 00:06:41,039](https://youtu.be/1gHAKhFBcOU?t=00h06m34s)

these theme objects and then those in


[00:06:38,379 --> 00:06:43,419](https://youtu.be/1gHAKhFBcOU?t=00h06m38s)

turn are being shoved into a view model


[00:06:41,039 --> 00:06:45,999](https://youtu.be/1gHAKhFBcOU?t=00h06m41s)

which just makes it a little easier to


[00:06:43,419 --> 00:06:48,460](https://youtu.be/1gHAKhFBcOU?t=00h06m43s)

pull off a sample brush which is what


[00:06:45,999 --> 00:06:51,399](https://youtu.be/1gHAKhFBcOU?t=00h06m45s)

gets used to show off this color in the


[00:06:48,460 --> 00:06:53,139](https://youtu.be/1gHAKhFBcOU?t=00h06m48s)

ellipse as well as a name and then


[00:06:51,399 --> 00:06:54,939](https://youtu.be/1gHAKhFBcOU?t=00h06m51s)

obviously the theme that it needs to go


[00:06:53,139 --> 00:06:57,729](https://youtu.be/1gHAKhFBcOU?t=00h06m53s)

through and do it so and these are


[00:06:54,939 --> 00:07:00,310](https://youtu.be/1gHAKhFBcOU?t=00h06m54s)

pretty simple and straightforward setups


[00:06:57,729 --> 00:07:05,229](https://youtu.be/1gHAKhFBcOU?t=00h06m57s)

in general I'd probably tell people


[00:07:00,310 --> 00:07:09,610](https://youtu.be/1gHAKhFBcOU?t=00h07m00s)

avoid view models with brushes in them I


[00:07:05,229 --> 00:07:11,529](https://youtu.be/1gHAKhFBcOU?t=00h07m05s)

tend to advocate for not having view


[00:07:09,610 --> 00:07:14,139](https://youtu.be/1gHAKhFBcOU?t=00h07m09s)

models reference anything inside of the


[00:07:11,529 --> 00:07:16,029](https://youtu.be/1gHAKhFBcOU?t=00h07m11s)

system windows namespace usually that's


[00:07:14,139 --> 00:07:19,569](https://youtu.be/1gHAKhFBcOU?t=00h07m14s)

an indicator that you're mixing view


[00:07:16,029 --> 00:07:21,969](https://youtu.be/1gHAKhFBcOU?t=00h07m16s)

code with your view models so in general


[00:07:19,569 --> 00:07:25,240](https://youtu.be/1gHAKhFBcOU?t=00h07m19s)

normally what I would do is just expose


[00:07:21,969 --> 00:07:26,770](https://youtu.be/1gHAKhFBcOU?t=00h07m21s)

up the color and then let a value


[00:07:25,240 --> 00:07:29,050](https://youtu.be/1gHAKhFBcOU?t=00h07m25s)

convert or convert between the color and


[00:07:26,770 --> 00:07:30,520](https://youtu.be/1gHAKhFBcOU?t=00h07m26s)

brush because really this view model


[00:07:29,050 --> 00:07:32,680](https://youtu.be/1gHAKhFBcOU?t=00h07m29s)

only has a color the fact that it's a


[00:07:30,520 --> 00:07:35,259](https://youtu.be/1gHAKhFBcOU?t=00h07m30s)

solid color brush is an implementation


[00:07:32,680 --> 00:07:38,949](https://youtu.be/1gHAKhFBcOU?t=00h07m32s)

detail of the view and view model should


[00:07:35,259 --> 00:07:41,399](https://youtu.be/1gHAKhFBcOU?t=00h07m35s)

be agnostic of your views I tend to be a


[00:07:38,949 --> 00:07:43,360](https://youtu.be/1gHAKhFBcOU?t=00h07m38s)

more of an mvvm purist in that regard


[00:07:41,399 --> 00:07:45,219](https://youtu.be/1gHAKhFBcOU?t=00h07m41s)

but the most important thing is that


[00:07:43,360 --> 00:07:48,839](https://youtu.be/1gHAKhFBcOU?t=00h07m43s)

your app ships so whatever gets you to


[00:07:45,219 --> 00:07:52,539](https://youtu.be/1gHAKhFBcOU?t=00h07m45s)

there quickest and hopefully unit tested


[00:07:48,839 --> 00:07:55,839](https://youtu.be/1gHAKhFBcOU?t=00h07m48s)

so this is the the whole app there is


[00:07:52,539 --> 00:07:59,409](https://youtu.be/1gHAKhFBcOU?t=00h07m52s)

this palette helper class that I ended


[00:07:55,839 --> 00:08:04,990](https://youtu.be/1gHAKhFBcOU?t=00h07m55s)

up writing because part of the old to


[00:07:59,409 --> 00:08:06,289](https://youtu.be/1gHAKhFBcOU?t=00h07m59s)

five-o interface oh cool


[00:08:04,990 --> 00:08:07,629](https://youtu.be/1gHAKhFBcOU?t=00h08m04s)

remind me tide once I get


[00:08:06,289 --> 00:08:10,219](https://youtu.be/1gHAKhFBcOU?t=00h08m06s)

through this I want to come back and and


[00:08:07,629 --> 00:08:12,349](https://youtu.be/1gHAKhFBcOU?t=00h08m07s)

look at that question because I think


[00:08:10,219 --> 00:08:15,830](https://youtu.be/1gHAKhFBcOU?t=00h08m10s)

this may help a little bit with doing it


[00:08:12,349 --> 00:08:17,719](https://youtu.be/1gHAKhFBcOU?t=00h08m12s)

so on the MA app side of things this


[00:08:15,830 --> 00:08:20,899](https://youtu.be/1gHAKhFBcOU?t=00h08m15s)

palette helper is deriving from the old


[00:08:17,719 --> 00:08:22,849](https://youtu.be/1gHAKhFBcOU?t=00h08m17s)

palette helper because all of the MA


[00:08:20,899 --> 00:08:25,159](https://youtu.be/1gHAKhFBcOU?t=00h08m20s)

apps have a bunch of built-in brushes


[00:08:22,849 --> 00:08:29,449](https://youtu.be/1gHAKhFBcOU?t=00h08m22s)

that need to get set in order for all of


[00:08:25,159 --> 00:08:31,249](https://youtu.be/1gHAKhFBcOU?t=00h08m25s)

the MA apps controls to actually have


[00:08:29,449 --> 00:08:33,259](https://youtu.be/1gHAKhFBcOU?t=00h08m29s)

their color thing set which is why I


[00:08:31,249 --> 00:08:34,610](https://youtu.be/1gHAKhFBcOU?t=00h08m31s)

left this sort of tab control in here


[00:08:33,259 --> 00:08:36,979](https://youtu.be/1gHAKhFBcOU?t=00h08m33s)

just to make sure that things were


[00:08:34,610 --> 00:08:38,479](https://youtu.be/1gHAKhFBcOU?t=00h08m34s)

actually propagating correctly and you


[00:08:36,979 --> 00:08:40,579](https://youtu.be/1gHAKhFBcOU?t=00h08m36s)

can also see some of the brushes in like


[00:08:38,479 --> 00:08:41,899](https://youtu.be/1gHAKhFBcOU?t=00h08m38s)

the the window theme or even this


[00:08:40,579 --> 00:08:43,430](https://youtu.be/1gHAKhFBcOU?t=00h08m40s)

outliner


[00:08:41,899 --> 00:08:45,529](https://youtu.be/1gHAKhFBcOU?t=00h08m41s)

if you look really closely there's kind


[00:08:43,430 --> 00:08:48,410](https://youtu.be/1gHAKhFBcOU?t=00h08m43s)

of this glow around the outside of the


[00:08:45,529 --> 00:08:51,170](https://youtu.be/1gHAKhFBcOU?t=00h08m45s)

window so all of these usually come in


[00:08:48,410 --> 00:08:53,089](https://youtu.be/1gHAKhFBcOU?t=00h08m48s)

from one of these brushes and just


[00:08:51,170 --> 00:08:57,259](https://youtu.be/1gHAKhFBcOU?t=00h08m51s)

getting these set up correctly


[00:08:53,089 --> 00:08:59,240](https://youtu.be/1gHAKhFBcOU?t=00h08m53s)

now the goal of all of the to 600


[00:08:57,259 --> 00:09:00,560](https://youtu.be/1gHAKhFBcOU?t=00h08m57s)

interface was to eliminate this mess so


[00:08:59,240 --> 00:09:03,250](https://youtu.be/1gHAKhFBcOU?t=00h08m59s)

that you guys don't have to do this


[00:09:00,560 --> 00:09:06,139](https://youtu.be/1gHAKhFBcOU?t=00h09m00s)

because this quite frankly was rather


[00:09:03,250 --> 00:09:07,220](https://youtu.be/1gHAKhFBcOU?t=00h09m03s)

painful once I started down the path to


[00:09:06,139 --> 00:09:10,430](https://youtu.be/1gHAKhFBcOU?t=00h09m06s)

figure out what it was going to take to


[00:09:07,220 --> 00:09:11,930](https://youtu.be/1gHAKhFBcOU?t=00h09m07s)

actually implement all of this so with


[00:09:10,430 --> 00:09:13,579](https://youtu.be/1gHAKhFBcOU?t=00h09m10s)

that in mind where we're ultimately


[00:09:11,930 --> 00:09:16,010](https://youtu.be/1gHAKhFBcOU?t=00h09m11s)

going is we're gonna switch this app


[00:09:13,579 --> 00:09:18,019](https://youtu.be/1gHAKhFBcOU?t=00h09m13s)

over to the to 600 interface and delete


[00:09:16,010 --> 00:09:21,230](https://youtu.be/1gHAKhFBcOU?t=00h09m16s)

a bunch of this code because most of


[00:09:18,019 --> 00:09:22,819](https://youtu.be/1gHAKhFBcOU?t=00h09m18s)

this shouldn't be necessary anymore tied


[00:09:21,230 --> 00:09:25,519](https://youtu.be/1gHAKhFBcOU?t=00h09m21s)

when you said you needed help with that


[00:09:22,819 --> 00:09:28,699](https://youtu.be/1gHAKhFBcOU?t=00h09m22s)

in the color picker what do you mean by


[00:09:25,519 --> 00:09:30,110](https://youtu.be/1gHAKhFBcOU?t=00h09m25s)

that is that were you referring to sort


[00:09:28,699 --> 00:09:32,300](https://youtu.be/1gHAKhFBcOU?t=00h09m28s)

of the layout and how you create those


[00:09:30,110 --> 00:09:37,790](https://youtu.be/1gHAKhFBcOU?t=00h09m30s)

theme objects or was this more regarding


[00:09:32,300 --> 00:09:42,740](https://youtu.be/1gHAKhFBcOU?t=00h09m32s)

the palette helper a brush in the view


[00:09:37,790 --> 00:09:44,600](https://youtu.be/1gHAKhFBcOU?t=00h09m37s)

model okay actually if you want we will


[00:09:42,740 --> 00:09:48,110](https://youtu.be/1gHAKhFBcOU?t=00h09m42s)

go through and I think by the end of


[00:09:44,600 --> 00:09:49,819](https://youtu.be/1gHAKhFBcOU?t=00h09m44s)

this I will I'll whack that brush and


[00:09:48,110 --> 00:09:51,410](https://youtu.be/1gHAKhFBcOU?t=00h09m48s)

show you how I would end up doing it in


[00:09:49,819 --> 00:09:56,050](https://youtu.be/1gHAKhFBcOU?t=00h09m49s)

this app and that'll probably leave a


[00:09:51,410 --> 00:09:58,939](https://youtu.be/1gHAKhFBcOU?t=00h09m51s)

better example so to start from here


[00:09:56,050 --> 00:10:02,930](https://youtu.be/1gHAKhFBcOU?t=00h09m56s)

we're going to jump into our new get


[00:09:58,939 --> 00:10:05,480](https://youtu.be/1gHAKhFBcOU?t=00h09m58s)

references and so this is what most apps


[00:10:02,930 --> 00:10:09,199](https://youtu.be/1gHAKhFBcOU?t=00h10m02s)

probably look like today is they're


[00:10:05,480 --> 00:10:11,509](https://youtu.be/1gHAKhFBcOU?t=00h10m05s)

referencing the to 500 or 251 interface


[00:10:09,199 --> 00:10:15,050](https://youtu.be/1gHAKhFBcOU?t=00h10m09s)

and so we are going to cheat and I'm


[00:10:11,509 --> 00:10:17,389](https://youtu.be/1gHAKhFBcOU?t=00h10m11s)

going to grab so key part here is check


[00:10:15,050 --> 00:10:20,029](https://youtu.be/1gHAKhFBcOU?t=00h10m15s)

the include pre-release and I'm going to


[00:10:17,389 --> 00:10:23,720](https://youtu.be/1gHAKhFBcOU?t=00h10m17s)

be looking for the latest CI


[00:10:20,029 --> 00:10:25,970](https://youtu.be/1gHAKhFBcOU?t=00h10m20s)

so the to 6o version 1560 I believe is


[00:10:23,720 --> 00:10:28,099](https://youtu.be/1gHAKhFBcOU?t=00h10m23s)

latest and then my dependency behavior


[00:10:25,970 --> 00:10:30,589](https://youtu.be/1gHAKhFBcOU?t=00h10m25s)

I'm setting to highest so it's going to


[00:10:28,099 --> 00:10:32,689](https://youtu.be/1gHAKhFBcOU?t=00h10m28s)

ultimately grab the the latest on both


[00:10:30,589 --> 00:10:34,749](https://youtu.be/1gHAKhFBcOU?t=00h10m30s)

of these other ones as well actually I


[00:10:32,689 --> 00:10:37,999](https://youtu.be/1gHAKhFBcOU?t=00h10m32s)

think I can probably do both of these so


[00:10:34,749 --> 00:10:40,189](https://youtu.be/1gHAKhFBcOU?t=00h10m34s)

let's do updates and we'll just jump


[00:10:37,999 --> 00:10:45,889](https://youtu.be/1gHAKhFBcOU?t=00h10m37s)

over here and say update all the things


[00:10:40,189 --> 00:10:49,159](https://youtu.be/1gHAKhFBcOU?t=00h10m40s)

here and I don't want to grab I need to


[00:10:45,889 --> 00:10:52,729](https://youtu.be/1gHAKhFBcOU?t=00h10m45s)

look a little closer at what's in the -


[00:10:49,159 --> 00:10:53,799](https://youtu.be/1gHAKhFBcOU?t=00h10m49s)

oh ma app stuff because I want to make


[00:10:52,729 --> 00:10:57,499](https://youtu.be/1gHAKhFBcOU?t=00h10m52s)

sure that there's not necessarily


[00:10:53,799 --> 00:10:59,119](https://youtu.be/1gHAKhFBcOU?t=00h10m53s)

theming bits that go into it there might


[00:10:57,499 --> 00:11:00,979](https://youtu.be/1gHAKhFBcOU?t=00h10m57s)

be and I might just need to update some


[00:10:59,119 --> 00:11:03,789](https://youtu.be/1gHAKhFBcOU?t=00h10m59s)

of our color so we do try to keep in


[00:11:00,979 --> 00:11:06,229](https://youtu.be/1gHAKhFBcOU?t=00h11m00s)

sync when ma apps push out an update


[00:11:03,789 --> 00:11:09,439](https://youtu.be/1gHAKhFBcOU?t=00h11m03s)

trying to update our brushes and theming


[00:11:06,229 --> 00:11:12,019](https://youtu.be/1gHAKhFBcOU?t=00h11m06s)

stuff and hopefully with this new API


[00:11:09,439 --> 00:11:14,629](https://youtu.be/1gHAKhFBcOU?t=00h11m09s)

all we have to do is kick out an update


[00:11:12,019 --> 00:11:16,849](https://youtu.be/1gHAKhFBcOU?t=00h11m12s)

to our my apps integration package which


[00:11:14,629 --> 00:11:18,679](https://youtu.be/1gHAKhFBcOU?t=00h11m14s)

is all this guy is right here it's


[00:11:16,849 --> 00:11:21,519](https://youtu.be/1gHAKhFBcOU?t=00h11m16s)

basically just the glue to go between


[00:11:18,679 --> 00:11:27,709](https://youtu.be/1gHAKhFBcOU?t=00h11m18s)

material design and my apps


[00:11:21,519 --> 00:11:35,449](https://youtu.be/1gHAKhFBcOU?t=00h11m21s)

let's kick all of these guys up mmm


[00:11:27,709 --> 00:11:40,759](https://youtu.be/1gHAKhFBcOU?t=00h11m27s)

caffeine is necessary today oh okay so -


[00:11:35,449 --> 00:11:43,459](https://youtu.be/1gHAKhFBcOU?t=00h11m35s)

sick so interface and let's just restart


[00:11:40,759 --> 00:11:46,099](https://youtu.be/1gHAKhFBcOU?t=00h11m40s)

the app because there should be the the


[00:11:43,459 --> 00:11:46,939](https://youtu.be/1gHAKhFBcOU?t=00h11m43s)

old two five one interface should work


[00:11:46,099 --> 00:11:53,720](https://youtu.be/1gHAKhFBcOU?t=00h11m46s)

just fine


[00:11:46,939 --> 00:11:55,249](https://youtu.be/1gHAKhFBcOU?t=00h11m46s)

with the new to six Oh packages so if


[00:11:53,720 --> 00:11:57,079](https://youtu.be/1gHAKhFBcOU?t=00h11m53s)

you're worried about backwards


[00:11:55,249 --> 00:11:59,919](https://youtu.be/1gHAKhFBcOU?t=00h11m55s)

compatibility you should be able to go


[00:11:57,079 --> 00:12:03,349](https://youtu.be/1gHAKhFBcOU?t=00h11m57s)

through and update to the two six Oh


[00:11:59,919 --> 00:12:04,939](https://youtu.be/1gHAKhFBcOU?t=00h11m59s)

release and as long as you don't do


[00:12:03,349 --> 00:12:07,009](https://youtu.be/1gHAKhFBcOU?t=00h12m03s)

anything else your app should just work


[00:12:04,939 --> 00:12:09,109](https://youtu.be/1gHAKhFBcOU?t=00h12m04s)

just fine all the theming stuff should


[00:12:07,009 --> 00:12:10,819](https://youtu.be/1gHAKhFBcOU?t=00h12m07s)

still work so we're just gonna fire this


[00:12:09,109 --> 00:12:15,679](https://youtu.be/1gHAKhFBcOU?t=00h12m09s)

up and prove that that much is still


[00:12:10,819 --> 00:12:17,989](https://youtu.be/1gHAKhFBcOU?t=00h12m10s)

there so light theme dark theme looks


[00:12:15,679 --> 00:12:20,329](https://youtu.be/1gHAKhFBcOU?t=00h12m15s)

like I may have broken something in


[00:12:17,989 --> 00:12:22,609](https://youtu.be/1gHAKhFBcOU?t=00h12m17s)

there I might double check that to make


[00:12:20,329 --> 00:12:26,989](https://youtu.be/1gHAKhFBcOU?t=00h12m20s)

sure that it's not completely broken and


[00:12:22,609 --> 00:12:30,709](https://youtu.be/1gHAKhFBcOU?t=00h12m22s)

then something here is something here oh


[00:12:26,989 --> 00:12:33,769](https://youtu.be/1gHAKhFBcOU?t=00h12m26s)

this is the theming stuff okay so this


[00:12:30,709 --> 00:12:36,019](https://youtu.be/1gHAKhFBcOU?t=00h12m30s)

sort of makes sense so this guy in


[00:12:33,769 --> 00:12:38,119](https://youtu.be/1gHAKhFBcOU?t=00h12m33s)

here is falling apart because he's


[00:12:36,019 --> 00:12:41,119](https://youtu.be/1gHAKhFBcOU?t=00h12m36s)

trying to set set a ma apps brush that


[00:12:38,119 --> 00:12:44,679](https://youtu.be/1gHAKhFBcOU?t=00h12m38s)

is no longer there so let's look at


[00:12:41,119 --> 00:12:46,910](https://youtu.be/1gHAKhFBcOU?t=00h12m41s)

doing this update because some of this


[00:12:44,679 --> 00:12:48,980](https://youtu.be/1gHAKhFBcOU?t=00h12m44s)

palette helper stuff you'll notice so


[00:12:46,910 --> 00:12:51,379](https://youtu.be/1gHAKhFBcOU?t=00h12m46s)

for example this palette helper the


[00:12:48,980 --> 00:12:54,769](https://youtu.be/1gHAKhFBcOU?t=00h12m48s)

replace palette method is now marked as


[00:12:51,379 --> 00:12:56,839](https://youtu.be/1gHAKhFBcOU?t=00h12m51s)

obsolete so we're gonna mark this guy is


[00:12:54,769 --> 00:12:59,629](https://youtu.be/1gHAKhFBcOU?t=00h12m54s)

obsolete as well just so I get warnings


[00:12:56,839 --> 00:13:02,899](https://youtu.be/1gHAKhFBcOU?t=00h12m56s)

and then we will we will deal with


[00:12:59,629 --> 00:13:05,959](https://youtu.be/1gHAKhFBcOU?t=00h12m59s)

changing him out so the first thing we


[00:13:02,899 --> 00:13:10,790](https://youtu.be/1gHAKhFBcOU?t=00h13m02s)

want to do is go over to our app dot


[00:13:05,959 --> 00:13:12,860](https://youtu.be/1gHAKhFBcOU?t=00h13m05s)

zamel so before we had to pull in for


[00:13:10,790 --> 00:13:15,790](https://youtu.be/1gHAKhFBcOU?t=00h13m10s)

material design all of these


[00:13:12,860 --> 00:13:19,160](https://youtu.be/1gHAKhFBcOU?t=00h13m12s)

dictionaries and of these dictionaries


[00:13:15,790 --> 00:13:22,339](https://youtu.be/1gHAKhFBcOU?t=00h13m15s)

this one for defaults is still somewhat


[00:13:19,160 --> 00:13:24,439](https://youtu.be/1gHAKhFBcOU?t=00h13m19s)

important this guy brings in all of the


[00:13:22,339 --> 00:13:26,660](https://youtu.be/1gHAKhFBcOU?t=00h13m22s)

default themes for all of the controls


[00:13:24,439 --> 00:13:28,040](https://youtu.be/1gHAKhFBcOU?t=00h13m24s)

which is what we need but these three


[00:13:26,660 --> 00:13:30,860](https://youtu.be/1gHAKhFBcOU?t=00h13m26s)

resource dictionaries down near the


[00:13:28,040 --> 00:13:32,720](https://youtu.be/1gHAKhFBcOU?t=00h13m28s)

bottom are all around color theming so


[00:13:30,860 --> 00:13:35,329](https://youtu.be/1gHAKhFBcOU?t=00h13m30s)

we've got the light color theme that


[00:13:32,720 --> 00:13:37,339](https://youtu.be/1gHAKhFBcOU?t=00h13m32s)

we're going to start with deep purple as


[00:13:35,329 --> 00:13:40,220](https://youtu.be/1gHAKhFBcOU?t=00h13m35s)

the primary color and then lime is the


[00:13:37,339 --> 00:13:41,990](https://youtu.be/1gHAKhFBcOU?t=00h13m37s)

accent color so we don't need these


[00:13:40,220 --> 00:13:44,899](https://youtu.be/1gHAKhFBcOU?t=00h13m40s)

resource dictionaries anymore


[00:13:41,990 --> 00:13:47,269](https://youtu.be/1gHAKhFBcOU?t=00h13m41s)

so these guys can go away I'll just


[00:13:44,899 --> 00:13:50,470](https://youtu.be/1gHAKhFBcOU?t=00h13m44s)

comment them for now and instead what we


[00:13:47,269 --> 00:13:54,170](https://youtu.be/1gHAKhFBcOU?t=00h13m47s)

have access to and I believe bundled


[00:13:50,470 --> 00:13:57,829](https://youtu.be/1gHAKhFBcOU?t=00h13m50s)

color theme right so that guy should


[00:13:54,170 --> 00:14:01,670](https://youtu.be/1gHAKhFBcOU?t=00h13m54s)

squawk and go find it


[00:13:57,829 --> 00:14:05,480](https://youtu.be/1gHAKhFBcOU?t=00h13m57s)

what is it bundle color theme I'm gonna


[00:14:01,670 --> 00:14:11,899](https://youtu.be/1gHAKhFBcOU?t=00h14m01s)

have to go look our knife so real quick


[00:14:05,480 --> 00:14:13,819](https://youtu.be/1gHAKhFBcOU?t=00h14m05s)

let me grab my dude to do so let me get


[00:14:11,899 --> 00:14:20,499](https://youtu.be/1gHAKhFBcOU?t=00h14m11s)

the webpage open and bring this guy over


[00:14:13,819 --> 00:14:23,389](https://youtu.be/1gHAKhFBcOU?t=00h14m13s)

here so on the top to upload my files so


[00:14:20,499 --> 00:14:26,360](https://youtu.be/1gHAKhFBcOU?t=00h14m20s)

back on the material design in zamel


[00:14:23,389 --> 00:14:32,029](https://youtu.be/1gHAKhFBcOU?t=00h14m23s)

repo demo app because i can't remember


[00:14:26,360 --> 00:14:36,949](https://youtu.be/1gHAKhFBcOU?t=00h14m26s)

my own syntax apt sam'l this got your


[00:14:32,029 --> 00:14:41,600](https://youtu.be/1gHAKhFBcOU?t=00h14m32s)

bundled theme I missed missed one ah


[00:14:36,949 --> 00:14:43,990](https://youtu.be/1gHAKhFBcOU?t=00h14m36s)

Thank You Kirk oh I think is if I'm


[00:14:41,600 --> 00:14:43,990](https://youtu.be/1gHAKhFBcOU?t=00h14m41s)

saying that right


[00:14:46,600 --> 00:14:50,600](https://youtu.be/1gHAKhFBcOU?t=00h14m46s)

fundal theme that's what we're looking


[00:14:48,529 --> 00:14:52,640](https://youtu.be/1gHAKhFBcOU?t=00h14m48s)

for okay so this guy has a couple


[00:14:50,600 --> 00:14:55,450](https://youtu.be/1gHAKhFBcOU?t=00h14m50s)

properties on him base theme which is


[00:14:52,640 --> 00:14:59,990](https://youtu.be/1gHAKhFBcOU?t=00h14m52s)

ultimately looking for light or dark oh


[00:14:55,450 --> 00:15:02,360](https://youtu.be/1gHAKhFBcOU?t=00h14m55s)

good good to know so there-there is


[00:14:59,990 --> 00:15:05,360](https://youtu.be/1gHAKhFBcOU?t=00h14m59s)

technically an inherit property this one


[00:15:02,360 --> 00:15:07,459](https://youtu.be/1gHAKhFBcOU?t=00h15m02s)

is not currently being used there is a


[00:15:05,360 --> 00:15:09,140](https://youtu.be/1gHAKhFBcOU?t=00h15m05s)

theme assist class if you wanted to


[00:15:07,459 --> 00:15:11,180](https://youtu.be/1gHAKhFBcOU?t=00h15m07s)

apply a different color theme at a


[00:15:09,140 --> 00:15:16,310](https://youtu.be/1gHAKhFBcOU?t=00h15m09s)

subsection of your app that will use


[00:15:11,180 --> 00:15:19,459](https://youtu.be/1gHAKhFBcOU?t=00h15m11s)

inherit my plan is to in a later release


[00:15:16,310 --> 00:15:22,130](https://youtu.be/1gHAKhFBcOU?t=00h15m16s)

add inherit if it's set at the root to


[00:15:19,459 --> 00:15:23,690](https://youtu.be/1gHAKhFBcOU?t=00h15m19s)

go out and pull from the if you're on


[00:15:22,130 --> 00:15:26,570](https://youtu.be/1gHAKhFBcOU?t=00h15m22s)

Windows 8 or Windows 10


[00:15:23,690 --> 00:15:28,070](https://youtu.be/1gHAKhFBcOU?t=00h15m23s)

pull the built in theme to know if


[00:15:26,570 --> 00:15:30,470](https://youtu.be/1gHAKhFBcOU?t=00h15m26s)

you're on light or dark and adjust


[00:15:28,070 --> 00:15:32,990](https://youtu.be/1gHAKhFBcOU?t=00h15m28s)

accordingly but currently the only


[00:15:30,470 --> 00:15:35,420](https://youtu.be/1gHAKhFBcOU?t=00h15m30s)

things that will make any difference at


[00:15:32,990 --> 00:15:38,930](https://youtu.be/1gHAKhFBcOU?t=00h15m32s)

the root level are light and dark so


[00:15:35,420 --> 00:15:40,550](https://youtu.be/1gHAKhFBcOU?t=00h15m35s)

primary color will go with purple or I'm


[00:15:38,930 --> 00:15:44,000](https://youtu.be/1gHAKhFBcOU?t=00h15m38s)

sorry deep purple we should match what


[00:15:40,550 --> 00:15:48,680](https://youtu.be/1gHAKhFBcOU?t=00h15m40s)

we were before and then secondary color


[00:15:44,000 --> 00:15:51,320](https://youtu.be/1gHAKhFBcOU?t=00h15m44s)

is lime there is a somewhat for anyone


[00:15:48,680 --> 00:15:53,540](https://youtu.be/1gHAKhFBcOU?t=00h15m48s)

used to the the terminology of accent


[00:15:51,320 --> 00:15:58,490](https://youtu.be/1gHAKhFBcOU?t=00h15m51s)

color there is an intent to switch this


[00:15:53,540 --> 00:16:00,050](https://youtu.be/1gHAKhFBcOU?t=00h15m53s)

over to using secondary rather than


[00:15:58,490 --> 00:16:02,450](https://youtu.be/1gHAKhFBcOU?t=00h15m58s)

accent and I don't know why it is


[00:16:00,050 --> 00:16:06,500](https://youtu.be/1gHAKhFBcOU?t=00h16m00s)

highlighting secondary did I'm typo


[00:16:02,450 --> 00:16:08,209](https://youtu.be/1gHAKhFBcOU?t=00h16m02s)

something secondary color nope should be


[00:16:06,500 --> 00:16:11,089](https://youtu.be/1gHAKhFBcOU?t=00h16m06s)

fine I think that's probably just


[00:16:08,209 --> 00:16:14,240](https://youtu.be/1gHAKhFBcOU?t=00h16m08s)

resharper losing its mind there is also


[00:16:11,089 --> 00:16:23,800](https://youtu.be/1gHAKhFBcOU?t=00h16m11s)

a second option so if you don't want to


[00:16:14,240 --> 00:16:26,540](https://youtu.be/1gHAKhFBcOU?t=00h16m14s)

just do the Tyrael design there is a


[00:16:23,800 --> 00:16:30,110](https://youtu.be/1gHAKhFBcOU?t=00h16m23s)

second option rather than the the


[00:16:26,540 --> 00:16:31,820](https://youtu.be/1gHAKhFBcOU?t=00h16m26s)

bundled theme for custom color theme has


[00:16:30,110 --> 00:16:34,540](https://youtu.be/1gHAKhFBcOU?t=00h16m30s)

the same type of thing for base theme


[00:16:31,820 --> 00:16:37,850](https://youtu.be/1gHAKhFBcOU?t=00h16m31s)

but then for the primary and secondary


[00:16:34,540 --> 00:16:41,209](https://youtu.be/1gHAKhFBcOU?t=00h16m34s)

you can just put in arbitrary colors so


[00:16:37,850 --> 00:16:44,089](https://youtu.be/1gHAKhFBcOU?t=00h16m37s)

any RGB color that you want what this


[00:16:41,209 --> 00:16:46,339](https://youtu.be/1gHAKhFBcOU?t=00h16m41s)

will do is it'll set the mid color for


[00:16:44,089 --> 00:16:51,709](https://youtu.be/1gHAKhFBcOU?t=00h16m44s)

both primary and secondary and then


[00:16:46,339 --> 00:16:53,810](https://youtu.be/1gHAKhFBcOU?t=00h16m46s)

it'll jump up a couple lightness levels


[00:16:51,709 --> 00:16:55,459](https://youtu.be/1gHAKhFBcOU?t=00h16m51s)

on the HSV color space and just


[00:16:53,810 --> 00:16:58,100](https://youtu.be/1gHAKhFBcOU?t=00h16m53s)

automatically pick your light and dark


[00:16:55,459 --> 00:17:00,259](https://youtu.be/1gHAKhFBcOU?t=00h16m55s)

version so for people who just want to


[00:16:58,100 --> 00:17:01,579](https://youtu.be/1gHAKhFBcOU?t=00h16m58s)

quick and easy way and you don't


[00:17:00,259 --> 00:17:03,620](https://youtu.be/1gHAKhFBcOU?t=00h17m00s)

necessarily like the built-in color


[00:17:01,579 --> 00:17:05,780](https://youtu.be/1gHAKhFBcOU?t=00h17m01s)

themes and want to roll their own this


[00:17:03,620 --> 00:17:07,660](https://youtu.be/1gHAKhFBcOU?t=00h17m03s)

is a quick and easy way to do it but for


[00:17:05,780 --> 00:17:11,449](https://youtu.be/1gHAKhFBcOU?t=00h17m05s)

now we're gonna stick with this guy so


[00:17:07,660 --> 00:17:14,240](https://youtu.be/1gHAKhFBcOU?t=00h17m07s)

that gets that in there that goes light


[00:17:11,449 --> 00:17:15,799](https://youtu.be/1gHAKhFBcOU?t=00h17m11s)

and dark but in our case there's


[00:17:14,240 --> 00:17:18,230](https://youtu.be/1gHAKhFBcOU?t=00h17m14s)

actually one other one that we care


[00:17:15,799 --> 00:17:21,770](https://youtu.be/1gHAKhFBcOU?t=00h17m15s)

about so this is bundled theme there's


[00:17:18,230 --> 00:17:24,860](https://youtu.be/1gHAKhFBcOU?t=00h17m18s)

custom colored theme but there's also ma


[00:17:21,770 --> 00:17:27,890](https://youtu.be/1gHAKhFBcOU?t=00h17m21s)

apps bundled theme and this is important


[00:17:24,860 --> 00:17:30,830](https://youtu.be/1gHAKhFBcOU?t=00h17m24s)

if you're actually going to be using ma


[00:17:27,890 --> 00:17:33,380](https://youtu.be/1gHAKhFBcOU?t=00h17m27s)

apps with your with material design and


[00:17:30,830 --> 00:17:36,169](https://youtu.be/1gHAKhFBcOU?t=00h17m30s)

the new API so the the only difference


[00:17:33,380 --> 00:17:38,860](https://youtu.be/1gHAKhFBcOU?t=00h17m33s)

between this bundled theme and the other


[00:17:36,169 --> 00:17:42,380](https://youtu.be/1gHAKhFBcOU?t=00h17m36s)

bundled theme is this one is going to do


[00:17:38,860 --> 00:17:44,630](https://youtu.be/1gHAKhFBcOU?t=00h17m38s)

all of these brush setters that we did


[00:17:42,380 --> 00:17:46,850](https://youtu.be/1gHAKhFBcOU?t=00h17m42s)

manually in our app it's going to handle


[00:17:44,630 --> 00:17:49,159](https://youtu.be/1gHAKhFBcOU?t=00h17m44s)

those for us so then you no longer have


[00:17:46,850 --> 00:17:50,840](https://youtu.be/1gHAKhFBcOU?t=00h17m46s)

to keep track of what are all the ma app


[00:17:49,159 --> 00:17:52,549](https://youtu.be/1gHAKhFBcOU?t=00h17m49s)

brushes that I need a set and how do


[00:17:50,840 --> 00:17:57,200](https://youtu.be/1gHAKhFBcOU?t=00h17m50s)

those map to my material design theme


[00:17:52,549 --> 00:17:59,840](https://youtu.be/1gHAKhFBcOU?t=00h17m52s)

colors if you use the the the bundled


[00:17:57,200 --> 00:18:02,450](https://youtu.be/1gHAKhFBcOU?t=00h17m57s)

theme out of the MA apps library it just


[00:17:59,840 --> 00:18:05,630](https://youtu.be/1gHAKhFBcOU?t=00h17m59s)

pulls it in for you so quick and easy


[00:18:02,450 --> 00:18:07,640](https://youtu.be/1gHAKhFBcOU?t=00h18m02s)

much simpler I like better so we're


[00:18:05,630 --> 00:18:09,620](https://youtu.be/1gHAKhFBcOU?t=00h18m05s)

going to go with this route the other


[00:18:07,640 --> 00:18:12,919](https://youtu.be/1gHAKhFBcOU?t=00h18m07s)

resource dictionaries that you need for


[00:18:09,620 --> 00:18:15,679](https://youtu.be/1gHAKhFBcOU?t=00h18m09s)

ma apps because these come out of their


[00:18:12,919 --> 00:18:18,350](https://youtu.be/1gHAKhFBcOU?t=00h18m12s)

library nothing I can do about those and


[00:18:15,679 --> 00:18:21,740](https://youtu.be/1gHAKhFBcOU?t=00h18m15s)

then well nothing that I should do about


[00:18:18,350 --> 00:18:24,320](https://youtu.be/1gHAKhFBcOU?t=00h18m18s)

those I'll put it that way and then you


[00:18:21,740 --> 00:18:27,049](https://youtu.be/1gHAKhFBcOU?t=00h18m21s)

also still need to pull in the defaults


[00:18:24,320 --> 00:18:28,520](https://youtu.be/1gHAKhFBcOU?t=00h18m24s)

from the material design ma apps just


[00:18:27,049 --> 00:18:31,309](https://youtu.be/1gHAKhFBcOU?t=00h18m27s)

like you did before because this brings


[00:18:28,520 --> 00:18:33,620](https://youtu.be/1gHAKhFBcOU?t=00h18m28s)

in the material design themes for each


[00:18:31,309 --> 00:18:35,450](https://youtu.be/1gHAKhFBcOU?t=00h18m31s)

of them so another question so are all


[00:18:33,620 --> 00:18:37,549](https://youtu.be/1gHAKhFBcOU?t=00h18m33s)

shades automatically calculated based on


[00:18:35,450 --> 00:18:41,630](https://youtu.be/1gHAKhFBcOU?t=00h18m35s)

primary to match the material design


[00:18:37,549 --> 00:18:46,130](https://youtu.be/1gHAKhFBcOU?t=00h18m37s)

rules so the rules are pretty laxed when


[00:18:41,630 --> 00:18:48,169](https://youtu.be/1gHAKhFBcOU?t=00h18m41s)

it comes to going up and down a hue


[00:18:46,130 --> 00:18:50,500](https://youtu.be/1gHAKhFBcOU?t=00h18m46s)

we've tried to match them as close as


[00:18:48,169 --> 00:18:55,429](https://youtu.be/1gHAKhFBcOU?t=00h18m48s)

possible but definitely welcome feedback


[00:18:50,500 --> 00:18:56,960](https://youtu.be/1gHAKhFBcOU?t=00h18m50s)

if you use these markup extensions


[00:18:55,429 --> 00:19:00,110](https://youtu.be/1gHAKhFBcOU?t=00h18m55s)

because all these markup is extensions


[00:18:56,960 --> 00:19:01,549](https://youtu.be/1gHAKhFBcOU?t=00h18m56s)

do is generate a resource dictionary if


[00:19:00,110 --> 00:19:04,250](https://youtu.be/1gHAKhFBcOU?t=00h19m00s)

you use these than yes they are


[00:19:01,549 --> 00:19:07,280](https://youtu.be/1gHAKhFBcOU?t=00h19m01s)

automatically calculated however I'll


[00:19:04,250 --> 00:19:09,350](https://youtu.be/1gHAKhFBcOU?t=00h19m04s)

look a little later at rolling your own


[00:19:07,280 --> 00:19:11,870](https://youtu.be/1gHAKhFBcOU?t=00h19m07s)

custom themes because that's what we're


[00:19:09,350 --> 00:19:15,710](https://youtu.be/1gHAKhFBcOU?t=00h19m09s)

going to need to do for


[00:19:11,870 --> 00:19:18,669](https://youtu.be/1gHAKhFBcOU?t=00h19m11s)

some of the other themes that are that


[00:19:15,710 --> 00:19:21,440](https://youtu.be/1gHAKhFBcOU?t=00h19m15s)

are in because this library has both a


[00:19:18,669 --> 00:19:22,880](https://youtu.be/1gHAKhFBcOU?t=00h19m18s)

let's jump back over here it has both a


[00:19:21,440 --> 00:19:24,500](https://youtu.be/1gHAKhFBcOU?t=00h19m21s)

color theme that it generates from a


[00:19:22,880 --> 00:19:27,169](https://youtu.be/1gHAKhFBcOU?t=00h19m22s)

resource dictionary as well as


[00:19:24,500 --> 00:19:29,960](https://youtu.be/1gHAKhFBcOU?t=00h19m24s)

generating a theming code and so if you


[00:19:27,169 --> 00:19:32,870](https://youtu.be/1gHAKhFBcOU?t=00h19m27s)

want to go through and take full control


[00:19:29,960 --> 00:19:35,990](https://youtu.be/1gHAKhFBcOU?t=00h19m29s)

of it and set all of the colors you can


[00:19:32,870 --> 00:19:37,580](https://youtu.be/1gHAKhFBcOU?t=00h19m32s)

do that but if you take full control and


[00:19:35,990 --> 00:19:38,779](https://youtu.be/1gHAKhFBcOU?t=00h19m35s)

set all the colors you're now in full


[00:19:37,580 --> 00:19:42,130](https://youtu.be/1gHAKhFBcOU?t=00h19m37s)

control and you have to set all the


[00:19:38,779 --> 00:19:44,960](https://youtu.be/1gHAKhFBcOU?t=00h19m38s)

colors so or at least most of them


[00:19:42,130 --> 00:19:51,169](https://youtu.be/1gHAKhFBcOU?t=00h19m42s)

okay so we'll go through we'll take care


[00:19:44,960 --> 00:19:53,419](https://youtu.be/1gHAKhFBcOU?t=00h19m44s)

of that and switch that guy out cool so


[00:19:51,169 --> 00:19:55,730](https://youtu.be/1gHAKhFBcOU?t=00h19m51s)

I think that is everything we need from


[00:19:53,419 --> 00:20:01,090](https://youtu.be/1gHAKhFBcOU?t=00h19m53s)

our app dot sam'l except for I'm pretty


[00:19:55,730 --> 00:20:04,250](https://youtu.be/1gHAKhFBcOU?t=00h19m55s)

sure all of these brushes go away too


[00:20:01,090 --> 00:20:06,380](https://youtu.be/1gHAKhFBcOU?t=00h20m01s)

because these we don't need the mark-up


[00:20:04,250 --> 00:20:09,169](https://youtu.be/1gHAKhFBcOU?t=00h20m04s)

extensions should just handle those for


[00:20:06,380 --> 00:20:13,340](https://youtu.be/1gHAKhFBcOU?t=00h20m06s)

us because these I believe are all just


[00:20:09,169 --> 00:20:16,210](https://youtu.be/1gHAKhFBcOU?t=00h20m09s)

the ma apps color theme brushes looks


[00:20:13,340 --> 00:20:19,130](https://youtu.be/1gHAKhFBcOU?t=00h20m13s)

like it cool so what we had to do here


[00:20:16,210 --> 00:20:24,049](https://youtu.be/1gHAKhFBcOU?t=00h20m16s)

we're now down to just one line of code


[00:20:19,130 --> 00:20:26,179](https://youtu.be/1gHAKhFBcOU?t=00h20m19s)

I like better okay so back over here so


[00:20:24,049 --> 00:20:28,610](https://youtu.be/1gHAKhFBcOU?t=00h20m24s)

now we need to actually go through and


[00:20:26,179 --> 00:20:30,559](https://youtu.be/1gHAKhFBcOU?t=00h20m26s)

pull off all of these and I am going to


[00:20:28,610 --> 00:20:32,779](https://youtu.be/1gHAKhFBcOU?t=00h20m28s)

cheat slightly and look at some code


[00:20:30,559 --> 00:20:33,860](https://youtu.be/1gHAKhFBcOU?t=00h20m30s)

that I wrote previously because I can't


[00:20:32,779 --> 00:20:34,760](https://youtu.be/1gHAKhFBcOU?t=00h20m32s)

promise myself that I was going to


[00:20:33,860 --> 00:20:37,070](https://youtu.be/1gHAKhFBcOU?t=00h20m33s)

remember all of this


[00:20:34,760 --> 00:20:41,000](https://youtu.be/1gHAKhFBcOU?t=00h20m34s)

so I cheated and wrote some of it ahead


[00:20:37,070 --> 00:20:48,470](https://youtu.be/1gHAKhFBcOU?t=00h20m37s)

of time because unfortunately memorizing


[00:20:41,000 --> 00:20:50,870](https://youtu.be/1gHAKhFBcOU?t=00h20m41s)

API is it's not quite what I do so we


[00:20:48,470 --> 00:20:53,330](https://youtu.be/1gHAKhFBcOU?t=00h20m48s)

are going to just I think I'm just gonna


[00:20:50,870 --> 00:20:59,090](https://youtu.be/1gHAKhFBcOU?t=00h20m50s)

grab this whole block of code and bring


[00:20:53,330 --> 00:21:03,830](https://youtu.be/1gHAKhFBcOU?t=00h20m53s)

this in and yeah so all of this code


[00:20:59,090 --> 00:21:06,429](https://youtu.be/1gHAKhFBcOU?t=00h20m59s)

here oh not what I want to do too much


[00:21:03,830 --> 00:21:13,850](https://youtu.be/1gHAKhFBcOU?t=00h21m03s)

time in vs code wrong keyboard shortcut


[00:21:06,429 --> 00:21:17,990](https://youtu.be/1gHAKhFBcOU?t=00h21m06s)

okay okay so here we are pulling this


[00:21:13,850 --> 00:21:19,760](https://youtu.be/1gHAKhFBcOU?t=00h21m13s)

guy in and theme create so I need a


[00:21:17,990 --> 00:21:22,909](https://youtu.be/1gHAKhFBcOU?t=00h21m17s)

different this is resolving to the wrong


[00:21:19,760 --> 00:21:25,720](https://youtu.be/1gHAKhFBcOU?t=00h21m19s)

theme let me grab because this really


[00:21:22,909 --> 00:21:30,590](https://youtu.be/1gHAKhFBcOU?t=00h21m22s)

should be


[00:21:25,720 --> 00:21:36,289](https://youtu.be/1gHAKhFBcOU?t=00h21m25s)

using or I'm sorry using theme is going


[00:21:30,590 --> 00:21:38,179](https://youtu.be/1gHAKhFBcOU?t=00h21m30s)

to be I promise I really do know how to


[00:21:36,289 --> 00:21:42,710](https://youtu.be/1gHAKhFBcOU?t=00h21m36s)

type it's just hard to tell with how


[00:21:38,179 --> 00:21:45,470](https://youtu.be/1gHAKhFBcOU?t=00h21m38s)

poorly I'm doing right now should be


[00:21:42,710 --> 00:21:47,179](https://youtu.be/1gHAKhFBcOU?t=00h21m42s)

that theme object I just have to fully


[00:21:45,470 --> 00:21:50,299](https://youtu.be/1gHAKhFBcOU?t=00h21m45s)

qualify this right now because this


[00:21:47,179 --> 00:21:52,029](https://youtu.be/1gHAKhFBcOU?t=00h21m47s)

project actually has a theme class and I


[00:21:50,299 --> 00:21:55,249](https://youtu.be/1gHAKhFBcOU?t=00h21m50s)

need it to not resolve to that right now


[00:21:52,029 --> 00:22:00,980](https://youtu.be/1gHAKhFBcOU?t=00h21m52s)

so we're gonna come down here and this


[00:21:55,249 --> 00:22:02,960](https://youtu.be/1gHAKhFBcOU?t=00h21m55s)

guy here is what are you doing


[00:22:00,980 --> 00:22:04,669](https://youtu.be/1gHAKhFBcOU?t=00h22m00s)

I might just exclude you from the


[00:22:02,960 --> 00:22:04,940](https://youtu.be/1gHAKhFBcOU?t=00h22m02s)

project real quick just to make you go


[00:22:04,669 --> 00:22:07,249](https://youtu.be/1gHAKhFBcOU?t=00h22m04s)

away


[00:22:04,940 --> 00:22:12,169](https://youtu.be/1gHAKhFBcOU?t=00h22m04s)

I don't really want to think about what


[00:22:07,249 --> 00:22:13,850](https://youtu.be/1gHAKhFBcOU?t=00h22m07s)

you're resolving to perfect okay so in


[00:22:12,169 --> 00:22:17,240](https://youtu.be/1gHAKhFBcOU?t=00h22m12s)

the material design library there is a


[00:22:13,850 --> 00:22:19,570](https://youtu.be/1gHAKhFBcOU?t=00h22m13s)

new theme object itself and more


[00:22:17,240 --> 00:22:23,629](https://youtu.be/1gHAKhFBcOU?t=00h22m17s)

importantly let's get rid of this bar


[00:22:19,570 --> 00:22:25,909](https://youtu.be/1gHAKhFBcOU?t=00h22m19s)

and there is a convenient little static


[00:22:23,629 --> 00:22:29,149](https://youtu.be/1gHAKhFBcOU?t=00h22m23s)

helper on it that takes in a base theme


[00:22:25,909 --> 00:22:32,240](https://youtu.be/1gHAKhFBcOU?t=00h22m25s)

as well as a primary and secondary color


[00:22:29,149 --> 00:22:33,830](https://youtu.be/1gHAKhFBcOU?t=00h22m29s)

so if you were curious what that markup


[00:22:32,240 --> 00:22:35,929](https://youtu.be/1gHAKhFBcOU?t=00h22m32s)

extension does when you call custom


[00:22:33,830 --> 00:22:38,179](https://youtu.be/1gHAKhFBcOU?t=00h22m33s)

theme it really is just doing this it's


[00:22:35,929 --> 00:22:40,190](https://youtu.be/1gHAKhFBcOU?t=00h22m35s)

passing in a base theme a primary color


[00:22:38,179 --> 00:22:42,860](https://youtu.be/1gHAKhFBcOU?t=00h22m38s)

and an accent color and then it's


[00:22:40,190 --> 00:22:45,080](https://youtu.be/1gHAKhFBcOU?t=00h22m40s)

setting these you'll notice their static


[00:22:42,860 --> 00:22:47,990](https://youtu.be/1gHAKhFBcOU?t=00h22m42s)

members on theme for getting both the


[00:22:45,080 --> 00:22:49,879](https://youtu.be/1gHAKhFBcOU?t=00h22m45s)

light and the dark theme classes


[00:22:47,990 --> 00:22:52,639](https://youtu.be/1gHAKhFBcOU?t=00h22m47s)

basically we've gone through and


[00:22:49,879 --> 00:22:54,379](https://youtu.be/1gHAKhFBcOU?t=00h22m49s)

codified up all of the theming brushes


[00:22:52,639 --> 00:22:55,429](https://youtu.be/1gHAKhFBcOU?t=00h22m52s)

so that now you can act on


[00:22:54,379 --> 00:22:57,259](https://youtu.be/1gHAKhFBcOU?t=00h22m54s)

strongly-typed


[00:22:55,429 --> 00:23:01,129](https://youtu.be/1gHAKhFBcOU?t=00h22m55s)

objects without necessarily having to


[00:22:57,259 --> 00:23:03,080](https://youtu.be/1gHAKhFBcOU?t=00h22m57s)

guess at and remember the keys you'll


[00:23:01,129 --> 00:23:06,830](https://youtu.be/1gHAKhFBcOU?t=00h23m01s)

notice that all of these things like so


[00:23:03,080 --> 00:23:10,429](https://youtu.be/1gHAKhFBcOU?t=00h23m03s)

primary mid is this color pair a color


[00:23:06,830 --> 00:23:12,889](https://youtu.be/1gHAKhFBcOU?t=00h23m06s)

pair class has a color and then an


[00:23:10,429 --> 00:23:14,720](https://youtu.be/1gHAKhFBcOU?t=00h23m10s)

optional foreground color so if you


[00:23:12,889 --> 00:23:18,019](https://youtu.be/1gHAKhFBcOU?t=00h23m12s)

don't specify a foreground color


[00:23:14,720 --> 00:23:20,419](https://youtu.be/1gHAKhFBcOU?t=00h23m14s)

explicitly it will generate or I should


[00:23:18,019 --> 00:23:21,889](https://youtu.be/1gHAKhFBcOU?t=00h23m18s)

say it'll guess based upon the lightness


[00:23:20,419 --> 00:23:23,379](https://youtu.be/1gHAKhFBcOU?t=00h23m20s)

of the color whether the foreground


[00:23:21,889 --> 00:23:25,519](https://youtu.be/1gHAKhFBcOU?t=00h23m21s)

color should be either white or black


[00:23:23,379 --> 00:23:27,019](https://youtu.be/1gHAKhFBcOU?t=00h23m23s)

so we'll take advantage of that later


[00:23:25,519 --> 00:23:30,950](https://youtu.be/1gHAKhFBcOU?t=00h23m25s)

that's all this contrasting foreground


[00:23:27,019 --> 00:23:35,509](https://youtu.be/1gHAKhFBcOU?t=00h23m27s)

color method does here and then let's


[00:23:30,950 --> 00:23:38,779](https://youtu.be/1gHAKhFBcOU?t=00h23m30s)

see jump back back back back and too far


[00:23:35,509 --> 00:23:39,340](https://youtu.be/1gHAKhFBcOU?t=00h23m35s)

and let's see here so if you want to go


[00:23:38,779 --> 00:23:41,050](https://youtu.be/1gHAKhFBcOU?t=00h23m38s)

through and


[00:23:39,340 --> 00:23:43,180](https://youtu.be/1gHAKhFBcOU?t=00h23m39s)

actually generate up one of these themes


[00:23:41,050 --> 00:23:44,920](https://youtu.be/1gHAKhFBcOU?t=00h23m41s)

and then you decide you know I really


[00:23:43,180 --> 00:23:47,530](https://youtu.be/1gHAKhFBcOU?t=00h23m43s)

don't like what you guys generated for


[00:23:44,920 --> 00:23:49,360](https://youtu.be/1gHAKhFBcOU?t=00h23m44s)

me for the the primary color for the


[00:23:47,530 --> 00:23:51,850](https://youtu.be/1gHAKhFBcOU?t=00h23m47s)

light and the dark you can just go


[00:23:49,360 --> 00:23:55,630](https://youtu.be/1gHAKhFBcOU?t=00h23m49s)

through and change these after the fact


[00:23:51,850 --> 00:23:58,420](https://youtu.be/1gHAKhFBcOU?t=00h23m51s)

or just don't call this helper method so


[00:23:55,630 --> 00:24:00,160](https://youtu.be/1gHAKhFBcOU?t=00h23m55s)

when you call set primary color it


[00:23:58,420 --> 00:24:02,470](https://youtu.be/1gHAKhFBcOU?t=00h23m58s)

brings in a primary color and just calls


[00:24:00,160 --> 00:24:04,000](https://youtu.be/1gHAKhFBcOU?t=00h24m00s)

lighten and darken on it effectively


[00:24:02,470 --> 00:24:05,950](https://youtu.be/1gHAKhFBcOU?t=00h24m02s)

going one shade lighter or one shade


[00:24:04,000 --> 00:24:09,550](https://youtu.be/1gHAKhFBcOU?t=00h24m04s)

darker again you are free to change


[00:24:05,950 --> 00:24:11,560](https://youtu.be/1gHAKhFBcOU?t=00h24m05s)

these or if this doesn't end up lining


[00:24:09,550 --> 00:24:13,810](https://youtu.be/1gHAKhFBcOU?t=00h24m09s)

up with the spec very well please let us


[00:24:11,560 --> 00:24:15,610](https://youtu.be/1gHAKhFBcOU?t=00h24m11s)

know which colors were passed in and


[00:24:13,810 --> 00:24:16,990](https://youtu.be/1gHAKhFBcOU?t=00h24m13s)

what they should have been and I'm happy


[00:24:15,610 --> 00:24:19,210](https://youtu.be/1gHAKhFBcOU?t=00h24m15s)

to take a look at it and try to adjust


[00:24:16,990 --> 00:24:21,840](https://youtu.be/1gHAKhFBcOU?t=00h24m16s)

this to make it match the hard part is


[00:24:19,210 --> 00:24:24,820](https://youtu.be/1gHAKhFBcOU?t=00h24m19s)

we are especially with arbitrary colors


[00:24:21,840 --> 00:24:27,340](https://youtu.be/1gHAKhFBcOU?t=00h24m21s)

some of the material design ones don't


[00:24:24,820 --> 00:24:28,950](https://youtu.be/1gHAKhFBcOU?t=00h24m24s)

necessarily line up with this this


[00:24:27,340 --> 00:24:31,570](https://youtu.be/1gHAKhFBcOU?t=00h24m27s)

single shade lighter and darker


[00:24:28,950 --> 00:24:34,360](https://youtu.be/1gHAKhFBcOU?t=00h24m28s)

different colors switch just a little


[00:24:31,570 --> 00:24:36,310](https://youtu.be/1gHAKhFBcOU?t=00h24m31s)

bit and so it's hard with arbitrary


[00:24:34,360 --> 00:24:37,870](https://youtu.be/1gHAKhFBcOU?t=00h24m34s)

colors to make this work so this is sort


[00:24:36,310 --> 00:24:40,330](https://youtu.be/1gHAKhFBcOU?t=00h24m36s)

of a best guess


[00:24:37,870 --> 00:24:42,310](https://youtu.be/1gHAKhFBcOU?t=00h24m37s)

but the bundled themes should still line


[00:24:40,330 --> 00:24:43,990](https://youtu.be/1gHAKhFBcOU?t=00h24m40s)

up pretty accurately with everything


[00:24:42,310 --> 00:24:48,640](https://youtu.be/1gHAKhFBcOU?t=00h24m42s)

because on those we control all the


[00:24:43,990 --> 00:24:51,850](https://youtu.be/1gHAKhFBcOU?t=00h24m43s)

colors okay so that's that's basically


[00:24:48,640 --> 00:24:54,370](https://youtu.be/1gHAKhFBcOU?t=00h24m48s)

all of that gut all that this does so


[00:24:51,850 --> 00:24:58,450](https://youtu.be/1gHAKhFBcOU?t=00h24m51s)

what this is doing is there is a


[00:24:54,370 --> 00:25:01,780](https://youtu.be/1gHAKhFBcOU?t=00h24m54s)

material design color enum and it


[00:24:58,450 --> 00:25:04,060](https://youtu.be/1gHAKhFBcOU?t=00h24m58s)

contains inu members for every color


[00:25:01,780 --> 00:25:06,130](https://youtu.be/1gHAKhFBcOU?t=00h25m01s)

that was defined in the library so


[00:25:04,060 --> 00:25:09,010](https://youtu.be/1gHAKhFBcOU?t=00h25m04s)

before all of these existed inside of


[00:25:06,130 --> 00:25:11,980](https://youtu.be/1gHAKhFBcOU?t=00h25m06s)

resource dictionaries and so now we have


[00:25:09,010 --> 00:25:15,490](https://youtu.be/1gHAKhFBcOU?t=00h25m09s)

basically the base color and then as


[00:25:11,980 --> 00:25:16,900](https://youtu.be/1gHAKhFBcOU?t=00h25m11s)

well as references to all of the


[00:25:15,490 --> 00:25:19,180](https://youtu.be/1gHAKhFBcOU?t=00h25m15s)

individual brushes that were used


[00:25:16,900 --> 00:25:21,790](https://youtu.be/1gHAKhFBcOU?t=00h25m16s)

typically five through nine hundred and


[00:25:19,180 --> 00:25:23,320](https://youtu.be/1gHAKhFBcOU?t=00h25m19s)

then accent color one two four and seven


[00:25:21,790 --> 00:25:25,800](https://youtu.be/1gHAKhFBcOU?t=00h25m21s)

hundred you don't necessarily need to


[00:25:23,320 --> 00:25:28,360](https://youtu.be/1gHAKhFBcOU?t=00h25m23s)

worry too much about these exact values


[00:25:25,800 --> 00:25:30,760](https://youtu.be/1gHAKhFBcOU?t=00h25m25s)

it's really just to try and make these


[00:25:28,360 --> 00:25:32,500](https://youtu.be/1gHAKhFBcOU?t=00h25m28s)

guys line up nicely but in our view


[00:25:30,760 --> 00:25:35,590](https://youtu.be/1gHAKhFBcOU?t=00h25m30s)

model to go through and generate out


[00:25:32,500 --> 00:25:38,680](https://youtu.be/1gHAKhFBcOU?t=00h25m32s)

this list what we're doing is we're just


[00:25:35,590 --> 00:25:40,510](https://youtu.be/1gHAKhFBcOU?t=00h25m35s)

iterating over these new members and


[00:25:38,680 --> 00:25:44,470](https://youtu.be/1gHAKhFBcOU?t=00h25m38s)

then we are checking to see if there is


[00:25:40,510 --> 00:25:47,880](https://youtu.be/1gHAKhFBcOU?t=00h25m40s)

a corresponding accent value so you'll


[00:25:44,470 --> 00:25:51,370](https://youtu.be/1gHAKhFBcOU?t=00h25m44s)

notice these guys in here and then


[00:25:47,880 --> 00:25:53,020](https://youtu.be/1gHAKhFBcOU?t=00h25m47s)

somewhere in here you'll notice there's


[00:25:51,370 --> 00:25:56,020](https://youtu.be/1gHAKhFBcOU?t=00h25m51s)

for example deep


[00:25:53,020 --> 00:25:57,730](https://youtu.be/1gHAKhFBcOU?t=00h25m53s)

orange and then deep orange accent so


[00:25:56,020 --> 00:26:00,160](https://youtu.be/1gHAKhFBcOU?t=00h25m56s)

all this is doing is iterating through


[00:25:57,730 --> 00:26:01,930](https://youtu.be/1gHAKhFBcOU?t=00h25m57s)

this a new member saying okay do I have


[00:26:00,160 --> 00:26:04,950](https://youtu.be/1gHAKhFBcOU?t=00h26m00s)

a course does this member have a


[00:26:01,930 --> 00:26:07,480](https://youtu.be/1gHAKhFBcOU?t=00h26m01s)

corresponding member that ends an accent


[00:26:04,950 --> 00:26:12,160](https://youtu.be/1gHAKhFBcOU?t=00h26m04s)

sort of a cheater way of doing


[00:26:07,480 --> 00:26:13,660](https://youtu.be/1gHAKhFBcOU?t=00h26m07s)

effectively oh thanks Magnus this is


[00:26:12,160 --> 00:26:17,080](https://youtu.be/1gHAKhFBcOU?t=00h26m12s)

effectively a cheater way of going


[00:26:13,660 --> 00:26:18,670](https://youtu.be/1gHAKhFBcOU?t=00h26m13s)

through and checking to say hey does


[00:26:17,080 --> 00:26:21,850](https://youtu.be/1gHAKhFBcOU?t=00h26m17s)

this particular color theme have an


[00:26:18,670 --> 00:26:25,560](https://youtu.be/1gHAKhFBcOU?t=00h26m18s)

accent color defined and then it simply


[00:26:21,850 --> 00:26:28,000](https://youtu.be/1gHAKhFBcOU?t=00h26m21s)

goes through and looks up the theme and


[00:26:25,560 --> 00:26:30,880](https://youtu.be/1gHAKhFBcOU?t=00h26m25s)

builds it out and then sets it into the


[00:26:28,000 --> 00:26:34,660](https://youtu.be/1gHAKhFBcOU?t=00h26m28s)

view model so this view model is what we


[00:26:30,880 --> 00:26:36,520](https://youtu.be/1gHAKhFBcOU?t=00h26m30s)

need to change out next I think once


[00:26:34,660 --> 00:26:38,830](https://youtu.be/1gHAKhFBcOU?t=00h26m34s)

again I am going to somewhat cheat


[00:26:36,520 --> 00:26:43,050](https://youtu.be/1gHAKhFBcOU?t=00h26m36s)

because I wrote this ahead of time and


[00:26:38,830 --> 00:26:45,580](https://youtu.be/1gHAKhFBcOU?t=00h26m38s)

think I remember what I did okay so


[00:26:43,050 --> 00:26:47,620](https://youtu.be/1gHAKhFBcOU?t=00h26m43s)

rather than the theme object itself


[00:26:45,580 --> 00:26:49,690](https://youtu.be/1gHAKhFBcOU?t=00h26m45s)

we're going to switch so in general I


[00:26:47,620 --> 00:26:52,500](https://youtu.be/1gHAKhFBcOU?t=00h26m47s)

usually prefer to you to act on


[00:26:49,690 --> 00:26:55,330](https://youtu.be/1gHAKhFBcOU?t=00h26m49s)

interface interfaces rather than


[00:26:52,500 --> 00:26:58,030](https://youtu.be/1gHAKhFBcOU?t=00h26m52s)

concrete implementations so we're just


[00:26:55,330 --> 00:26:59,860](https://youtu.be/1gHAKhFBcOU?t=00h26m55s)

gonna flip these guys both over so that


[00:26:58,030 --> 00:27:04,630](https://youtu.be/1gHAKhFBcOU?t=00h26m58s)

theme class implements the eye theme


[00:26:59,860 --> 00:27:06,880](https://youtu.be/1gHAKhFBcOU?t=00h26m59s)

interface this is a it's a fairly simple


[00:27:04,630 --> 00:27:08,770](https://youtu.be/1gHAKhFBcOU?t=00h27m04s)

interface but it's basically just a


[00:27:06,880 --> 00:27:11,890](https://youtu.be/1gHAKhFBcOU?t=00h27m06s)

whole bunch of colors and color pairs


[00:27:08,770 --> 00:27:15,070](https://youtu.be/1gHAKhFBcOU?t=00h27m08s)

and again color pair is just a color


[00:27:11,890 --> 00:27:17,290](https://youtu.be/1gHAKhFBcOU?t=00h27m11s)

with an optional foreground color to go


[00:27:15,070 --> 00:27:19,600](https://youtu.be/1gHAKhFBcOU?t=00h27m15s)

with it again you'll notice all of these


[00:27:17,290 --> 00:27:21,640](https://youtu.be/1gHAKhFBcOU?t=00h27m17s)

things are get set you're free to take


[00:27:19,600 --> 00:27:24,160](https://youtu.be/1gHAKhFBcOU?t=00h27m19s)

one of these theme objects and tweak it


[00:27:21,640 --> 00:27:27,490](https://youtu.be/1gHAKhFBcOU?t=00h27m21s)

to make it match or persist and reload


[00:27:24,160 --> 00:27:30,130](https://youtu.be/1gHAKhFBcOU?t=00h27m24s)

as much as as much as you need so and it


[00:27:27,490 --> 00:27:32,200](https://youtu.be/1gHAKhFBcOU?t=00h27m27s)

should should make it simple so this guy


[00:27:30,130 --> 00:27:34,960](https://youtu.be/1gHAKhFBcOU?t=00h27m30s)

here I did say I was going to change


[00:27:32,200 --> 00:27:37,210](https://youtu.be/1gHAKhFBcOU?t=00h27m32s)

this out to make it a little nicer so


[00:27:34,960 --> 00:27:38,770](https://youtu.be/1gHAKhFBcOU?t=00h27m34s)

rather than doing sample brush let's


[00:27:37,210 --> 00:27:40,630](https://youtu.be/1gHAKhFBcOU?t=00h27m37s)

let's make it obvious that we're


[00:27:38,770 --> 00:27:45,700](https://youtu.be/1gHAKhFBcOU?t=00h27m38s)

changing it so let's go with sample


[00:27:40,630 --> 00:27:48,700](https://youtu.be/1gHAKhFBcOU?t=00h27m40s)

color color and actually you know what


[00:27:45,700 --> 00:27:54,190](https://youtu.be/1gHAKhFBcOU?t=00h27m45s)

we probably don't even need to have this


[00:27:48,700 --> 00:27:55,950](https://youtu.be/1gHAKhFBcOU?t=00h27m48s)

property anymore do we yeah we could


[00:27:54,190 --> 00:27:58,630](https://youtu.be/1gHAKhFBcOU?t=00h27m54s)

cheat we don't even necessarily well


[00:27:55,950 --> 00:28:01,990](https://youtu.be/1gHAKhFBcOU?t=00h27m55s)

let's let's hide the implementation so


[00:27:58,630 --> 00:28:06,190](https://youtu.be/1gHAKhFBcOU?t=00h27m58s)

this guy is just going to become will go


[00:28:01,990 --> 00:28:10,220](https://youtu.be/1gHAKhFBcOU?t=00h28m01s)

with a lambda body member theme


[00:28:06,190 --> 00:28:11,600](https://youtu.be/1gHAKhFBcOU?t=00h28m06s)

primary mid color so this guy is just


[00:28:10,220 --> 00:28:16,070](https://youtu.be/1gHAKhFBcOU?t=00h28m10s)

going to kick back the color and we'll


[00:28:11,600 --> 00:28:18,500](https://youtu.be/1gHAKhFBcOU?t=00h28m11s)

deal with we'll deal with converting


[00:28:16,070 --> 00:28:20,150](https://youtu.be/1gHAKhFBcOU?t=00h28m16s)

that to a brush over in the view and


[00:28:18,500 --> 00:28:23,180](https://youtu.be/1gHAKhFBcOU?t=00h28m18s)

then here I think we're gonna switch


[00:28:20,150 --> 00:28:25,910](https://youtu.be/1gHAKhFBcOU?t=00h28m20s)

this over and just do string name


[00:28:23,180 --> 00:28:26,420](https://youtu.be/1gHAKhFBcOU?t=00h28m23s)

I think that's roughly what I had done


[00:28:25,910 --> 00:28:32,330](https://youtu.be/1gHAKhFBcOU?t=00h28m25s)

before


[00:28:26,420 --> 00:28:36,830](https://youtu.be/1gHAKhFBcOU?t=00h28m26s)

and then something like this so that


[00:28:32,330 --> 00:28:39,230](https://youtu.be/1gHAKhFBcOU?t=00h28m32s)

works there and we'll jump back to our


[00:28:36,830 --> 00:28:43,940](https://youtu.be/1gHAKhFBcOU?t=00h28m36s)

main view model and this this should get


[00:28:39,230 --> 00:28:46,280](https://youtu.be/1gHAKhFBcOU?t=00h28m39s)

at least this much compiling so let's


[00:28:43,940 --> 00:28:48,880](https://youtu.be/1gHAKhFBcOU?t=00h28m43s)

back up before we before we deal with


[00:28:46,280 --> 00:28:51,770](https://youtu.be/1gHAKhFBcOU?t=00h28m46s)

these guys I'm gonna just comment out


[00:28:48,880 --> 00:28:53,600](https://youtu.be/1gHAKhFBcOU?t=00h28m48s)

these ones really quick so these are the


[00:28:51,770 --> 00:28:55,370](https://youtu.be/1gHAKhFBcOU?t=00h28m51s)

two custom themes that were being


[00:28:53,600 --> 00:28:57,650](https://youtu.be/1gHAKhFBcOU?t=00h28m53s)

defined from code and from resource


[00:28:55,370 --> 00:28:59,450](https://youtu.be/1gHAKhFBcOU?t=00h28m55s)

dictionaries but before we get to


[00:28:57,650 --> 00:29:01,940](https://youtu.be/1gHAKhFBcOU?t=00h28m57s)

dealing with those I want to deal with


[00:28:59,450 --> 00:29:04,190](https://youtu.be/1gHAKhFBcOU?t=00h28m59s)

sort of these other ones up here so this


[00:29:01,940 --> 00:29:06,620](https://youtu.be/1gHAKhFBcOU?t=00h29m01s)

idea of being able to toggle is light


[00:29:04,190 --> 00:29:10,250](https://youtu.be/1gHAKhFBcOU?t=00h29m04s)

theme and is dark theme one thing I will


[00:29:06,620 --> 00:29:13,070](https://youtu.be/1gHAKhFBcOU?t=00h29m06s)

mention if you start switching over to


[00:29:10,250 --> 00:29:15,920](https://youtu.be/1gHAKhFBcOU?t=00h29m10s)

this new API you need to switch all of


[00:29:13,070 --> 00:29:17,960](https://youtu.be/1gHAKhFBcOU?t=00h29m13s)

your code over to this API you'll get


[00:29:15,920 --> 00:29:20,660](https://youtu.be/1gHAKhFBcOU?t=00h29m15s)

into very weird situations if you keep


[00:29:17,960 --> 00:29:25,370](https://youtu.be/1gHAKhFBcOU?t=00h29m17s)

using the old obsolete methods with the


[00:29:20,660 --> 00:29:27,260](https://youtu.be/1gHAKhFBcOU?t=00h29m20s)

newer to 600 theming stuff so if you


[00:29:25,370 --> 00:29:31,280](https://youtu.be/1gHAKhFBcOU?t=00h29m25s)

start to do the switch do it all or do


[00:29:27,260 --> 00:29:36,410](https://youtu.be/1gHAKhFBcOU?t=00h29m27s)

none of it don't mix and match but for


[00:29:31,280 --> 00:29:38,180](https://youtu.be/1gHAKhFBcOU?t=00h29m31s)

this guy here the the easiest way and


[00:29:36,410 --> 00:29:43,610](https://youtu.be/1gHAKhFBcOU?t=00h29m36s)

this sort of starts to kind of highlight


[00:29:38,180 --> 00:29:46,460](https://youtu.be/1gHAKhFBcOU?t=00h29m38s)

some of the basics of what is in this so


[00:29:43,610 --> 00:29:48,320](https://youtu.be/1gHAKhFBcOU?t=00h29m43s)

for starters we don't really want to use


[00:29:46,460 --> 00:29:51,650](https://youtu.be/1gHAKhFBcOU?t=00h29m46s)

this pallet helper anymore because this


[00:29:48,320 --> 00:29:53,690](https://youtu.be/1gHAKhFBcOU?t=00h29m48s)

guy's whole point in life was to


[00:29:51,650 --> 00:29:55,820](https://youtu.be/1gHAKhFBcOU?t=00h29m51s)

basically wrap setting all these MA app


[00:29:53,690 --> 00:29:59,150](https://youtu.be/1gHAKhFBcOU?t=00h29m53s)

brushes so I think what I'm going to do


[00:29:55,820 --> 00:30:03,170](https://youtu.be/1gHAKhFBcOU?t=00h29m55s)

is I'm just going to drop him from the


[00:29:59,150 --> 00:30:05,390](https://youtu.be/1gHAKhFBcOU?t=00h29m59s)

project - let's bring him back and so


[00:30:03,170 --> 00:30:08,480](https://youtu.be/1gHAKhFBcOU?t=00h30m03s)

rather than the MA apps pallet helper we


[00:30:05,390 --> 00:30:11,660](https://youtu.be/1gHAKhFBcOU?t=00h30m05s)

will go back to just the the built in


[00:30:08,480 --> 00:30:14,540](https://youtu.be/1gHAKhFBcOU?t=00h30m08s)

pallet helper class so this is now the


[00:30:11,660 --> 00:30:18,320](https://youtu.be/1gHAKhFBcOU?t=00h30m11s)

one that is right inside material design


[00:30:14,540 --> 00:30:20,119](https://youtu.be/1gHAKhFBcOU?t=00h30m14s)

themes the same one that most of you are


[00:30:18,320 --> 00:30:25,059](https://youtu.be/1gHAKhFBcOU?t=00h30m18s)

probably using


[00:30:20,119 --> 00:30:27,830](https://youtu.be/1gHAKhFBcOU?t=00h30m20s)

it's just got some obsolete members now


[00:30:25,059 --> 00:30:32,600](https://youtu.be/1gHAKhFBcOU?t=00h30m25s)

so things like query palette set


[00:30:27,830 --> 00:30:36,619](https://youtu.be/1gHAKhFBcOU?t=00h30m27s)

light-dark set accent color set primary


[00:30:32,600 --> 00:30:40,070](https://youtu.be/1gHAKhFBcOU?t=00h30m32s)

color all of those are now effectively


[00:30:36,619 --> 00:30:43,249](https://youtu.be/1gHAKhFBcOU?t=00h30m36s)

broken hey thanks for the follow bf


[00:30:40,070 --> 00:30:47,029](https://youtu.be/1gHAKhFBcOU?t=00h30m40s)

ozone I think so


[00:30:43,249 --> 00:30:48,739](https://youtu.be/1gHAKhFBcOU?t=00h30m43s)

those accent colors are now or those


[00:30:47,029 --> 00:30:51,440](https://youtu.be/1gHAKhFBcOU?t=00h30m47s)

methods are now obsolete in favor of


[00:30:48,739 --> 00:30:53,179](https://youtu.be/1gHAKhFBcOU?t=00h30m48s)

some of these other ones so effectively


[00:30:51,440 --> 00:30:55,070](https://youtu.be/1gHAKhFBcOU?t=00h30m51s)

if you want to go through before there


[00:30:53,179 --> 00:30:58,519](https://youtu.be/1gHAKhFBcOU?t=00h30m53s)

was a nice little just set light dark


[00:30:55,070 --> 00:31:00,619](https://youtu.be/1gHAKhFBcOU?t=00h30m55s)

that has been slightly changed and if


[00:30:58,519 --> 00:31:03,080](https://youtu.be/1gHAKhFBcOU?t=00h30m58s)

you want to wrap this in a similar


[00:31:00,619 --> 00:31:08,269](https://youtu.be/1gHAKhFBcOU?t=00h31m00s)

helper method I never quite got around


[00:31:03,080 --> 00:31:12,019](https://youtu.be/1gHAKhFBcOU?t=00h31m03s)

to it but you can pull out the current


[00:31:08,269 --> 00:31:13,940](https://youtu.be/1gHAKhFBcOU?t=00h31m08s)

theme which is just going to give you


[00:31:12,019 --> 00:31:15,769](https://youtu.be/1gHAKhFBcOU?t=00h31m12s)

back one of those theme objects that you


[00:31:13,940 --> 00:31:19,899](https://youtu.be/1gHAKhFBcOU?t=00h31m13s)

can then act on and modify as you need


[00:31:15,769 --> 00:31:22,729](https://youtu.be/1gHAKhFBcOU?t=00h31m15s)

to so then in this case we will do theme


[00:31:19,899 --> 00:31:25,249](https://youtu.be/1gHAKhFBcOU?t=00h31m19s)

set base theme which you'll note this is


[00:31:22,729 --> 00:31:29,599](https://youtu.be/1gHAKhFBcOU?t=00h31m22s)

an extension method on it and we will


[00:31:25,249 --> 00:31:31,849](https://youtu.be/1gHAKhFBcOU?t=00h31m25s)

just do theme let's see here what do we


[00:31:29,599 --> 00:31:34,460](https://youtu.be/1gHAKhFBcOU?t=00h31m29s)

got coming in we've got a boolean coming


[00:31:31,849 --> 00:31:37,220](https://youtu.be/1gHAKhFBcOU?t=00h31m31s)

in so if the value is true we'll do


[00:31:34,460 --> 00:31:44,929](https://youtu.be/1gHAKhFBcOU?t=00h31m34s)

theme dot light the value is false we'll


[00:31:37,220 --> 00:31:47,479](https://youtu.be/1gHAKhFBcOU?t=00h31m37s)

do theme dark something like that and


[00:31:44,929 --> 00:31:50,299](https://youtu.be/1gHAKhFBcOU?t=00h31m44s)

then finally now that we've modified the


[00:31:47,479 --> 00:31:54,379](https://youtu.be/1gHAKhFBcOU?t=00h31m47s)

theme itself we just simply go palette


[00:31:50,299 --> 00:31:58,549](https://youtu.be/1gHAKhFBcOU?t=00h31m50s)

helper set theme and these two methods


[00:31:54,379 --> 00:32:00,019](https://youtu.be/1gHAKhFBcOU?t=00h31m54s)

are sort of the the key pieces that that


[00:31:58,549 --> 00:32:03,710](https://youtu.be/1gHAKhFBcOU?t=00h31m58s)

the whole new theming API is built


[00:32:00,019 --> 00:32:05,659](https://youtu.be/1gHAKhFBcOU?t=00h32m00s)

around the idea of being able to query


[00:32:03,710 --> 00:32:08,570](https://youtu.be/1gHAKhFBcOU?t=00h32m03s)

out your current theme which wasn't


[00:32:05,659 --> 00:32:10,669](https://youtu.be/1gHAKhFBcOU?t=00h32m05s)

necessarily easy to do before there was


[00:32:08,570 --> 00:32:12,919](https://youtu.be/1gHAKhFBcOU?t=00h32m08s)

the query palette but then making


[00:32:10,669 --> 00:32:14,809](https://youtu.be/1gHAKhFBcOU?t=00h32m10s)

modifications to that and reapplying


[00:32:12,919 --> 00:32:18,019](https://youtu.be/1gHAKhFBcOU?t=00h32m12s)

that wasn't always as trivial as you


[00:32:14,809 --> 00:32:21,619](https://youtu.be/1gHAKhFBcOU?t=00h32m14s)

would hope so now you can pull the theme


[00:32:18,019 --> 00:32:23,389](https://youtu.be/1gHAKhFBcOU?t=00h32m18s)

out again it's just that same bunch of


[00:32:21,619 --> 00:32:24,950](https://youtu.be/1gHAKhFBcOU?t=00h32m21s)

colors so that you can see all of your


[00:32:23,389 --> 00:32:28,460](https://youtu.be/1gHAKhFBcOU?t=00h32m23s)

brushes that you might want to set and


[00:32:24,950 --> 00:32:31,129](https://youtu.be/1gHAKhFBcOU?t=00h32m24s)

then you can call set theme right back


[00:32:28,460 --> 00:32:33,620](https://youtu.be/1gHAKhFBcOU?t=00h32m28s)

there are extension methods for the set


[00:32:31,129 --> 00:32:36,050](https://youtu.be/1gHAKhFBcOU?t=00h32m31s)

base theme set primary and secondary


[00:32:33,620 --> 00:32:37,730](https://youtu.be/1gHAKhFBcOU?t=00h32m33s)

which are just those fancy helpers for


[00:32:36,050 --> 00:32:40,790](https://youtu.be/1gHAKhFBcOU?t=00h32m36s)

automatically you know adjusting back


[00:32:37,730 --> 00:32:42,380](https://youtu.be/1gHAKhFBcOU?t=00h32m37s)

and forth so this will toggle light and


[00:32:40,790 --> 00:32:46,510](https://youtu.be/1gHAKhFBcOU?t=00h32m40s)

dark


[00:32:42,380 --> 00:32:49,850](https://youtu.be/1gHAKhFBcOU?t=00h32m42s)

this guy here so let's see here


[00:32:46,510 --> 00:32:51,590](https://youtu.be/1gHAKhFBcOU?t=00h32m46s)

so when is set theme called so this is


[00:32:49,850 --> 00:32:54,260](https://youtu.be/1gHAKhFBcOU?t=00h32m49s)

called when one of those buttons is


[00:32:51,590 --> 00:32:56,960](https://youtu.be/1gHAKhFBcOU?t=00h32m51s)

clicked so it calls in with the theme


[00:32:54,260 --> 00:32:58,820](https://youtu.be/1gHAKhFBcOU?t=00h32m54s)

color view model which is the one that


[00:32:56,960 --> 00:33:02,630](https://youtu.be/1gHAKhFBcOU?t=00h32m56s)

we modified here that has a theme in a


[00:32:58,820 --> 00:33:06,130](https://youtu.be/1gHAKhFBcOU?t=00h32m58s)

name and so in this case this method


[00:33:02,630 --> 00:33:13,850](https://youtu.be/1gHAKhFBcOU?t=00h33m02s)

just becomes palette helper set theme


[00:33:06,130 --> 00:33:17,450](https://youtu.be/1gHAKhFBcOU?t=00h33m06s)

theme theme and this is only mostly


[00:33:13,850 --> 00:33:19,550](https://youtu.be/1gHAKhFBcOU?t=00h33m13s)

right so the the the problem here is


[00:33:17,450 --> 00:33:21,920](https://youtu.be/1gHAKhFBcOU?t=00h33m17s)

this theme object was created right here


[00:33:19,550 --> 00:33:24,290](https://youtu.be/1gHAKhFBcOU?t=00h33m19s)

and you'll notice it was always created


[00:33:21,920 --> 00:33:27,740](https://youtu.be/1gHAKhFBcOU?t=00h33m21s)

with a light theme so we actually want


[00:33:24,290 --> 00:33:29,840](https://youtu.be/1gHAKhFBcOU?t=00h33m24s)

to not just blindly set it and this is


[00:33:27,740 --> 00:33:32,810](https://youtu.be/1gHAKhFBcOU?t=00h33m27s)

mostly this is a lesson artifact of the


[00:33:29,840 --> 00:33:35,360](https://youtu.be/1gHAKhFBcOU?t=00h33m29s)

API and a little bit more of the way I


[00:33:32,810 --> 00:33:38,290](https://youtu.be/1gHAKhFBcOU?t=00h33m32s)

structured this app but we will do this


[00:33:35,360 --> 00:33:46,520](https://youtu.be/1gHAKhFBcOU?t=00h33m35s)

and I'm just going to cheat and grab


[00:33:38,290 --> 00:33:50,510](https://youtu.be/1gHAKhFBcOU?t=00h33m38s)

this line right here let's the in view


[00:33:46,520 --> 00:33:52,160](https://youtu.be/1gHAKhFBcOU?t=00h33m46s)

model let's just disambiguate these


[00:33:50,510 --> 00:33:58,400](https://youtu.be/1gHAKhFBcOU?t=00h33m50s)

names since I'm reusing the word theme


[00:33:52,160 --> 00:34:02,990](https://youtu.be/1gHAKhFBcOU?t=00h33m52s)

all over the place like that and then


[00:33:58,400 --> 00:34:04,910](https://youtu.be/1gHAKhFBcOU?t=00h33m58s)

this becomes so if we're in the light


[00:34:02,990 --> 00:34:06,800](https://youtu.be/1gHAKhFBcOU?t=00h34m02s)

theme we'll just toggle that and make


[00:34:04,910 --> 00:34:08,659](https://youtu.be/1gHAKhFBcOU?t=00h34m04s)

sure that this theme has the appropriate


[00:34:06,800 --> 00:34:09,919](https://youtu.be/1gHAKhFBcOU?t=00h34m06s)

base to go along with it because really


[00:34:08,659 --> 00:34:12,980](https://youtu.be/1gHAKhFBcOU?t=00h34m08s)

all we're looking to do is change


[00:34:09,919 --> 00:34:16,190](https://youtu.be/1gHAKhFBcOU?t=00h34m09s)

whatever is set for the primary accent


[00:34:12,980 --> 00:34:20,300](https://youtu.be/1gHAKhFBcOU?t=00h34m12s)

colors and then we will just call set


[00:34:16,190 --> 00:34:21,590](https://youtu.be/1gHAKhFBcOU?t=00h34m16s)

theme which will adjust it well what are


[00:34:20,300 --> 00:34:25,700](https://youtu.be/1gHAKhFBcOU?t=00h34m20s)

you squawking about resharper you don't


[00:34:21,590 --> 00:34:30,530](https://youtu.be/1gHAKhFBcOU?t=00h34m21s)

like my name Oh lower case him sure why


[00:34:25,700 --> 00:34:32,570](https://youtu.be/1gHAKhFBcOU?t=00h34m25s)

not okay so this is this guy here this


[00:34:30,530 --> 00:34:34,340](https://youtu.be/1gHAKhFBcOU?t=00h34m30s)

comment is now highly misleading because


[00:34:32,570 --> 00:34:37,940](https://youtu.be/1gHAKhFBcOU?t=00h34m32s)

this isn't easily an extension method


[00:34:34,340 --> 00:34:41,060](https://youtu.be/1gHAKhFBcOU?t=00h34m34s)

and let's just comment these out and I


[00:34:37,940 --> 00:34:46,429](https://youtu.be/1gHAKhFBcOU?t=00h34m37s)

think we are close to running the last


[00:34:41,060 --> 00:34:48,379](https://youtu.be/1gHAKhFBcOU?t=00h34m41s)

thing we need to do is we switched over


[00:34:46,429 --> 00:34:50,329](https://youtu.be/1gHAKhFBcOU?t=00h34m46s)

so clean up those usings and I don't


[00:34:48,379 --> 00:34:52,129](https://youtu.be/1gHAKhFBcOU?t=00h34m48s)

need my nougat window open anymore we


[00:34:50,329 --> 00:34:55,099](https://youtu.be/1gHAKhFBcOU?t=00h34m50s)

switched over the theme color view model


[00:34:52,129 --> 00:34:58,069](https://youtu.be/1gHAKhFBcOU?t=00h34m52s)

to rather than having a brush in it to


[00:34:55,099 --> 00:35:00,920](https://youtu.be/1gHAKhFBcOU?t=00h34m55s)

just having the color all by itself so


[00:34:58,069 --> 00:35:03,319](https://youtu.be/1gHAKhFBcOU?t=00h34m58s)

we need to address that in our view so


[00:35:00,920 --> 00:35:06,589](https://youtu.be/1gHAKhFBcOU?t=00h35m00s)

this is I believe what you were driving


[00:35:03,319 --> 00:35:10,400](https://youtu.be/1gHAKhFBcOU?t=00h35m03s)

at earlier tide so this binding here is


[00:35:06,589 --> 00:35:13,990](https://youtu.be/1gHAKhFBcOU?t=00h35m06s)

now going to go to sample color but


[00:35:10,400 --> 00:35:28,069](https://youtu.be/1gHAKhFBcOU?t=00h35m10s)

color is not a brush so we need a


[00:35:13,990 --> 00:35:31,569](https://youtu.be/1gHAKhFBcOU?t=00h35m13s)

converter and aesthetic resource let's


[00:35:28,069 --> 00:35:35,630](https://youtu.be/1gHAKhFBcOU?t=00h35m28s)

do something like solid brush converter


[00:35:31,569 --> 00:35:40,400](https://youtu.be/1gHAKhFBcOU?t=00h35m31s)

which we need to create so let's just go


[00:35:35,630 --> 00:35:54,829](https://youtu.be/1gHAKhFBcOU?t=00h35m35s)

and spin that guy real quick so add new


[00:35:40,400 --> 00:35:57,819](https://youtu.be/1gHAKhFBcOU?t=00h35m40s)

class solid brush converter so value


[00:35:54,829 --> 00:36:02,960](https://youtu.be/1gHAKhFBcOU?t=00h35m54s)

converter don't implement interface


[00:35:57,819 --> 00:36:05,119](https://youtu.be/1gHAKhFBcOU?t=00h35m57s)

thank you and I'm just going to go


[00:36:02,960 --> 00:36:10,309](https://youtu.be/1gHAKhFBcOU?t=00h36m02s)

quickly


[00:36:05,119 --> 00:36:14,859](https://youtu.be/1gHAKhFBcOU?t=00h36m05s)

in reality you you should really type


[00:36:10,309 --> 00:36:23,829](https://youtu.be/1gHAKhFBcOU?t=00h36m10s)

check your values and not just blindly


[00:36:14,859 --> 00:36:27,980](https://youtu.be/1gHAKhFBcOU?t=00h36m14s)

new solid let's say solid color brush


[00:36:23,829 --> 00:36:30,170](https://youtu.be/1gHAKhFBcOU?t=00h36m23s)

and then if it i suppose if somebody


[00:36:27,980 --> 00:36:33,700](https://youtu.be/1gHAKhFBcOU?t=00h36m27s)

wanted to use it on our two-way binding


[00:36:30,170 --> 00:36:37,579](https://youtu.be/1gHAKhFBcOU?t=00h36m30s)

which we won't be at the moment but so


[00:36:33,700 --> 00:36:40,400](https://youtu.be/1gHAKhFBcOU?t=00h36m33s)

solid color brush and just grab the


[00:36:37,579 --> 00:36:41,960](https://youtu.be/1gHAKhFBcOU?t=00h36m37s)

color right back off of it yeah I


[00:36:40,400 --> 00:36:44,359](https://youtu.be/1gHAKhFBcOU?t=00h36m40s)

understand no reference exceptions


[00:36:41,960 --> 00:36:46,970](https://youtu.be/1gHAKhFBcOU?t=00h36m41s)

possible we aren't going to stress about


[00:36:44,359 --> 00:36:49,220](https://youtu.be/1gHAKhFBcOU?t=00h36m44s)

those because those shouldn't be


[00:36:46,970 --> 00:36:54,410](https://youtu.be/1gHAKhFBcOU?t=00h36m46s)

possible and then we will just add this


[00:36:49,220 --> 00:36:56,920](https://youtu.be/1gHAKhFBcOU?t=00h36m49s)

converter at the top solid rush


[00:36:54,410 --> 00:36:56,920](https://youtu.be/1gHAKhFBcOU?t=00h36m54s)

converter


[00:37:01,099 --> 00:37:05,430](https://youtu.be/1gHAKhFBcOU?t=00h37m01s)

pick that guy up and now it should just


[00:37:03,960 --> 00:37:07,829](https://youtu.be/1gHAKhFBcOU?t=00h37m03s)

convert back and forth so this is


[00:37:05,430 --> 00:37:09,410](https://youtu.be/1gHAKhFBcOU?t=00h37m05s)

basically the the short way how I would


[00:37:07,829 --> 00:37:11,940](https://youtu.be/1gHAKhFBcOU?t=00h37m07s)

go around it most of the time tied is


[00:37:09,410 --> 00:37:15,890](https://youtu.be/1gHAKhFBcOU?t=00h37m09s)

having my view model just expose the


[00:37:11,940 --> 00:37:19,170](https://youtu.be/1gHAKhFBcOU?t=00h37m11s)

data and have it not know about the view


[00:37:15,890 --> 00:37:21,450](https://youtu.be/1gHAKhFBcOU?t=00h37m15s)

most of the time I try to make my view


[00:37:19,170 --> 00:37:30,150](https://youtu.be/1gHAKhFBcOU?t=00h37m19s)

models as agnostic of the view as I


[00:37:21,450 --> 00:37:32,309](https://youtu.be/1gHAKhFBcOU?t=00h37m21s)

possibly can get them and secondary


[00:37:30,150 --> 00:37:42,660](https://youtu.be/1gHAKhFBcOU?t=00h37m30s)

color was not found although what did I


[00:37:32,309 --> 00:37:47,520](https://youtu.be/1gHAKhFBcOU?t=00h37m32s)

call it why are you so confused my apps


[00:37:42,660 --> 00:37:53,180](https://youtu.be/1gHAKhFBcOU?t=00h37m42s)

bundled theme bundled theme secondary


[00:37:47,520 --> 00:38:05,069](https://youtu.be/1gHAKhFBcOU?t=00h37m47s)

color like somebody just lost their mind


[00:37:53,180 --> 00:38:07,109](https://youtu.be/1gHAKhFBcOU?t=00h37m53s)

let's rebuild this hub of the property


[00:38:05,069 --> 00:38:08,730](https://youtu.be/1gHAKhFBcOU?t=00h38m05s)

secondary color was not found okay let's


[00:38:07,109 --> 00:38:11,369](https://youtu.be/1gHAKhFBcOU?t=00h38m07s)

whack you real quick and just get you to


[00:38:08,730 --> 00:38:14,579](https://youtu.be/1gHAKhFBcOU?t=00h38m08s)

compile what is what is your problem


[00:38:11,369 --> 00:38:18,109](https://youtu.be/1gHAKhFBcOU?t=00h38m11s)

this may be the fun of using a nougat


[00:38:14,579 --> 00:38:18,109](https://youtu.be/1gHAKhFBcOU?t=00h38m14s)

package that I just did the other night


[00:38:19,700 --> 00:38:25,529](https://youtu.be/1gHAKhFBcOU?t=00h38m19s)

material design colors public key token


[00:38:22,890 --> 00:38:36,089](https://youtu.be/1gHAKhFBcOU?t=00h38m22s)

did I not get all of mine you gets


[00:38:25,529 --> 00:38:42,569](https://youtu.be/1gHAKhFBcOU?t=00h38m25s)

updated did not roll a new I know what


[00:38:36,089 --> 00:38:49,589](https://youtu.be/1gHAKhFBcOU?t=00h38m36s)

happened this guy updated oh but it


[00:38:42,569 --> 00:38:53,400](https://youtu.be/1gHAKhFBcOU?t=00h38m42s)

didn't generate it did not build new


[00:38:49,589 --> 00:38:58,049](https://youtu.be/1gHAKhFBcOU?t=00h38m49s)

nougat packages out on nougat org that


[00:38:53,400 --> 00:38:59,609](https://youtu.be/1gHAKhFBcOU?t=00h38m53s)

is the problem okay so we're gonna work


[00:38:58,049 --> 00:39:06,480](https://youtu.be/1gHAKhFBcOU?t=00h38m58s)

about go around this problem for the


[00:38:59,609 --> 00:39:07,799](https://youtu.be/1gHAKhFBcOU?t=00h38m59s)

moment so there is a let's see here let


[00:39:06,480 --> 00:39:09,869](https://youtu.be/1gHAKhFBcOU?t=00h39m06s)

me just make sure I get signed into the


[00:39:07,799 --> 00:39:11,719](https://youtu.be/1gHAKhFBcOU?t=00h39m07s)

right instance real quick before I drag


[00:39:09,869 --> 00:39:16,319](https://youtu.be/1gHAKhFBcOU?t=00h39m09s)

my screen over


[00:39:11,719 --> 00:39:19,559](https://youtu.be/1gHAKhFBcOU?t=00h39m11s)

so just one second here real quick we


[00:39:16,319 --> 00:39:20,959](https://youtu.be/1gHAKhFBcOU?t=00h39m16s)

are going to switch so I can make sure


[00:39:19,559 --> 00:39:23,579](https://youtu.be/1gHAKhFBcOU?t=00h39m19s)

I'm in the right


[00:39:20,959 --> 00:39:26,969](https://youtu.be/1gHAKhFBcOU?t=00h39m20s)

DevOps instance so right now we have to


[00:39:23,579 --> 00:39:29,819](https://youtu.be/1gHAKhFBcOU?t=00h39m23s)

build systems that are running one on as


[00:39:26,969 --> 00:39:31,979](https://youtu.be/1gHAKhFBcOU?t=00h39m26s)

your DevOps and one on at their the plan


[00:39:29,819 --> 00:39:36,299](https://youtu.be/1gHAKhFBcOU?t=00h39m29s)

is eventually to obsolete app they're in


[00:39:31,979 --> 00:39:40,999](https://youtu.be/1gHAKhFBcOU?t=00h39m31s)

favor of DevOps the problem is right now


[00:39:36,299 --> 00:39:46,109](https://youtu.be/1gHAKhFBcOU?t=00h39m36s)

app fare is still what's pushing out the


[00:39:40,999 --> 00:39:48,440](https://youtu.be/1gHAKhFBcOU?t=00h39m40s)

nougat packages to nougat org and I was


[00:39:46,109 --> 00:39:52,410](https://youtu.be/1gHAKhFBcOU?t=00h39m46s)

running with packages that were built on


[00:39:48,440 --> 00:39:54,660](https://youtu.be/1gHAKhFBcOU?t=00h39m48s)

Azure DevOps which as your DevOps is now


[00:39:52,410 --> 00:39:57,109](https://youtu.be/1gHAKhFBcOU?t=00h39m52s)

building all of the nougat packages


[00:39:54,660 --> 00:40:00,029](https://youtu.be/1gHAKhFBcOU?t=00h39m54s)

whereas app there is only building


[00:39:57,109 --> 00:40:06,209](https://youtu.be/1gHAKhFBcOU?t=00h39m57s)

material design in zamel the core


[00:40:00,029 --> 00:40:10,349](https://youtu.be/1gHAKhFBcOU?t=00h40m00s)

library so let's switch back okay so


[00:40:06,209 --> 00:40:15,719](https://youtu.be/1gHAKhFBcOU?t=00h40m06s)

DevOps and I'm going to just cheat real


[00:40:10,349 --> 00:40:18,449](https://youtu.be/1gHAKhFBcOU?t=00h40m10s)

quick so there is technically a quite a


[00:40:15,719 --> 00:40:22,829](https://youtu.be/1gHAKhFBcOU?t=00h40m15s)

few pipelines but what I am interested


[00:40:18,449 --> 00:40:28,979](https://youtu.be/1gHAKhFBcOU?t=00h40m18s)

in is grabbing these builds which I


[00:40:22,829 --> 00:40:30,509](https://youtu.be/1gHAKhFBcOU?t=00h40m22s)

suspect will be the you know do not let


[00:40:28,979 --> 00:40:33,390](https://youtu.be/1gHAKhFBcOU?t=00h40m28s)

me down oh you're gonna make me download


[00:40:30,509 --> 00:40:40,229](https://youtu.be/1gHAKhFBcOU?t=00h40m30s)

them one at a time okay fine just grab


[00:40:33,390 --> 00:40:43,170](https://youtu.be/1gHAKhFBcOU?t=00h40m33s)

you one at a time then I am wanting


[00:40:40,229 --> 00:40:45,959](https://youtu.be/1gHAKhFBcOU?t=00h40m40s)

these latest ones I did put in a request


[00:40:43,170 --> 00:40:48,180](https://youtu.be/1gHAKhFBcOU?t=00h40m43s)

to James to review the stuff so that we


[00:40:45,959 --> 00:40:51,809](https://youtu.be/1gHAKhFBcOU?t=00h40m45s)

can kick the to 6o version live so


[00:40:48,180 --> 00:40:53,910](https://youtu.be/1gHAKhFBcOU?t=00h40m48s)

hopefully that happens in not too


[00:40:51,809 --> 00:40:55,709](https://youtu.be/1gHAKhFBcOU?t=00h40m51s)

distant of a future because you'll


[00:40:53,910 --> 00:40:59,759](https://youtu.be/1gHAKhFBcOU?t=00h40m53s)

notice I have started tagging several of


[00:40:55,709 --> 00:41:03,690](https://youtu.be/1gHAKhFBcOU?t=00h40m55s)

the issues as the three oh release so


[00:40:59,759 --> 00:41:06,680](https://youtu.be/1gHAKhFBcOU?t=00h40m59s)

that we can get those guys fixed so I'm


[00:41:03,690 --> 00:41:09,449](https://youtu.be/1gHAKhFBcOU?t=00h41m03s)

going to just cheat really quick so


[00:41:06,680 --> 00:41:11,719](https://youtu.be/1gHAKhFBcOU?t=00h41m06s)

downloaded all the nougat packages if


[00:41:09,449 --> 00:41:14,459](https://youtu.be/1gHAKhFBcOU?t=00h41m09s)

people want I will make these available


[00:41:11,719 --> 00:41:19,949](https://youtu.be/1gHAKhFBcOU?t=00h41m11s)

you can always download them directly


[00:41:14,459 --> 00:41:22,049](https://youtu.be/1gHAKhFBcOU?t=00h41m14s)

the plan is to expose a better CI feed


[00:41:19,949 --> 00:41:23,459](https://youtu.be/1gHAKhFBcOU?t=00h41m19s)

so that people can get these a lot


[00:41:22,049 --> 00:41:24,930](https://youtu.be/1gHAKhFBcOU?t=00h41m22s)

better but again we're kind of in that


[00:41:23,459 --> 00:41:26,069](https://youtu.be/1gHAKhFBcOU?t=00h41m23s)

halfway point and


[00:41:24,930 --> 00:41:27,750](https://youtu.be/1gHAKhFBcOU?t=00h41m24s)

one of those things I want to get


[00:41:26,069 --> 00:41:30,200](https://youtu.be/1gHAKhFBcOU?t=00h41m26s)

addressed on the 300 release is getting


[00:41:27,750 --> 00:41:35,750](https://youtu.be/1gHAKhFBcOU?t=00h41m27s)

these pipelines hammered out and running


[00:41:30,200 --> 00:41:38,760](https://youtu.be/1gHAKhFBcOU?t=00h41m30s)

so let's see here I need to put these in


[00:41:35,750 --> 00:41:43,200](https://youtu.be/1gHAKhFBcOU?t=00h41m35s)

so I don't know how many people may have


[00:41:38,760 --> 00:41:46,109](https://youtu.be/1gHAKhFBcOU?t=00h41m38s)

seen these before but there is a place


[00:41:43,200 --> 00:41:47,430](https://youtu.be/1gHAKhFBcOU?t=00h41m43s)

files in the definition so one of the


[00:41:46,109 --> 00:41:49,710](https://youtu.be/1gHAKhFBcOU?t=00h41m46s)

things that you can do with nougat if


[00:41:47,430 --> 00:41:51,960](https://youtu.be/1gHAKhFBcOU?t=00h41m47s)

you get access to the the nougat


[00:41:49,710 --> 00:41:55,079](https://youtu.be/1gHAKhFBcOU?t=00h41m49s)

packages is I just have this folder


[00:41:51,960 --> 00:41:58,800](https://youtu.be/1gHAKhFBcOU?t=00h41m51s)

setup in sequel and dev nougat and then


[00:41:55,079 --> 00:42:00,660](https://youtu.be/1gHAKhFBcOU?t=00h41m55s)

over on my nougat browser you'll notice


[00:41:58,800 --> 00:42:03,540](https://youtu.be/1gHAKhFBcOU?t=00h41m58s)

my source is currently set to nougat org


[00:42:00,660 --> 00:42:05,220](https://youtu.be/1gHAKhFBcOU?t=00h42m00s)

but I also have this local source that's


[00:42:03,540 --> 00:42:07,500](https://youtu.be/1gHAKhFBcOU?t=00h42m03s)

set up right here that's just pointed at


[00:42:05,220 --> 00:42:09,859](https://youtu.be/1gHAKhFBcOU?t=00h42m05s)

this folder so as long as you put all of


[00:42:07,500 --> 00:42:14,280](https://youtu.be/1gHAKhFBcOU?t=00h42m07s)

your new get packages in this folder I


[00:42:09,859 --> 00:42:17,790](https://youtu.be/1gHAKhFBcOU?t=00h42m09s)

can just flip over to local and grab all


[00:42:14,280 --> 00:42:20,490](https://youtu.be/1gHAKhFBcOU?t=00h42m14s)

my updates which is awesome because this


[00:42:17,790 --> 00:42:23,309](https://youtu.be/1gHAKhFBcOU?t=00h42m17s)

is what I want this is one of the


[00:42:20,490 --> 00:42:25,980](https://youtu.be/1gHAKhFBcOU?t=00h42m20s)

reasons why switching over to the other


[00:42:23,309 --> 00:42:28,230](https://youtu.be/1gHAKhFBcOU?t=00h42m23s)

build system is going to be hard we kind


[00:42:25,980 --> 00:42:30,900](https://youtu.be/1gHAKhFBcOU?t=00h42m25s)

of have to do it with a major Rev of the


[00:42:28,230 --> 00:42:33,270](https://youtu.be/1gHAKhFBcOU?t=00h42m28s)

the package or at least a full version


[00:42:30,900 --> 00:42:36,480](https://youtu.be/1gHAKhFBcOU?t=00h42m30s)

Rev of the package otherwise these CI


[00:42:33,270 --> 00:42:39,660](https://youtu.be/1gHAKhFBcOU?t=00h42m33s)

numbers the build ID is between a fare


[00:42:36,480 --> 00:42:43,730](https://youtu.be/1gHAKhFBcOU?t=00h42m36s)

and DevOps I wasn't gonna try to keep


[00:42:39,660 --> 00:42:45,960](https://youtu.be/1gHAKhFBcOU?t=00h42m39s)

those in sync and go back and forth so I


[00:42:43,730 --> 00:42:49,319](https://youtu.be/1gHAKhFBcOU?t=00h42m43s)

kind of want to just do a whole package


[00:42:45,960 --> 00:42:52,920](https://youtu.be/1gHAKhFBcOU?t=00h42m45s)

version so same thing but I'm going to


[00:42:49,319 --> 00:42:54,960](https://youtu.be/1gHAKhFBcOU?t=00h42m49s)

flip over this does mean now that I'm


[00:42:52,920 --> 00:42:57,809](https://youtu.be/1gHAKhFBcOU?t=00h42m52s)

thinking about it that the packages that


[00:42:54,960 --> 00:42:59,790](https://youtu.be/1gHAKhFBcOU?t=00h42m54s)

I pushed out Sunday and Monday night are


[00:42:57,809 --> 00:43:02,339](https://youtu.be/1gHAKhFBcOU?t=00h42m57s)

probably broken for people trying to use


[00:42:59,790 --> 00:43:04,740](https://youtu.be/1gHAKhFBcOU?t=00h42m59s)

this new API so please don't grab those


[00:43:02,339 --> 00:43:07,170](https://youtu.be/1gHAKhFBcOU?t=00h43m02s)

CI packages and try to use this you'll


[00:43:04,740 --> 00:43:09,450](https://youtu.be/1gHAKhFBcOU?t=00h43m04s)

get the same air that I did because we


[00:43:07,170 --> 00:43:11,490](https://youtu.be/1gHAKhFBcOU?t=00h43m07s)

need to get out those API changes to the


[00:43:09,450 --> 00:43:13,319](https://youtu.be/1gHAKhFBcOU?t=00h43m09s)

other nougats as well so I will see


[00:43:11,490 --> 00:43:18,210](https://youtu.be/1gHAKhFBcOU?t=00h43m11s)

about getting CI packages pushed for


[00:43:13,319 --> 00:43:22,109](https://youtu.be/1gHAKhFBcOU?t=00h43m13s)

those so this guy here that should now


[00:43:18,210 --> 00:43:23,849](https://youtu.be/1gHAKhFBcOU?t=00h43m18s)

exist Hey look no more no more little


[00:43:22,109 --> 00:43:25,910](https://youtu.be/1gHAKhFBcOU?t=00h43m22s)

squigglies that's what we're talking


[00:43:23,849 --> 00:43:25,910](https://youtu.be/1gHAKhFBcOU?t=00h43m23s)

about


[00:43:33,380 --> 00:43:40,019](https://youtu.be/1gHAKhFBcOU?t=00h43m33s)

okay compile and run this should now


[00:43:36,599 --> 00:43:41,309](https://youtu.be/1gHAKhFBcOU?t=00h43m36s)

work like I said the other thing too is


[00:43:40,019 --> 00:43:43,230](https://youtu.be/1gHAKhFBcOU?t=00h43m40s)

if people are wanting these and you


[00:43:41,309 --> 00:43:46,710](https://youtu.be/1gHAKhFBcOU?t=00h43m41s)

don't see the nougat packages you can


[00:43:43,230 --> 00:43:50,249](https://youtu.be/1gHAKhFBcOU?t=00h43m43s)

just go out and download them and I have


[00:43:46,710 --> 00:43:57,059](https://youtu.be/1gHAKhFBcOU?t=00h43m46s)

clearly broken something my color theme


[00:43:50,249 --> 00:43:59,609](https://youtu.be/1gHAKhFBcOU?t=00h43m50s)

is kind of there but I have lost my my


[00:43:57,059 --> 00:44:01,410](https://youtu.be/1gHAKhFBcOU?t=00h43m57s)

view of the universe so what the heck


[00:43:59,609 --> 00:44:06,049](https://youtu.be/1gHAKhFBcOU?t=00h43m59s)

did I do on my main window that caused


[00:44:01,410 --> 00:44:06,049](https://youtu.be/1gHAKhFBcOU?t=00h44m01s)

all those to break so my items control


[00:44:06,650 --> 00:44:13,829](https://youtu.be/1gHAKhFBcOU?t=00h44m06s)

that guy there


[00:44:10,200 --> 00:44:16,289](https://youtu.be/1gHAKhFBcOU?t=00h44m10s)

did I not add something into my main


[00:44:13,829 --> 00:44:20,999](https://youtu.be/1gHAKhFBcOU?t=00h44m13s)

window view model let's see here so


[00:44:16,289 --> 00:44:23,130](https://youtu.be/1gHAKhFBcOU?t=00h44m16s)

theme colors add range theme colors


[00:44:20,999 --> 00:44:25,499](https://youtu.be/1gHAKhFBcOU?t=00h44m20s)

should be defaulting to a list it should


[00:44:23,130 --> 00:44:31,049](https://youtu.be/1gHAKhFBcOU?t=00h44m23s)

have a bunch of stuff great


[00:44:25,499 --> 00:44:32,239](https://youtu.be/1gHAKhFBcOU?t=00h44m25s)

that should get built what did i do what


[00:44:31,049 --> 00:44:38,640](https://youtu.be/1gHAKhFBcOU?t=00h44m31s)

did I do


[00:44:32,239 --> 00:44:41,519](https://youtu.be/1gHAKhFBcOU?t=00h44m32s)

let's take a look because all I change


[00:44:38,640 --> 00:44:45,900](https://youtu.be/1gHAKhFBcOU?t=00h44m38s)

was there and there that should build


[00:44:41,519 --> 00:44:51,799](https://youtu.be/1gHAKhFBcOU?t=00h44m41s)

that should build set light dark get


[00:44:45,900 --> 00:44:57,539](https://youtu.be/1gHAKhFBcOU?t=00h44m45s)

primary theme you should be obsolete


[00:44:51,799 --> 00:45:02,549](https://youtu.be/1gHAKhFBcOU?t=00h44m51s)

you should be obsolete that should not


[00:44:57,539 --> 00:45:04,019](https://youtu.be/1gHAKhFBcOU?t=00h44m57s)

be necessary so let's just relaunch this


[00:45:02,549 --> 00:45:06,299](https://youtu.be/1gHAKhFBcOU?t=00h45m02s)

guy real quick and I'm gonna fire up


[00:45:04,019 --> 00:45:08,430](https://youtu.be/1gHAKhFBcOU?t=00h45m04s)

snoop and we're gonna see what the heck


[00:45:06,299 --> 00:45:11,730](https://youtu.be/1gHAKhFBcOU?t=00h45m06s)

is happening to my items control because


[00:45:08,430 --> 00:45:19,970](https://youtu.be/1gHAKhFBcOU?t=00h45m08s)

it should be right there it's clearly


[00:45:11,730 --> 00:45:22,289](https://youtu.be/1gHAKhFBcOU?t=00h45m11s)

not it's bound there data type is set


[00:45:19,970 --> 00:45:27,029](https://youtu.be/1gHAKhFBcOU?t=00h45m19s)

this seems like the only way this should


[00:45:22,289 --> 00:45:31,890](https://youtu.be/1gHAKhFBcOU?t=00h45m22s)

happen is if I don't have any items in


[00:45:27,029 --> 00:45:36,140](https://youtu.be/1gHAKhFBcOU?t=00h45m27s)

my collection did I maybe I should


[00:45:31,890 --> 00:45:36,140](https://youtu.be/1gHAKhFBcOU?t=00h45m31s)

validate that those still line up


[00:45:37,300 --> 00:45:42,460](https://youtu.be/1gHAKhFBcOU?t=00h45m37s)

so let's see navigate in there and then


[00:45:40,720 --> 00:45:45,490](https://youtu.be/1gHAKhFBcOU?t=00h45m40s)

the items control is gonna be right next


[00:45:42,460 --> 00:45:48,580](https://youtu.be/1gHAKhFBcOU?t=00h45m42s)

door so switch


[00:45:45,490 --> 00:45:50,680](https://youtu.be/1gHAKhFBcOU?t=00h45m45s)

there's my items control there's my


[00:45:48,580 --> 00:45:52,690](https://youtu.be/1gHAKhFBcOU?t=00h45m48s)

items control axle height to zero which


[00:45:50,680 --> 00:45:56,230](https://youtu.be/1gHAKhFBcOU?t=00h45m50s)

is why we're not seeing anything let's


[00:45:52,690 --> 00:46:01,390](https://youtu.be/1gHAKhFBcOU?t=00h45m52s)

look at the data context theme colors is


[00:45:56,230 --> 00:46:05,350](https://youtu.be/1gHAKhFBcOU?t=00h45m56s)

a list and it has no items in it okay so


[00:46:01,390 --> 00:46:11,020](https://youtu.be/1gHAKhFBcOU?t=00h46m01s)

this would clearly be a problem let's


[00:46:05,350 --> 00:46:11,830](https://youtu.be/1gHAKhFBcOU?t=00h46m05s)

see here you're telling me none of these


[00:46:11,020 --> 00:46:16,770](https://youtu.be/1gHAKhFBcOU?t=00h46m11s)

matched


[00:46:11,830 --> 00:46:21,340](https://youtu.be/1gHAKhFBcOU?t=00h46m11s)

oh let's see so tryparse go through


[00:46:16,770 --> 00:46:24,880](https://youtu.be/1gHAKhFBcOU?t=00h46m16s)

select add range let's just rebuild this


[00:46:21,340 --> 00:46:26,500](https://youtu.be/1gHAKhFBcOU?t=00h46m21s)

guy real quick a little shocked given


[00:46:24,880 --> 00:46:31,870](https://youtu.be/1gHAKhFBcOU?t=00h46m24s)

that I copied and pasted this code from


[00:46:26,500 --> 00:46:37,510](https://youtu.be/1gHAKhFBcOU?t=00h46m26s)

something I wrote previously so seems a


[00:46:31,870 --> 00:46:42,640](https://youtu.be/1gHAKhFBcOU?t=00h46m31s)

little off so step over and theme colors


[00:46:37,510 --> 00:46:44,260](https://youtu.be/1gHAKhFBcOU?t=00h46m37s)

count zero so let's let's go back my


[00:46:42,640 --> 00:46:47,760](https://youtu.be/1gHAKhFBcOU?t=00h46m42s)

execution pointer up and let's rerun


[00:46:44,260 --> 00:46:47,760](https://youtu.be/1gHAKhFBcOU?t=00h46m44s)

this and see what the heck is going on


[00:46:48,810 --> 00:46:59,470](https://youtu.be/1gHAKhFBcOU?t=00h46m48s)

set next statement ok and f11 so enum


[00:46:55,480 --> 00:47:14,980](https://youtu.be/1gHAKhFBcOU?t=00h46m55s)

tryparse red is 50 don't expect don't


[00:46:59,470 --> 00:47:20,280](https://youtu.be/1gHAKhFBcOU?t=00h46m59s)

expect 300 400 500 red really you new


[00:47:14,980 --> 00:47:28,920](https://youtu.be/1gHAKhFBcOU?t=00h47m14s)

tryparse on all of those returned false


[00:47:20,280 --> 00:47:28,920](https://youtu.be/1gHAKhFBcOU?t=00h47m20s)

what the heck this is red ah


[00:47:29,290 --> 00:47:35,620](https://youtu.be/1gHAKhFBcOU?t=00h47m29s)

that's why because somebody renamed his


[00:47:32,080 --> 00:47:39,760](https://youtu.be/1gHAKhFBcOU?t=00h47m32s)

Inu members right after dropping the


[00:47:35,620 --> 00:47:42,820](https://youtu.be/1gHAKhFBcOU?t=00h47m35s)

word accent from it because I was trying


[00:47:39,760 --> 00:47:44,410](https://youtu.be/1gHAKhFBcOU?t=00h47m39s)

to standardize the API that's the


[00:47:42,820 --> 00:47:48,130](https://youtu.be/1gHAKhFBcOU?t=00h47m42s)

problem so we'll back up and try the


[00:47:44,410 --> 00:47:50,560](https://youtu.be/1gHAKhFBcOU?t=00h47m44s)

skin so again rather than the word


[00:47:48,130 --> 00:47:53,500](https://youtu.be/1gHAKhFBcOU?t=00h47m48s)

accent the word secondary


[00:47:50,560 --> 00:47:55,000](https://youtu.be/1gHAKhFBcOU?t=00h47m50s)

for the what used to be accent colors at


[00:47:53,500 --> 00:47:57,720](https://youtu.be/1gHAKhFBcOU?t=00h47m53s)

least from what I saw on the new


[00:47:55,000 --> 00:48:00,040](https://youtu.be/1gHAKhFBcOU?t=00h47m55s)

material design Docs this seemed to be


[00:47:57,720 --> 00:48:01,750](https://youtu.be/1gHAKhFBcOU?t=00h47m57s)

the naming scheme they were going with


[00:48:00,040 --> 00:48:05,530](https://youtu.be/1gHAKhFBcOU?t=00h48m00s)

though I still found a couple references


[00:48:01,750 --> 00:48:11,550](https://youtu.be/1gHAKhFBcOU?t=00h48m01s)

to accent in a few places requested


[00:48:05,530 --> 00:48:16,060](https://youtu.be/1gHAKhFBcOU?t=00h48m05s)

value uh and I broke the universe


[00:48:11,550 --> 00:48:18,310](https://youtu.be/1gHAKhFBcOU?t=00h48m11s)

because one should always change all of


[00:48:16,060 --> 00:48:19,590](https://youtu.be/1gHAKhFBcOU?t=00h48m16s)

their code yeah yeah yeah I hear ya I


[00:48:18,310 --> 00:48:24,760](https://youtu.be/1gHAKhFBcOU?t=00h48m18s)

hear ya


[00:48:19,590 --> 00:48:27,160](https://youtu.be/1gHAKhFBcOU?t=00h48m19s)

switch over and paste there we are try


[00:48:24,760 --> 00:48:28,600](https://youtu.be/1gHAKhFBcOU?t=00h48m24s)

this again so if you change the text in


[00:48:27,160 --> 00:48:40,780](https://youtu.be/1gHAKhFBcOU?t=00h48m27s)

one spot you should change it in the


[00:48:28,600 --> 00:48:45,190](https://youtu.be/1gHAKhFBcOU?t=00h48m28s)

other or perhaps this should be a tuple


[00:48:40,780 --> 00:48:47,740](https://youtu.be/1gHAKhFBcOU?t=00h48m40s)

or something ah there we go okay so this


[00:48:45,190 --> 00:48:55,410](https://youtu.be/1gHAKhFBcOU?t=00h48m45s)

guy now comes through we can change our


[00:48:47,740 --> 00:48:57,340](https://youtu.be/1gHAKhFBcOU?t=00h48m47s)

themes go through like dark pink lime


[00:48:55,410 --> 00:49:05,170](https://youtu.be/1gHAKhFBcOU?t=00h48m55s)

more importantly you'll notice this


[00:48:57,340 --> 00:49:07,240](https://youtu.be/1gHAKhFBcOU?t=00h48m57s)

guy's toggling - I might double check my


[00:49:05,170 --> 00:49:09,220](https://youtu.be/1gHAKhFBcOU?t=00h49m05s)

my apps brushes because it looks like


[00:49:07,240 --> 00:49:11,140](https://youtu.be/1gHAKhFBcOU?t=00h49m07s)

whatever brush this guy is using I don't


[00:49:09,220 --> 00:49:13,210](https://youtu.be/1gHAKhFBcOU?t=00h49m09s)

know if that's intentional there's that


[00:49:11,140 --> 00:49:15,910](https://youtu.be/1gHAKhFBcOU?t=00h49m11s)

stained blue or if it's not I think the


[00:49:13,210 --> 00:49:17,380](https://youtu.be/1gHAKhFBcOU?t=00h49m13s)

answer is not real quick while I'm in


[00:49:15,910 --> 00:49:19,960](https://youtu.be/1gHAKhFBcOU?t=00h49m15s)

here let me just look because there is a


[00:49:17,380 --> 00:49:22,540](https://youtu.be/1gHAKhFBcOU?t=00h49m17s)

chance that the my apps version I'm


[00:49:19,960 --> 00:49:24,660](https://youtu.be/1gHAKhFBcOU?t=00h49m19s)

using isn't compatible and if it is I


[00:49:22,540 --> 00:49:28,510](https://youtu.be/1gHAKhFBcOU?t=00h49m22s)

would like to know that


[00:49:24,660 --> 00:49:32,320](https://youtu.be/1gHAKhFBcOU?t=00h49m24s)

let's see dragging thumb let's see where


[00:49:28,510 --> 00:49:34,870](https://youtu.be/1gHAKhFBcOU?t=00h49m28s)

is that toggle switch button it's


[00:49:32,320 --> 00:49:38,560](https://youtu.be/1gHAKhFBcOU?t=00h49m32s)

probably got the brush up here to


[00:49:34,870 --> 00:49:44,980](https://youtu.be/1gHAKhFBcOU?t=00h49m34s)

Maude's metro is it gonna be down a


[00:49:38,560 --> 00:49:50,710](https://youtu.be/1gHAKhFBcOU?t=00h49m38s)

little further so this is toggle switch


[00:49:44,980 --> 00:49:55,450](https://youtu.be/1gHAKhFBcOU?t=00h49m44s)

on brush win 10 toggle switch button on


[00:49:50,710 --> 00:50:01,120](https://youtu.be/1gHAKhFBcOU?t=00h49m50s)

switch brush win 10 I'm gonna just make


[00:49:55,450 --> 00:50:03,880](https://youtu.be/1gHAKhFBcOU?t=00h49m55s)

a note of this brush to go and I don't


[00:50:01,120 --> 00:50:10,300](https://youtu.be/1gHAKhFBcOU?t=00h50m01s)

know I want to copy that resource name


[00:50:03,880 --> 00:50:11,740](https://youtu.be/1gHAKhFBcOU?t=00h50m03s)

prtscn it is I just want to make sure


[00:50:10,300 --> 00:50:13,000](https://youtu.be/1gHAKhFBcOU?t=00h50m10s)

that I go back and check that brush


[00:50:11,740 --> 00:50:14,710](https://youtu.be/1gHAKhFBcOU?t=00h50m11s)

because if there's another one that we


[00:50:13,000 --> 00:50:17,830](https://youtu.be/1gHAKhFBcOU?t=00h50m13s)

should be setting I would like to know


[00:50:14,710 --> 00:50:20,260](https://youtu.be/1gHAKhFBcOU?t=00h50m14s)

it and get that adjusted because again


[00:50:17,830 --> 00:50:25,240](https://youtu.be/1gHAKhFBcOU?t=00h50m17s)

the nice part is now I don't have to rev


[00:50:20,260 --> 00:50:26,650](https://youtu.be/1gHAKhFBcOU?t=00h50m20s)

the entire library if I need to if I


[00:50:25,240 --> 00:50:28,450](https://youtu.be/1gHAKhFBcOU?t=00h50m25s)

need to change some of the my apps


[00:50:26,650 --> 00:50:31,090](https://youtu.be/1gHAKhFBcOU?t=00h50m26s)

integration I can just Rev that library


[00:50:28,450 --> 00:50:36,580](https://youtu.be/1gHAKhFBcOU?t=00h50m28s)

by itself so going to ignore that for


[00:50:31,090 --> 00:50:40,000](https://youtu.be/1gHAKhFBcOU?t=00h50m31s)

now and let's go back and look at doing


[00:50:36,580 --> 00:50:41,620](https://youtu.be/1gHAKhFBcOU?t=00h50m36s)

the custom ones it would be good to use


[00:50:40,000 --> 00:50:44,500](https://youtu.be/1gHAKhFBcOU?t=00h50m40s)

this app for the color picker testing


[00:50:41,620 --> 00:50:47,500](https://youtu.be/1gHAKhFBcOU?t=00h50m41s)

yeah I don't disagree tie-dye actually


[00:50:44,500 --> 00:50:49,600](https://youtu.be/1gHAKhFBcOU?t=00h50m44s)

so my material design example repo one


[00:50:47,500 --> 00:50:53,050](https://youtu.be/1gHAKhFBcOU?t=00h50m47s)

of the things that I did for the to 600


[00:50:49,600 --> 00:50:55,330](https://youtu.be/1gHAKhFBcOU?t=00h50m49s)

release is I just updated every project


[00:50:53,050 --> 00:50:57,360](https://youtu.be/1gHAKhFBcOU?t=00h50m53s)

I had admittedly they're all small


[00:50:55,330 --> 00:50:59,830](https://youtu.be/1gHAKhFBcOU?t=00h50m55s)

projects with one or two things in them


[00:50:57,360 --> 00:51:03,250](https://youtu.be/1gHAKhFBcOU?t=00h50m57s)

and then I just started running them all


[00:50:59,830 --> 00:51:05,380](https://youtu.be/1gHAKhFBcOU?t=00h50m59s)

to see if I saw any problems and so this


[00:51:03,250 --> 00:51:08,200](https://youtu.be/1gHAKhFBcOU?t=00h51m03s)

is one of the first ones I run to test


[00:51:05,380 --> 00:51:11,020](https://youtu.be/1gHAKhFBcOU?t=00h51m05s)

the the theming stuff this and the two


[00:51:08,200 --> 00:51:15,190](https://youtu.be/1gHAKhFBcOU?t=00h51m08s)

demo apps are usually the sum total of


[00:51:11,020 --> 00:51:16,930](https://youtu.be/1gHAKhFBcOU?t=00h51m11s)

my full testing because if I if I get


[00:51:15,190 --> 00:51:19,210](https://youtu.be/1gHAKhFBcOU?t=00h51m15s)

all of those working across the board


[00:51:16,930 --> 00:51:21,130](https://youtu.be/1gHAKhFBcOU?t=00h51m16s)

I'm usually fairly confident we've


[00:51:19,210 --> 00:51:22,720](https://youtu.be/1gHAKhFBcOU?t=00h51m19s)

covered everything and if there's a


[00:51:21,130 --> 00:51:26,290](https://youtu.be/1gHAKhFBcOU?t=00h51m21s)

control that we miss I try to get it


[00:51:22,720 --> 00:51:28,240](https://youtu.be/1gHAKhFBcOU?t=00h51m22s)

added to one of the projects okay so


[00:51:26,290 --> 00:51:29,530](https://youtu.be/1gHAKhFBcOU?t=00h51m26s)

back to the other thing so this is all


[00:51:28,240 --> 00:51:31,840](https://youtu.be/1gHAKhFBcOU?t=00h51m28s)

well and good as long as you're using


[00:51:29,530 --> 00:51:35,410](https://youtu.be/1gHAKhFBcOU?t=00h51m29s)

the built-in color theme stuff but now


[00:51:31,840 --> 00:51:37,360](https://youtu.be/1gHAKhFBcOU?t=00h51m31s)

let's look at doing both generating


[00:51:35,410 --> 00:51:40,360](https://youtu.be/1gHAKhFBcOU?t=00h51m35s)

color themes from resource dictionaries


[00:51:37,360 --> 00:51:43,990](https://youtu.be/1gHAKhFBcOU?t=00h51m37s)

as well as from code so this app here


[00:51:40,360 --> 00:51:47,860](https://youtu.be/1gHAKhFBcOU?t=00h51m40s)

has this custom zamel theme and all it


[00:51:43,990 --> 00:51:50,370](https://youtu.be/1gHAKhFBcOU?t=00h51m43s)

does is declare a bunch of colors just


[00:51:47,860 --> 00:51:52,630](https://youtu.be/1gHAKhFBcOU?t=00h51m47s)

right here in line with each of these


[00:51:50,370 --> 00:51:56,110](https://youtu.be/1gHAKhFBcOU?t=00h51m50s)

nothing fancy


[00:51:52,630 --> 00:51:58,830](https://youtu.be/1gHAKhFBcOU?t=00h51m52s)

these happen to match the material


[00:51:56,110 --> 00:52:00,790](https://youtu.be/1gHAKhFBcOU?t=00h51m56s)

design brush names but that's


[00:51:58,830 --> 00:52:03,100](https://youtu.be/1gHAKhFBcOU?t=00h51m58s)

coincidental you could theoretically


[00:52:00,790 --> 00:52:07,150](https://youtu.be/1gHAKhFBcOU?t=00h52m00s)

name these however you want as you will


[00:52:03,100 --> 00:52:10,780](https://youtu.be/1gHAKhFBcOU?t=00h52m03s)

see so let's take and pick on I think


[00:52:07,150 --> 00:52:12,150](https://youtu.be/1gHAKhFBcOU?t=00h52m07s)

let's do the the code one first because


[00:52:10,780 --> 00:52:15,520](https://youtu.be/1gHAKhFBcOU?t=00h52m10s)

I think that's that was probably the


[00:52:12,150 --> 00:52:17,470](https://youtu.be/1gHAKhFBcOU?t=00h52m12s)

simpler option so we will do generate


[00:52:15,520 --> 00:52:20,770](https://youtu.be/1gHAKhFBcOU?t=00h52m15s)

theme from code


[00:52:17,470 --> 00:52:24,880](https://youtu.be/1gHAKhFBcOU?t=00h52m17s)

bring that guy back and then let's see


[00:52:20,770 --> 00:52:27,339](https://youtu.be/1gHAKhFBcOU?t=00h52m20s)

generate theme from code so this was the


[00:52:24,880 --> 00:52:33,130](https://youtu.be/1gHAKhFBcOU?t=00h52m24s)

Fire and Ice theme the the blue and


[00:52:27,339 --> 00:52:36,099](https://youtu.be/1gHAKhFBcOU?t=00h52m27s)

orange as it were okay so this code is


[00:52:33,130 --> 00:52:39,339](https://youtu.be/1gHAKhFBcOU?t=00h52m33s)

all well and good we're gonna just


[00:52:36,099 --> 00:52:42,790](https://youtu.be/1gHAKhFBcOU?t=00h52m36s)

comment it out so step one create a new


[00:52:39,339 --> 00:52:46,510](https://youtu.be/1gHAKhFBcOU?t=00h52m39s)

theme so I think I'm just going to just


[00:52:42,790 --> 00:52:51,430](https://youtu.be/1gHAKhFBcOU?t=00h52m42s)

straight up new up a new theme object we


[00:52:46,510 --> 00:52:54,599](https://youtu.be/1gHAKhFBcOU?t=00h52m46s)

will then set the base theme and this


[00:52:51,430 --> 00:52:59,339](https://youtu.be/1gHAKhFBcOU?t=00h52m51s)

one isn't going to matter too much


[00:52:54,599 --> 00:53:01,300](https://youtu.be/1gHAKhFBcOU?t=00h52m54s)

because ultimately these this theme here


[00:52:59,339 --> 00:53:04,119](https://youtu.be/1gHAKhFBcOU?t=00h52m59s)

the base theme is going to get


[00:53:01,300 --> 00:53:06,220](https://youtu.be/1gHAKhFBcOU?t=00h53m01s)

overwritten on the onset theme so we can


[00:53:04,119 --> 00:53:07,270](https://youtu.be/1gHAKhFBcOU?t=00h53m04s)

pass really anything we want here and


[00:53:06,220 --> 00:53:08,980](https://youtu.be/1gHAKhFBcOU?t=00h53m06s)

it's not going to really make a


[00:53:07,270 --> 00:53:10,720](https://youtu.be/1gHAKhFBcOU?t=00h53m07s)

difference just but the way this app is


[00:53:08,980 --> 00:53:13,270](https://youtu.be/1gHAKhFBcOU?t=00h53m08s)

set up so we'll just go with light


[00:53:10,720 --> 00:53:15,550](https://youtu.be/1gHAKhFBcOU?t=00h53m10s)

because it doesn't matter and then we


[00:53:13,270 --> 00:53:18,940](https://youtu.be/1gHAKhFBcOU?t=00h53m13s)

want to go through and set the the


[00:53:15,550 --> 00:53:21,819](https://youtu.be/1gHAKhFBcOU?t=00h53m15s)

primary colors and the the secondary


[00:53:18,940 --> 00:53:25,000](https://youtu.be/1gHAKhFBcOU?t=00h53m18s)

colors to effectively match these ones


[00:53:21,819 --> 00:53:28,030](https://youtu.be/1gHAKhFBcOU?t=00h53m21s)

here so you'll note the the light one


[00:53:25,000 --> 00:53:29,800](https://youtu.be/1gHAKhFBcOU?t=00h53m25s)

which used to be primary 200 was salmon


[00:53:28,030 --> 00:53:32,380](https://youtu.be/1gHAKhFBcOU?t=00h53m28s)

and then we went up to orange and then


[00:53:29,800 --> 00:53:36,400](https://youtu.be/1gHAKhFBcOU?t=00h53m29s)

red with the what used to be called


[00:53:32,380 --> 00:53:39,520](https://youtu.be/1gHAKhFBcOU?t=00h53m32s)

accent color being set to deep sky blue


[00:53:36,400 --> 00:53:41,800](https://youtu.be/1gHAKhFBcOU?t=00h53m36s)

with a foreground color of green so once


[00:53:39,520 --> 00:53:44,230](https://youtu.be/1gHAKhFBcOU?t=00h53m39s)

again I'm going to just cheat a little


[00:53:41,800 --> 00:53:48,599](https://youtu.be/1gHAKhFBcOU?t=00h53m41s)

bit so I don't have to type all this


[00:53:44,230 --> 00:53:55,329](https://youtu.be/1gHAKhFBcOU?t=00h53m44s)

again and so these are just the standard


[00:53:48,599 --> 00:53:58,270](https://youtu.be/1gHAKhFBcOU?t=00h53m48s)

WPF colors being brought in this this


[00:53:55,329 --> 00:54:00,400](https://youtu.be/1gHAKhFBcOU?t=00h53m55s)

demo app and currently nothing in the


[00:53:58,270 --> 00:54:02,680](https://youtu.be/1gHAKhFBcOU?t=00h53m58s)

material design library takes advantage


[00:54:00,400 --> 00:54:04,480](https://youtu.be/1gHAKhFBcOU?t=00h54m00s)

of secondary light and dark they're


[00:54:02,680 --> 00:54:06,099](https://youtu.be/1gHAKhFBcOU?t=00h54m02s)

added to the theme API with the


[00:54:04,480 --> 00:54:09,490](https://youtu.be/1gHAKhFBcOU?t=00h54m04s)

assumption that we will take advantage


[00:54:06,099 --> 00:54:11,560](https://youtu.be/1gHAKhFBcOU?t=00h54m06s)

of them in the future but they are there


[00:54:09,490 --> 00:54:12,849](https://youtu.be/1gHAKhFBcOU?t=00h54m09s)

for your usage just know that none of


[00:54:11,560 --> 00:54:14,980](https://youtu.be/1gHAKhFBcOU?t=00h54m11s)

the built-in controls are taking


[00:54:12,849 --> 00:54:17,970](https://youtu.be/1gHAKhFBcOU?t=00h54m12s)

advantage of these so for now we're just


[00:54:14,980 --> 00:54:22,329](https://youtu.be/1gHAKhFBcOU?t=00h54m14s)

setting all of them to the same color


[00:54:17,970 --> 00:54:27,819](https://youtu.be/1gHAKhFBcOU?t=00h54m17s)

okay and then finally we just kick back


[00:54:22,329 --> 00:54:30,460](https://youtu.be/1gHAKhFBcOU?t=00h54m22s)

the theme done and again this is going


[00:54:27,819 --> 00:54:31,930](https://youtu.be/1gHAKhFBcOU?t=00h54m27s)

through and explicitly setting the


[00:54:30,460 --> 00:54:34,300](https://youtu.be/1gHAKhFBcOU?t=00h54m30s)

foreground color


[00:54:31,930 --> 00:54:37,570](https://youtu.be/1gHAKhFBcOU?t=00h54m31s)

if we wanted to we could omit these and


[00:54:34,300 --> 00:54:40,870](https://youtu.be/1gHAKhFBcOU?t=00h54m34s)

let it guess at the appropriate


[00:54:37,570 --> 00:54:43,570](https://youtu.be/1gHAKhFBcOU?t=00h54m37s)

foreground color in fact let's do that


[00:54:40,870 --> 00:54:46,480](https://youtu.be/1gHAKhFBcOU?t=00h54m40s)

real quick again if you let it guess at


[00:54:43,570 --> 00:54:48,700](https://youtu.be/1gHAKhFBcOU?t=00h54m43s)

the foreground color it's only going to


[00:54:46,480 --> 00:54:50,560](https://youtu.be/1gHAKhFBcOU?t=00h54m46s)

pick white or black it's not going


[00:54:48,700 --> 00:54:52,540](https://youtu.be/1gHAKhFBcOU?t=00h54m48s)

there's no other ground it basically


[00:54:50,560 --> 00:54:54,220](https://youtu.be/1gHAKhFBcOU?t=00h54m50s)

says is this a dark color okay I'm gonna


[00:54:52,540 --> 00:54:55,930](https://youtu.be/1gHAKhFBcOU?t=00h54m52s)

pick light or I'm gonna pick white is


[00:54:54,220 --> 00:54:59,260](https://youtu.be/1gHAKhFBcOU?t=00h54m54s)

this a light color okay I'm gonna pick


[00:54:55,930 --> 00:55:02,410](https://youtu.be/1gHAKhFBcOU?t=00h54m55s)

black and so especially colors where


[00:54:59,260 --> 00:55:05,560](https://youtu.be/1gHAKhFBcOU?t=00h54m59s)

that that white or black neither one of


[00:55:02,410 --> 00:55:08,140](https://youtu.be/1gHAKhFBcOU?t=00h55m02s)

them are great you may end up wanting to


[00:55:05,560 --> 00:55:11,020](https://youtu.be/1gHAKhFBcOU?t=00h55m05s)

explicitly set a foreground color for


[00:55:08,140 --> 00:55:13,990](https://youtu.be/1gHAKhFBcOU?t=00h55m08s)

them the built-in color themes those all


[00:55:11,020 --> 00:55:16,150](https://youtu.be/1gHAKhFBcOU?t=00h55m11s)

just work just fine use the additional


[00:55:13,990 --> 00:55:17,590](https://youtu.be/1gHAKhFBcOU?t=00h55m13s)

secondary colors currently no tied the


[00:55:16,150 --> 00:55:22,090](https://youtu.be/1gHAKhFBcOU?t=00h55m16s)

only one that's being used by the


[00:55:17,590 --> 00:55:23,770](https://youtu.be/1gHAKhFBcOU?t=00h55m17s)

existing stuff is the secondary mid so


[00:55:22,090 --> 00:55:29,230](https://youtu.be/1gHAKhFBcOU?t=00h55m22s)

this is the only one that's currently in


[00:55:23,770 --> 00:55:33,310](https://youtu.be/1gHAKhFBcOU?t=00h55m23s)

use oh do any of the material design


[00:55:29,230 --> 00:55:35,740](https://youtu.be/1gHAKhFBcOU?t=00h55m29s)

controls that is a good question so the


[00:55:33,310 --> 00:55:38,670](https://youtu.be/1gHAKhFBcOU?t=00h55m33s)

spec itself even though it outlines the


[00:55:35,740 --> 00:55:42,640](https://youtu.be/1gHAKhFBcOU?t=00h55m35s)

controls isn't overly picky about


[00:55:38,670 --> 00:55:46,960](https://youtu.be/1gHAKhFBcOU?t=00h55m38s)

defining controls and colors sort of


[00:55:42,640 --> 00:55:49,090](https://youtu.be/1gHAKhFBcOU?t=00h55m42s)

having styles that mix a particular to a


[00:55:46,960 --> 00:55:52,210](https://youtu.be/1gHAKhFBcOU?t=00h55m46s)

control is something that this library


[00:55:49,090 --> 00:55:54,010](https://youtu.be/1gHAKhFBcOU?t=00h55m49s)

does just because it makes it easier on


[00:55:52,210 --> 00:55:58,510](https://youtu.be/1gHAKhFBcOU?t=00h55m52s)

the styles and doesn't force you to set


[00:55:54,010 --> 00:56:00,910](https://youtu.be/1gHAKhFBcOU?t=00h55m54s)

things repeatedly but the the spec


[00:55:58,510 --> 00:56:02,860](https://youtu.be/1gHAKhFBcOU?t=00h55m58s)

really just sort of outlines here's the


[00:56:00,910 --> 00:56:05,530](https://youtu.be/1gHAKhFBcOU?t=00h56m00s)

colors and here's what each color means


[00:56:02,860 --> 00:56:07,480](https://youtu.be/1gHAKhFBcOU?t=00h56m02s)

use it appropriately oh and here's a set


[00:56:05,530 --> 00:56:10,240](https://youtu.be/1gHAKhFBcOU?t=00h56m05s)

of controls and so mix and match where


[00:56:07,480 --> 00:56:13,530](https://youtu.be/1gHAKhFBcOU?t=00h56m07s)

it makes sense so they define the


[00:56:10,240 --> 00:56:16,450](https://youtu.be/1gHAKhFBcOU?t=00h56m10s)

concept of secondary mid light and dark


[00:56:13,530 --> 00:56:19,390](https://youtu.be/1gHAKhFBcOU?t=00h56m13s)

but they and sort of when those would


[00:56:16,450 --> 00:56:21,910](https://youtu.be/1gHAKhFBcOU?t=00h56m16s)

get used but there's not really a a


[00:56:19,390 --> 00:56:24,910](https://youtu.be/1gHAKhFBcOU?t=00h56m19s)

concept of mixing the the controls and


[00:56:21,910 --> 00:56:27,700](https://youtu.be/1gHAKhFBcOU?t=00h56m21s)

the colors together in the spec it is


[00:56:24,910 --> 00:56:30,010](https://youtu.be/1gHAKhFBcOU?t=00h56m24s)

the the material design spec is more of


[00:56:27,700 --> 00:56:31,690](https://youtu.be/1gHAKhFBcOU?t=00h56m27s)

here's how you should lay things out and


[00:56:30,010 --> 00:56:34,120](https://youtu.be/1gHAKhFBcOU?t=00h56m30s)

here's how what things mean and what


[00:56:31,690 --> 00:56:37,210](https://youtu.be/1gHAKhFBcOU?t=00h56m31s)

users are going to expect put them


[00:56:34,120 --> 00:56:38,770](https://youtu.be/1gHAKhFBcOU?t=00h56m34s)

together in the right way which is both


[00:56:37,210 --> 00:56:40,870](https://youtu.be/1gHAKhFBcOU?t=00h56m37s)

good and bad so it gives a lot of


[00:56:38,770 --> 00:56:44,200](https://youtu.be/1gHAKhFBcOU?t=00h56m38s)

freedom because part of what they've


[00:56:40,870 --> 00:56:45,609](https://youtu.be/1gHAKhFBcOU?t=00h56m40s)

done with it is the initially it was


[00:56:44,200 --> 00:56:47,670](https://youtu.be/1gHAKhFBcOU?t=00h56m44s)

just Android


[00:56:45,609 --> 00:56:50,020](https://youtu.be/1gHAKhFBcOU?t=00h56m45s)

but now you've got things like


[00:56:47,670 --> 00:56:52,330](https://youtu.be/1gHAKhFBcOU?t=00h56m47s)

Chromebooks where you're starting to see


[00:56:50,020 --> 00:56:54,550](https://youtu.be/1gHAKhFBcOU?t=00h56m50s)

these apps come across and material


[00:56:52,330 --> 00:56:57,730](https://youtu.be/1gHAKhFBcOU?t=00h56m52s)

design getting used in web pages and so


[00:56:54,550 --> 00:57:02,440](https://youtu.be/1gHAKhFBcOU?t=00h56m54s)

it's not just for mobile it's trying to


[00:56:57,730 --> 00:57:06,160](https://youtu.be/1gHAKhFBcOU?t=00h56m57s)

be an entire design framework if that


[00:57:02,440 --> 00:57:07,900](https://youtu.be/1gHAKhFBcOU?t=00h57m02s)

all makes sense okay so this is all it


[00:57:06,160 --> 00:57:10,450](https://youtu.be/1gHAKhFBcOU?t=00h57m06s)

takes if you want to go through and


[00:57:07,900 --> 00:57:13,690](https://youtu.be/1gHAKhFBcOU?t=00h57m07s)

create up a theme in code so if you want


[00:57:10,450 --> 00:57:15,880](https://youtu.be/1gHAKhFBcOU?t=00h57m10s)

it yeah or Windows apps exactly so if


[00:57:13,690 --> 00:57:18,970](https://youtu.be/1gHAKhFBcOU?t=00h57m13s)

you want to go through and build out


[00:57:15,880 --> 00:57:21,190](https://youtu.be/1gHAKhFBcOU?t=00h57m15s)

some means of serializing your theme and


[00:57:18,970 --> 00:57:24,690](https://youtu.be/1gHAKhFBcOU?t=00h57m18s)

reloading it or just building out your


[00:57:21,190 --> 00:57:27,790](https://youtu.be/1gHAKhFBcOU?t=00h57m21s)

own custom stuff in code behind it


[00:57:24,690 --> 00:57:29,470](https://youtu.be/1gHAKhFBcOU?t=00h57m24s)

shouldn't be any harder than this you do


[00:57:27,790 --> 00:57:32,980](https://youtu.be/1gHAKhFBcOU?t=00h57m27s)

need to make sure that you do set all of


[00:57:29,470 --> 00:57:35,740](https://youtu.be/1gHAKhFBcOU?t=00h57m29s)

the brushes on your theme and it can be


[00:57:32,980 --> 00:57:39,820](https://youtu.be/1gHAKhFBcOU?t=00h57m32s)

as simple as simply calling theme set


[00:57:35,740 --> 00:57:41,560](https://youtu.be/1gHAKhFBcOU?t=00h57m35s)

base set primary set secondary if you


[00:57:39,820 --> 00:57:44,099](https://youtu.be/1gHAKhFBcOU?t=00h57m39s)

call all three of those that'll have


[00:57:41,560 --> 00:57:46,300](https://youtu.be/1gHAKhFBcOU?t=00h57m41s)

everything set and you'll be done


[00:57:44,099 --> 00:57:48,430](https://youtu.be/1gHAKhFBcOU?t=00h57m44s)

because there are there are quite a few


[00:57:46,300 --> 00:57:52,089](https://youtu.be/1gHAKhFBcOU?t=00h57m46s)

brushes on this theme object but the


[00:57:48,430 --> 00:57:55,540](https://youtu.be/1gHAKhFBcOU?t=00h57m48s)

idea being that by codifying all of the


[00:57:52,089 --> 00:57:58,930](https://youtu.be/1gHAKhFBcOU?t=00h57m52s)

brushes it now means if and when we make


[00:57:55,540 --> 00:58:01,240](https://youtu.be/1gHAKhFBcOU?t=00h57m55s)

any breaking color or brush changes


[00:57:58,930 --> 00:58:03,160](https://youtu.be/1gHAKhFBcOU?t=00h57m58s)

you'll get compile errors and not just


[00:58:01,240 --> 00:58:06,040](https://youtu.be/1gHAKhFBcOU?t=00h58m01s)

missing resources and having to track


[00:58:03,160 --> 00:58:08,680](https://youtu.be/1gHAKhFBcOU?t=00h58m03s)

those down anymore which i think is much


[00:58:06,040 --> 00:58:11,920](https://youtu.be/1gHAKhFBcOU?t=00h58m06s)

nicer okay so let's do the one from the


[00:58:08,680 --> 00:58:14,500](https://youtu.be/1gHAKhFBcOU?t=00h58m08s)

resource dictionary as well so before


[00:58:11,920 --> 00:58:16,150](https://youtu.be/1gHAKhFBcOU?t=00h58m11s)

what this guy was doing is it was just


[00:58:14,500 --> 00:58:19,599](https://youtu.be/1gHAKhFBcOU?t=00h58m14s)

calling into the resource dictionary


[00:58:16,150 --> 00:58:21,820](https://youtu.be/1gHAKhFBcOU?t=00h58m16s)

okay fine load reference let's go be


[00:58:19,599 --> 00:58:23,650](https://youtu.be/1gHAKhFBcOU?t=00h58m19s)

happy singing stop whining at me is it


[00:58:21,820 --> 00:58:25,570](https://youtu.be/1gHAKhFBcOU?t=00h58m21s)

was just calling into the resource


[00:58:23,650 --> 00:58:28,150](https://youtu.be/1gHAKhFBcOU?t=00h58m23s)

dictionary and looking up those colors


[00:58:25,570 --> 00:58:29,859](https://youtu.be/1gHAKhFBcOU?t=00h58m25s)

based on their keys so again when I said


[00:58:28,150 --> 00:58:32,830](https://youtu.be/1gHAKhFBcOU?t=00h58m28s)

that these names just happen to match


[00:58:29,859 --> 00:58:35,589](https://youtu.be/1gHAKhFBcOU?t=00h58m29s)

the material design theme it really is


[00:58:32,830 --> 00:58:38,740](https://youtu.be/1gHAKhFBcOU?t=00h58m32s)

this for this this could be my hue color


[00:58:35,589 --> 00:58:41,020](https://youtu.be/1gHAKhFBcOU?t=00h58m35s)

one my hue color two if you wanted the


[00:58:38,740 --> 00:58:43,390](https://youtu.be/1gHAKhFBcOU?t=00h58m38s)

the key part is these keys just have to


[00:58:41,020 --> 00:58:47,500](https://youtu.be/1gHAKhFBcOU?t=00h58m41s)

match the keys from the from the zamel


[00:58:43,390 --> 00:58:50,800](https://youtu.be/1gHAKhFBcOU?t=00h58m43s)

dictionary so if we wanted to go through


[00:58:47,500 --> 00:58:53,980](https://youtu.be/1gHAKhFBcOU?t=00h58m47s)

and change these guys out all we got to


[00:58:50,800 --> 00:58:56,170](https://youtu.be/1gHAKhFBcOU?t=00h58m50s)

do is a couple quick switches so once


[00:58:53,980 --> 00:58:57,690](https://youtu.be/1gHAKhFBcOU?t=00h58m53s)

again I'm going to just comment this guy


[00:58:56,170 --> 00:59:00,839](https://youtu.be/1gHAKhFBcOU?t=00h58m56s)

out because


[00:58:57,690 --> 00:59:04,170](https://youtu.be/1gHAKhFBcOU?t=00h58m57s)

he's a little meaningless and we're


[00:59:00,839 --> 00:59:06,720](https://youtu.be/1gHAKhFBcOU?t=00h59m00s)

gonna start same same thing here we're


[00:59:04,170 --> 00:59:08,789](https://youtu.be/1gHAKhFBcOU?t=00h59m04s)

gonna set a base theme just so that I


[00:59:06,720 --> 00:59:10,380](https://youtu.be/1gHAKhFBcOU?t=00h59m06s)

know that all my brushes are set but


[00:59:08,789 --> 00:59:11,849](https://youtu.be/1gHAKhFBcOU?t=00h59m08s)

again this this set is pretty


[00:59:10,380 --> 00:59:13,980](https://youtu.be/1gHAKhFBcOU?t=00h59m10s)

meaningless because it's going to get


[00:59:11,849 --> 00:59:16,319](https://youtu.be/1gHAKhFBcOU?t=00h59m11s)

overridden here before this theme


[00:59:13,980 --> 00:59:21,089](https://youtu.be/1gHAKhFBcOU?t=00h59m13s)

actually get applies it gets applied to


[00:59:16,319 --> 00:59:25,380](https://youtu.be/1gHAKhFBcOU?t=00h59m16s)

anything and then let's just I'm gonna


[00:59:21,089 --> 00:59:28,680](https://youtu.be/1gHAKhFBcOU?t=00h59m21s)

once again just cheat and grab my little


[00:59:25,380 --> 00:59:31,319](https://youtu.be/1gHAKhFBcOU?t=00h59m25s)

code snippet ahead of time so same type


[00:59:28,680 --> 00:59:33,270](https://youtu.be/1gHAKhFBcOU?t=00h59m28s)

of thing as before it just pulls out the


[00:59:31,319 --> 00:59:37,280](https://youtu.be/1gHAKhFBcOU?t=00h59m31s)

color pair and looks up the color from


[00:59:33,270 --> 00:59:42,690](https://youtu.be/1gHAKhFBcOU?t=00h59m33s)

the resource dictionary pulls it out and


[00:59:37,280 --> 00:59:44,000](https://youtu.be/1gHAKhFBcOU?t=00h59m37s)

sends it back so nothing nothing too


[00:59:42,690 --> 00:59:46,799](https://youtu.be/1gHAKhFBcOU?t=00h59m42s)

fancy


[00:59:44,000 --> 00:59:51,450](https://youtu.be/1gHAKhFBcOU?t=00h59m44s)

rather than name I think we're gonna


[00:59:46,799 --> 00:59:53,490](https://youtu.be/1gHAKhFBcOU?t=00h59m46s)

change this up to be key because name


[00:59:51,450 --> 00:59:55,890](https://youtu.be/1gHAKhFBcOU?t=00h59m51s)

was the name of the theme not the name


[00:59:53,490 --> 00:59:59,760](https://youtu.be/1gHAKhFBcOU?t=00h59m53s)

of the color so that was a wee bit


[00:59:55,890 --> 01:00:06,510](https://youtu.be/1gHAKhFBcOU?t=00h59m55s)

misleading in the previous code and then


[00:59:59,760 --> 01:00:11,480](https://youtu.be/1gHAKhFBcOU?t=00h59m59s)

the last thing returned theme okay so


[01:00:06,510 --> 01:00:11,480](https://youtu.be/1gHAKhFBcOU?t=01h00m06s)

this guy the name no longer goes here


[01:00:11,569 --> 01:00:17,430](https://youtu.be/1gHAKhFBcOU?t=01h00m11s)

and actually I'm gonna make these guys


[01:00:14,069 --> 01:00:19,079](https://youtu.be/1gHAKhFBcOU?t=01h00m14s)

return I themes just so that just to be


[01:00:17,430 --> 01:00:23,460](https://youtu.be/1gHAKhFBcOU?t=01h00m17s)

a little nicer because there's no reason


[01:00:19,079 --> 01:00:27,480](https://youtu.be/1gHAKhFBcOU?t=01h00m19s)

to make this API strongly coupled to


[01:00:23,460 --> 01:00:30,150](https://youtu.be/1gHAKhFBcOU?t=01h00m23s)

that particular object okay and so this


[01:00:27,480 --> 01:00:34,260](https://youtu.be/1gHAKhFBcOU?t=01h00m27s)

guy here loads up the resource


[01:00:30,150 --> 01:00:38,369](https://youtu.be/1gHAKhFBcOU?t=01h00m30s)

dictionary and then we're going to do


[01:00:34,260 --> 01:00:39,779](https://youtu.be/1gHAKhFBcOU?t=01h00m34s)

this guy where we go control you let's


[01:00:38,369 --> 01:00:42,450](https://youtu.be/1gHAKhFBcOU?t=01h00m38s)

see you get theme from resource


[01:00:39,779 --> 01:00:46,470](https://youtu.be/1gHAKhFBcOU?t=01h00m39s)

dictionary and there we go so we've got


[01:00:42,450 --> 01:00:49,710](https://youtu.be/1gHAKhFBcOU?t=01h00m42s)

our jungle green theme here that it's


[01:00:46,470 --> 01:00:52,309](https://youtu.be/1gHAKhFBcOU?t=01h00m46s)

going to pull out of that let's fire


[01:00:49,710 --> 01:00:52,309](https://youtu.be/1gHAKhFBcOU?t=01h00m49s)

this guy up


[01:01:03,950 --> 01:01:09,579](https://youtu.be/1gHAKhFBcOU?t=01h01m03s)

and hopefully this guy go go go go go go


[01:01:15,750 --> 01:01:20,280](https://youtu.be/1gHAKhFBcOU?t=01h01m15s)

and now we should have two extra options


[01:01:18,300 --> 01:01:24,720](https://youtu.be/1gHAKhFBcOU?t=01h01m18s)

in our list of color themes that we can


[01:01:20,280 --> 01:01:26,240](https://youtu.be/1gHAKhFBcOU?t=01h01m20s)

just toggle between so make this window


[01:01:24,720 --> 01:01:29,099](https://youtu.be/1gHAKhFBcOU?t=01h01m24s)

a little bigger so I can see everything


[01:01:26,240 --> 01:01:34,200](https://youtu.be/1gHAKhFBcOU?t=01h01m26s)

so if I go with my fire and ice' option


[01:01:29,099 --> 01:01:36,680](https://youtu.be/1gHAKhFBcOU?t=01h01m29s)

I now have those colors if we go dark I


[01:01:34,200 --> 01:01:40,140](https://youtu.be/1gHAKhFBcOU?t=01h01m34s)

think it's a little more obvious to see


[01:01:36,680 --> 01:01:43,530](https://youtu.be/1gHAKhFBcOU?t=01h01m36s)

if I go jungle I now have my jungle


[01:01:40,140 --> 01:01:48,570](https://youtu.be/1gHAKhFBcOU?t=01h01m40s)

themed ones as well you can see those


[01:01:43,530 --> 01:01:53,090](https://youtu.be/1gHAKhFBcOU?t=01h01m43s)

switched all over and that's all there


[01:01:48,570 --> 01:01:56,880](https://youtu.be/1gHAKhFBcOU?t=01h01m48s)

is to it really everything in this


[01:01:53,090 --> 01:01:59,790](https://youtu.be/1gHAKhFBcOU?t=01h01m53s)

theming API I think boils down to using


[01:01:56,880 --> 01:02:02,609](https://youtu.be/1gHAKhFBcOU?t=01h01m56s)

the new get set theme on the palette


[01:01:59,790 --> 01:02:05,760](https://youtu.be/1gHAKhFBcOU?t=01h01m59s)

helper and if you want to go even more


[01:02:02,609 --> 01:02:09,890](https://youtu.be/1gHAKhFBcOU?t=01h02m02s)

low-level than that on the resource


[01:02:05,760 --> 01:02:12,780](https://youtu.be/1gHAKhFBcOU?t=01h02m05s)

dictionary itself most of the calls


[01:02:09,890 --> 01:02:17,670](https://youtu.be/1gHAKhFBcOU?t=01h02m09s)

ultimately boil down to resource


[01:02:12,780 --> 01:02:19,980](https://youtu.be/1gHAKhFBcOU?t=01h02m12s)

dictionary set theme which this


[01:02:17,670 --> 01:02:22,640](https://youtu.be/1gHAKhFBcOU?t=01h02m17s)

extension method just shells out


[01:02:19,980 --> 01:02:22,640](https://youtu.be/1gHAKhFBcOU?t=01h02m19s)

go-go-go


[01:02:24,330 --> 01:02:28,619](https://youtu.be/1gHAKhFBcOU?t=01h02m24s)

shells out to a resource dictionary it


[01:02:26,430 --> 01:02:30,869](https://youtu.be/1gHAKhFBcOU?t=01h02m26s)

takes in a theme object and this is


[01:02:28,619 --> 01:02:33,869](https://youtu.be/1gHAKhFBcOU?t=01h02m28s)

somewhat ugly to look at but all it does


[01:02:30,869 --> 01:02:36,450](https://youtu.be/1gHAKhFBcOU?t=01h02m30s)

is go through it go through and set all


[01:02:33,869 --> 01:02:42,570](https://youtu.be/1gHAKhFBcOU?t=01h02m33s)

of those brushes from the theme into the


[01:02:36,450 --> 01:02:44,040](https://youtu.be/1gHAKhFBcOU?t=01h02m36s)

resource dictionary and that's it Magnus


[01:02:42,570 --> 01:02:45,720](https://youtu.be/1gHAKhFBcOU?t=01h02m42s)

oh I know I saw you in the the chat


[01:02:44,040 --> 01:02:47,700](https://youtu.be/1gHAKhFBcOU?t=01h02m44s)

earlier is is that helpful I know you


[01:02:45,720 --> 01:02:49,080](https://youtu.be/1gHAKhFBcOU?t=01h02m45s)

were you were asking for a blog post on


[01:02:47,700 --> 01:02:51,119](https://youtu.be/1gHAKhFBcOU?t=01h02m47s)

this and I think I may still end up


[01:02:49,080 --> 01:02:52,740](https://youtu.be/1gHAKhFBcOU?t=01h02m49s)

writing one just so that there's a


[01:02:51,119 --> 01:02:55,140](https://youtu.be/1gHAKhFBcOU?t=01h02m51s)

little bit more thorough documentation


[01:02:52,740 --> 01:02:57,810](https://youtu.be/1gHAKhFBcOU?t=01h02m52s)

but I figured I at least wanted to go


[01:02:55,140 --> 01:03:01,770](https://youtu.be/1gHAKhFBcOU?t=01h02m55s)

through this to just show off what I


[01:02:57,810 --> 01:03:04,430](https://youtu.be/1gHAKhFBcOU?t=01h02m57s)

what I think as a cleaner API I hope so


[01:03:01,770 --> 01:03:06,720](https://youtu.be/1gHAKhFBcOU?t=01h03m01s)

I'm hoping this is easier for everybody


[01:03:04,430 --> 01:03:08,640](https://youtu.be/1gHAKhFBcOU?t=01h03m04s)

one other thing I don't think I I


[01:03:06,720 --> 01:03:11,760](https://youtu.be/1gHAKhFBcOU?t=01h03m06s)

mentioned I think I implied so there's


[01:03:08,640 --> 01:03:14,930](https://youtu.be/1gHAKhFBcOU?t=01h03m08s)

my apps bundled theme Oh awesome and


[01:03:11,760 --> 01:03:19,740](https://youtu.be/1gHAKhFBcOU?t=01h03m11s)

then there there is also the MA apps


[01:03:14,930 --> 01:03:21,510](https://youtu.be/1gHAKhFBcOU?t=01h03m14s)

what is it a custom color theme so if


[01:03:19,740 --> 01:03:24,349](https://youtu.be/1gHAKhFBcOU?t=01h03m19s)

you want to go through and change up


[01:03:21,510 --> 01:03:28,480](https://youtu.be/1gHAKhFBcOU?t=01h03m21s)

rather than using the built-in ones so


[01:03:24,349 --> 01:03:34,770](https://youtu.be/1gHAKhFBcOU?t=01h03m24s)

so primary you know


[01:03:28,480 --> 01:03:37,119](https://youtu.be/1gHAKhFBcOU?t=01h03m28s)

aqua secondary we'll just make this


[01:03:34,770 --> 01:03:40,030](https://youtu.be/1gHAKhFBcOU?t=01h03m34s)

really obvious I don't know


[01:03:37,119 --> 01:03:42,810](https://youtu.be/1gHAKhFBcOU?t=01h03m37s)

red so you can go through and do


[01:03:40,030 --> 01:03:45,490](https://youtu.be/1gHAKhFBcOU?t=01h03m40s)

something like this both of these guys


[01:03:42,810 --> 01:03:48,220](https://youtu.be/1gHAKhFBcOU?t=01h03m42s)

just arrived from the material design


[01:03:45,490 --> 01:03:51,700](https://youtu.be/1gHAKhFBcOU?t=01h03m45s)

markup extension the one thing that it


[01:03:48,220 --> 01:03:53,890](https://youtu.be/1gHAKhFBcOU?t=01h03m48s)

does do is it gives you a nice injection


[01:03:51,700 --> 01:03:55,329](https://youtu.be/1gHAKhFBcOU?t=01h03m51s)

point to be able to hijack it so I think


[01:03:53,890 --> 01:03:57,670](https://youtu.be/1gHAKhFBcOU?t=01h03m53s)

I'll walk through that real quick as


[01:03:55,329 --> 01:04:00,160](https://youtu.be/1gHAKhFBcOU?t=01h03m55s)

well so in addition to this I theme


[01:03:57,670 --> 01:04:03,700](https://youtu.be/1gHAKhFBcOU?t=01h03m57s)

interface subtly hidden under the covers


[01:04:00,160 --> 01:04:05,770](https://youtu.be/1gHAKhFBcOU?t=01h04m00s)

is also a theme manager so if you have


[01:04:03,700 --> 01:04:09,640](https://youtu.be/1gHAKhFBcOU?t=01h04m03s)

something in your app where you want to


[01:04:05,770 --> 01:04:11,560](https://youtu.be/1gHAKhFBcOU?t=01h04m05s)

do stuff when the theme changes there is


[01:04:09,640 --> 01:04:14,349](https://youtu.be/1gHAKhFBcOU?t=01h04m09s)

an event that gets raised that you can


[01:04:11,560 --> 01:04:17,200](https://youtu.be/1gHAKhFBcOU?t=01h04m11s)

tie into and watch to effectively make


[01:04:14,349 --> 01:04:19,630](https://youtu.be/1gHAKhFBcOU?t=01h04m14s)

additional changes so there we go so awk


[01:04:17,200 --> 01:04:22,089](https://youtu.be/1gHAKhFBcOU?t=01h04m17s)

was the primary and you can see in this


[01:04:19,630 --> 01:04:24,460](https://youtu.be/1gHAKhFBcOU?t=01h04m19s)

case even though with aquas the mid the


[01:04:22,089 --> 01:04:27,270](https://youtu.be/1gHAKhFBcOU?t=01h04m22s)

the light is pretty obvious but the dark


[01:04:24,460 --> 01:04:30,280](https://youtu.be/1gHAKhFBcOU?t=01h04m24s)

I don't know I might want that more dark


[01:04:27,270 --> 01:04:32,770](https://youtu.be/1gHAKhFBcOU?t=01h04m27s)

at least from on my screen those look


[01:04:30,280 --> 01:04:36,849](https://youtu.be/1gHAKhFBcOU?t=01h04m30s)

fairly similar maybe it's not as bad as


[01:04:32,770 --> 01:04:41,680](https://youtu.be/1gHAKhFBcOU?t=01h04m32s)

I think well let's take a look at that


[01:04:36,849 --> 01:04:44,859](https://youtu.be/1gHAKhFBcOU?t=01h04m36s)

real quick so inside of these guys did


[01:04:41,680 --> 01:04:50,589](https://youtu.be/1gHAKhFBcOU?t=01h04m41s)

you I don't remember if it's exposed on


[01:04:44,859 --> 01:04:54,910](https://youtu.be/1gHAKhFBcOU?t=01h04m44s)

the palette helper or not let's look so


[01:04:50,589 --> 01:04:57,430](https://youtu.be/1gHAKhFBcOU?t=01h04m50s)

is the theme manager here it's not so I


[01:04:54,910 --> 01:04:59,680](https://youtu.be/1gHAKhFBcOU?t=01h04m54s)

think it's at all only on the resource


[01:04:57,430 --> 01:05:04,540](https://youtu.be/1gHAKhFBcOU?t=01h04m57s)

dictionary


[01:04:59,680 --> 01:05:08,500](https://youtu.be/1gHAKhFBcOU?t=01h04m59s)

let's see your research dictionary get


[01:05:04,540 --> 01:05:10,390](https://youtu.be/1gHAKhFBcOU?t=01h05m04s)

theme manager so on the and this is one


[01:05:08,500 --> 01:05:12,640](https://youtu.be/1gHAKhFBcOU?t=01h05m08s)

of the kind of the hidden parts of the


[01:05:10,390 --> 01:05:15,730](https://youtu.be/1gHAKhFBcOU?t=01h05m10s)

API it's it's public so you have access


[01:05:12,640 --> 01:05:18,700](https://youtu.be/1gHAKhFBcOU?t=01h05m12s)

to it if you want it but it's I'm not


[01:05:15,730 --> 01:05:21,339](https://youtu.be/1gHAKhFBcOU?t=01h05m15s)

100% sure on it yet which is why it


[01:05:18,700 --> 01:05:25,560](https://youtu.be/1gHAKhFBcOU?t=01h05m18s)

hasn't migrated throughout so if you


[01:05:21,339 --> 01:05:29,680](https://youtu.be/1gHAKhFBcOU?t=01h05m21s)

were to look on let's see app current


[01:05:25,560 --> 01:05:38,829](https://youtu.be/1gHAKhFBcOU?t=01h05m25s)

let's see resource dictionary get theme


[01:05:29,680 --> 01:05:42,619](https://youtu.be/1gHAKhFBcOU?t=01h05m29s)

manager oh Barth theme manager so you


[01:05:38,829 --> 01:05:44,779](https://youtu.be/1gHAKhFBcOU?t=01h05m38s)

can call this guy did you do


[01:05:42,619 --> 01:05:47,769](https://youtu.be/1gHAKhFBcOU?t=01h05m42s)

clean that up replace my bar so it's a


[01:05:44,779 --> 01:05:53,089](https://youtu.be/1gHAKhFBcOU?t=01h05m44s)

little more obvious base class great


[01:05:47,769 --> 01:05:54,650](https://youtu.be/1gHAKhFBcOU?t=01h05m47s)

this theme manager class itself just


[01:05:53,089 --> 01:05:55,430](https://youtu.be/1gHAKhFBcOU?t=01h05m53s)

contains a single event for theme


[01:05:54,650 --> 01:05:57,529](https://youtu.be/1gHAKhFBcOU?t=01h05m54s)

changed


[01:05:55,430 --> 01:06:03,799](https://youtu.be/1gHAKhFBcOU?t=01h05m55s)

so we'll just register up on this guy


[01:05:57,529 --> 01:06:06,140](https://youtu.be/1gHAKhFBcOU?t=01h05m57s)

and great method so if you want to go


[01:06:03,799 --> 01:06:08,089](https://youtu.be/1gHAKhFBcOU?t=01h06m03s)

through and do something the event args


[01:06:06,140 --> 01:06:10,160](https://youtu.be/1gHAKhFBcOU?t=01h06m06s)

that come through on this guy have both


[01:06:08,089 --> 01:06:11,480](https://youtu.be/1gHAKhFBcOU?t=01h06m08s)

the old theme the new theme as well and


[01:06:10,160 --> 01:06:13,579](https://youtu.be/1gHAKhFBcOU?t=01h06m10s)

the resource dictionary that it's


[01:06:11,480 --> 01:06:16,819](https://youtu.be/1gHAKhFBcOU?t=01h06m11s)

getting applied to because all of this


[01:06:13,579 --> 01:06:22,329](https://youtu.be/1gHAKhFBcOU?t=01h06m13s)

theming stuff especially inside of WPF


[01:06:16,819 --> 01:06:25,400](https://youtu.be/1gHAKhFBcOU?t=01h06m16s)

themes are implicitly hierarchical


[01:06:22,329 --> 01:06:28,849](https://youtu.be/1gHAKhFBcOU?t=01h06m22s)

hierarchical I haven't had enough


[01:06:25,400 --> 01:06:31,670](https://youtu.be/1gHAKhFBcOU?t=01h06m25s)

caffeine I can't talk tonight in that if


[01:06:28,849 --> 01:06:34,130](https://youtu.be/1gHAKhFBcOU?t=01h06m28s)

you apply these theme resource


[01:06:31,670 --> 01:06:35,930](https://youtu.be/1gHAKhFBcOU?t=01h06m31s)

dictionaries at a lower level that will


[01:06:34,130 --> 01:06:39,009](https://youtu.be/1gHAKhFBcOU?t=01h06m34s)

override something that was set say in


[01:06:35,930 --> 01:06:41,509](https://youtu.be/1gHAKhFBcOU?t=01h06m35s)

your app dog zamel or window dot sam'l


[01:06:39,009 --> 01:06:44,630](https://youtu.be/1gHAKhFBcOU?t=01h06m39s)

which is why this thing also comes


[01:06:41,509 --> 01:06:48,019](https://youtu.be/1gHAKhFBcOU?t=01h06m41s)

through with the resource dictionary


[01:06:44,630 --> 01:06:50,239](https://youtu.be/1gHAKhFBcOU?t=01h06m44s)

where those were applied at the the


[01:06:48,019 --> 01:06:53,720](https://youtu.be/1gHAKhFBcOU?t=01h06m48s)

thing to note is this theme manager is


[01:06:50,239 --> 01:06:57,819](https://youtu.be/1gHAKhFBcOU?t=01h06m50s)

also per resource dictionaries so when


[01:06:53,720 --> 01:07:01,460](https://youtu.be/1gHAKhFBcOU?t=01h06m53s)

you do the the new set theme methods on


[01:06:57,819 --> 01:07:03,410](https://youtu.be/1gHAKhFBcOU?t=01h06m57s)

like the palette helper so when you call


[01:07:01,460 --> 01:07:05,029](https://youtu.be/1gHAKhFBcOU?t=01h07m01s)

palette helper set theme one of the


[01:07:03,410 --> 01:07:06,529](https://youtu.be/1gHAKhFBcOU?t=01h07m03s)

things that does at the very end of the


[01:07:05,029 --> 01:07:08,630](https://youtu.be/1gHAKhFBcOU?t=01h07m05s)

method and I should probably stop


[01:07:06,529 --> 01:07:10,839](https://youtu.be/1gHAKhFBcOU?t=01h07m06s)

looking at so you'll notice this is just


[01:07:08,630 --> 01:07:13,759](https://youtu.be/1gHAKhFBcOU?t=01h07m08s)

application current resources set theme


[01:07:10,839 --> 01:07:16,839](https://youtu.be/1gHAKhFBcOU?t=01h07m10s)

come on all the way in the last thing


[01:07:13,759 --> 01:07:19,369](https://youtu.be/1gHAKhFBcOU?t=01h07m13s)

that this method does dududududududududu


[01:07:16,839 --> 01:07:22,819](https://youtu.be/1gHAKhFBcOU?t=01h07m16s)

this is horrible to look at let's look


[01:07:19,369 --> 01:07:26,299](https://youtu.be/1gHAKhFBcOU?t=01h07m19s)

at the real code bring this over real


[01:07:22,819 --> 01:07:28,369](https://youtu.be/1gHAKhFBcOU?t=01h07m22s)

quick is it goes through and sets a it


[01:07:26,299 --> 01:07:30,470](https://youtu.be/1gHAKhFBcOU?t=01h07m26s)

sets up the theme manager so that it


[01:07:28,369 --> 01:07:32,539](https://youtu.be/1gHAKhFBcOU?t=01h07m28s)

exists but that theme manager only


[01:07:30,470 --> 01:07:34,730](https://youtu.be/1gHAKhFBcOU?t=01h07m30s)

exists at that resource dictionary so if


[01:07:32,539 --> 01:07:39,559](https://youtu.be/1gHAKhFBcOU?t=01h07m32s)

you wire up on this event on the theme


[01:07:34,730 --> 01:07:41,329](https://youtu.be/1gHAKhFBcOU?t=01h07m34s)

manager that is at the root so your app


[01:07:39,559 --> 01:07:44,539](https://youtu.be/1gHAKhFBcOU?t=01h07m39s)

dot sam'l so resource dictionary


[01:07:41,329 --> 01:07:46,789](https://youtu.be/1gHAKhFBcOU?t=01h07m41s)

extensions you will not get events if


[01:07:44,539 --> 01:07:49,700](https://youtu.be/1gHAKhFBcOU?t=01h07m44s)

somebody changed it only at a lower


[01:07:46,789 --> 01:07:52,309](https://youtu.be/1gHAKhFBcOU?t=01h07m46s)

level there's not a great way of


[01:07:49,700 --> 01:07:54,440](https://youtu.be/1gHAKhFBcOU?t=01h07m49s)

handling that at the moment so there's


[01:07:52,309 --> 01:07:56,520](https://youtu.be/1gHAKhFBcOU?t=01h07m52s)

there's an outstanding feature that I


[01:07:54,440 --> 01:07:58,590](https://youtu.be/1gHAKhFBcOU?t=01h07m54s)

know Roberts


[01:07:56,520 --> 01:08:02,190](https://youtu.be/1gHAKhFBcOU?t=01h07m56s)

knife was looking at implementing


[01:07:58,590 --> 01:08:05,100](https://youtu.be/1gHAKhFBcOU?t=01h07m58s)

potentially for routed events which then


[01:08:02,190 --> 01:08:08,220](https://youtu.be/1gHAKhFBcOU?t=01h08m02s)

would give you a means of hijacking it


[01:08:05,100 --> 01:08:09,810](https://youtu.be/1gHAKhFBcOU?t=01h08m05s)

so when you call set theme at the very


[01:08:08,220 --> 01:08:11,460](https://youtu.be/1gHAKhFBcOU?t=01h08m08s)

end it checks your resource dictionary


[01:08:09,810 --> 01:08:14,100](https://youtu.be/1gHAKhFBcOU?t=01h08m09s)

to see if there's a theme manager if


[01:08:11,460 --> 01:08:16,589](https://youtu.be/1gHAKhFBcOU?t=01h08m11s)

there's not it creates a new one for you


[01:08:14,100 --> 01:08:19,589](https://youtu.be/1gHAKhFBcOU?t=01h08m14s)

and sets it in and then calls on theme


[01:08:16,589 --> 01:08:22,950](https://youtu.be/1gHAKhFBcOU?t=01h08m16s)

change just notifying you that hey by


[01:08:19,589 --> 01:08:25,200](https://youtu.be/1gHAKhFBcOU?t=01h08m19s)

the way the theme has changed this theme


[01:08:22,950 --> 01:08:29,690](https://youtu.be/1gHAKhFBcOU?t=01h08m22s)

manager is how the mah app stuff is


[01:08:25,200 --> 01:08:34,830](https://youtu.be/1gHAKhFBcOU?t=01h08m25s)

ultimately working so if we look at our


[01:08:29,690 --> 01:08:36,750](https://youtu.be/1gHAKhFBcOU?t=01h08m29s)

custom color theme this guy here is just


[01:08:34,830 --> 01:08:39,600](https://youtu.be/1gHAKhFBcOU?t=01h08m34s)

wiring up on that theme changed event


[01:08:36,750 --> 01:08:42,000](https://youtu.be/1gHAKhFBcOU?t=01h08m36s)

and so when the theme changes it goes


[01:08:39,600 --> 01:08:44,069](https://youtu.be/1gHAKhFBcOU?t=01h08m39s)

through and applies all of the MA


[01:08:42,000 --> 01:08:46,440](https://youtu.be/1gHAKhFBcOU?t=01h08m42s)

apps brushes to that resource dictionary


[01:08:44,069 --> 01:08:48,839](https://youtu.be/1gHAKhFBcOU?t=01h08m44s)

and just builds it out and this set my


[01:08:46,440 --> 01:08:51,450](https://youtu.be/1gHAKhFBcOU?t=01h08m46s)

apps extension method is effectively


[01:08:48,839 --> 01:08:54,420](https://youtu.be/1gHAKhFBcOU?t=01h08m48s)

what that other one was before setting


[01:08:51,450 --> 01:08:58,650](https://youtu.be/1gHAKhFBcOU?t=01h08m51s)

up all of those brushes to make sure


[01:08:54,420 --> 01:08:59,850](https://youtu.be/1gHAKhFBcOU?t=01h08m54s)

that those line up correctly so if in


[01:08:58,650 --> 01:09:01,440](https://youtu.be/1gHAKhFBcOU?t=01h08m58s)

the event that there is something that


[01:08:59,850 --> 01:09:03,210](https://youtu.be/1gHAKhFBcOU?t=01h08m59s)

you want to do and you want to get


[01:09:01,440 --> 01:09:06,089](https://youtu.be/1gHAKhFBcOU?t=01h09m01s)

access to those theme changed events


[01:09:03,210 --> 01:09:08,160](https://youtu.be/1gHAKhFBcOU?t=01h09m03s)

again most of the time what you're


[01:09:06,089 --> 01:09:12,029](https://youtu.be/1gHAKhFBcOU?t=01h09m06s)

probably looking to do is grab it off of


[01:09:08,160 --> 01:09:13,529](https://youtu.be/1gHAKhFBcOU?t=01h09m08s)

your application level resources since I


[01:09:12,029 --> 01:09:14,940](https://youtu.be/1gHAKhFBcOU?t=01h09m12s)

think most of the time this is where


[01:09:13,529 --> 01:09:17,580](https://youtu.be/1gHAKhFBcOU?t=01h09m13s)

people are probably changing their theme


[01:09:14,940 --> 01:09:18,779](https://youtu.be/1gHAKhFBcOU?t=01h09m14s)

again your app made you something


[01:09:17,580 --> 01:09:21,380](https://youtu.be/1gHAKhFBcOU?t=01h09m17s)

different I've heard of people who have


[01:09:18,779 --> 01:09:24,240](https://youtu.be/1gHAKhFBcOU?t=01h09m18s)

different themes per window or whatnot


[01:09:21,380 --> 01:09:25,950](https://youtu.be/1gHAKhFBcOU?t=01h09m21s)

but you can grab the theme manager for


[01:09:24,240 --> 01:09:31,020](https://youtu.be/1gHAKhFBcOU?t=01h09m24s)

that appropriate level to be able to


[01:09:25,950 --> 01:09:33,930](https://youtu.be/1gHAKhFBcOU?t=01h09m25s)

pull it through and I think that that


[01:09:31,020 --> 01:09:36,359](https://youtu.be/1gHAKhFBcOU?t=01h09m31s)

probably covers all of the the theming


[01:09:33,930 --> 01:09:38,069](https://youtu.be/1gHAKhFBcOU?t=01h09m33s)

API that I was gonna look at tonight


[01:09:36,359 --> 01:09:39,440](https://youtu.be/1gHAKhFBcOU?t=01h09m36s)

does anyone have any questions on this


[01:09:38,069 --> 01:09:42,930](https://youtu.be/1gHAKhFBcOU?t=01h09m38s)

or is there anything else


[01:09:39,440 --> 01:09:50,400](https://youtu.be/1gHAKhFBcOU?t=01h09m39s)

Femi related that people are hoping to


[01:09:42,930 --> 01:09:51,900](https://youtu.be/1gHAKhFBcOU?t=01h09m42s)

see or wanting to see this actually


[01:09:50,400 --> 01:09:54,390](https://youtu.be/1gHAKhFBcOU?t=01h09m50s)

ended up going a lot quicker than I


[01:09:51,900 --> 01:09:57,090](https://youtu.be/1gHAKhFBcOU?t=01h09m51s)

expected normally I type a lot slower


[01:09:54,390 --> 01:09:59,600](https://youtu.be/1gHAKhFBcOU?t=01h09m54s)

than this at least when people are


[01:09:57,090 --> 01:09:59,600](https://youtu.be/1gHAKhFBcOU?t=01h09m57s)

looking at me


[01:10:00,720 --> 01:10:06,720](https://youtu.be/1gHAKhFBcOU?t=01h10m00s)

no questions Wow I'm either good at


[01:10:04,230 --> 01:10:10,620](https://youtu.be/1gHAKhFBcOU?t=01h10m04s)

explaining this or it's as clear as mud


[01:10:06,720 --> 01:10:15,590](https://youtu.be/1gHAKhFBcOU?t=01h10m06s)

so I'm gonna go with hopefully this all


[01:10:10,620 --> 01:10:17,790](https://youtu.be/1gHAKhFBcOU?t=01h10m10s)

makes sense in here so with that said


[01:10:15,590 --> 01:10:23,400](https://youtu.be/1gHAKhFBcOU?t=01h10m15s)

probably go through and start looking at


[01:10:17,790 --> 01:10:25,320](https://youtu.be/1gHAKhFBcOU?t=01h10m17s)

a few other things so I think one of the


[01:10:23,400 --> 01:10:28,380](https://youtu.be/1gHAKhFBcOU?t=01h10m23s)

things I wanted to take a quick peek at


[01:10:25,320 --> 01:10:29,730](https://youtu.be/1gHAKhFBcOU?t=01h10m25s)

was this this MA apps brush thing to see


[01:10:28,380 --> 01:10:33,420](https://youtu.be/1gHAKhFBcOU?t=01h10m28s)

if there was something else that needed


[01:10:29,730 --> 01:10:36,330](https://youtu.be/1gHAKhFBcOU?t=01h10m29s)

to be fixed on this so people want to


[01:10:33,420 --> 01:10:40,050](https://youtu.be/1gHAKhFBcOU?t=01h10m33s)

hang around I may just see about sniping


[01:10:36,330 --> 01:10:42,330](https://youtu.be/1gHAKhFBcOU?t=01h10m36s)

this bug real quick there was up here


[01:10:40,050 --> 01:10:46,070](https://youtu.be/1gHAKhFBcOU?t=01h10m40s)

and I think there may have this may have


[01:10:42,330 --> 01:10:49,560](https://youtu.be/1gHAKhFBcOU?t=01h10m42s)

been somewhat the crux of the problem


[01:10:46,070 --> 01:10:55,760](https://youtu.be/1gHAKhFBcOU?t=01h10m46s)

these brushes here I don't know if these


[01:10:49,560 --> 01:11:00,030](https://youtu.be/1gHAKhFBcOU?t=01h10m49s)

got migrated into the MA apps helper


[01:10:55,760 --> 01:11:02,820](https://youtu.be/1gHAKhFBcOU?t=01h10m55s)

this might be the I suspect the crux of


[01:11:00,030 --> 01:11:07,050](https://youtu.be/1gHAKhFBcOU?t=01h11m00s)

the problem so let's let's just jump


[01:11:02,820 --> 01:11:08,970](https://youtu.be/1gHAKhFBcOU?t=01h11m02s)

into the library and start looking at


[01:11:07,050 --> 01:11:10,980](https://youtu.be/1gHAKhFBcOU?t=01h11m07s)

these because that that would be one one


[01:11:08,970 --> 01:11:17,190](https://youtu.be/1gHAKhFBcOU?t=01h11m08s)

nice thing to go through and fix as well


[01:11:10,980 --> 01:11:21,300](https://youtu.be/1gHAKhFBcOU?t=01h11m10s)

real quick and I think we so the the


[01:11:17,190 --> 01:11:24,900](https://youtu.be/1gHAKhFBcOU?t=01h11m17s)

mixing of these cans still work when the


[01:11:21,300 --> 01:11:29,760](https://youtu.be/1gHAKhFBcOU?t=01h11m21s)

theme gets applied in did you jump back


[01:11:24,900 --> 01:11:33,810](https://youtu.be/1gHAKhFBcOU?t=01h11m24s)

over here so when we apply a and call


[01:11:29,760 --> 01:11:36,810](https://youtu.be/1gHAKhFBcOU?t=01h11m29s)

this set call a solid color brush let's


[01:11:33,810 --> 01:11:41,640](https://youtu.be/1gHAKhFBcOU?t=01h11m33s)

just jump down to set solid color brush


[01:11:36,810 --> 01:11:44,070](https://youtu.be/1gHAKhFBcOU?t=01h11m36s)

it does two things so in addition to


[01:11:41,640 --> 01:11:48,270](https://youtu.be/1gHAKhFBcOU?t=01h11m41s)

setting the brush with the name it'll


[01:11:44,070 --> 01:11:50,640](https://youtu.be/1gHAKhFBcOU?t=01h11m44s)

also add brush with color suffix on the


[01:11:48,270 --> 01:11:56,760](https://youtu.be/1gHAKhFBcOU?t=01h11m48s)

end and embed the color name as well as


[01:11:50,640 --> 01:11:58,680](https://youtu.be/1gHAKhFBcOU?t=01h11m50s)

as a resource so if you want to go


[01:11:56,760 --> 01:12:01,760](https://youtu.be/1gHAKhFBcOU?t=01h11m56s)

through and reference just the colors by


[01:11:58,680 --> 01:12:05,340](https://youtu.be/1gHAKhFBcOU?t=01h11m58s)

themselves say your wreath II mean a


[01:12:01,760 --> 01:12:07,020](https://youtu.be/1gHAKhFBcOU?t=01h12m01s)

another third-party library and you need


[01:12:05,340 --> 01:12:09,540](https://youtu.be/1gHAKhFBcOU?t=01h12m05s)

access to the colors and not necessarily


[01:12:07,020 --> 01:12:11,820](https://youtu.be/1gHAKhFBcOU?t=01h12m07s)

the direct brushes you can get access to


[01:12:09,540 --> 01:12:13,380](https://youtu.be/1gHAKhFBcOU?t=01h12m09s)

them this way as well again this does


[01:12:11,820 --> 01:12:14,400](https://youtu.be/1gHAKhFBcOU?t=01h12m11s)

assume that you're calling the new API


[01:12:13,380 --> 01:12:15,630](https://youtu.be/1gHAKhFBcOU?t=01h12m13s)

and you're not using


[01:12:14,400 --> 01:12:19,500](https://youtu.be/1gHAKhFBcOU?t=01h12m14s)

the old straight-up resource


[01:12:15,630 --> 01:12:21,570](https://youtu.be/1gHAKhFBcOU?t=01h12m15s)

dictionaries let's clobber that real


[01:12:19,500 --> 01:12:26,250](https://youtu.be/1gHAKhFBcOU?t=01h12m19s)

quick and where'd you go


[01:12:21,570 --> 01:12:29,060](https://youtu.be/1gHAKhFBcOU?t=01h12m21s)

Jill studio you are somewhere off in


[01:12:26,250 --> 01:12:31,860](https://youtu.be/1gHAKhFBcOU?t=01h12m26s)

la-la land


[01:12:29,060 --> 01:12:32,699](https://youtu.be/1gHAKhFBcOU?t=01h12m29s)

well monitor you opening on oh it's


[01:12:31,860 --> 01:12:36,750](https://youtu.be/1gHAKhFBcOU?t=01h12m31s)

right in front of me


[01:12:32,699 --> 01:12:38,820](https://youtu.be/1gHAKhFBcOU?t=01h12m32s)

perfect so MA apps dragonballs demo so


[01:12:36,750 --> 01:12:41,250](https://youtu.be/1gHAKhFBcOU?t=01h12m36s)

this is the other app tight I don't know


[01:12:38,820 --> 01:12:46,770](https://youtu.be/1gHAKhFBcOU?t=01h12m38s)

if you've seen this one also has a


[01:12:41,250 --> 01:12:50,520](https://youtu.be/1gHAKhFBcOU?t=01h12m41s)

similar color picker set up on it and it


[01:12:46,770 --> 01:12:53,850](https://youtu.be/1gHAKhFBcOU?t=01h12m46s)

looks like this is probably the problem


[01:12:50,520 --> 01:12:57,710](https://youtu.be/1gHAKhFBcOU?t=01h12m50s)

is this guy only had a subset of the


[01:12:53,850 --> 01:13:00,150](https://youtu.be/1gHAKhFBcOU?t=01h12m53s)

brushes whereas mine had all of them I


[01:12:57,710 --> 01:13:03,810](https://youtu.be/1gHAKhFBcOU?t=01h12m57s)

don't know why I did not notice this


[01:13:00,150 --> 01:13:09,870](https://youtu.be/1gHAKhFBcOU?t=01h13m00s)

before so that is probably the issue so


[01:13:03,810 --> 01:13:14,340](https://youtu.be/1gHAKhFBcOU?t=01h13m03s)

well let's jump over to this guy here


[01:13:09,870 --> 01:13:16,290](https://youtu.be/1gHAKhFBcOU?t=01h13m09s)

and let's just close out everything way


[01:13:14,340 --> 01:13:21,570](https://youtu.be/1gHAKhFBcOU?t=01h13m14s)

too many tabs open way too many tabs


[01:13:16,290 --> 01:13:23,219](https://youtu.be/1gHAKhFBcOU?t=01h13m16s)

open and I think all we need to do is


[01:13:21,570 --> 01:13:26,969](https://youtu.be/1gHAKhFBcOU?t=01h13m21s)

get all of these brushes set up


[01:13:23,219 --> 01:13:31,710](https://youtu.be/1gHAKhFBcOU?t=01h13m23s)

appropriately and then get a new set of


[01:13:26,969 --> 01:13:36,710](https://youtu.be/1gHAKhFBcOU?t=01h13m26s)

nougat packages built and then the world


[01:13:31,710 --> 01:13:40,230](https://youtu.be/1gHAKhFBcOU?t=01h13m31s)

should be a happy place come on come on


[01:13:36,710 --> 01:13:43,190](https://youtu.be/1gHAKhFBcOU?t=01h13m36s)

resharper has to probably go and grep


[01:13:40,230 --> 01:13:43,190](https://youtu.be/1gHAKhFBcOU?t=01h13m40s)

everything i


[01:13:47,280 --> 01:13:51,560](https://youtu.be/1gHAKhFBcOU?t=01h13m47s)

forgot to turn off my notifications go


[01:13:51,800 --> 01:13:58,760](https://youtu.be/1gHAKhFBcOU?t=01h13m51s)

away stop helping me focus assist thank


[01:13:56,489 --> 01:13:58,760](https://youtu.be/1gHAKhFBcOU?t=01h13m56s)

you


[01:13:59,660 --> 01:14:05,610](https://youtu.be/1gHAKhFBcOU?t=01h13m59s)

okay so we'll pick this up and I think


[01:14:02,460 --> 01:14:08,310](https://youtu.be/1gHAKhFBcOU?t=01h14m02s)

then the question is just which of these


[01:14:05,610 --> 01:14:11,489](https://youtu.be/1gHAKhFBcOU?t=01h14m05s)

got omitted so let's just copy this set


[01:14:08,310 --> 01:14:13,380](https://youtu.be/1gHAKhFBcOU?t=01h14m08s)

of brushes and then we'll bring these


[01:14:11,489 --> 01:14:15,480](https://youtu.be/1gHAKhFBcOU?t=01h14m11s)

over and make sure we cover these cases


[01:14:13,380 --> 01:14:18,060](https://youtu.be/1gHAKhFBcOU?t=01h14m13s)

because I would hate I would hate to


[01:14:15,480 --> 01:14:21,630](https://youtu.be/1gHAKhFBcOU?t=01h14m15s)

break mops partly because one of the


[01:14:18,060 --> 01:14:24,000](https://youtu.be/1gHAKhFBcOU?t=01h14m18s)

apps that I work on at work leverages it


[01:14:21,630 --> 01:14:32,699](https://youtu.be/1gHAKhFBcOU?t=01h14m21s)

and so I have a vested interest in


[01:14:24,000 --> 01:14:34,290](https://youtu.be/1gHAKhFBcOU?t=01h14m24s)

making sure I don't just hose it okay so


[01:14:32,699 --> 01:14:38,640](https://youtu.be/1gHAKhFBcOU?t=01h14m32s)

we'll just bring these guys in


[01:14:34,290 --> 01:14:39,210](https://youtu.be/1gHAKhFBcOU?t=01h14m34s)

great perfect so highlight brush cover


[01:14:38,640 --> 01:14:45,620](https://youtu.be/1gHAKhFBcOU?t=01h14m38s)

it already


[01:14:39,210 --> 01:14:45,620](https://youtu.be/1gHAKhFBcOU?t=01h14m39s)

great done accent base color brush


[01:14:46,760 --> 01:14:58,530](https://youtu.be/1gHAKhFBcOU?t=01h14m46s)

accent base color brush not there so


[01:14:51,920 --> 01:15:00,570](https://youtu.be/1gHAKhFBcOU?t=01h14m51s)

accent clear brush so accent base color


[01:14:58,530 --> 01:15:03,840](https://youtu.be/1gHAKhFBcOU?t=01h14m58s)

brush and it should be the same as


[01:15:00,570 --> 01:15:07,469](https://youtu.be/1gHAKhFBcOU?t=01h15m00s)

accent color brush great great


[01:15:03,840 --> 01:15:13,910](https://youtu.be/1gHAKhFBcOU?t=01h15m03s)

those are both done color brushes two


[01:15:07,469 --> 01:15:22,290](https://youtu.be/1gHAKhFBcOU?t=01h15m07s)

three and four done but color brush two


[01:15:13,910 --> 01:15:25,650](https://youtu.be/1gHAKhFBcOU?t=01h15m13s)

has primary a 500 and opacity set we are


[01:15:22,290 --> 01:15:30,660](https://youtu.be/1gHAKhFBcOU?t=01h15m22s)

dropping so let's see three should be


[01:15:25,650 --> 01:15:34,770](https://youtu.be/1gHAKhFBcOU?t=01h15m25s)

fine as light great two and four I want


[01:15:30,660 --> 01:15:39,110](https://youtu.be/1gHAKhFBcOU?t=01h15m30s)

to come back to window title brush dark


[01:15:34,770 --> 01:15:45,050](https://youtu.be/1gHAKhFBcOU?t=01h15m34s)

at seven hundred great done progress


[01:15:39,110 --> 01:15:55,140](https://youtu.be/1gHAKhFBcOU?t=01h15m39s)

linear gradient from dark to mid great


[01:15:45,050 --> 01:15:59,150](https://youtu.be/1gHAKhFBcOU?t=01h15m45s)

done checkmark fill primary five hundred


[01:15:55,140 --> 01:15:59,150](https://youtu.be/1gHAKhFBcOU?t=01h15m55s)

and that should be primary mid


[01:16:01,010 --> 01:16:12,870](https://youtu.be/1gHAKhFBcOU?t=01h16m01s)

okay right arrow fill mid right cuz


[01:16:08,520 --> 01:16:17,090](https://youtu.be/1gHAKhFBcOU?t=01h16m08s)

primary 500 accent color brush to mid


[01:16:12,870 --> 01:16:20,610](https://youtu.be/1gHAKhFBcOU?t=01h16m12s)

yeah cuz 700 dark 500s mid 200s light


[01:16:17,090 --> 01:16:24,890](https://youtu.be/1gHAKhFBcOU?t=01h16m17s)

those should have both been mid I'm


[01:16:20,610 --> 01:16:29,630](https://youtu.be/1gHAKhFBcOU?t=01h16m20s)

finding several bugs in here awesome


[01:16:24,890 --> 01:16:29,630](https://youtu.be/1gHAKhFBcOU?t=01h16m24s)

okay ideal foreground color brush


[01:16:29,960 --> 01:16:35,460](https://youtu.be/1gHAKhFBcOU?t=01h16m29s)

primary mid and then it grabs the


[01:16:34,500 --> 01:16:37,410](https://youtu.be/1gHAKhFBcOU?t=01h16m34s)

foreground color


[01:16:35,460 --> 01:16:41,790](https://youtu.be/1gHAKhFBcOU?t=01h16m35s)

so this get foreground color all this


[01:16:37,410 --> 01:16:44,130](https://youtu.be/1gHAKhFBcOU?t=01h16m37s)

does on a color pair will either return


[01:16:41,790 --> 01:16:46,170](https://youtu.be/1gHAKhFBcOU?t=01h16m41s)

the the foreground color that was set or


[01:16:44,130 --> 01:16:49,170](https://youtu.be/1gHAKhFBcOU?t=01h16m44s)

do the the lookup to determine if it


[01:16:46,170 --> 01:16:52,380](https://youtu.be/1gHAKhFBcOU?t=01h16m46s)

should be white or black so it's just a


[01:16:49,170 --> 01:16:56,850](https://youtu.be/1gHAKhFBcOU?t=01h16m49s)

convenience method on there so ideal


[01:16:52,380 --> 01:17:02,489](https://youtu.be/1gHAKhFBcOU?t=01h16m52s)

foreground color should be mid ideal


[01:16:56,850 --> 01:17:05,370](https://youtu.be/1gHAKhFBcOU?t=01h16m56s)

disabled brush that has no pasty oh set


[01:17:02,489 --> 01:17:12,230](https://youtu.be/1gHAKhFBcOU?t=01h17m02s)

brush has an opacity why don't why


[01:17:05,370 --> 01:17:19,590](https://youtu.be/1gHAKhFBcOU?t=01h17m05s)

aren't we using this accent brush to 0.8


[01:17:12,230 --> 01:17:22,680](https://youtu.be/1gHAKhFBcOU?t=01h17m12s)

and I'm guessing editing yeah I think


[01:17:19,590 --> 01:17:25,380](https://youtu.be/1gHAKhFBcOU?t=01h17m19s)

you are right I that is exactly where


[01:17:22,680 --> 01:17:26,640](https://youtu.be/1gHAKhFBcOU?t=01h17m22s)

I'm where I was landing I'm not sure why


[01:17:25,380 --> 01:17:31,469](https://youtu.be/1gHAKhFBcOU?t=01h17m25s)

this one was point eight and the other


[01:17:26,640 --> 01:17:35,070](https://youtu.be/1gHAKhFBcOU?t=01h17m26s)

one was point two I'm seriously doubting


[01:17:31,469 --> 01:17:38,430](https://youtu.be/1gHAKhFBcOU?t=01h17m31s)

that 2/100 on the opacity is probably


[01:17:35,070 --> 01:17:40,500](https://youtu.be/1gHAKhFBcOU?t=01h17m35s)

even visible there's a certain point


[01:17:38,430 --> 01:17:43,800](https://youtu.be/1gHAKhFBcOU?t=01h17m38s)

where your I just can't usually detect


[01:17:40,500 --> 01:17:49,890](https://youtu.be/1gHAKhFBcOU?t=01h17m40s)

it maybe it's my old eyes that are are


[01:17:43,800 --> 01:17:56,489](https://youtu.be/1gHAKhFBcOU?t=01h17m43s)

not good at this and my glasses so let's


[01:17:49,890 --> 01:17:58,170](https://youtu.be/1gHAKhFBcOU?t=01h17m49s)

see and this is primary mid and okay so


[01:17:56,489 --> 01:18:00,810](https://youtu.be/1gHAKhFBcOU?t=01h17m56s)

I'm gonna apologize to anybody who is


[01:17:58,170 --> 01:18:02,580](https://youtu.be/1gHAKhFBcOU?t=01h17m58s)

using these this new API on my ops


[01:18:00,810 --> 01:18:06,480](https://youtu.be/1gHAKhFBcOU?t=01h18m00s)

because clearly I had several of these


[01:18:02,580 --> 01:18:07,860](https://youtu.be/1gHAKhFBcOU?t=01h18m02s)

brushes that were wrong okay so this is


[01:18:06,480 --> 01:18:12,000](https://youtu.be/1gHAKhFBcOU?t=01h18m06s)

where we start getting into the area


[01:18:07,860 --> 01:18:13,409](https://youtu.be/1gHAKhFBcOU?t=01h18m07s)

that wasn't covered before is all of


[01:18:12,000 --> 01:18:16,530](https://youtu.be/1gHAKhFBcOU?t=01h18m12s)

these because the data


[01:18:13,409 --> 01:18:20,219](https://youtu.be/1gHAKhFBcOU?t=01h18m13s)

brushes weren't added and the MA


[01:18:16,530 --> 01:18:25,590](https://youtu.be/1gHAKhFBcOU?t=01h18m16s)

apps toggle switch brushes were not


[01:18:20,219 --> 01:18:29,280](https://youtu.be/1gHAKhFBcOU?t=01h18m20s)

added okay and I might I might even go


[01:18:25,590 --> 01:18:31,650](https://youtu.be/1gHAKhFBcOU?t=01h18m25s)

pull up the MA apps code real quick and


[01:18:29,280 --> 01:18:35,309](https://youtu.be/1gHAKhFBcOU?t=01h18m29s)

just check it because I'm wondering if


[01:18:31,650 --> 01:18:37,699](https://youtu.be/1gHAKhFBcOU?t=01h18m31s)

there are new brushes in there sort of


[01:18:35,309 --> 01:18:41,309](https://youtu.be/1gHAKhFBcOU?t=01h18m35s)

the the nice cheater approaches I can


[01:18:37,699 --> 01:18:44,130](https://youtu.be/1gHAKhFBcOU?t=01h18m37s)

update to match their update cadence now


[01:18:41,309 --> 01:18:48,059](https://youtu.be/1gHAKhFBcOU?t=01h18m41s)

and so in theory I should be able to get


[01:18:44,130 --> 01:18:55,669](https://youtu.be/1gHAKhFBcOU?t=01h18m44s)

all of this going so let's see highlight


[01:18:48,059 --> 01:19:04,280](https://youtu.be/1gHAKhFBcOU?t=01h18m48s)

brush should be primary mid I believe


[01:18:55,669 --> 01:19:07,889](https://youtu.be/1gHAKhFBcOU?t=01h18m55s)

let's see mid color cool that does that


[01:19:04,280 --> 01:19:10,590](https://youtu.be/1gHAKhFBcOU?t=01h19m04s)

let's see here let's do because I think


[01:19:07,889 --> 01:19:16,530](https://youtu.be/1gHAKhFBcOU?t=01h19m07s)

I want these grouped that just makes


[01:19:10,590 --> 01:19:21,289](https://youtu.be/1gHAKhFBcOU?t=01h19m10s)

sense highlight text color let's see


[01:19:16,530 --> 01:19:24,599](https://youtu.be/1gHAKhFBcOU?t=01h19m16s)

primary mid get foreground color


[01:19:21,289 --> 01:19:27,059](https://youtu.be/1gHAKhFBcOU?t=01h19m21s)

there was no pasty on that guy shouldn't


[01:19:24,599 --> 01:19:31,139](https://youtu.be/1gHAKhFBcOU?t=01h19m24s)

be any on this guy that's a copy and


[01:19:27,059 --> 01:19:34,739](https://youtu.be/1gHAKhFBcOU?t=01h19m27s)

paste air or editor inheritance as I


[01:19:31,139 --> 01:19:38,909](https://youtu.be/1gHAKhFBcOU?t=01h19m31s)

commonly like to call it let's see here


[01:19:34,739 --> 01:19:52,439](https://youtu.be/1gHAKhFBcOU?t=01h19m34s)

so mouse over highlight brush and that's


[01:19:38,909 --> 01:19:58,219](https://youtu.be/1gHAKhFBcOU?t=01h19m38s)

a primary light color focus we can walk


[01:19:52,439 --> 01:20:03,209](https://youtu.be/1gHAKhFBcOU?t=01h19m52s)

this guy know this is a primary mid and


[01:19:58,219 --> 01:20:05,550](https://youtu.be/1gHAKhFBcOU?t=01h19m58s)

that goes away and this is also making


[01:20:03,209 --> 01:20:10,709](https://youtu.be/1gHAKhFBcOU?t=01h20m03s)

me wonder if I need to be adding data


[01:20:05,550 --> 01:20:12,419](https://youtu.be/1gHAKhFBcOU?t=01h20m05s)

grids to these demo apps because I know


[01:20:10,709 --> 01:20:14,039](https://youtu.be/1gHAKhFBcOU?t=01h20m10s)

I've got toggle switches in there which


[01:20:12,419 --> 01:20:22,559](https://youtu.be/1gHAKhFBcOU?t=01h20m12s)

is what I was using for that toggle


[01:20:14,039 --> 01:20:24,570](https://youtu.be/1gHAKhFBcOU?t=01h20m14s)

light dark but the fact that the fact


[01:20:22,559 --> 01:20:27,000](https://youtu.be/1gHAKhFBcOU?t=01h20m22s)

that we missed all these brushes makes


[01:20:24,570 --> 01:20:31,800](https://youtu.be/1gHAKhFBcOU?t=01h20m24s)

me think that we need data grid to


[01:20:27,000 --> 01:20:33,690](https://youtu.be/1gHAKhFBcOU?t=01h20m27s)

ensure that I catch those so if somebody


[01:20:31,800 --> 01:20:36,060](https://youtu.be/1gHAKhFBcOU?t=01h20m31s)

wants to add that to this my apps


[01:20:33,690 --> 01:20:38,310](https://youtu.be/1gHAKhFBcOU?t=01h20m33s)

draggable demo that would be great I


[01:20:36,060 --> 01:20:39,320](https://youtu.be/1gHAKhFBcOU?t=01h20m36s)

don't think there's anything in there


[01:20:38,310 --> 01:20:44,820](https://youtu.be/1gHAKhFBcOU?t=01h20m38s)

that does it


[01:20:39,320 --> 01:20:47,730](https://youtu.be/1gHAKhFBcOU?t=01h20m39s)

let's see primary mid get foreground


[01:20:44,820 --> 01:20:50,970](https://youtu.be/1gHAKhFBcOU?t=01h20m44s)

color and that'll clear up the two data


[01:20:47,730 --> 01:20:55,920](https://youtu.be/1gHAKhFBcOU?t=01h20m47s)

grids and then we will do the toggle


[01:20:50,970 --> 01:21:03,150](https://youtu.be/1gHAKhFBcOU?t=01h20m50s)

brushes there this this should be better


[01:20:55,920 --> 01:21:04,800](https://youtu.be/1gHAKhFBcOU?t=01h20m55s)

I might just replace this dll on my demo


[01:21:03,150 --> 01:21:12,060](https://youtu.be/1gHAKhFBcOU?t=01h21m03s)

app and make sure that this guy switches


[01:21:04,800 --> 01:21:13,470](https://youtu.be/1gHAKhFBcOU?t=01h21m04s)

over appropriately primary mid color and


[01:21:12,060 --> 01:21:15,420](https://youtu.be/1gHAKhFBcOU?t=01h21m12s)

there there is a reason that this


[01:21:13,470 --> 01:21:17,400](https://youtu.be/1gHAKhFBcOU?t=01h21m13s)

foreground color is a method and not


[01:21:15,420 --> 01:21:19,020](https://youtu.be/1gHAKhFBcOU?t=01h21m15s)

just a property aside from the fact that


[01:21:17,400 --> 01:21:22,260](https://youtu.be/1gHAKhFBcOU?t=01h21m17s)

foreground color exists as a property


[01:21:19,020 --> 01:21:26,610](https://youtu.be/1gHAKhFBcOU?t=01h21m19s)

here this contrasting foreground color


[01:21:22,260 --> 01:21:30,750](https://youtu.be/1gHAKhFBcOU?t=01h21m22s)

can be mildly expensive I mean it's just


[01:21:26,610 --> 01:21:32,250](https://youtu.be/1gHAKhFBcOU?t=01h21m26s)

some math but it is like even on the


[01:21:30,750 --> 01:21:35,430](https://youtu.be/1gHAKhFBcOU?t=01h21m30s)

color picker tie-dye I think you've


[01:21:32,250 --> 01:21:41,090](https://youtu.be/1gHAKhFBcOU?t=01h21m32s)

noticed this the the delay and having to


[01:21:35,430 --> 01:21:43,260](https://youtu.be/1gHAKhFBcOU?t=01h21m35s)

calculate the HSV colour transformations


[01:21:41,090 --> 01:21:47,150](https://youtu.be/1gHAKhFBcOU?t=01h21m41s)

isn't something you necessarily wanted


[01:21:43,260 --> 01:21:49,830](https://youtu.be/1gHAKhFBcOU?t=01h21m43s)

to be doing say several times a second


[01:21:47,150 --> 01:21:53,340](https://youtu.be/1gHAKhFBcOU?t=01h21m47s)

like in the order of a few dozen it gets


[01:21:49,830 --> 01:21:55,800](https://youtu.be/1gHAKhFBcOU?t=01h21m49s)

it gets a little laggy so that is one of


[01:21:53,340 --> 01:21:57,990](https://youtu.be/1gHAKhFBcOU?t=01h21m53s)

the things that I'm hoping to take a


[01:21:55,800 --> 01:22:01,260](https://youtu.be/1gHAKhFBcOU?t=01h21m55s)

look at in 302 is to try and get that to


[01:21:57,990 --> 01:22:04,620](https://youtu.be/1gHAKhFBcOU?t=01h21m57s)

the point where the performance doesn't


[01:22:01,260 --> 01:22:05,900](https://youtu.be/1gHAKhFBcOU?t=01h22m01s)

add doesn't slow it down and we don't


[01:22:04,620 --> 01:22:09,180](https://youtu.be/1gHAKhFBcOU?t=01h22m04s)

need to have a delay on the binding


[01:22:05,900 --> 01:22:10,500](https://youtu.be/1gHAKhFBcOU?t=01h22m05s)

which would be nice there's a couple


[01:22:09,180 --> 01:22:13,380](https://youtu.be/1gHAKhFBcOU?t=01h22m09s)

kind of performance things that I'm


[01:22:10,500 --> 01:22:17,700](https://youtu.be/1gHAKhFBcOU?t=01h22m10s)

hoping to squeeze into three oh the big


[01:22:13,380 --> 01:22:20,340](https://youtu.be/1gHAKhFBcOU?t=01h22m13s)

thing is probably going to be dotnet v


[01:22:17,700 --> 01:22:23,190](https://youtu.be/1gHAKhFBcOU?t=01h22m17s)

or dotnet core 300 depending on which


[01:22:20,340 --> 01:22:27,810](https://youtu.be/1gHAKhFBcOU?t=01h22m20s)

version name you've heard support for


[01:22:23,190 --> 01:22:30,030](https://youtu.be/1gHAKhFBcOU?t=01h22m23s)

that C primary five foreground get


[01:22:27,810 --> 01:22:31,740](https://youtu.be/1gHAKhFBcOU?t=01h22m27s)

foreground color okay that should say


[01:22:30,030 --> 01:22:33,360](https://youtu.be/1gHAKhFBcOU?t=01h22m30s)

all the brothers that's probably going


[01:22:31,740 --> 01:22:37,400](https://youtu.be/1gHAKhFBcOU?t=01h22m31s)

to be the big feature and I'm planning


[01:22:33,360 --> 01:22:40,890](https://youtu.be/1gHAKhFBcOU?t=01h22m33s)

on revving the the core package version


[01:22:37,400 --> 01:22:44,310](https://youtu.be/1gHAKhFBcOU?t=01h22m37s)

to 3.0 at the same time


[01:22:40,890 --> 01:22:46,260](https://youtu.be/1gHAKhFBcOU?t=01h22m40s)

and then also cleaning up a bunch of


[01:22:44,310 --> 01:22:49,710](https://youtu.be/1gHAKhFBcOU?t=01h22m44s)

obsolete and making several breaking


[01:22:46,260 --> 01:22:51,180](https://youtu.be/1gHAKhFBcOU?t=01h22m46s)

changes for those who are interested and


[01:22:49,710 --> 01:22:53,400](https://youtu.be/1gHAKhFBcOU?t=01h22m49s)

I will point this issue out because I


[01:22:51,180 --> 01:22:56,070](https://youtu.be/1gHAKhFBcOU?t=01h22m51s)

would like I would like feedback from


[01:22:53,400 --> 01:22:59,250](https://youtu.be/1gHAKhFBcOU?t=01h22m53s)

people I haven't posted or made a big


[01:22:56,070 --> 01:23:01,860](https://youtu.be/1gHAKhFBcOU?t=01h22m56s)

fuss about it yet because it's still a


[01:22:59,250 --> 01:23:04,500](https://youtu.be/1gHAKhFBcOU?t=01h22m59s)

ways out but if there are breaking level


[01:23:01,860 --> 01:23:08,610](https://youtu.be/1gHAKhFBcOU?t=01h23m01s)

changes or other issues people want to


[01:23:04,500 --> 01:23:10,770](https://youtu.be/1gHAKhFBcOU?t=01h23m04s)

link to for stuff to change please


[01:23:08,610 --> 01:23:12,690](https://youtu.be/1gHAKhFBcOU?t=01h23m08s)

comment on here and these breaking three


[01:23:10,770 --> 01:23:15,240](https://youtu.be/1gHAKhFBcOU?t=01h23m10s)

OH changes so there are several things


[01:23:12,690 --> 01:23:17,880](https://youtu.be/1gHAKhFBcOU?t=01h23m12s)

that have been kind of common pain


[01:23:15,240 --> 01:23:19,980](https://youtu.be/1gHAKhFBcOU?t=01h23m15s)

points like the card defaulting its


[01:23:17,880 --> 01:23:21,840](https://youtu.be/1gHAKhFBcOU?t=01h23m17s)

vertical alignment to top that's bitten


[01:23:19,980 --> 01:23:23,610](https://youtu.be/1gHAKhFBcOU?t=01h23m19s)

a lot of people when they when it


[01:23:21,840 --> 01:23:23,760](https://youtu.be/1gHAKhFBcOU?t=01h23m21s)

doesn't resize like you would expect it


[01:23:23,610 --> 01:23:26,970](https://youtu.be/1gHAKhFBcOU?t=01h23m23s)

to


[01:23:23,760 --> 01:23:28,950](https://youtu.be/1gHAKhFBcOU?t=01h23m23s)

because in WPF the default vertical


[01:23:26,970 --> 01:23:32,340](https://youtu.be/1gHAKhFBcOU?t=01h23m26s)

alignment is stretch this one changes


[01:23:28,950 --> 01:23:33,900](https://youtu.be/1gHAKhFBcOU?t=01h23m28s)

that default it's confusing so but


[01:23:32,340 --> 01:23:36,480](https://youtu.be/1gHAKhFBcOU?t=01h23m32s)

unfortunately to change that default is


[01:23:33,900 --> 01:23:40,290](https://youtu.be/1gHAKhFBcOU?t=01h23m33s)

a breaking change so a lot of those


[01:23:36,480 --> 01:23:42,900](https://youtu.be/1gHAKhFBcOU?t=01h23m36s)

breaking changes I'm looking to document


[01:23:40,290 --> 01:23:44,960](https://youtu.be/1gHAKhFBcOU?t=01h23m40s)

here and get lined up this was another


[01:23:42,900 --> 01:23:47,640](https://youtu.be/1gHAKhFBcOU?t=01h23m42s)

one that somebody pointed out that was


[01:23:44,960 --> 01:23:50,280](https://youtu.be/1gHAKhFBcOU?t=01h23m44s)

absolutely perfect how our vertical


[01:23:47,640 --> 01:23:53,220](https://youtu.be/1gHAKhFBcOU?t=01h23m47s)

alignments aren't even close to lining


[01:23:50,280 --> 01:23:54,720](https://youtu.be/1gHAKhFBcOU?t=01h23m50s)

up and these all should be I wanted to


[01:23:53,220 --> 01:23:57,810](https://youtu.be/1gHAKhFBcOU?t=01h23m53s)

go through and look at this a little


[01:23:54,720 --> 01:24:02,010](https://youtu.be/1gHAKhFBcOU?t=01h23m54s)

closer I think they should all default


[01:23:57,810 --> 01:24:04,380](https://youtu.be/1gHAKhFBcOU?t=01h23m57s)

to center or the because that's somewhat


[01:24:02,010 --> 01:24:05,520](https://youtu.be/1gHAKhFBcOU?t=01h24m02s)

the the problem here is I wasn't sure


[01:24:04,380 --> 01:24:07,980](https://youtu.be/1gHAKhFBcOU?t=01h24m04s)

whether it was just the vertical


[01:24:05,520 --> 01:24:09,930](https://youtu.be/1gHAKhFBcOU?t=01h24m05s)

alignment or if it was the vertical


[01:24:07,980 --> 01:24:11,820](https://youtu.be/1gHAKhFBcOU?t=01h24m07s)

content alignment inside of those that


[01:24:09,930 --> 01:24:14,880](https://youtu.be/1gHAKhFBcOU?t=01h24m09s)

was getting each of these off


[01:24:11,820 --> 01:24:16,770](https://youtu.be/1gHAKhFBcOU?t=01h24m11s)

regardless it's clearly a problem I


[01:24:14,880 --> 01:24:19,590](https://youtu.be/1gHAKhFBcOU?t=01h24m14s)

think the only question is what is the


[01:24:16,770 --> 01:24:20,400](https://youtu.be/1gHAKhFBcOU?t=01h24m16s)

correct fix and so I was gonna take a


[01:24:19,590 --> 01:24:22,560](https://youtu.be/1gHAKhFBcOU?t=01h24m19s)

quick peek at that


[01:24:20,400 --> 01:24:24,420](https://youtu.be/1gHAKhFBcOU?t=01h24m20s)

I think the vertical alignment all of


[01:24:22,560 --> 01:24:26,370](https://youtu.be/1gHAKhFBcOU?t=01h24m22s)

these should be stretch and I think the


[01:24:24,420 --> 01:24:28,350](https://youtu.be/1gHAKhFBcOU?t=01h24m24s)

vertical content alignment should


[01:24:26,370 --> 01:24:30,720](https://youtu.be/1gHAKhFBcOU?t=01h24m26s)

probably be centered but I wanted to


[01:24:28,350 --> 01:24:32,190](https://youtu.be/1gHAKhFBcOU?t=01h24m28s)

look specifically the text box that may


[01:24:30,720 --> 01:24:35,430](https://youtu.be/1gHAKhFBcOU?t=01h24m30s)

not work for due to our underlying


[01:24:32,190 --> 01:24:38,310](https://youtu.be/1gHAKhFBcOU?t=01h24m32s)

control and these things may need to all


[01:24:35,430 --> 01:24:40,170](https://youtu.be/1gHAKhFBcOU?t=01h24m35s)

just default their their vertical


[01:24:38,310 --> 01:24:42,360](https://youtu.be/1gHAKhFBcOU?t=01h24m38s)

content alignment to bottom which I


[01:24:40,170 --> 01:24:45,270](https://youtu.be/1gHAKhFBcOU?t=01h24m40s)

think as long as they all line up that's


[01:24:42,360 --> 01:24:47,000](https://youtu.be/1gHAKhFBcOU?t=01h24m42s)

the big thing because I've run into this


[01:24:45,270 --> 01:24:49,200](https://youtu.be/1gHAKhFBcOU?t=01h24m45s)

before when you're building a form and


[01:24:47,000 --> 01:24:50,670](https://youtu.be/1gHAKhFBcOU?t=01h24m47s)

stuff just doesn't line up and you end


[01:24:49,200 --> 01:24:52,890](https://youtu.be/1gHAKhFBcOU?t=01h24m49s)

up starting to tweak those properties


[01:24:50,670 --> 01:24:54,420](https://youtu.be/1gHAKhFBcOU?t=01h24m50s)

and I think by default they should line


[01:24:52,890 --> 01:24:57,000](https://youtu.be/1gHAKhFBcOU?t=01h24m52s)

up unless


[01:24:54,420 --> 01:24:58,920](https://youtu.be/1gHAKhFBcOU?t=01h24m54s)

changed something so I was gonna gonna


[01:24:57,000 --> 01:25:02,190](https://youtu.be/1gHAKhFBcOU?t=01h24m57s)

look at that if anyone else wants to


[01:24:58,920 --> 01:25:04,199](https://youtu.be/1gHAKhFBcOU?t=01h24m58s)

look at it and throw a comment submitted


[01:25:02,190 --> 01:25:07,440](https://youtu.be/1gHAKhFBcOU?t=01h25m02s)

an issue to add the datagrid drag was


[01:25:04,199 --> 01:25:10,140](https://youtu.be/1gHAKhFBcOU?t=01h25m04s)

demo awesome thank you tide that is that


[01:25:07,440 --> 01:25:14,820](https://youtu.be/1gHAKhFBcOU?t=01h25m07s)

is perfect in fact I'm gonna go in if


[01:25:10,140 --> 01:25:17,640](https://youtu.be/1gHAKhFBcOU?t=01h25m10s)

that's something we just added I'm going


[01:25:14,820 --> 01:25:21,960](https://youtu.be/1gHAKhFBcOU?t=01h25m14s)

to label this up real quick so good


[01:25:17,640 --> 01:25:23,580](https://youtu.be/1gHAKhFBcOU?t=01h25m17s)

first issue relates to mah apps up for


[01:25:21,960 --> 01:25:26,520](https://youtu.be/1gHAKhFBcOU?t=01h25m21s)

grabs


[01:25:23,580 --> 01:25:29,370](https://youtu.be/1gHAKhFBcOU?t=01h25m23s)

and for anybody watching anything that I


[01:25:26,520 --> 01:25:32,190](https://youtu.be/1gHAKhFBcOU?t=01h25m26s)

label as good first issue this is pretty


[01:25:29,370 --> 01:25:35,699](https://youtu.be/1gHAKhFBcOU?t=01h25m29s)

much me signing up to help you if you


[01:25:32,190 --> 01:25:38,070](https://youtu.be/1gHAKhFBcOU?t=01h25m32s)

have any problems I do try to when I'm


[01:25:35,699 --> 01:25:40,290](https://youtu.be/1gHAKhFBcOU?t=01h25m35s)

when I'm going through and you know


[01:25:38,070 --> 01:25:43,170](https://youtu.be/1gHAKhFBcOU?t=01h25m38s)

triaging issues and looking at questions


[01:25:40,290 --> 01:25:45,840](https://youtu.be/1gHAKhFBcOU?t=01h25m40s)

I try to prioritize anybody who has a


[01:25:43,170 --> 01:25:47,760](https://youtu.be/1gHAKhFBcOU?t=01h25m43s)

question on a good first issue first so


[01:25:45,840 --> 01:25:49,620](https://youtu.be/1gHAKhFBcOU?t=01h25m45s)

if you're working on one of these I do


[01:25:47,760 --> 01:25:51,870](https://youtu.be/1gHAKhFBcOU?t=01h25m47s)

try to give that a little bit more


[01:25:49,620 --> 01:25:53,340](https://youtu.be/1gHAKhFBcOU?t=01h25m49s)

attention so if you want to work on one


[01:25:51,870 --> 01:25:55,260](https://youtu.be/1gHAKhFBcOU?t=01h25m51s)

of these the only thing you have to do


[01:25:53,340 --> 01:25:58,110](https://youtu.be/1gHAKhFBcOU?t=01h25m53s)

is throw a comment saying hey I'm gonna


[01:25:55,260 --> 01:25:59,400](https://youtu.be/1gHAKhFBcOU?t=01h25m55s)

work on it and then go to town so if I


[01:25:58,110 --> 01:26:01,320](https://youtu.be/1gHAKhFBcOU?t=01h25m58s)

don't hear from you in like a week I'll


[01:25:59,400 --> 01:26:02,910](https://youtu.be/1gHAKhFBcOU?t=01h25m59s)

probably comment and say hey you're


[01:26:01,320 --> 01:26:04,949](https://youtu.be/1gHAKhFBcOU?t=01h26m01s)

still working on it you need help just


[01:26:02,910 --> 01:26:07,469](https://youtu.be/1gHAKhFBcOU?t=01h26m02s)

can somebody else pick it up but other


[01:26:04,949 --> 01:26:11,370](https://youtu.be/1gHAKhFBcOU?t=01h26m04s)

than that you're good to go


[01:26:07,469 --> 01:26:14,040](https://youtu.be/1gHAKhFBcOU?t=01h26m07s)

okay so this guy is here I want to


[01:26:11,370 --> 01:26:17,390](https://youtu.be/1gHAKhFBcOU?t=01h26m11s)

rebuild this dll real quick and then I'm


[01:26:14,040 --> 01:26:20,850](https://youtu.be/1gHAKhFBcOU?t=01h26m14s)

gonna just throw this into my other app


[01:26:17,390 --> 01:26:23,280](https://youtu.be/1gHAKhFBcOU?t=01h26m17s)

and make sure that this changes that


[01:26:20,850 --> 01:26:26,190](https://youtu.be/1gHAKhFBcOU?t=01h26m20s)

toggle switch at the top because before


[01:26:23,280 --> 01:26:28,650](https://youtu.be/1gHAKhFBcOU?t=01h26m23s)

we were just getting that that blue and


[01:26:26,190 --> 01:26:31,080](https://youtu.be/1gHAKhFBcOU?t=01h26m26s)

I think this will address that I'm


[01:26:28,650 --> 01:26:34,170](https://youtu.be/1gHAKhFBcOU?t=01h26m28s)

thinking I probably forgot to comment


[01:26:31,080 --> 01:26:35,940](https://youtu.be/1gHAKhFBcOU?t=01h26m31s)

out these brushes when I was working on


[01:26:34,170 --> 01:26:39,560](https://youtu.be/1gHAKhFBcOU?t=01h26m34s)

this the other night which is probably


[01:26:35,940 --> 01:26:42,300](https://youtu.be/1gHAKhFBcOU?t=01h26m35s)

why it looked to me like it was working


[01:26:39,560 --> 01:26:47,370](https://youtu.be/1gHAKhFBcOU?t=01h26m39s)

because these resources would have


[01:26:42,300 --> 01:26:51,890](https://youtu.be/1gHAKhFBcOU?t=01h26m42s)

gotten set which unfortunately gave me


[01:26:47,370 --> 01:26:51,890](https://youtu.be/1gHAKhFBcOU?t=01h26m47s)

false confidence just not good not good


[01:26:53,449 --> 01:26:59,429](https://youtu.be/1gHAKhFBcOU?t=01h26m53s)

okay


[01:26:55,760 --> 01:27:03,050](https://youtu.be/1gHAKhFBcOU?t=01h26m55s)

it's only ten-thirty a little more


[01:26:59,429 --> 01:27:03,050](https://youtu.be/1gHAKhFBcOU?t=01h26m59s)

caffeine a little more Kennington Oh


[01:27:07,550 --> 01:27:11,810](https://youtu.be/1gHAKhFBcOU?t=01h27m07s)

Mountain Dew the sweet nectar of life


[01:27:12,110 --> 01:27:19,409](https://youtu.be/1gHAKhFBcOU?t=01h27m12s)

okay did you finish great rebuild


[01:27:15,540 --> 01:27:23,159](https://youtu.be/1gHAKhFBcOU?t=01h27m15s)

successful and let's go into here and I


[01:27:19,409 --> 01:27:27,270](https://youtu.be/1gHAKhFBcOU?t=01h27m19s)

think I just whacked the nougat package


[01:27:23,159 --> 01:27:34,320](https://youtu.be/1gHAKhFBcOU?t=01h27m23s)

and do a straight-up project reference


[01:27:27,270 --> 01:27:41,360](https://youtu.be/1gHAKhFBcOU?t=01h27m27s)

instead so yeah you go away yep thank


[01:27:34,320 --> 01:27:46,500](https://youtu.be/1gHAKhFBcOU?t=01h27m34s)

you and remove that NuGet package for me


[01:27:41,360 --> 01:27:53,130](https://youtu.be/1gHAKhFBcOU?t=01h27m41s)

and that'll get closed and let's go


[01:27:46,500 --> 01:27:54,630](https://youtu.be/1gHAKhFBcOU?t=01h27m46s)

through and references just add


[01:27:53,130 --> 01:28:01,770](https://youtu.be/1gHAKhFBcOU?t=01h27m53s)

reference and we're just going to go


[01:27:54,630 --> 01:28:09,170](https://youtu.be/1gHAKhFBcOU?t=01h27m54s)

straight to the DLL brows huh material


[01:28:01,770 --> 01:28:09,170](https://youtu.be/1gHAKhFBcOU?t=01h28m01s)

design toolkit and mops Ben debug and


[01:28:10,280 --> 01:28:15,829](https://youtu.be/1gHAKhFBcOU?t=01h28m10s)

okay great


[01:28:17,769 --> 01:28:25,090](https://youtu.be/1gHAKhFBcOU?t=01h28m17s)

and hopefully just do a rebuild to make


[01:28:22,420 --> 01:28:26,559](https://youtu.be/1gHAKhFBcOU?t=01h28m22s)

sure that it wipes out that old


[01:28:25,090 --> 01:28:33,030](https://youtu.be/1gHAKhFBcOU?t=01h28m25s)

reference and puts the new one in its


[01:28:26,559 --> 01:28:36,400](https://youtu.be/1gHAKhFBcOU?t=01h28m26s)

place because I don't always trust the


[01:28:33,030 --> 01:28:38,110](https://youtu.be/1gHAKhFBcOU?t=01h28m33s)

the versioning on it Visual Studio does


[01:28:36,400 --> 01:28:42,699](https://youtu.be/1gHAKhFBcOU?t=01h28m36s)

a pretty good job of knowing when things


[01:28:38,110 --> 01:28:46,239](https://youtu.be/1gHAKhFBcOU?t=01h28m38s)

need to be updated but there are times


[01:28:42,699 --> 01:28:49,510](https://youtu.be/1gHAKhFBcOU?t=01h28m42s)

it misses so sometimes that clean and


[01:28:46,239 --> 01:28:52,030](https://youtu.be/1gHAKhFBcOU?t=01h28m46s)

rebuild is at minimum just for my own


[01:28:49,510 --> 01:28:55,659](https://youtu.be/1gHAKhFBcOU?t=01h28m49s)

good peace of mind hey that looks


[01:28:52,030 --> 01:28:57,940](https://youtu.be/1gHAKhFBcOU?t=01h28m52s)

promising that's what I'm talking about


[01:28:55,659 --> 01:28:59,340](https://youtu.be/1gHAKhFBcOU?t=01h28m55s)

that toggle switch now changes so that's


[01:28:57,940 --> 01:29:04,510](https://youtu.be/1gHAKhFBcOU?t=01h28m57s)

what we were missing


[01:28:59,340 --> 01:29:06,730](https://youtu.be/1gHAKhFBcOU?t=01h28m59s)

that is what we were missing that little


[01:29:04,510 --> 01:29:10,210](https://youtu.be/1gHAKhFBcOU?t=01h29m04s)

toggle switch one okay while we're on


[01:29:06,730 --> 01:29:16,960](https://youtu.be/1gHAKhFBcOU?t=01h29m06s)

the topic of my apps brushes let's go


[01:29:10,210 --> 01:29:19,239](https://youtu.be/1gHAKhFBcOU?t=01h29m10s)

jump real quick over at my apps and


[01:29:16,960 --> 01:29:20,980](https://youtu.be/1gHAKhFBcOU?t=01h29m16s)

let's go look because I'm curious I


[01:29:19,239 --> 01:29:22,960](https://youtu.be/1gHAKhFBcOU?t=01h29m19s)

realize I'm gonna be looking at their


[01:29:20,980 --> 01:29:26,139](https://youtu.be/1gHAKhFBcOU?t=01h29m20s)

their latest - OH


[01:29:22,960 --> 01:29:33,039](https://youtu.be/1gHAKhFBcOU?t=01h29m22s)

stuff but I am I am curious as to what


[01:29:26,139 --> 01:29:44,050](https://youtu.be/1gHAKhFBcOU?t=01h29m26s)

brushes are being defined over here okay


[01:29:33,039 --> 01:29:49,480](https://youtu.be/1gHAKhFBcOU?t=01h29m33s)

so mops metro and as you can tell I


[01:29:44,050 --> 01:29:52,510](https://youtu.be/1gHAKhFBcOU?t=01h29m44s)

don't necessarily play in this one too


[01:29:49,480 --> 01:29:57,010](https://youtu.be/1gHAKhFBcOU?t=01h29m49s)

much so I'm sort of gonna fumble my way


[01:29:52,510 --> 01:29:59,409](https://youtu.be/1gHAKhFBcOU?t=01h29m52s)

around for a moment oh you know what we


[01:29:57,010 --> 01:30:02,170](https://youtu.be/1gHAKhFBcOU?t=01h29m57s)

can do you know what we can do we can


[01:29:59,409 --> 01:30:02,920](https://youtu.be/1gHAKhFBcOU?t=01h29m59s)

just as ultimately this is what I'm


[01:30:02,170 --> 01:30:07,320](https://youtu.be/1gHAKhFBcOU?t=01h30m02s)

looking for


[01:30:02,920 --> 01:30:07,320](https://youtu.be/1gHAKhFBcOU?t=01h30m02s)

let's just find this guy in the source I


[01:30:08,489 --> 01:30:13,059](https://youtu.be/1gHAKhFBcOU?t=01h30m08s)

think I dropped the M yeah let's just


[01:30:11,380 --> 01:30:19,869](https://youtu.be/1gHAKhFBcOU?t=01h30m11s)

find this guy and see where he lives


[01:30:13,059 --> 01:30:26,289](https://youtu.be/1gHAKhFBcOU?t=01h30m13s)

cuz I can't imagine yeah so Styles theme


[01:30:19,869 --> 01:30:27,900](https://youtu.be/1gHAKhFBcOU?t=01h30m19s)

theme template perfect this is what


[01:30:26,289 --> 01:30:33,240](https://youtu.be/1gHAKhFBcOU?t=01h30m26s)

we're looking for


[01:30:27,900 --> 01:30:36,090](https://youtu.be/1gHAKhFBcOU?t=01h30m27s)

ah so he's got something fancy I'm gonna


[01:30:33,240 --> 01:30:38,820](https://youtu.be/1gHAKhFBcOU?t=01h30m33s)

have to look at how he's doing this


[01:30:36,090 --> 01:30:40,890](https://youtu.be/1gHAKhFBcOU?t=01h30m36s)

so he's embedding string resources for


[01:30:38,820 --> 01:30:43,560](https://youtu.be/1gHAKhFBcOU?t=01h30m38s)

the name and the display name that is


[01:30:40,890 --> 01:30:45,750](https://youtu.be/1gHAKhFBcOU?t=01h30m40s)

one thing that I did not add in this to


[01:30:43,560 --> 01:30:47,730](https://youtu.be/1gHAKhFBcOU?t=01h30m43s)

six-oh release and I'm curious if people


[01:30:45,750 --> 01:30:49,890](https://youtu.be/1gHAKhFBcOU?t=01h30m45s)

have an opinion if it matters if


[01:30:47,730 --> 01:30:54,150](https://youtu.be/1gHAKhFBcOU?t=01h30m47s)

embedding the name of the theme inside


[01:30:49,890 --> 01:30:55,860](https://youtu.be/1gHAKhFBcOU?t=01h30m49s)

of it is useful the though so I can see


[01:30:54,150 --> 01:30:57,270](https://youtu.be/1gHAKhFBcOU?t=01h30m54s)

how how it would be helpful to be able


[01:30:55,860 --> 01:30:59,910](https://youtu.be/1gHAKhFBcOU?t=01h30m55s)

to query that out of the resource


[01:30:57,270 --> 01:31:03,450](https://youtu.be/1gHAKhFBcOU?t=01h30m57s)

dictionary the only thing that always


[01:30:59,910 --> 01:31:05,970](https://youtu.be/1gHAKhFBcOU?t=01h30m59s)

got me is you're always in control of


[01:31:03,450 --> 01:31:13,890](https://youtu.be/1gHAKhFBcOU?t=01h31m03s)

what theme is being set so you could


[01:31:05,970 --> 01:31:15,060](https://youtu.be/1gHAKhFBcOU?t=01h31m05s)

always track it and add it so if people


[01:31:13,890 --> 01:31:16,860](https://youtu.be/1gHAKhFBcOU?t=01h31m13s)

are interested the other thing is


[01:31:15,060 --> 01:31:20,460](https://youtu.be/1gHAKhFBcOU?t=01h31m15s)

because it just accepts an IEEE theme


[01:31:16,860 --> 01:31:22,620](https://youtu.be/1gHAKhFBcOU?t=01h31m16s)

interface you could always derive from


[01:31:20,460 --> 01:31:24,450](https://youtu.be/1gHAKhFBcOU?t=01h31m20s)

that and add your own name property and


[01:31:22,620 --> 01:31:28,560](https://youtu.be/1gHAKhFBcOU?t=01h31m22s)

then register up on that theme manager


[01:31:24,450 --> 01:31:31,740](https://youtu.be/1gHAKhFBcOU?t=01h31m24s)

event and again handle it I don't know


[01:31:28,560 --> 01:31:33,510](https://youtu.be/1gHAKhFBcOU?t=01h31m28s)

I'm I'm torn some people like this and


[01:31:31,740 --> 01:31:36,750](https://youtu.be/1gHAKhFBcOU?t=01h31m31s)

I'm guessing he probably has a nice


[01:31:33,510 --> 01:31:40,550](https://youtu.be/1gHAKhFBcOU?t=01h31m33s)

honesty manager a nice way of querying


[01:31:36,750 --> 01:31:44,700](https://youtu.be/1gHAKhFBcOU?t=01h31m36s)

all this stuff out so it does look nice


[01:31:40,550 --> 01:31:48,030](https://youtu.be/1gHAKhFBcOU?t=01h31m40s)

okay so these are all his colors I'm


[01:31:44,700 --> 01:31:49,830](https://youtu.be/1gHAKhFBcOU?t=01h31m44s)

more interested in the brushes universal


[01:31:48,030 --> 01:31:53,550](https://youtu.be/1gHAKhFBcOU?t=01h31m48s)

control brushes ooh


[01:31:49,830 --> 01:31:56,730](https://youtu.be/1gHAKhFBcOU?t=01h31m49s)

so these have changed a bit there are a


[01:31:53,550 --> 01:32:01,230](https://youtu.be/1gHAKhFBcOU?t=01h31m53s)

lot of brushes in here control


[01:31:56,730 --> 01:32:05,180](https://youtu.be/1gHAKhFBcOU?t=01h31m56s)

validation brushes WPF default brushes


[01:32:01,230 --> 01:32:05,180](https://youtu.be/1gHAKhFBcOU?t=01h32m01s)

so these ones I'm less concerned with


[01:32:08,630 --> 01:32:14,460](https://youtu.be/1gHAKhFBcOU?t=01h32m08s)

looks like I could prob well shoot some


[01:32:11,760 --> 01:32:16,170](https://youtu.be/1gHAKhFBcOU?t=01h32m11s)

of these whoo


[01:32:14,460 --> 01:32:21,060](https://youtu.be/1gHAKhFBcOU?t=01h32m14s)

so I might need to go through and check


[01:32:16,170 --> 01:32:27,150](https://youtu.be/1gHAKhFBcOU?t=01h32m16s)

these and see so at minimum these guys


[01:32:21,060 --> 01:32:28,710](https://youtu.be/1gHAKhFBcOU?t=01h32m21s)

have been significantly expanded let's


[01:32:27,150 --> 01:32:32,970](https://youtu.be/1gHAKhFBcOU?t=01h32m27s)

let's take a look at the history on this


[01:32:28,710 --> 01:32:34,770](https://youtu.be/1gHAKhFBcOU?t=01h32m28s)

file real quick I'm curious how I'm


[01:32:32,970 --> 01:32:38,540](https://youtu.be/1gHAKhFBcOU?t=01h32m32s)

wondering how much of this is coming


[01:32:34,770 --> 01:32:38,540](https://youtu.be/1gHAKhFBcOU?t=01h32m34s)

from his new - OH stuff


[01:32:40,949 --> 01:32:46,059](https://youtu.be/1gHAKhFBcOU?t=01h32m40s)

for step four generated themes Oh


[01:32:43,889 --> 01:32:51,070](https://youtu.be/1gHAKhFBcOU?t=01h32m43s)

Sebastian Schmitt was the one who


[01:32:46,059 --> 01:32:52,599](https://youtu.be/1gHAKhFBcOU?t=01h32m46s)

started this work cool cool cool cool it


[01:32:51,070 --> 01:32:56,139](https://youtu.be/1gHAKhFBcOU?t=01h32m51s)

looks like he probably started it


[01:32:52,599 --> 01:33:00,519](https://youtu.be/1gHAKhFBcOU?t=01h32m52s)

similar time as we did we ended up at a


[01:32:56,139 --> 01:33:03,579](https://youtu.be/1gHAKhFBcOU?t=01h32m56s)

slightly different solution got it so he


[01:33:00,519 --> 01:33:06,189](https://youtu.be/1gHAKhFBcOU?t=01h33m00s)

basically templated out all of these


[01:33:03,579 --> 01:33:08,019](https://youtu.be/1gHAKhFBcOU?t=01h33m03s)

things and I'm guessing they've got


[01:33:06,189 --> 01:33:10,179](https://youtu.be/1gHAKhFBcOU?t=01h33m06s)

something that goes through and just


[01:33:08,019 --> 01:33:16,090](https://youtu.be/1gHAKhFBcOU?t=01h33m08s)

does a magical string replace on all of


[01:33:10,179 --> 01:33:19,360](https://youtu.be/1gHAKhFBcOU?t=01h33m10s)

these guys so if that's the case I


[01:33:16,090 --> 01:33:22,329](https://youtu.be/1gHAKhFBcOU?t=01h33m16s)

wonder if we could cheat and leverage


[01:33:19,360 --> 01:33:26,039](https://youtu.be/1gHAKhFBcOU?t=01h33m19s)

this because it looks like there's only


[01:33:22,329 --> 01:33:28,449](https://youtu.be/1gHAKhFBcOU?t=01h33m22s)

a fixed number of variables on this guy


[01:33:26,039 --> 01:33:30,309](https://youtu.be/1gHAKhFBcOU?t=01h33m26s)

and I'm wondering if we just set the


[01:33:28,449 --> 01:33:35,409](https://youtu.be/1gHAKhFBcOU?t=01h33m28s)

appropriate variables then I don't have


[01:33:30,309 --> 01:33:39,809](https://youtu.be/1gHAKhFBcOU?t=01h33m30s)

to worry about the exact brushes that


[01:33:35,409 --> 01:33:42,849](https://youtu.be/1gHAKhFBcOU?t=01h33m35s)

might be cleaner the only part they and


[01:33:39,809 --> 01:33:48,599](https://youtu.be/1gHAKhFBcOU?t=01h33m39s)

so we wouldn't necessarily be overriding


[01:33:42,849 --> 01:33:48,599](https://youtu.be/1gHAKhFBcOU?t=01h33m42s)

these brushes but maybe that's okay


[01:33:49,260 --> 01:33:52,829](https://youtu.be/1gHAKhFBcOU?t=01h33m49s)

might be okay


[01:33:55,430 --> 01:34:00,380](https://youtu.be/1gHAKhFBcOU?t=01h33m55s)

because they're steaming clearly doesn't


[01:33:58,550 --> 01:34:06,500](https://youtu.be/1gHAKhFBcOU?t=01h33m58s)

override these directly unless they've


[01:34:00,380 --> 01:34:07,790](https://youtu.be/1gHAKhFBcOU?t=01h34m00s)

got something extra in okay I can get on


[01:34:06,500 --> 01:34:08,770](https://youtu.be/1gHAKhFBcOU?t=01h34m06s)

boy with that let's look at what else is


[01:34:07,790 --> 01:34:13,700](https://youtu.be/1gHAKhFBcOU?t=01h34m07s)

in here


[01:34:08,770 --> 01:34:17,540](https://youtu.be/1gHAKhFBcOU?t=01h34m08s)

generator parameters so I'm curious when


[01:34:13,700 --> 01:34:19,910](https://youtu.be/1gHAKhFBcOU?t=01h34m13s)

this thing runs so this is the dark


[01:34:17,540 --> 01:34:22,460](https://youtu.be/1gHAKhFBcOU?t=01h34m17s)

theme because this is the other thing


[01:34:19,910 --> 01:34:24,890](https://youtu.be/1gHAKhFBcOU?t=01h34m19s)

that's a little a little weird is we


[01:34:22,460 --> 01:34:28,880](https://youtu.be/1gHAKhFBcOU?t=01h34m22s)

don't necessarily need to override all


[01:34:24,890 --> 01:34:31,580](https://youtu.be/1gHAKhFBcOU?t=01h34m24s)

their themes some of them it's important


[01:34:28,880 --> 01:34:36,440](https://youtu.be/1gHAKhFBcOU?t=01h34m28s)

to do so other ones it really doesn't


[01:34:31,580 --> 01:34:39,170](https://youtu.be/1gHAKhFBcOU?t=01h34m31s)

matter so this is dark light and then


[01:34:36,440 --> 01:34:41,390](https://youtu.be/1gHAKhFBcOU?t=01h34m36s)

these are the color schemes of changing


[01:34:39,170 --> 01:34:47,780](https://youtu.be/1gHAKhFBcOU?t=01h34m39s)

them so it must something must just


[01:34:41,390 --> 01:34:55,430](https://youtu.be/1gHAKhFBcOU?t=01h34m41s)

ingest this guy and do a set of all of


[01:34:47,780 --> 01:34:58,550](https://youtu.be/1gHAKhFBcOU?t=01h34m47s)

these things cuz for the most part we


[01:34:55,430 --> 01:35:03,050](https://youtu.be/1gHAKhFBcOU?t=01h34m55s)

don't care too much about all the


[01:34:58,550 --> 01:35:04,580](https://youtu.be/1gHAKhFBcOU?t=01h34m58s)

brushes now I'm no I'm not I'm really


[01:35:03,050 --> 01:35:07,460](https://youtu.be/1gHAKhFBcOU?t=01h35m03s)

curious as to how this thing's working


[01:35:04,580 --> 01:35:13,370](https://youtu.be/1gHAKhFBcOU?t=01h35m04s)

okay so let's back up there's the steam


[01:35:07,460 --> 01:35:15,700](https://youtu.be/1gHAKhFBcOU?t=01h35m07s)

generator what how do you work kind of


[01:35:13,370 --> 01:35:18,650](https://youtu.be/1gHAKhFBcOU?t=01h35m13s)

curious to go and look at this commit


[01:35:15,700 --> 01:35:21,980](https://youtu.be/1gHAKhFBcOU?t=01h35m15s)

the initial one first step and generated


[01:35:18,650 --> 01:35:25,250](https://youtu.be/1gHAKhFBcOU?t=01h35m18s)

themes so what else did you add in here


[01:35:21,980 --> 01:35:31,100](https://youtu.be/1gHAKhFBcOU?t=01h35m21s)

so let's see build props sure great


[01:35:25,250 --> 01:35:36,800](https://youtu.be/1gHAKhFBcOU?t=01h35m25s)

great zamel color scheme generator so


[01:35:31,100 --> 01:35:39,770](https://youtu.be/1gHAKhFBcOU?t=01h35m31s)

this is a nougat package huh yeah the


[01:35:36,800 --> 01:35:44,450](https://youtu.be/1gHAKhFBcOU?t=01h35m36s)

the my app stuff does Rev pretty quick


[01:35:39,770 --> 01:35:48,370](https://youtu.be/1gHAKhFBcOU?t=01h35m39s)

so one and Bastian do quite a bit on it


[01:35:44,450 --> 01:35:52,450](https://youtu.be/1gHAKhFBcOU?t=01h35m44s)

they also Bastian smitten works on the


[01:35:48,370 --> 01:35:56,210](https://youtu.be/1gHAKhFBcOU?t=01h35m48s)

control ZX library which if you've


[01:35:52,450 --> 01:35:58,490](https://youtu.be/1gHAKhFBcOU?t=01h35m52s)

looked around in our packet files you'll


[01:35:56,210 --> 01:36:04,330](https://youtu.be/1gHAKhFBcOU?t=01h35m56s)

notice we actually reference it as well


[01:35:58,490 --> 01:36:08,360](https://youtu.be/1gHAKhFBcOU?t=01h35m58s)

ah this library okay so this is this is


[01:36:04,330 --> 01:36:10,940](https://youtu.be/1gHAKhFBcOU?t=01h36m04s)

bastions zamel color scheme generator


[01:36:08,360 --> 01:36:13,880](https://youtu.be/1gHAKhFBcOU?t=01h36m08s)

haha well we place in certain parts of a


[01:36:10,940 --> 01:36:18,980](https://youtu.be/1gHAKhFBcOU?t=01h36m10s)

temple I see the generator input and


[01:36:13,880 --> 01:36:23,389](https://youtu.be/1gHAKhFBcOU?t=01h36m13s)

template files so this is how this guy


[01:36:18,980 --> 01:36:28,159](https://youtu.be/1gHAKhFBcOU?t=01h36m18s)

is working ah interesting interesting


[01:36:23,389 --> 01:36:30,830](https://youtu.be/1gHAKhFBcOU?t=01h36m23s)

interesting interesting okay I want to


[01:36:28,159 --> 01:36:32,630](https://youtu.be/1gHAKhFBcOU?t=01h36m28s)

see this guy here because this is kind


[01:36:30,830 --> 01:36:33,860](https://youtu.be/1gHAKhFBcOU?t=01h36m30s)

of clever I might need this for another


[01:36:32,630 --> 01:36:38,570](https://youtu.be/1gHAKhFBcOU?t=01h36m32s)

project where I was doing some


[01:36:33,860 --> 01:36:44,780](https://youtu.be/1gHAKhFBcOU?t=01h36m33s)

generation on zamel files so he is using


[01:36:38,570 --> 01:36:48,350](https://youtu.be/1gHAKhFBcOU?t=01h36m38s)

it for his fluent ribbon got it


[01:36:44,780 --> 01:36:53,000](https://youtu.be/1gHAKhFBcOU?t=01h36m44s)

so template files default values base


[01:36:48,350 --> 01:36:57,230](https://youtu.be/1gHAKhFBcOU?t=01h36m48s)

colors and clearly that's changed since


[01:36:53,000 --> 01:36:59,929](https://youtu.be/1gHAKhFBcOU?t=01h36m53s)

the readme interesting interesting


[01:36:57,230 --> 01:37:02,210](https://youtu.be/1gHAKhFBcOU?t=01h36m57s)

interesting okay this is worthy of a


[01:36:59,929 --> 01:37:04,580](https://youtu.be/1gHAKhFBcOU?t=01h36m59s)

star I'm gonna I'm gonna keep this as


[01:37:02,210 --> 01:37:07,369](https://youtu.be/1gHAKhFBcOU?t=01h37m02s)

one of those libraries I like to keep in


[01:37:04,580 --> 01:37:12,050](https://youtu.be/1gHAKhFBcOU?t=01h37m04s)

your back pocket just to see and does it


[01:37:07,369 --> 01:37:17,290](https://youtu.be/1gHAKhFBcOU?t=01h37m07s)

kick off from see what the build script


[01:37:12,050 --> 01:37:24,260](https://youtu.be/1gHAKhFBcOU?t=01h37m12s)

does target build and this configure


[01:37:17,290 --> 01:37:31,489](https://youtu.be/1gHAKhFBcOU?t=01h37m17s)

pre-release not a lot not a lot of


[01:37:24,260 --> 01:37:35,659](https://youtu.be/1gHAKhFBcOU?t=01h37m24s)

fanciness tools version this looks like


[01:37:31,489 --> 01:37:38,949](https://youtu.be/1gHAKhFBcOU?t=01h37m31s)

an old msbuild powershell script not too


[01:37:35,659 --> 01:37:42,880](https://youtu.be/1gHAKhFBcOU?t=01h37m35s)

interesting show me the app there so


[01:37:38,949 --> 01:37:48,550](https://youtu.be/1gHAKhFBcOU?t=01h37m38s)

nothing fancy literally just calls build


[01:37:42,880 --> 01:37:55,820](https://youtu.be/1gHAKhFBcOU?t=01h37m42s)

for CI builds it out and away you go


[01:37:48,550 --> 01:38:03,260](https://youtu.be/1gHAKhFBcOU?t=01h37m48s)

okay so not not overly fancy ad strong


[01:37:55,820 --> 01:38:10,250](https://youtu.be/1gHAKhFBcOU?t=01h37m55s)

name disassembly builds that out it's on


[01:38:03,260 --> 01:38:11,869](https://youtu.be/1gHAKhFBcOU?t=01h38m03s)

JSON and the tools scene generator so it


[01:38:10,250 --> 01:38:16,989](https://youtu.be/1gHAKhFBcOU?t=01h38m10s)

looks like this is actually something


[01:38:11,869 --> 01:38:18,920](https://youtu.be/1gHAKhFBcOU?t=01h38m11s)

that could go as a dotnet global tool


[01:38:16,989 --> 01:38:20,510](https://youtu.be/1gHAKhFBcOU?t=01h38m16s)

doesn't look like that's what it is


[01:38:18,920 --> 01:38:22,219](https://youtu.be/1gHAKhFBcOU?t=01h38m18s)

right now because it's generating out


[01:38:20,510 --> 01:38:28,570](https://youtu.be/1gHAKhFBcOU?t=01h38m20s)

but it seems like it's


[01:38:22,219 --> 01:38:28,570](https://youtu.be/1gHAKhFBcOU?t=01h38m22s)

just built as a straight-up executable


[01:38:29,030 --> 01:38:35,900](https://youtu.be/1gHAKhFBcOU?t=01h38m29s)

[Laughter]


[01:38:30,789 --> 01:38:43,219](https://youtu.be/1gHAKhFBcOU?t=01h38m30s)

sorry Ted I just saw your message this


[01:38:35,900 --> 01:38:47,030](https://youtu.be/1gHAKhFBcOU?t=01h38m35s)

guy here interesting okay so it builds


[01:38:43,219 --> 01:38:59,300](https://youtu.be/1gHAKhFBcOU?t=01h38m43s)

this out grabs a mutex lock on the


[01:38:47,030 --> 01:39:01,190](https://youtu.be/1gHAKhFBcOU?t=01h38m47s)

individual file ooh interesting looks


[01:38:59,300 --> 01:39:03,889](https://youtu.be/1gHAKhFBcOU?t=01h38m59s)

like it's using the grid to identify


[01:39:01,190 --> 01:39:11,210](https://youtu.be/1gHAKhFBcOU?t=01h39m01s)

current any version of his assembly


[01:39:03,889 --> 01:39:13,099](https://youtu.be/1gHAKhFBcOU?t=01h39m03s)

that's locked on it and blocks so that


[01:39:11,210 --> 01:39:15,079](https://youtu.be/1gHAKhFBcOU?t=01h39m11s)

this guy can basically be tied in


[01:39:13,099 --> 01:39:17,929](https://youtu.be/1gHAKhFBcOU?t=01h39m13s)

because you you sometimes run into this


[01:39:15,079 --> 01:39:22,489](https://youtu.be/1gHAKhFBcOU?t=01h39m15s)

case where you get multiple processes


[01:39:17,929 --> 01:39:24,949](https://youtu.be/1gHAKhFBcOU?t=01h39m17s)

loading up your project specifically if


[01:39:22,489 --> 01:39:27,260](https://youtu.be/1gHAKhFBcOU?t=01h39m22s)

you've got like some sort of live unit


[01:39:24,949 --> 01:39:29,570](https://youtu.be/1gHAKhFBcOU?t=01h39m24s)

testing or and crunch those type of ones


[01:39:27,260 --> 01:39:33,940](https://youtu.be/1gHAKhFBcOU?t=01h39m27s)

that that may kick off or multiple


[01:39:29,570 --> 01:39:37,639](https://youtu.be/1gHAKhFBcOU?t=01h39m29s)

msbuild processes so dealing with that


[01:39:33,940 --> 01:39:39,260](https://youtu.be/1gHAKhFBcOU?t=01h39m33s)

d5 hash so this isn't this is basically


[01:39:37,639 --> 01:39:42,019](https://youtu.be/1gHAKhFBcOU?t=01h39m37s)

just shelling out to the color scheme


[01:39:39,260 --> 01:39:43,249](https://youtu.be/1gHAKhFBcOU?t=01h39m39s)

generator and this guy is the one that


[01:39:42,019 --> 01:39:46,670](https://youtu.be/1gHAKhFBcOU?t=01h39m42s)

actually does all the work


[01:39:43,249 --> 01:39:49,789](https://youtu.be/1gHAKhFBcOU?t=01h39m43s)

so reads in the input file DC realizes


[01:39:46,670 --> 01:39:53,449](https://youtu.be/1gHAKhFBcOU?t=01h39m46s)

the JSON out color scheme base colors


[01:39:49,789 --> 01:39:55,099](https://youtu.be/1gHAKhFBcOU?t=01h39m49s)

color scheme double iterates over the


[01:39:53,449 --> 01:39:59,329](https://youtu.be/1gHAKhFBcOU?t=01h39m53s)

base and the color scheme colors


[01:39:55,099 --> 01:40:05,960](https://youtu.be/1gHAKhFBcOU?t=01h39m55s)

generates the file generates it out okay


[01:39:59,329 --> 01:40:10,130](https://youtu.be/1gHAKhFBcOU?t=01h39m59s)

so yeah really is just a fancy albeit


[01:40:05,960 --> 01:40:14,269](https://youtu.be/1gHAKhFBcOU?t=01h40m05s)

very fancy find and replace on all of


[01:40:10,130 --> 01:40:18,010](https://youtu.be/1gHAKhFBcOU?t=01h40m10s)

the colors oh gotta love those curly


[01:40:14,269 --> 01:40:21,309](https://youtu.be/1gHAKhFBcOU?t=01h40m14s)

braces inside of an interpolated string


[01:40:18,010 --> 01:40:24,050](https://youtu.be/1gHAKhFBcOU?t=01h40m18s)

yeah this is one of the only times where


[01:40:21,309 --> 01:40:26,840](https://youtu.be/1gHAKhFBcOU?t=01h40m21s)

the c-sharp string interpolation gets


[01:40:24,050 --> 01:40:29,659](https://youtu.be/1gHAKhFBcOU?t=01h40m24s)

really really ugly is when you need to


[01:40:26,840 --> 01:40:31,760](https://youtu.be/1gHAKhFBcOU?t=01h40m26s)

do like say double curly braces and you


[01:40:29,659 --> 01:40:33,969](https://youtu.be/1gHAKhFBcOU?t=01h40m29s)

need to escape those which itself is


[01:40:31,760 --> 01:40:35,900](https://youtu.be/1gHAKhFBcOU?t=01h40m31s)

another curly brace so you just get


[01:40:33,969 --> 01:40:42,070](https://youtu.be/1gHAKhFBcOU?t=01h40m33s)

curly braces BAM


[01:40:35,900 --> 01:40:44,510](https://youtu.be/1gHAKhFBcOU?t=01h40m35s)

all the way across so nice and clean


[01:40:42,070 --> 01:40:46,960](https://youtu.be/1gHAKhFBcOU?t=01h40m42s)

don't know if I wouldn't necessarily


[01:40:44,510 --> 01:40:49,250](https://youtu.be/1gHAKhFBcOU?t=01h40m44s)

leverage it on our project but


[01:40:46,960 --> 01:40:51,140](https://youtu.be/1gHAKhFBcOU?t=01h40m46s)

definitely a worthwhile a worthwhile


[01:40:49,250 --> 01:40:53,300](https://youtu.be/1gHAKhFBcOU?t=01h40m49s)

thing to keep in mind so that's


[01:40:51,140 --> 01:40:59,600](https://youtu.be/1gHAKhFBcOU?t=01h40m51s)

ultimately how they're generating it but


[01:40:53,300 --> 01:41:02,170](https://youtu.be/1gHAKhFBcOU?t=01h40m53s)

that leaves me in a good position see


[01:40:59,600 --> 01:41:07,190](https://youtu.be/1gHAKhFBcOU?t=01h40m59s)

jump back here


[01:41:02,170 --> 01:41:10,910](https://youtu.be/1gHAKhFBcOU?t=01h41m02s)

when it comes to looking up the themes


[01:41:07,190 --> 01:41:12,680](https://youtu.be/1gHAKhFBcOU?t=01h41m07s)

for these brushes so it does make me


[01:41:10,910 --> 01:41:17,390](https://youtu.be/1gHAKhFBcOU?t=01h41m10s)

wonder though at least for the next


[01:41:12,680 --> 01:41:19,190](https://youtu.be/1gHAKhFBcOU?t=01h41m12s)

release because this is what makes it


[01:41:17,390 --> 01:41:22,100](https://youtu.be/1gHAKhFBcOU?t=01h41m17s)

hard is because this has clearly been


[01:41:19,190 --> 01:41:27,710](https://youtu.be/1gHAKhFBcOU?t=01h41m19s)

switched for they're there next to o


[01:41:22,100 --> 01:41:31,040](https://youtu.be/1gHAKhFBcOU?t=01h41m22s)

release this is coming so I will want to


[01:41:27,710 --> 01:41:33,980](https://youtu.be/1gHAKhFBcOU?t=01h41m27s)

make sure that we are updated for these


[01:41:31,040 --> 01:41:36,040](https://youtu.be/1gHAKhFBcOU?t=01h41m31s)

and again I'm not sure because we can


[01:41:33,980 --> 01:41:38,810](https://youtu.be/1gHAKhFBcOU?t=01h41m33s)

kind of cheat and get away with not


[01:41:36,040 --> 01:41:41,930](https://youtu.be/1gHAKhFBcOU?t=01h41m36s)

supporting all the brushes because we


[01:41:38,810 --> 01:41:46,430](https://youtu.be/1gHAKhFBcOU?t=01h41m38s)

don't have to necessarily apply all of


[01:41:41,930 --> 01:41:48,880](https://youtu.be/1gHAKhFBcOU?t=01h41m41s)

them it's only the ones that matter we


[01:41:46,430 --> 01:41:51,950](https://youtu.be/1gHAKhFBcOU?t=01h41m46s)

create things from Bob's back in the day


[01:41:48,880 --> 01:41:53,750](https://youtu.be/1gHAKhFBcOU?t=01h41m48s)

yeah I've done something similar to


[01:41:51,950 --> 01:41:57,380](https://youtu.be/1gHAKhFBcOU?t=01h41m51s)

where I've needed to have a bunch of


[01:41:53,750 --> 01:41:59,120](https://youtu.be/1gHAKhFBcOU?t=01h41m53s)

themes where I effectively did just load


[01:41:57,380 --> 01:42:03,020](https://youtu.be/1gHAKhFBcOU?t=01h41m57s)

it in as XML and do a find and replace


[01:41:59,120 --> 01:42:04,640](https://youtu.be/1gHAKhFBcOU?t=01h41m59s)

on it it's not necessarily a terribly


[01:42:03,020 --> 01:42:07,490](https://youtu.be/1gHAKhFBcOU?t=01h42m03s)

complicated thing but it is one of those


[01:42:04,640 --> 01:42:09,970](https://youtu.be/1gHAKhFBcOU?t=01h42m04s)

issues that these types of files you end


[01:42:07,490 --> 01:42:12,590](https://youtu.be/1gHAKhFBcOU?t=01h42m07s)

up with a lot of duplication for each


[01:42:09,970 --> 01:42:15,100](https://youtu.be/1gHAKhFBcOU?t=01h42m09s)

for each of your color themes which is


[01:42:12,590 --> 01:42:18,860](https://youtu.be/1gHAKhFBcOU?t=01h42m12s)

part of where we started to end up with


[01:42:15,100 --> 01:42:23,630](https://youtu.be/1gHAKhFBcOU?t=01h42m15s)

and I think the I think I like our


[01:42:18,860 --> 01:42:26,720](https://youtu.be/1gHAKhFBcOU?t=01h42m18s)

codified API because this certainly


[01:42:23,630 --> 01:42:28,400](https://youtu.be/1gHAKhFBcOU?t=01h42m23s)

solves part of the problem with dealing


[01:42:26,720 --> 01:42:30,290](https://youtu.be/1gHAKhFBcOU?t=01h42m26s)

with the spam and trying to manage all


[01:42:28,400 --> 01:42:32,330](https://youtu.be/1gHAKhFBcOU?t=01h42m28s)

of these but I don't know if it


[01:42:30,290 --> 01:42:34,850](https://youtu.be/1gHAKhFBcOU?t=01h42m30s)

necessarily fixes the issue of making it


[01:42:32,330 --> 01:42:36,650](https://youtu.be/1gHAKhFBcOU?t=01h42m32s)

easier for somebody who wants to change


[01:42:34,850 --> 01:42:38,900](https://youtu.be/1gHAKhFBcOU?t=01h42m34s)

the color theme it's gonna look I


[01:42:36,650 --> 01:42:41,900](https://youtu.be/1gHAKhFBcOU?t=01h42m36s)

thought I saw a theme manager sitting


[01:42:38,900 --> 01:42:44,710](https://youtu.be/1gHAKhFBcOU?t=01h42m38s)

around in here I'm curious what the API


[01:42:41,900 --> 01:42:47,300](https://youtu.be/1gHAKhFBcOU?t=01h42m41s)

is yeah a theme manager what's this guy


[01:42:44,710 --> 01:42:49,250](https://youtu.be/1gHAKhFBcOU?t=01h42m44s)

what do you do because I'm guessing this


[01:42:47,300 --> 01:42:49,820](https://youtu.be/1gHAKhFBcOU?t=01h42m47s)

theme manager and theme class of God to


[01:42:49,250 --> 01:42:52,910](https://youtu.be/1gHAKhFBcOU?t=01h42m49s)

be


[01:42:49,820 --> 01:42:55,070](https://youtu.be/1gHAKhFBcOU?t=01h42m49s)

similar to what what we built out where


[01:42:52,910 --> 01:42:57,410](https://youtu.be/1gHAKhFBcOU?t=01h42m52s)

it's effectively a codified version of


[01:42:55,070 --> 01:43:00,920](https://youtu.be/1gHAKhFBcOU?t=01h42m55s)

it so theme takes in a resource


[01:42:57,410 --> 01:43:03,740](https://youtu.be/1gHAKhFBcOU?t=01h42m57s)

dictionary okay so he uses these to pull


[01:43:00,920 --> 01:43:09,860](https://youtu.be/1gHAKhFBcOU?t=01h43m00s)

out those name display name color themes


[01:43:03,740 --> 01:43:12,680](https://youtu.be/1gHAKhFBcOU?t=01h43m03s)

stuff great showcase brush a color


[01:43:09,860 --> 01:43:17,120](https://youtu.be/1gHAKhFBcOU?t=01h43m09s)

scheme base color scheme still just


[01:43:12,680 --> 01:43:19,070](https://youtu.be/1gHAKhFBcOU?t=01h43m12s)

straight-up string matching which I I


[01:43:17,120 --> 01:43:20,810](https://youtu.be/1gHAKhFBcOU?t=01h43m17s)

understand not necessarily wanting to


[01:43:19,070 --> 01:43:23,630](https://youtu.be/1gHAKhFBcOU?t=01h43m19s)

codify your brushes because it means you


[01:43:20,810 --> 01:43:25,310](https://youtu.be/1gHAKhFBcOU?t=01h43m20s)

have to yeah it is very tedious it means


[01:43:23,630 --> 01:43:30,260](https://youtu.be/1gHAKhFBcOU?t=01h43m23s)

you have to keep everything in sync


[01:43:25,310 --> 01:43:33,830](https://youtu.be/1gHAKhFBcOU?t=01h43m25s)

which is obnoxious but I I guess my


[01:43:30,260 --> 01:43:36,520](https://youtu.be/1gHAKhFBcOU?t=01h43m30s)

opinion is it feels like with good unit


[01:43:33,830 --> 01:43:42,860](https://youtu.be/1gHAKhFBcOU?t=01h43m33s)

testing it doesn't really matter so


[01:43:36,520 --> 01:43:45,680](https://youtu.be/1gHAKhFBcOU?t=01h43m36s)

theme manager very similar to what we


[01:43:42,860 --> 01:43:47,630](https://youtu.be/1gHAKhFBcOU?t=01h43m42s)

used to do for pulling out all of our


[01:43:45,680 --> 01:43:52,250](https://youtu.be/1gHAKhFBcOU?t=01h43m45s)

built-in themes is extract out the


[01:43:47,630 --> 01:43:56,630](https://youtu.be/1gHAKhFBcOU?t=01h43m47s)

compiled resources which isn't horrible


[01:43:52,250 --> 01:44:05,800](https://youtu.be/1gHAKhFBcOU?t=01h43m52s)

totally doable obviously let's see add a


[01:43:56,630 --> 01:44:08,240](https://youtu.be/1gHAKhFBcOU?t=01h43m56s)

theme pulse to get inverse theme so


[01:44:05,800 --> 01:44:11,770](https://youtu.be/1gHAKhFBcOU?t=01h44m05s)

basically just does a switch on the name


[01:44:08,240 --> 01:44:14,480](https://youtu.be/1gHAKhFBcOU?t=01h44m08s)

and looks for the appropriate URI okay


[01:44:11,770 --> 01:44:17,690](https://youtu.be/1gHAKhFBcOU?t=01h44m11s)

steam dictionary resource for map style


[01:44:14,480 --> 01:44:21,650](https://youtu.be/1gHAKhFBcOU?t=01h44m14s)

change theme just ain't change theme


[01:44:17,690 --> 01:44:27,070](https://youtu.be/1gHAKhFBcOU?t=01h44m17s)

works it does cap you at using one of


[01:44:21,650 --> 01:44:29,630](https://youtu.be/1gHAKhFBcOU?t=01h44m21s)

the built-in theme names which is fine


[01:44:27,070 --> 01:44:31,880](https://youtu.be/1gHAKhFBcOU?t=01h44m27s)

because the app that I work on that uses


[01:44:29,630 --> 01:44:34,880](https://youtu.be/1gHAKhFBcOU?t=01h44m29s)

my apps there is no real theming change


[01:44:31,880 --> 01:44:37,160](https://youtu.be/1gHAKhFBcOU?t=01h44m31s)

there's a there's a slider that lets you


[01:44:34,880 --> 01:44:42,260](https://youtu.be/1gHAKhFBcOU?t=01h44m34s)

effectively go from light to dark theme


[01:44:37,160 --> 01:44:46,220](https://youtu.be/1gHAKhFBcOU?t=01h44m37s)

and that's about it so not overly not


[01:44:42,260 --> 01:44:53,590](https://youtu.be/1gHAKhFBcOU?t=01h44m42s)

overly advanced let's say yeah so detect


[01:44:46,220 --> 01:44:53,590](https://youtu.be/1gHAKhFBcOU?t=01h44m46s)

theme extracts the stuff out yeah okay


[01:44:54,490 --> 01:45:02,120](https://youtu.be/1gHAKhFBcOU?t=01h44m54s)

so that for reference this I believe


[01:44:58,490 --> 01:45:03,489](https://youtu.be/1gHAKhFBcOU?t=01h44m58s)

here is the hacker II I was talking


[01:45:02,120 --> 01:45:06,680](https://youtu.be/1gHAKhFBcOU?t=01h45m02s)

about doing


[01:45:03,489 --> 01:45:11,660](https://youtu.be/1gHAKhFBcOU?t=01h45m03s)

so because this is and I think this is


[01:45:06,680 --> 01:45:14,560](https://youtu.be/1gHAKhFBcOU?t=01h45m06s)

where I had seen it before the the


[01:45:11,660 --> 01:45:21,650](https://youtu.be/1gHAKhFBcOU?t=01h45m11s)

Windows 10 stuff you can detect where


[01:45:14,560 --> 01:45:23,870](https://youtu.be/1gHAKhFBcOU?t=01h45m14s)

let's see so if I do personalize what is


[01:45:21,650 --> 01:45:24,170](https://youtu.be/1gHAKhFBcOU?t=01h45m21s)

it theme it was the easiest way to get


[01:45:23,870 --> 01:45:27,860](https://youtu.be/1gHAKhFBcOU?t=01h45m23s)

it


[01:45:24,170 --> 01:45:31,340](https://youtu.be/1gHAKhFBcOU?t=01h45m24s)

theme in related settings so under


[01:45:27,860 --> 01:45:34,910](https://youtu.be/1gHAKhFBcOU?t=01h45m27s)

Windows 8 and Windows 10 they added the


[01:45:31,340 --> 01:45:39,500](https://youtu.be/1gHAKhFBcOU?t=01h45m31s)

concept of dark theme to Windows where


[01:45:34,910 --> 01:45:42,560](https://youtu.be/1gHAKhFBcOU?t=01h45m34s)

the my synced theme is this where it is


[01:45:39,500 --> 01:45:45,350](https://youtu.be/1gHAKhFBcOU?t=01h45m39s)

I know somewhat hesitant to just change


[01:45:42,560 --> 01:45:48,230](https://youtu.be/1gHAKhFBcOU?t=01h45m42s)

it there it is choose your default app


[01:45:45,350 --> 01:45:50,090](https://youtu.be/1gHAKhFBcOU?t=01h45m45s)

mode light and dark theme so you can and


[01:45:48,230 --> 01:45:51,590](https://youtu.be/1gHAKhFBcOU?t=01h45m48s)

I'm I've got this synced across too many


[01:45:50,090 --> 01:45:54,170](https://youtu.be/1gHAKhFBcOU?t=01h45m50s)

machines so I don't actually click the


[01:45:51,590 --> 01:45:57,170](https://youtu.be/1gHAKhFBcOU?t=01h45m51s)

mouse but you can actually go through


[01:45:54,170 --> 01:46:00,050](https://youtu.be/1gHAKhFBcOU?t=01h45m54s)

and query this information back out and


[01:45:57,170 --> 01:46:01,820](https://youtu.be/1gHAKhFBcOU?t=01h45m57s)

so ultimately what I would love to yeah


[01:46:00,050 --> 01:46:02,180](https://youtu.be/1gHAKhFBcOU?t=01h46m00s)

exactly tied for inherit at the root


[01:46:01,820 --> 01:46:04,430](https://youtu.be/1gHAKhFBcOU?t=01h46m01s)

level


[01:46:02,180 --> 01:46:06,980](https://youtu.be/1gHAKhFBcOU?t=01h46m02s)

I want to query that value back out and


[01:46:04,430 --> 01:46:09,110](https://youtu.be/1gHAKhFBcOU?t=01h46m04s)

then default based upon the user setting


[01:46:06,980 --> 01:46:11,090](https://youtu.be/1gHAKhFBcOU?t=01h46m06s)

because if you set your window or your


[01:46:09,110 --> 01:46:13,580](https://youtu.be/1gHAKhFBcOU?t=01h46m09s)

windows layout into dark theme


[01:46:11,090 --> 01:46:16,190](https://youtu.be/1gHAKhFBcOU?t=01h46m11s)

you probably want your apps to fall into


[01:46:13,580 --> 01:46:18,530](https://youtu.be/1gHAKhFBcOU?t=01h46m13s)

dark theme by default again it as the


[01:46:16,190 --> 01:46:20,690](https://youtu.be/1gHAKhFBcOU?t=01h46m16s)

app developer you're still in control if


[01:46:18,530 --> 01:46:24,110](https://youtu.be/1gHAKhFBcOU?t=01h46m18s)

you want that behavior you can go with


[01:46:20,690 --> 01:46:25,670](https://youtu.be/1gHAKhFBcOU?t=01h46m20s)

inherit if you want to you know say no


[01:46:24,110 --> 01:46:27,830](https://youtu.be/1gHAKhFBcOU?t=01h46m24s)

my app doesn't look good in dark theme


[01:46:25,670 --> 01:46:31,699](https://youtu.be/1gHAKhFBcOU?t=01h46m25s)

I'm gonna do light only great set it to


[01:46:27,830 --> 01:46:34,420](https://youtu.be/1gHAKhFBcOU?t=01h46m27s)

light you're done but it then leaves it


[01:46:31,699 --> 01:46:36,680](https://youtu.be/1gHAKhFBcOU?t=01h46m31s)

up to you as the app developer to pick


[01:46:34,420 --> 01:46:38,780](https://youtu.be/1gHAKhFBcOU?t=01h46m34s)

sort of which behavior you want to do


[01:46:36,680 --> 01:46:41,540](https://youtu.be/1gHAKhFBcOU?t=01h46m36s)

the one thing I will say is if you let


[01:46:38,780 --> 01:46:44,120](https://youtu.be/1gHAKhFBcOU?t=01h46m38s)

the users toggle between themes always


[01:46:41,540 --> 01:46:46,640](https://youtu.be/1gHAKhFBcOU?t=01h46m41s)

always test in all of them because it


[01:46:44,120 --> 01:46:48,350](https://youtu.be/1gHAKhFBcOU?t=01h46m44s)

will bite you if you don't I cannot tell


[01:46:46,640 --> 01:46:51,650](https://youtu.be/1gHAKhFBcOU?t=01h46m46s)

you how many bugs in my apps I've had to


[01:46:48,350 --> 01:46:56,719](https://youtu.be/1gHAKhFBcOU?t=01h46m48s)

fix because of that this is always


[01:46:51,650 --> 01:46:58,430](https://youtu.be/1gHAKhFBcOU?t=01h46m51s)

interesting so cool well that at least


[01:46:56,719 --> 01:46:59,570](https://youtu.be/1gHAKhFBcOU?t=01h46m56s)

gets that lined up and that gives me


[01:46:58,430 --> 01:47:01,340](https://youtu.be/1gHAKhFBcOU?t=01h46m58s)

pointing in the right direction I think


[01:46:59,570 --> 01:47:04,370](https://youtu.be/1gHAKhFBcOU?t=01h46m59s)

I am going to poke a little bit further


[01:47:01,340 --> 01:47:07,430](https://youtu.be/1gHAKhFBcOU?t=01h47m01s)

at the mah app stuff I'm probably going


[01:47:04,370 --> 01:47:09,980](https://youtu.be/1gHAKhFBcOU?t=01h47m04s)

to pull down the one six version of the


[01:47:07,430 --> 01:47:11,480](https://youtu.be/1gHAKhFBcOU?t=01h47m07s)

code and take a look at it just to make


[01:47:09,980 --> 01:47:13,699](https://youtu.be/1gHAKhFBcOU?t=01h47m09s)

sure that we are covering all of the


[01:47:11,480 --> 01:47:15,620](https://youtu.be/1gHAKhFBcOU?t=01h47m11s)

brushes for their latest release and


[01:47:13,699 --> 01:47:17,180](https://youtu.be/1gHAKhFBcOU?t=01h47m13s)

make sure that this is a reasonably


[01:47:15,620 --> 01:47:18,860](https://youtu.be/1gHAKhFBcOU?t=01h47m15s)

complete set


[01:47:17,180 --> 01:47:20,390](https://youtu.be/1gHAKhFBcOU?t=01h47m17s)

again there might be some brushes that


[01:47:18,860 --> 01:47:23,270](https://youtu.be/1gHAKhFBcOU?t=01h47m18s)

they have that we don't bother to set


[01:47:20,390 --> 01:47:25,100](https://youtu.be/1gHAKhFBcOU?t=01h47m20s)

because we don't have a meaningful color


[01:47:23,270 --> 01:47:27,920](https://youtu.be/1gHAKhFBcOU?t=01h47m23s)

to set there but I think for at least


[01:47:25,100 --> 01:47:33,140](https://youtu.be/1gHAKhFBcOU?t=01h47m25s)

all of these these look good in oh so we


[01:47:27,920 --> 01:47:35,060](https://youtu.be/1gHAKhFBcOU?t=01h47m27s)

were going to we changed this let's see


[01:47:33,140 --> 01:47:38,390](https://youtu.be/1gHAKhFBcOU?t=01h47m33s)

I should do this right we should pull


[01:47:35,060 --> 01:47:40,670](https://youtu.be/1gHAKhFBcOU?t=01h47m35s)

request it in we should pull request it


[01:47:38,390 --> 01:47:43,940](https://youtu.be/1gHAKhFBcOU?t=01h47m38s)

I occasionally get into the habit of


[01:47:40,670 --> 01:47:46,490](https://youtu.be/1gHAKhFBcOU?t=01h47m40s)

just cowboy might commit straight into


[01:47:43,940 --> 01:47:52,370](https://youtu.be/1gHAKhFBcOU?t=01h47m43s)

master which is not a good idea


[01:47:46,490 --> 01:47:56,330](https://youtu.be/1gHAKhFBcOU?t=01h47m46s)

create branch ma apps brushes will just


[01:47:52,370 --> 01:48:02,140](https://youtu.be/1gHAKhFBcOU?t=01h47m52s)

make we have get we can use good


[01:47:56,330 --> 01:48:12,980](https://youtu.be/1gHAKhFBcOU?t=01h47m56s)

branching so let's do here let's do here


[01:48:02,140 --> 01:48:14,360](https://youtu.be/1gHAKhFBcOU?t=01h48m02s)

fixing missing ma apps brushes cool and


[01:48:12,980 --> 01:48:26,690](https://youtu.be/1gHAKhFBcOU?t=01h48m12s)

I just want to double check some of


[01:48:14,360 --> 01:48:31,700](https://youtu.be/1gHAKhFBcOU?t=01h48m14s)

these dr. D gets all those in great okay


[01:48:26,690 --> 01:48:33,140](https://youtu.be/1gHAKhFBcOU?t=01h48m26s)

so we'll push that and I'll pull request


[01:48:31,700 --> 01:48:35,660](https://youtu.be/1gHAKhFBcOU?t=01h48m31s)

it and just make sure that the CI


[01:48:33,140 --> 01:48:38,300](https://youtu.be/1gHAKhFBcOU?t=01h48m33s)

systems kick off I have been doing quite


[01:48:35,660 --> 01:48:39,980](https://youtu.be/1gHAKhFBcOU?t=01h48m35s)

a bit of pipelining work and I'm I'm


[01:48:38,300 --> 01:48:41,690](https://youtu.be/1gHAKhFBcOU?t=01h48m38s)

finally at the point where I'm I'm


[01:48:39,980 --> 01:48:48,230](https://youtu.be/1gHAKhFBcOU?t=01h48m39s)

reasonably happy with it


[01:48:41,690 --> 01:48:53,660](https://youtu.be/1gHAKhFBcOU?t=01h48m41s)

where'd my okay so I'm sure some of you


[01:48:48,230 --> 01:48:55,310](https://youtu.be/1gHAKhFBcOU?t=01h48m48s)

have probably seen way too many way too


[01:48:53,660 --> 01:48:58,610](https://youtu.be/1gHAKhFBcOU?t=01h48m53s)

many commits of mine going in just


[01:48:55,310 --> 01:49:07,340](https://youtu.be/1gHAKhFBcOU?t=01h48m55s)

mucking with llamó files it's


[01:48:58,610 --> 01:49:10,310](https://youtu.be/1gHAKhFBcOU?t=01h48m58s)

unfortunately addictive yeah there are


[01:49:07,340 --> 01:49:13,280](https://youtu.be/1gHAKhFBcOU?t=01h49m07s)

quite a few if people are interested I


[01:49:10,310 --> 01:49:14,810](https://youtu.be/1gHAKhFBcOU?t=01h49m10s)

might even just pop over in didn't I


[01:49:13,280 --> 01:49:19,460](https://youtu.be/1gHAKhFBcOU?t=01h49m13s)

have that open on one of these screens


[01:49:14,810 --> 01:49:20,450](https://youtu.be/1gHAKhFBcOU?t=01h49m14s)

oh yeah I did have it open let's pull


[01:49:19,460 --> 01:49:24,350](https://youtu.be/1gHAKhFBcOU?t=01h49m19s)

request this guy real quick


[01:49:20,450 --> 01:49:26,360](https://youtu.be/1gHAKhFBcOU?t=01h49m20s)

fixing my Missy mops brushes so let's do


[01:49:24,350 --> 01:49:27,619](https://youtu.be/1gHAKhFBcOU?t=01h49m24s)

this is technically going to drop on to


[01:49:26,360 --> 01:49:31,849](https://youtu.be/1gHAKhFBcOU?t=01h49m26s)

six


[01:49:27,619 --> 01:49:35,570](https://youtu.be/1gHAKhFBcOU?t=01h49m27s)

and sure poll requests so if people are


[01:49:31,849 --> 01:49:38,030](https://youtu.be/1gHAKhFBcOU?t=01h49m31s)

interested not all of this is public but


[01:49:35,570 --> 01:49:41,360](https://youtu.be/1gHAKhFBcOU?t=01h49m35s)

at least for like the build pipelines


[01:49:38,030 --> 01:49:43,369](https://youtu.be/1gHAKhFBcOU?t=01h49m38s)

when you kickoff poll requests you can


[01:49:41,360 --> 01:49:46,849](https://youtu.be/1gHAKhFBcOU?t=01h49m41s)

go through and click and at least get a


[01:49:43,369 --> 01:49:50,540](https://youtu.be/1gHAKhFBcOU?t=01h49m43s)

view of the pipelines that have been run


[01:49:46,849 --> 01:49:54,860](https://youtu.be/1gHAKhFBcOU?t=01h49m46s)

and what gets kicked off so this one is


[01:49:50,540 --> 01:49:59,679](https://youtu.be/1gHAKhFBcOU?t=01h49m50s)

the simple so I've got a couple build


[01:49:54,860 --> 01:50:04,310](https://youtu.be/1gHAKhFBcOU?t=01h49m54s)

pipelines this one kicks off for both


[01:49:59,679 --> 01:50:06,230](https://youtu.be/1gHAKhFBcOU?t=01h49m59s)

pull requests and merges into master and


[01:50:04,310 --> 01:50:09,980](https://youtu.be/1gHAKhFBcOU?t=01h50m04s)

it'll just validate that your pull


[01:50:06,230 --> 01:50:12,349](https://youtu.be/1gHAKhFBcOU?t=01h50m06s)

request runs so to six-hour release


[01:50:09,980 --> 01:50:14,360](https://youtu.be/1gHAKhFBcOU?t=01h50m09s)

window yet so the answer tied given that


[01:50:12,349 --> 01:50:20,270](https://youtu.be/1gHAKhFBcOU?t=01h50m12s)

I just found a couple bugs after this


[01:50:14,360 --> 01:50:22,730](https://youtu.be/1gHAKhFBcOU?t=01h50m14s)

thing emerges I wait on the library


[01:50:20,270 --> 01:50:25,250](https://youtu.be/1gHAKhFBcOU?t=01h50m20s)

owner James to just give a quick sign


[01:50:22,730 --> 01:50:28,510](https://youtu.be/1gHAKhFBcOU?t=01h50m22s)

off before things get pushed out I got a


[01:50:25,250 --> 01:50:31,969](https://youtu.be/1gHAKhFBcOU?t=01h50m25s)

message from him yesterday


[01:50:28,510 --> 01:50:34,070](https://youtu.be/1gHAKhFBcOU?t=01h50m28s)

recently he he'd been out for a little


[01:50:31,969 --> 01:50:35,690](https://youtu.be/1gHAKhFBcOU?t=01h50m31s)

bit said he would review it soon and


[01:50:34,070 --> 01:50:38,480](https://youtu.be/1gHAKhFBcOU?t=01h50m34s)

should be able to get it pushed out so


[01:50:35,690 --> 01:50:40,610](https://youtu.be/1gHAKhFBcOU?t=01h50m35s)

hopefully soon I'm kind of hoping that I


[01:50:38,480 --> 01:50:44,750](https://youtu.be/1gHAKhFBcOU?t=01h50m38s)

don't run into too many more of these to


[01:50:40,610 --> 01:50:49,130](https://youtu.be/1gHAKhFBcOU?t=01h50m40s)

600 issues as I've been fixing them I


[01:50:44,750 --> 01:50:50,210](https://youtu.be/1gHAKhFBcOU?t=01h50m44s)

might start a 300 branch and just work


[01:50:49,130 --> 01:50:52,219](https://youtu.be/1gHAKhFBcOU?t=01h50m49s)

on getting some of the other pull


[01:50:50,210 --> 01:50:56,540](https://youtu.be/1gHAKhFBcOU?t=01h50m50s)

requests merging into that just to get a


[01:50:52,219 --> 01:50:59,210](https://youtu.be/1gHAKhFBcOU?t=01h50m52s)

bit of ahead of the game but I would


[01:50:56,540 --> 01:51:03,440](https://youtu.be/1gHAKhFBcOU?t=01h50m56s)

hope in the next week but don't hold me


[01:50:59,210 --> 01:51:07,400](https://youtu.be/1gHAKhFBcOU?t=01h50m59s)

too tightly to that so other build


[01:51:03,440 --> 01:51:08,659](https://youtu.be/1gHAKhFBcOU?t=01h51m03s)

pipelines yeah yeah I agree and I'm one


[01:51:07,400 --> 01:51:10,909](https://youtu.be/1gHAKhFBcOU?t=01h51m07s)

of the things is with these new


[01:51:08,659 --> 01:51:13,130](https://youtu.be/1gHAKhFBcOU?t=01h51m08s)

pipelines I'm kind of hoping that we can


[01:51:10,909 --> 01:51:14,810](https://youtu.be/1gHAKhFBcOU?t=01h51m10s)

increase the the speed in the Akkadians


[01:51:13,130 --> 01:51:16,730](https://youtu.be/1gHAKhFBcOU?t=01h51m13s)

because right now doing a release


[01:51:14,810 --> 01:51:18,619](https://youtu.be/1gHAKhFBcOU?t=01h51m14s)

there's a bunch of manual steps and I'm


[01:51:16,730 --> 01:51:21,980](https://youtu.be/1gHAKhFBcOU?t=01h51m16s)

trying to automate all of those away


[01:51:18,619 --> 01:51:23,869](https://youtu.be/1gHAKhFBcOU?t=01h51m18s)

so this one here this one actually


[01:51:21,980 --> 01:51:26,929](https://youtu.be/1gHAKhFBcOU?t=01h51m21s)

helped me out earlier today so on the


[01:51:23,869 --> 01:51:29,659](https://youtu.be/1gHAKhFBcOU?t=01h51m23s)

wiki we have a page that lists out all


[01:51:26,929 --> 01:51:33,230](https://youtu.be/1gHAKhFBcOU?t=01h51m26s)

of the control styles that are inside of


[01:51:29,659 --> 01:51:37,460](https://youtu.be/1gHAKhFBcOU?t=01h51m29s)

the library and one of the things so


[01:51:33,230 --> 01:51:41,389](https://youtu.be/1gHAKhFBcOU?t=01h51m33s)

there's a this guy fires up there's a


[01:51:37,460 --> 01:51:43,489](https://youtu.be/1gHAKhFBcOU?t=01h51m37s)

nice little hidden mark down comment


[01:51:41,389 --> 01:51:45,499](https://youtu.be/1gHAKhFBcOU?t=01h51m41s)

if you if you do go to hit edit I'm


[01:51:43,489 --> 01:51:47,649](https://youtu.be/1gHAKhFBcOU?t=01h51m43s)

hoping this big warning right at the top


[01:51:45,499 --> 01:51:52,610](https://youtu.be/1gHAKhFBcOU?t=01h51m45s)

of the file tells people please don't


[01:51:47,649 --> 01:51:55,309](https://youtu.be/1gHAKhFBcOU?t=01h51m47s)

because this on every merge into master


[01:51:52,610 --> 01:51:58,010](https://youtu.be/1gHAKhFBcOU?t=01h51m52s)

this build pipeline runs and it kicks


[01:51:55,309 --> 01:51:59,499](https://youtu.be/1gHAKhFBcOU?t=01h51m55s)

off a PowerShell script that's right


[01:51:58,010 --> 01:52:03,169](https://youtu.be/1gHAKhFBcOU?t=01h51m58s)

inside of the scripts directory that


[01:51:59,499 --> 01:52:04,999](https://youtu.be/1gHAKhFBcOU?t=01h51m59s)

generates this markdown and in addition


[01:52:03,169 --> 01:52:07,340](https://youtu.be/1gHAKhFBcOU?t=01h52m03s)

to generating it it all it just pushes


[01:52:04,999 --> 01:52:11,030](https://youtu.be/1gHAKhFBcOU?t=01h52m04s)

it straight over the top of the wiki so


[01:52:07,340 --> 01:52:12,919](https://youtu.be/1gHAKhFBcOU?t=01h52m07s)

if you edit this manually your change is


[01:52:11,030 --> 01:52:15,409](https://youtu.be/1gHAKhFBcOU?t=01h52m11s)

going to get wiped out the very next


[01:52:12,919 --> 01:52:17,179](https://youtu.be/1gHAKhFBcOU?t=01h52m12s)

merge into master so one of those things


[01:52:15,409 --> 01:52:21,439](https://youtu.be/1gHAKhFBcOU?t=01h52m15s)

that I just got annoyed managing myself


[01:52:17,179 --> 01:52:23,360](https://youtu.be/1gHAKhFBcOU?t=01h52m17s)

and so I hijacked it and said okay I'm


[01:52:21,439 --> 01:52:24,829](https://youtu.be/1gHAKhFBcOU?t=01h52m21s)

done managing this I'm gonna start


[01:52:23,360 --> 01:52:29,869](https://youtu.be/1gHAKhFBcOU?t=01h52m23s)

scripting it just to keep things in sync


[01:52:24,829 --> 01:52:35,059](https://youtu.be/1gHAKhFBcOU?t=01h52m24s)

and then my release pipelines look a


[01:52:29,869 --> 01:52:37,939](https://youtu.be/1gHAKhFBcOU?t=01h52m29s)

little bit uglier so there is a icon


[01:52:35,059 --> 01:52:40,789](https://youtu.be/1gHAKhFBcOU?t=01h52m35s)

update one and this one's actually set


[01:52:37,939 --> 01:52:43,760](https://youtu.be/1gHAKhFBcOU?t=01h52m37s)

to kick off at midnight my time once a


[01:52:40,789 --> 01:52:46,630](https://youtu.be/1gHAKhFBcOU?t=01h52m40s)

day and its sole purpose in life is to


[01:52:43,760 --> 01:52:51,169](https://youtu.be/1gHAKhFBcOU?t=01h52m43s)

go out to the material design icons


[01:52:46,630 --> 01:52:53,139](https://youtu.be/1gHAKhFBcOU?t=01h52m46s)

website and run our icon update and if


[01:52:51,169 --> 01:52:56,619](https://youtu.be/1gHAKhFBcOU?t=01h52m51s)

it finds changes create a pull request


[01:52:53,139 --> 01:52:58,909](https://youtu.be/1gHAKhFBcOU?t=01h52m53s)

with the changes into master so


[01:52:56,619 --> 01:53:02,689](https://youtu.be/1gHAKhFBcOU?t=01h52m56s)

hopefully I will stop running into


[01:52:58,909 --> 01:53:05,229](https://youtu.be/1gHAKhFBcOU?t=01h52m58s)

issues now with this library falling


[01:53:02,689 --> 01:53:07,969](https://youtu.be/1gHAKhFBcOU?t=01h53m02s)

behind when they release new icons and


[01:53:05,229 --> 01:53:10,219](https://youtu.be/1gHAKhFBcOU?t=01h53m05s)

may not realize it or miss an update so


[01:53:07,969 --> 01:53:12,260](https://youtu.be/1gHAKhFBcOU?t=01h53m07s)

I figure running this once a day is


[01:53:10,219 --> 01:53:17,630](https://youtu.be/1gHAKhFBcOU?t=01h53m10s)

probably good enough to be reasonably


[01:53:12,260 --> 01:53:23,239](https://youtu.be/1gHAKhFBcOU?t=01h53m12s)

up-to-date I think a video and github


[01:53:17,630 --> 01:53:25,340](https://youtu.be/1gHAKhFBcOU?t=01h53m17s)

with me nice oh yeah I'd happily to go


[01:53:23,239 --> 01:53:28,309](https://youtu.be/1gHAKhFBcOU?t=01h53m23s)

through and show it's actually so the


[01:53:25,340 --> 01:53:30,079](https://youtu.be/1gHAKhFBcOU?t=01h53m25s)

Edit of the wiki with the exception of


[01:53:28,309 --> 01:53:32,769](https://youtu.be/1gHAKhFBcOU?t=01h53m28s)

this page this is the only page I would


[01:53:30,079 --> 01:53:35,269](https://youtu.be/1gHAKhFBcOU?t=01h53m30s)

say don't edit but with most of these


[01:53:32,769 --> 01:53:39,199](https://youtu.be/1gHAKhFBcOU?t=01h53m32s)

for example the getting started guide if


[01:53:35,269 --> 01:53:41,149](https://youtu.be/1gHAKhFBcOU?t=01h53m35s)

you come across with any issues or


[01:53:39,199 --> 01:53:44,389](https://youtu.be/1gHAKhFBcOU?t=01h53m39s)

changes that you see it's just a matter


[01:53:41,149 --> 01:53:46,639](https://youtu.be/1gHAKhFBcOU?t=01h53m41s)

of hitting the edit button and making


[01:53:44,389 --> 01:53:49,459](https://youtu.be/1gHAKhFBcOU?t=01h53m44s)

the appropriate changes everyone has


[01:53:46,639 --> 01:53:52,399](https://youtu.be/1gHAKhFBcOU?t=01h53m46s)

right permission to the wiki I do keep a


[01:53:49,459 --> 01:53:55,100](https://youtu.be/1gHAKhFBcOU?t=01h53m49s)

local clone up-to-date so don't worry


[01:53:52,399 --> 01:53:56,630](https://youtu.be/1gHAKhFBcOU?t=01h53m52s)

about making changes


[01:53:55,100 --> 01:53:59,420](https://youtu.be/1gHAKhFBcOU?t=01h53m55s)

in the event that anything goes through


[01:53:56,630 --> 01:54:01,670](https://youtu.be/1gHAKhFBcOU?t=01h53m56s)

that's bad the wiki itself is actually


[01:53:59,420 --> 01:54:03,350](https://youtu.be/1gHAKhFBcOU?t=01h53m59s)

just a git repo so if you wanted to


[01:54:01,670 --> 01:54:05,690](https://youtu.be/1gHAKhFBcOU?t=01h54m01s)

clone everything locally and edit a


[01:54:03,350 --> 01:54:08,240](https://youtu.be/1gHAKhFBcOU?t=01h54m03s)

bunch of files at once you can do that


[01:54:05,690 --> 01:54:11,060](https://youtu.be/1gHAKhFBcOU?t=01h54m05s)

but again it's a public repo everyone


[01:54:08,240 --> 01:54:13,520](https://youtu.be/1gHAKhFBcOU?t=01h54m08s)

has push access so anyone can make


[01:54:11,060 --> 01:54:16,910](https://youtu.be/1gHAKhFBcOU?t=01h54m11s)

changes in improvements so if you see


[01:54:13,520 --> 01:54:19,400](https://youtu.be/1gHAKhFBcOU?t=01h54m13s)

something that you want added go for it


[01:54:16,910 --> 01:54:22,040](https://youtu.be/1gHAKhFBcOU?t=01h54m16s)

I watched the changes and as long as


[01:54:19,400 --> 01:54:23,350](https://youtu.be/1gHAKhFBcOU?t=01h54m19s)

it's nothing horrible I usually let any


[01:54:22,040 --> 01:54:27,260](https://youtu.be/1gHAKhFBcOU?t=01h54m22s)

improvements people are willing to make


[01:54:23,350 --> 01:54:28,940](https://youtu.be/1gHAKhFBcOU?t=01h54m23s)

are more than welcome so and just going


[01:54:27,260 --> 01:54:31,580](https://youtu.be/1gHAKhFBcOU?t=01h54m27s)

back so and then the normal release


[01:54:28,940 --> 01:54:35,990](https://youtu.be/1gHAKhFBcOU?t=01h54m28s)

pipeline this one gets a little this one


[01:54:31,580 --> 01:54:38,870](https://youtu.be/1gHAKhFBcOU?t=01h54m31s)

gets uglier so this this is one that


[01:54:35,990 --> 01:54:45,770](https://youtu.be/1gHAKhFBcOU?t=01h54m35s)

I've been poking at and playing at for a


[01:54:38,870 --> 01:54:47,450](https://youtu.be/1gHAKhFBcOU?t=01h54m38s)

while so the the build pipeline that


[01:54:45,770 --> 01:54:50,660](https://youtu.be/1gHAKhFBcOU?t=01h54m45s)

kicks off on every merge to master


[01:54:47,450 --> 01:54:53,330](https://youtu.be/1gHAKhFBcOU?t=01h54m47s)

generates artifacts this things set up


[01:54:50,660 --> 01:54:57,140](https://youtu.be/1gHAKhFBcOU?t=01h54m50s)

on a once a day schedule and the idea


[01:54:53,330 --> 01:54:58,460](https://youtu.be/1gHAKhFBcOU?t=01h54m53s)

being that these CI builds would get


[01:54:57,140 --> 01:55:01,720](https://youtu.be/1gHAKhFBcOU?t=01h54m57s)

triggered once a day on the schedule


[01:54:58,460 --> 01:55:04,130](https://youtu.be/1gHAKhFBcOU?t=01h54m58s)

because right now a player runs on every


[01:55:01,720 --> 01:55:07,700](https://youtu.be/1gHAKhFBcOU?t=01h55m01s)

merging to master and that can get a


[01:55:04,130 --> 01:55:09,890](https://youtu.be/1gHAKhFBcOU?t=01h55m04s)

little noisy for the CI nougat packages


[01:55:07,700 --> 01:55:11,390](https://youtu.be/1gHAKhFBcOU?t=01h55m07s)

that are coming out especially when a1


[01:55:09,890 --> 01:55:13,850](https://youtu.be/1gHAKhFBcOU?t=01h55m09s)

I'm like reviewing and pulling in a


[01:55:11,390 --> 01:55:15,980](https://youtu.be/1gHAKhFBcOU?t=01h55m11s)

bunch of pull requests it'll kick off a


[01:55:13,850 --> 01:55:18,140](https://youtu.be/1gHAKhFBcOU?t=01h55m13s)

new CI package for every single one of


[01:55:15,980 --> 01:55:20,960](https://youtu.be/1gHAKhFBcOU?t=01h55m15s)

them so this will slow it down to


[01:55:18,140 --> 01:55:23,150](https://youtu.be/1gHAKhFBcOU?t=01h55m18s)

basically just nightly builds per day


[01:55:20,960 --> 01:55:24,470](https://youtu.be/1gHAKhFBcOU?t=01h55m20s)

that way if I merge something in and


[01:55:23,150 --> 01:55:26,600](https://youtu.be/1gHAKhFBcOU?t=01h55m23s)

maybe there's a bug with it that needs


[01:55:24,470 --> 01:55:28,970](https://youtu.be/1gHAKhFBcOU?t=01h55m24s)

to be fixed we don't necessarily get bad


[01:55:26,600 --> 01:55:30,950](https://youtu.be/1gHAKhFBcOU?t=01h55m26s)

packages distributed so I figured that


[01:55:28,970 --> 01:55:34,490](https://youtu.be/1gHAKhFBcOU?t=01h55m28s)

would be a little bit of a help there's


[01:55:30,950 --> 01:55:38,990](https://youtu.be/1gHAKhFBcOU?t=01h55m30s)

a approver gate to go out to nougat so


[01:55:34,490 --> 01:55:42,020](https://youtu.be/1gHAKhFBcOU?t=01h55m34s)

the idea being that this CI build ends


[01:55:38,990 --> 01:55:44,020](https://youtu.be/1gHAKhFBcOU?t=01h55m38s)

up going into these art of this


[01:55:42,020 --> 01:55:46,280](https://youtu.be/1gHAKhFBcOU?t=01h55m42s)

artifacts which is a private nougat feed


[01:55:44,020 --> 01:55:48,650](https://youtu.be/1gHAKhFBcOU?t=01h55m44s)

effectively for me to test and then


[01:55:46,280 --> 01:55:51,380](https://youtu.be/1gHAKhFBcOU?t=01h55m46s)

approve button out the door and it goes


[01:55:48,650 --> 01:55:54,860](https://youtu.be/1gHAKhFBcOU?t=01h55m48s)

out to nougat and then one more approver


[01:55:51,380 --> 01:55:58,190](https://youtu.be/1gHAKhFBcOU?t=01h55m51s)

gate to actually publish the full nougat


[01:55:54,860 --> 01:56:00,050](https://youtu.be/1gHAKhFBcOU?t=01h55m54s)

package out to new georg these things


[01:55:58,190 --> 01:56:02,420](https://youtu.be/1gHAKhFBcOU?t=01h55m58s)

are misleading names


[01:56:00,050 --> 01:56:06,980](https://youtu.be/1gHAKhFBcOU?t=01h56m00s)

it says nougat org right here but right


[01:56:02,420 --> 01:56:09,060](https://youtu.be/1gHAKhFBcOU?t=01h56m02s)

now it's tied into more private feeds on


[01:56:06,980 --> 01:56:11,760](https://youtu.be/1gHAKhFBcOU?t=01h56m06s)

this side


[01:56:09,060 --> 01:56:13,140](https://youtu.be/1gHAKhFBcOU?t=01h56m09s)

basically I'm simulating nougat org with


[01:56:11,760 --> 01:56:15,150](https://youtu.be/1gHAKhFBcOU?t=01h56m11s)

these artifacts just to make sure


[01:56:13,140 --> 01:56:17,130](https://youtu.be/1gHAKhFBcOU?t=01h56m13s)

everything's working right and then


[01:56:15,150 --> 01:56:18,870](https://youtu.be/1gHAKhFBcOU?t=01h56m15s)

ultimately I'm going to whack them and


[01:56:17,130 --> 01:56:21,870](https://youtu.be/1gHAKhFBcOU?t=01h56m17s)

switch it to actually point to nougat


[01:56:18,870 --> 01:56:24,540](https://youtu.be/1gHAKhFBcOU?t=01h56m18s)

org so just one of those like I said is


[01:56:21,870 --> 01:56:26,670](https://youtu.be/1gHAKhFBcOU?t=01h56m21s)

part of getting rid of app ver and


[01:56:24,540 --> 01:56:30,980](https://youtu.be/1gHAKhFBcOU?t=01h56m24s)

moving to DevOps


[01:56:26,670 --> 01:56:35,610](https://youtu.be/1gHAKhFBcOU?t=01h56m26s)

this whole kind of build stage pipeline


[01:56:30,980 --> 01:56:40,110](https://youtu.be/1gHAKhFBcOU?t=01h56m30s)

with this type of setup specifically


[01:56:35,610 --> 01:56:43,620](https://youtu.be/1gHAKhFBcOU?t=01h56m35s)

being able to walk individual packages


[01:56:40,110 --> 01:56:45,750](https://youtu.be/1gHAKhFBcOU?t=01h56m40s)

because just because one package works


[01:56:43,620 --> 01:56:47,310](https://youtu.be/1gHAKhFBcOU?t=01h56m43s)

its way down this line doesn't mean all


[01:56:45,750 --> 01:56:50,160](https://youtu.be/1gHAKhFBcOU?t=01h56m45s)

three of them will necessarily go at the


[01:56:47,310 --> 01:56:52,230](https://youtu.be/1gHAKhFBcOU?t=01h56m47s)

same rate so we can now Rev each of


[01:56:50,160 --> 01:56:54,240](https://youtu.be/1gHAKhFBcOU?t=01h56m50s)

these individually which will be nice so


[01:56:52,230 --> 01:56:56,790](https://youtu.be/1gHAKhFBcOU?t=01h56m52s)

for example my apps kicks out an update


[01:56:54,240 --> 01:56:58,170](https://youtu.be/1gHAKhFBcOU?t=01h56m54s)

we need to add some brushes great we can


[01:56:56,790 --> 01:57:00,660](https://youtu.be/1gHAKhFBcOU?t=01h56m56s)

just walk something through these stages


[01:56:58,170 --> 01:57:03,780](https://youtu.be/1gHAKhFBcOU?t=01h56m58s)

out the door and we're done


[01:57:00,660 --> 01:57:06,120](https://youtu.be/1gHAKhFBcOU?t=01h57m00s)

so once I'm confident that this is


[01:57:03,780 --> 01:57:08,070](https://youtu.be/1gHAKhFBcOU?t=01h57m03s)

actually working the way I expect I


[01:57:06,120 --> 01:57:11,190](https://youtu.be/1gHAKhFBcOU?t=01h57m06s)

think this will be the next the next


[01:57:08,070 --> 01:57:13,170](https://youtu.be/1gHAKhFBcOU?t=01h57m08s)

pass at making everything go so and then


[01:57:11,190 --> 01:57:15,240](https://youtu.be/1gHAKhFBcOU?t=01h57m11s)

it'll actually get tied into nougat org


[01:57:13,170 --> 01:57:17,520](https://youtu.be/1gHAKhFBcOU?t=01h57m13s)

rather than pointed at my private feeds


[01:57:15,240 --> 01:57:19,860](https://youtu.be/1gHAKhFBcOU?t=01h57m15s)

because these things I keep every time


[01:57:17,520 --> 01:57:22,290](https://youtu.be/1gHAKhFBcOU?t=01h57m17s)

there's an issue with it I don't want to


[01:57:19,860 --> 01:57:24,900](https://youtu.be/1gHAKhFBcOU?t=01h57m19s)

necessarily spam nougat org with my my


[01:57:22,290 --> 01:57:27,180](https://youtu.be/1gHAKhFBcOU?t=01h57m22s)

bad versioning or bugs that I've gone


[01:57:24,900 --> 01:57:29,490](https://youtu.be/1gHAKhFBcOU?t=01h57m24s)

through so once this is all stable and


[01:57:27,180 --> 01:57:32,010](https://youtu.be/1gHAKhFBcOU?t=01h57m27s)

and running hopefully it should work so


[01:57:29,490 --> 01:57:34,800](https://youtu.be/1gHAKhFBcOU?t=01h57m29s)

this has been a fun thing for me of


[01:57:32,010 --> 01:57:39,450](https://youtu.be/1gHAKhFBcOU?t=01h57m32s)

doing a bunch of DevOps stuff so and


[01:57:34,800 --> 01:57:47,040](https://youtu.be/1gHAKhFBcOU?t=01h57m34s)

this all checks passed great squash and


[01:57:39,450 --> 01:57:50,070](https://youtu.be/1gHAKhFBcOU?t=01h57m39s)

merge this won't be aware the app fair


[01:57:47,040 --> 01:57:54,870](https://youtu.be/1gHAKhFBcOU?t=01h57m47s)

isn't kicking out builds for the MA


[01:57:50,070 --> 01:57:57,840](https://youtu.be/1gHAKhFBcOU?t=01h57m50s)

apps for the MA apps NuGet package right


[01:57:54,870 --> 01:58:00,270](https://youtu.be/1gHAKhFBcOU?t=01h57m54s)

now so I will look at addressing that


[01:57:57,840 --> 01:58:02,430](https://youtu.be/1gHAKhFBcOU?t=01h57m57s)

and getting a new preview package up for


[01:58:00,270 --> 01:58:05,880](https://youtu.be/1gHAKhFBcOU?t=01h58m00s)

this library so that it's not broken for


[01:58:02,430 --> 01:58:08,190](https://youtu.be/1gHAKhFBcOU?t=01h58m02s)

everybody because it it needs to affect


[01:58:05,880 --> 01:58:09,900](https://youtu.be/1gHAKhFBcOU?t=01h58m05s)

both the colors and the MA apps packages


[01:58:08,190 --> 01:58:11,850](https://youtu.be/1gHAKhFBcOU?t=01h58m08s)

as well so I'll make sure that those get


[01:58:09,900 --> 01:58:15,210](https://youtu.be/1gHAKhFBcOU?t=01h58m09s)

updated on nougat org and the next day


[01:58:11,850 --> 01:58:16,830](https://youtu.be/1gHAKhFBcOU?t=01h58m11s)

or two so those will be those will be


[01:58:15,210 --> 01:58:19,050](https://youtu.be/1gHAKhFBcOU?t=01h58m15s)

going but just be aware that the stuff


[01:58:16,830 --> 01:58:20,790](https://youtu.be/1gHAKhFBcOU?t=01h58m16s)

that's sitting out on new georg right


[01:58:19,050 --> 01:58:22,739](https://youtu.be/1gHAKhFBcOU?t=01h58m19s)

now if you have the latest you are


[01:58:20,790 --> 01:58:24,809](https://youtu.be/1gHAKhFBcOU?t=01h58m20s)

probably going to be broken so


[01:58:22,739 --> 01:58:28,050](https://youtu.be/1gHAKhFBcOU?t=01h58m22s)

grab a package that's earlier than say


[01:58:24,809 --> 01:58:31,739](https://youtu.be/1gHAKhFBcOU?t=01h58m24s)

Sunday so for those people who aren't in


[01:58:28,050 --> 01:58:32,489](https://youtu.be/1gHAKhFBcOU?t=01h58m28s)

my time something before the 7th and you


[01:58:31,739 --> 01:58:34,409](https://youtu.be/1gHAKhFBcOU?t=01h58m31s)

should be fine


[01:58:32,489 --> 01:58:40,079](https://youtu.be/1gHAKhFBcOU?t=01h58m32s)

because I think the seventh is when I


[01:58:34,409 --> 01:58:41,460](https://youtu.be/1gHAKhFBcOU?t=01h58m34s)

was making changes ok with that I think


[01:58:40,079 --> 01:58:43,980](https://youtu.be/1gHAKhFBcOU?t=01h58m40s)

I've reached about my two-hour mark


[01:58:41,460 --> 01:58:45,329](https://youtu.be/1gHAKhFBcOU?t=01h58m41s)

hopefully this was helpful it made me


[01:58:43,980 --> 01:58:48,929](https://youtu.be/1gHAKhFBcOU?t=01h58m43s)

feel better to be able to catch these


[01:58:45,329 --> 01:58:51,690](https://youtu.be/1gHAKhFBcOU?t=01h58m45s)

bugs thank you guys for dropping in and


[01:58:48,929 --> 01:58:53,190](https://youtu.be/1gHAKhFBcOU?t=01h58m48s)

we will be planning on doing this again


[01:58:51,690 --> 01:58:54,869](https://youtu.be/1gHAKhFBcOU?t=01h58m51s)

next week if there are things that


[01:58:53,190 --> 01:58:58,519](https://youtu.be/1gHAKhFBcOU?t=01h58m53s)

people are interested in seen or


[01:58:54,869 --> 01:59:01,739](https://youtu.be/1gHAKhFBcOU?t=01h58m54s)

examples I think I'm probably going to


[01:58:58,519 --> 01:59:05,840](https://youtu.be/1gHAKhFBcOU?t=01h58m58s)

potentially start in on doing some


[01:59:01,739 --> 01:59:08,309](https://youtu.be/1gHAKhFBcOU?t=01h59m01s)

examples on WPF and mvvm next


[01:59:05,840 --> 01:59:10,340](https://youtu.be/1gHAKhFBcOU?t=01h59m05s)

specifically using this library but I


[01:59:08,309 --> 01:59:13,260](https://youtu.be/1gHAKhFBcOU?t=01h59m08s)

think next week might be a little more


[01:59:10,340 --> 01:59:16,309](https://youtu.be/1gHAKhFBcOU?t=01h59m10s)

WPF generic rather than material design


[01:59:13,260 --> 01:59:18,389](https://youtu.be/1gHAKhFBcOU?t=01h59m13s)

specific so we'll see how that goes


[01:59:16,309 --> 01:59:20,190](https://youtu.be/1gHAKhFBcOU?t=01h59m16s)

again if people have other things that


[01:59:18,389 --> 01:59:22,289](https://youtu.be/1gHAKhFBcOU?t=01h59m18s)

you want to see or examples or questions


[01:59:20,190 --> 01:59:24,659](https://youtu.be/1gHAKhFBcOU?t=01h59m20s)

feel free to just shoot them over to me


[01:59:22,289 --> 01:59:26,519](https://youtu.be/1gHAKhFBcOU?t=01h59m22s)

you can either comment on videos or


[01:59:24,659 --> 01:59:28,769](https://youtu.be/1gHAKhFBcOU?t=01h59m24s)

something on the git er chat usually


[01:59:26,519 --> 01:59:32,219](https://youtu.be/1gHAKhFBcOU?t=01h59m26s)

gets to me pretty quick and we will go


[01:59:28,769 --> 01:59:34,710](https://youtu.be/1gHAKhFBcOU?t=01h59m28s)

from there so with that say goodnight


[01:59:32,219 --> 01:59:36,829](https://youtu.be/1gHAKhFBcOU?t=01h59m32s)

happy coding guys and thanks for hanging


[01:59:34,710 --> 01:59:36,829](https://youtu.be/1gHAKhFBcOU?t=01h59m34s)

out

