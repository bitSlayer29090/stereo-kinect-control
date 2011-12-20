

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 7.00.0500 */
/* at Tue Dec 20 17:01:31 2011
 */
/* Compiler settings for StereoPlayer.IDL:
    Oicf, W1, Zp8, env=Win32 (32b run)
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
//@@MIDL_FILE_HEADING(  )

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__


#ifndef __stereoplayer_h__
#define __stereoplayer_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __Automation_FWD_DEFINED__
#define __Automation_FWD_DEFINED__

#ifdef __cplusplus
typedef class Automation Automation;
#else
typedef struct Automation Automation;
#endif /* __cplusplus */

#endif 	/* __Automation_FWD_DEFINED__ */


#ifndef __IAutomation_FWD_DEFINED__
#define __IAutomation_FWD_DEFINED__
typedef interface IAutomation IAutomation;
#endif 	/* __IAutomation_FWD_DEFINED__ */


#ifdef __cplusplus
extern "C"{
#endif 


/* interface __MIDL_itf_StereoPlayer_0000_0000 */
/* [local] */ 

typedef /* [public][public][version][uuid] */  DECLSPEC_UUID("44C1616D-FBE8-415D-869C-6D113C780C7F") 
enum __MIDL___MIDL_itf_StereoPlayer_0000_0000_0001
    {	PlaybackState_Play	= 0,
	PlaybackState_Pause	= 1,
	PlaybackState_Stop	= 2,
	PlaybackState_FastForward	= 3,
	PlaybackState_FastBackward	= 4
    } 	PlaybackState;

typedef /* [public][public][version][uuid] */  DECLSPEC_UUID("9D79E9CE-E2EC-423D-846C-17B887E6CD3E") 
enum __MIDL___MIDL_itf_StereoPlayer_0000_0000_0002
    {	AudioMode_NoAudio	= 0,
	AudioMode_SeparateFile	= 1,
	AudioMode_LeftFile	= 2,
	AudioMode_RightFile	= 3
    } 	AudioMode;

typedef /* [public][version][uuid] */  DECLSPEC_UUID("36F2BF51-D29E-498C-AFEA-BFCE002AE1AF") 
enum __MIDL___MIDL_itf_StereoPlayer_0000_0000_0003
    {	PlaybackMode_File	= 1,
	PlaybackMode_LeftRightFiles	= 2,
	PlaybackMode_DVD	= 3,
	PlaybackMode_URL	= 4,
	PlaybackMode_Device	= 5,
	PlaybackMode_None	= 0
    } 	PlaybackMode;



extern RPC_IF_HANDLE __MIDL_itf_StereoPlayer_0000_0000_v0_0_c_ifspec;
extern RPC_IF_HANDLE __MIDL_itf_StereoPlayer_0000_0000_v0_0_s_ifspec;


#ifndef __StereoPlayer_LIBRARY_DEFINED__
#define __StereoPlayer_LIBRARY_DEFINED__

/* library StereoPlayer */
/* [helpstring][version][uuid] */ 



EXTERN_C const IID LIBID_StereoPlayer;

#ifndef __IAutomation_INTERFACE_DEFINED__
#define __IAutomation_INTERFACE_DEFINED__

/* interface IAutomation */
/* [object][oleautomation][dual][helpstring][version][uuid] */ 


EXTERN_C const IID IID_IAutomation;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("54150FC5-F6D5-419A-BC0D-E2BE08558934")
    IAutomation : public IDispatch
    {
    public:
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetPlaylistItemCount( 
            /* [out] */ VARIANT *Count) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetPlaylistItem( 
            /* [out] */ VARIANT *Index) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE SetPlaylistItem( 
            /* [in] */ long Index) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE NextPlaylistItem( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE PreviousPlaylistItem( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE OpenFile( 
            /* [in] */ BSTR Filename) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE OpenLeftRightFiles( 
            /* [in] */ BSTR LeftFilename,
            /* [in] */ BSTR RightFilename,
            /* [in] */ BSTR AudioFilename,
            /* [in] */ AudioMode AudioMode) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE OpenDVD( 
            /* [in] */ BSTR Path) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE OpenURL( 
            /* [in] */ BSTR URL) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE OpenDevice( 
            /* [in] */ BSTR Device) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetPlaybackState( 
            /* [out] */ VARIANT *State) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE SetPlaybackState( 
            /* [in] */ PlaybackState State) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetPlaybackCompleted( 
            /* [out] */ VARIANT *Completed) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetDuration( 
            /* [out] */ VARIANT *Duration) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetPosition( 
            /* [out] */ VARIANT *Position) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetPlaybackMode( 
            /* [out] */ VARIANT *Mode) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE SetPosition( 
            /* [in] */ double Position) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetRepeat( 
            /* [out] */ VARIANT *RepeatMode) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE SetRepeat( 
            /* [in] */ VARIANT_BOOL RepeatMode) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE CloseVideo( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE ClosePlayer( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE EnterFullscreenMode( 
            /* [in] */ VARIANT_BOOL Scaled) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE LeaveFullscreenMode( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetReady( 
            /* [out] */ VARIANT *Ready) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetVolume( 
            /* [out] */ VARIANT *Volume) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE SetVolume( 
            /* [in] */ double Volume) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE SetParallaxHorizontal( 
            /* [in] */ long Parallax) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE SetParallaxVertical( 
            /* [in] */ long Parallax) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE SetParallax( 
            /* [in] */ long Horizontal,
            /* [in] */ long Vertical) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetZoom( 
            /* [out] */ VARIANT *Zoom) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE SetZoom( 
            /* [in] */ double Zoom) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE NextChapter( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE PreviousChapter( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE NextFileInFolder( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE PreviousFileInFolder( void) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE GetPlayFolder( 
            /* [out] */ VARIANT *PlayFolderMode) = 0;
        
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE SetPlayFolder( 
            /* [in] */ VARIANT_BOOL PlayFolderMode) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE GetViewingMethod( 
            /* [out] */ VARIANT *ViewingMethod) = 0;
        
        virtual /* [id] */ HRESULT STDMETHODCALLTYPE SetViewingMethod( 
            /* [in] */ BSTR ViewingMethod) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct IAutomationVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IAutomation * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ 
            __RPC__deref_out  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IAutomation * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IAutomation * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            IAutomation * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            IAutomation * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            IAutomation * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            IAutomation * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS *pDispParams,
            /* [out] */ VARIANT *pVarResult,
            /* [out] */ EXCEPINFO *pExcepInfo,
            /* [out] */ UINT *puArgErr);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *GetPlaylistItemCount )( 
            IAutomation * This,
            /* [out] */ VARIANT *Count);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *GetPlaylistItem )( 
            IAutomation * This,
            /* [out] */ VARIANT *Index);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *SetPlaylistItem )( 
            IAutomation * This,
            /* [in] */ long Index);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *NextPlaylistItem )( 
            IAutomation * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *PreviousPlaylistItem )( 
            IAutomation * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *OpenFile )( 
            IAutomation * This,
            /* [in] */ BSTR Filename);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *OpenLeftRightFiles )( 
            IAutomation * This,
            /* [in] */ BSTR LeftFilename,
            /* [in] */ BSTR RightFilename,
            /* [in] */ BSTR AudioFilename,
            /* [in] */ AudioMode AudioMode);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *OpenDVD )( 
            IAutomation * This,
            /* [in] */ BSTR Path);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *OpenURL )( 
            IAutomation * This,
            /* [in] */ BSTR URL);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *OpenDevice )( 
            IAutomation * This,
            /* [in] */ BSTR Device);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *GetPlaybackState )( 
            IAutomation * This,
            /* [out] */ VARIANT *State);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *SetPlaybackState )( 
            IAutomation * This,
            /* [in] */ PlaybackState State);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *GetPlaybackCompleted )( 
            IAutomation * This,
            /* [out] */ VARIANT *Completed);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *GetDuration )( 
            IAutomation * This,
            /* [out] */ VARIANT *Duration);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *GetPosition )( 
            IAutomation * This,
            /* [out] */ VARIANT *Position);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *GetPlaybackMode )( 
            IAutomation * This,
            /* [out] */ VARIANT *Mode);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *SetPosition )( 
            IAutomation * This,
            /* [in] */ double Position);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *GetRepeat )( 
            IAutomation * This,
            /* [out] */ VARIANT *RepeatMode);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *SetRepeat )( 
            IAutomation * This,
            /* [in] */ VARIANT_BOOL RepeatMode);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *CloseVideo )( 
            IAutomation * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *ClosePlayer )( 
            IAutomation * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *EnterFullscreenMode )( 
            IAutomation * This,
            /* [in] */ VARIANT_BOOL Scaled);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *LeaveFullscreenMode )( 
            IAutomation * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *GetReady )( 
            IAutomation * This,
            /* [out] */ VARIANT *Ready);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *GetVolume )( 
            IAutomation * This,
            /* [out] */ VARIANT *Volume);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *SetVolume )( 
            IAutomation * This,
            /* [in] */ double Volume);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *SetParallaxHorizontal )( 
            IAutomation * This,
            /* [in] */ long Parallax);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *SetParallaxVertical )( 
            IAutomation * This,
            /* [in] */ long Parallax);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *SetParallax )( 
            IAutomation * This,
            /* [in] */ long Horizontal,
            /* [in] */ long Vertical);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *GetZoom )( 
            IAutomation * This,
            /* [out] */ VARIANT *Zoom);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *SetZoom )( 
            IAutomation * This,
            /* [in] */ double Zoom);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *NextChapter )( 
            IAutomation * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *PreviousChapter )( 
            IAutomation * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *NextFileInFolder )( 
            IAutomation * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *PreviousFileInFolder )( 
            IAutomation * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *GetPlayFolder )( 
            IAutomation * This,
            /* [out] */ VARIANT *PlayFolderMode);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *SetPlayFolder )( 
            IAutomation * This,
            /* [in] */ VARIANT_BOOL PlayFolderMode);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *GetViewingMethod )( 
            IAutomation * This,
            /* [out] */ VARIANT *ViewingMethod);
        
        /* [id] */ HRESULT ( STDMETHODCALLTYPE *SetViewingMethod )( 
            IAutomation * This,
            /* [in] */ BSTR ViewingMethod);
        
        END_INTERFACE
    } IAutomationVtbl;

    interface IAutomation
    {
        CONST_VTBL struct IAutomationVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IAutomation_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define IAutomation_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define IAutomation_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define IAutomation_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define IAutomation_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define IAutomation_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define IAutomation_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 


#define IAutomation_GetPlaylistItemCount(This,Count)	\
    ( (This)->lpVtbl -> GetPlaylistItemCount(This,Count) ) 

#define IAutomation_GetPlaylistItem(This,Index)	\
    ( (This)->lpVtbl -> GetPlaylistItem(This,Index) ) 

#define IAutomation_SetPlaylistItem(This,Index)	\
    ( (This)->lpVtbl -> SetPlaylistItem(This,Index) ) 

#define IAutomation_NextPlaylistItem(This)	\
    ( (This)->lpVtbl -> NextPlaylistItem(This) ) 

#define IAutomation_PreviousPlaylistItem(This)	\
    ( (This)->lpVtbl -> PreviousPlaylistItem(This) ) 

#define IAutomation_OpenFile(This,Filename)	\
    ( (This)->lpVtbl -> OpenFile(This,Filename) ) 

#define IAutomation_OpenLeftRightFiles(This,LeftFilename,RightFilename,AudioFilename,AudioMode)	\
    ( (This)->lpVtbl -> OpenLeftRightFiles(This,LeftFilename,RightFilename,AudioFilename,AudioMode) ) 

#define IAutomation_OpenDVD(This,Path)	\
    ( (This)->lpVtbl -> OpenDVD(This,Path) ) 

#define IAutomation_OpenURL(This,URL)	\
    ( (This)->lpVtbl -> OpenURL(This,URL) ) 

#define IAutomation_OpenDevice(This,Device)	\
    ( (This)->lpVtbl -> OpenDevice(This,Device) ) 

#define IAutomation_GetPlaybackState(This,State)	\
    ( (This)->lpVtbl -> GetPlaybackState(This,State) ) 

#define IAutomation_SetPlaybackState(This,State)	\
    ( (This)->lpVtbl -> SetPlaybackState(This,State) ) 

#define IAutomation_GetPlaybackCompleted(This,Completed)	\
    ( (This)->lpVtbl -> GetPlaybackCompleted(This,Completed) ) 

#define IAutomation_GetDuration(This,Duration)	\
    ( (This)->lpVtbl -> GetDuration(This,Duration) ) 

#define IAutomation_GetPosition(This,Position)	\
    ( (This)->lpVtbl -> GetPosition(This,Position) ) 

#define IAutomation_GetPlaybackMode(This,Mode)	\
    ( (This)->lpVtbl -> GetPlaybackMode(This,Mode) ) 

#define IAutomation_SetPosition(This,Position)	\
    ( (This)->lpVtbl -> SetPosition(This,Position) ) 

#define IAutomation_GetRepeat(This,RepeatMode)	\
    ( (This)->lpVtbl -> GetRepeat(This,RepeatMode) ) 

#define IAutomation_SetRepeat(This,RepeatMode)	\
    ( (This)->lpVtbl -> SetRepeat(This,RepeatMode) ) 

#define IAutomation_CloseVideo(This)	\
    ( (This)->lpVtbl -> CloseVideo(This) ) 

#define IAutomation_ClosePlayer(This)	\
    ( (This)->lpVtbl -> ClosePlayer(This) ) 

#define IAutomation_EnterFullscreenMode(This,Scaled)	\
    ( (This)->lpVtbl -> EnterFullscreenMode(This,Scaled) ) 

#define IAutomation_LeaveFullscreenMode(This)	\
    ( (This)->lpVtbl -> LeaveFullscreenMode(This) ) 

#define IAutomation_GetReady(This,Ready)	\
    ( (This)->lpVtbl -> GetReady(This,Ready) ) 

#define IAutomation_GetVolume(This,Volume)	\
    ( (This)->lpVtbl -> GetVolume(This,Volume) ) 

#define IAutomation_SetVolume(This,Volume)	\
    ( (This)->lpVtbl -> SetVolume(This,Volume) ) 

#define IAutomation_SetParallaxHorizontal(This,Parallax)	\
    ( (This)->lpVtbl -> SetParallaxHorizontal(This,Parallax) ) 

#define IAutomation_SetParallaxVertical(This,Parallax)	\
    ( (This)->lpVtbl -> SetParallaxVertical(This,Parallax) ) 

#define IAutomation_SetParallax(This,Horizontal,Vertical)	\
    ( (This)->lpVtbl -> SetParallax(This,Horizontal,Vertical) ) 

#define IAutomation_GetZoom(This,Zoom)	\
    ( (This)->lpVtbl -> GetZoom(This,Zoom) ) 

#define IAutomation_SetZoom(This,Zoom)	\
    ( (This)->lpVtbl -> SetZoom(This,Zoom) ) 

#define IAutomation_NextChapter(This)	\
    ( (This)->lpVtbl -> NextChapter(This) ) 

#define IAutomation_PreviousChapter(This)	\
    ( (This)->lpVtbl -> PreviousChapter(This) ) 

#define IAutomation_NextFileInFolder(This)	\
    ( (This)->lpVtbl -> NextFileInFolder(This) ) 

#define IAutomation_PreviousFileInFolder(This)	\
    ( (This)->lpVtbl -> PreviousFileInFolder(This) ) 

#define IAutomation_GetPlayFolder(This,PlayFolderMode)	\
    ( (This)->lpVtbl -> GetPlayFolder(This,PlayFolderMode) ) 

#define IAutomation_SetPlayFolder(This,PlayFolderMode)	\
    ( (This)->lpVtbl -> SetPlayFolder(This,PlayFolderMode) ) 

#define IAutomation_GetViewingMethod(This,ViewingMethod)	\
    ( (This)->lpVtbl -> GetViewingMethod(This,ViewingMethod) ) 

#define IAutomation_SetViewingMethod(This,ViewingMethod)	\
    ( (This)->lpVtbl -> SetViewingMethod(This,ViewingMethod) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IAutomation_INTERFACE_DEFINED__ */

#endif /* __StereoPlayer_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


