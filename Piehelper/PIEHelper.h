
#pragma warning( disable: 4049 )  /* more than 64k source lines */

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 5.03.0286 */
/* at Mon Mar 08 18:40:13 2010
 */
/* Compiler settings for .\PIEHelper.idl:
    Oicf (OptLev=i2), W1, Zp8, env=Win32 (32b run), ms_ext, c_ext
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
//@@MIDL_FILE_HEADING(  )


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 440
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __PIEHelper_h__
#define __PIEHelper_h__

/* Forward Declarations */ 

#ifndef __IIEHlprObj_FWD_DEFINED__
#define __IIEHlprObj_FWD_DEFINED__
typedef interface IIEHlprObj IIEHlprObj;
#endif 	/* __IIEHlprObj_FWD_DEFINED__ */


#ifndef __IEHlprObj_FWD_DEFINED__
#define __IEHlprObj_FWD_DEFINED__

#ifdef __cplusplus
typedef class IEHlprObj IEHlprObj;
#else
typedef struct IEHlprObj IEHlprObj;
#endif /* __cplusplus */

#endif 	/* __IEHlprObj_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

#ifdef __cplusplus
extern "C"{
#endif 

void __RPC_FAR * __RPC_USER MIDL_user_allocate(size_t);
void __RPC_USER MIDL_user_free( void __RPC_FAR * ); 

#ifndef __IIEHlprObj_INTERFACE_DEFINED__
#define __IIEHlprObj_INTERFACE_DEFINED__

/* interface IIEHlprObj */
/* [unique][helpstring][uuid][object] */ 


EXTERN_C const IID IID_IIEHlprObj;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("C1B27B94-DBAF-48F3-A3E0-C87035131E9D")
    IIEHlprObj : public IUnknown
    {
    public:
    };
    
#else 	/* C style interface */

    typedef struct IIEHlprObjVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE __RPC_FAR *QueryInterface )( 
            IIEHlprObj __RPC_FAR * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void __RPC_FAR *__RPC_FAR *ppvObject);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *AddRef )( 
            IIEHlprObj __RPC_FAR * This);
        
        ULONG ( STDMETHODCALLTYPE __RPC_FAR *Release )( 
            IIEHlprObj __RPC_FAR * This);
        
        END_INTERFACE
    } IIEHlprObjVtbl;

    interface IIEHlprObj
    {
        CONST_VTBL struct IIEHlprObjVtbl __RPC_FAR *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IIEHlprObj_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define IIEHlprObj_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define IIEHlprObj_Release(This)	\
    (This)->lpVtbl -> Release(This)


#endif /* COBJMACROS */


#endif 	/* C style interface */




#endif 	/* __IIEHlprObj_INTERFACE_DEFINED__ */



#ifndef __IEHELPERLib_LIBRARY_DEFINED__
#define __IEHELPERLib_LIBRARY_DEFINED__

/* library IEHELPERLib */
/* [helpstring][version][uuid] */ 


EXTERN_C const IID LIBID_IEHELPERLib;

EXTERN_C const CLSID CLSID_IEHlprObj;

#ifdef __cplusplus

class DECLSPEC_UUID("93AFDD66-D450-42F5-9997-1E58C5582292")
IEHlprObj;
#endif
#endif /* __IEHELPERLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


