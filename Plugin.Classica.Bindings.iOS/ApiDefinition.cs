using System;
using Foundation;
using ObjCRuntime;

namespace Plugin.Classica.Bindings.iOS
{
	// @interface Music : NSObject
	[BaseType (typeof(NSObject))]
	interface Music
	{
		// @property (readonly, assign, nonatomic) NSInteger id;
		[Export ("id")]
		int Id { get; }

		// @property (readonly, assign, nonatomic) NSInteger composerId;
		[Export ("composerId")]
		int ComposerId { get; }

		// @property (readonly, nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// @property (readonly, assign, nonatomic) NSInteger year;
		[Export ("year")]
		int Year { get; }

		// @property (readonly, nonatomic, strong) NSString * opusNumber;
		[Export ("opusNumber", ArgumentSemantic.Strong)]
		string OpusNumber { get; }

		// -(instancetype)initWithId:(NSInteger)id composerId:(NSInteger)composerId name:(NSString *)name year:(NSInteger)year opusNumber:(NSString *)opusNumber;
		[Export ("initWithId:composerId:name:year:opusNumber:")]
		Music Constructor (nint id, nint composerId, string name, nint year, string opusNumber);
	}

	// @interface Composer : NSObject
	[BaseType (typeof(NSObject))]
	interface Composer
	{
		// @property (readonly, assign, nonatomic) NSInteger id;
		[Export ("id")]
		int Id { get; }

		// @property (readonly, nonatomic, strong) NSString * name;
		[Export ("name", ArgumentSemantic.Strong)]
		string Name { get; }

		// @property (readonly, assign, nonatomic) NSInteger birth;
		[Export ("birth")]
		int Birth { get; }

		// @property (readonly, assign, nonatomic) NSInteger death;
		[Export ("death")]
		int Death { get; }

		// @property (readonly, assign, nonatomic) NSArray * musics;
		[Export ("musics", ArgumentSemantic.Assign)]
		//[Verify (StronglyTypedNSArray)]
		Music[] Musics { get; }

		// -(instancetype)initWithId:(NSInteger)id name:(NSString *)name birth:(NSInteger)birth death:(NSInteger)death musics:(NSArray *)musics;
		[Export ("initWithId:name:birth:death:musics:")]
		//[Verify (StronglyTypedNSArray)]
		Composer Constructor (nint id, string name, nint birth, nint death, NSObject[] musics);
	}

	// @interface Classica : NSObject
	[BaseType (typeof(NSObject))]
	interface Classica
	{
		// @property (nonatomic, strong) NSArray * musics;
		[Export ("musics", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		Music[] Musics { get; set; }

		// @property (nonatomic, strong) NSArray * composers;
		[Export ("composers", ArgumentSemantic.Strong)]
		//[Verify (StronglyTypedNSArray)]
		Composer[] Composers { get; set; }

		// -(Composer *)getComposer:(NSInteger)id;
		[Export ("getComposer:")]
		Composer GetComposer (nint id);

		// -(Music *)getMusic:(NSInteger)id;
		[Export ("getMusic:")]
		Music GetMusic (nint id);
	}

	// @interface Music (Composer)
	[Category]
	[BaseType (typeof(Composer))]
	interface Composer_Music
	{
		// -(NSArray *)musicNames;
		[Export("musicNames")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		string[] GetMusicNames();
	}
}
