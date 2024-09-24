# Read me

## List buckt

Request
* Bucket: default

```
GET http://localhost:8000/default/?list-type=2 HTTP/1.1
User-Agent: aws-sdk-dotnet-coreclr/3.7.202.1 aws-sdk-dotnet-core/3.7.201.1 .NET_Core/8.0.8 OS/Microsoft_Windows_10.0.19045 ClientAsync
amz-sdk-invocation-id: 0559d410-6561-4591-9112-e454f74e881e
amz-sdk-request: attempt=4; max=5
Host: localhost:8000
X-Amz-Date: 20240924T053514Z
X-Amz-Content-SHA256: e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855
Authorization: AWS4-HMAC-SHA256 Credential=AKIAIOSFODNN7EXAMPLE/20240924/us-east-1/s3/aws4_request, SignedHeaders=host;user-agent;x-amz-content-sha256;x-amz-date, Signature=7d9b437f02a0bed3d0fff328cf2f1a624615b7aa79e987ae5e27c6d67737d0ee
```

Response

```
HTTP/1.1 200 OK
Cache-Control: no-cache
Content-Length: 681
Content-Type: application/xml
Server: S3Server Microsoft-HTTPAPI/2.0
x-amz-request-id: ampvUk03eVpva3FNSGx3QTl6U3EwZz09
x-amz-id-2: ZnNkME5aVVhBME84UXZWMDNYRmt4Zz09
x-amz-bucket-region: us-west-1
X-Amz-Date: Tue, 24 Sep 2024 05:35:15 GMT
Host: localhost
Access-Control-Allow-Origin: *
Access-Control-Allow-Methods: OPTIONS, HEAD, GET, PUT, POST, DELETE, PATCH
Access-Control-Allow-Headers: *
Access-Control-Expose-Headers: 
Accept: */*
Accept-Language: en-US, en
Accept-Charset: ISO-8859-1, utf-8
Date: Tue, 24 Sep 2024 05:35:15 GMT
Connection: close

<?xml version="1.0" encoding="iso-8859-1"?><ListBucketResult xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"><Name>default</Name><Prefix></Prefix><KeyCount>1</KeyCount><MaxKeys>1000</MaxKeys><Delimiter>/</Delimiter><EncodingType>url</EncodingType><IsTruncated>false</IsTruncated><Contents><Key>hello.txt</Key><LastModified>2024-09-24T13:35:11.9282169+08:00</LastModified><ETag>"etag"</ETag><ContentType>application/octet-stream</ContentType><Size>13</Size><StorageClass>STANDARD</StorageClass><Owner><ID>admin</ID><DisplayName>Administrator</DisplayName></Owner></Contents><BucketRegion>us-west-1</BucketRegion></ListBucketResult>
```

The XML as folloe:

```xml
<?xml version="1.0" encoding="iso-8859-1"?>
<ListBucketResult xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
    xmlns:xsd="http://www.w3.org/2001/XMLSchema">
    <Name>default</Name>
    <Prefix></Prefix>
    <KeyCount>1</KeyCount>
    <MaxKeys>1000</MaxKeys>
    <Delimiter>/</Delimiter>
    <EncodingType>url</EncodingType>
    <IsTruncated>false</IsTruncated>
    <Contents>
        <Key>hello.txt</Key>
        <LastModified>2024-09-24T13:35:11.9282169+08:00</LastModified>
        <ETag>"etag"</ETag>
        <ContentType>application/octet-stream</ContentType>
        <Size>13</Size>
        <StorageClass>STANDARD</StorageClass>
        <Owner>
            <ID>admin</ID>
            <DisplayName>Administrator</DisplayName>
        </Owner>
    </Contents>
    <BucketRegion>us-west-1</BucketRegion>
</ListBucketResult>
```

## upload new object

Request
* Bucket: default
* Key: text.txt
* Content: 0987654321

```
PUT http://localhost:8000/default/test.txt HTTP/1.1
Expect: 100-continue
User-Agent: aws-sdk-dotnet-coreclr/3.7.202.1 aws-sdk-dotnet-core/3.7.201.1 .NET_Core/8.0.8 OS/Microsoft_Windows_10.0.19045 ClientAsync
amz-sdk-invocation-id: af82ccb0-5bba-41c3-aa54-2a6ef3fc4bca
amz-sdk-request: attempt=1; max=5
Host: localhost:8000
X-Amz-Date: 20240924T053530Z
X-Amz-Decoded-Content-Length: 10
X-Amz-Content-SHA256: STREAMING-AWS4-HMAC-SHA256-PAYLOAD
Authorization: AWS4-HMAC-SHA256 Credential=AKIAIOSFODNN7EXAMPLE/20240924/us-east-1/s3/aws4_request, SignedHeaders=content-length;content-type;host;user-agent;x-amz-content-sha256;x-amz-date;x-amz-decoded-content-length, Signature=ac43bd9ed2e080a642420790bed40d741877d7450a80f845e444ce5e113467f9
Content-Length: 182
Content-Type: application/octet-stream

A;chunk-signature=dee546dc8e59a5e635f709bd3bbf8d1748968050d6cca8e6b01d3b274088c3e1
0987654321
0;chunk-signature=38f5024cdeebeb3cf4e72d7ac3a1c64770f5f99b3e583faaf2c65e8c2da4d345

```

Response

```
HTTP/1.1 200 OK
Cache-Control: no-cache
Content-Length: 0
Content-Type: text/plain
Server: S3Server Microsoft-HTTPAPI/2.0
x-amz-request-id: L2pXMmxQR0JZRXEvZS9YeUh4SWF0Zz09
x-amz-id-2: ZVYyUmJBN2NQMDZIZ21aR05lWVlwdz09
X-Amz-Date: Tue, 24 Sep 2024 05:35:31 GMT
Host: localhost
Access-Control-Allow-Origin: *
Access-Control-Allow-Methods: OPTIONS, HEAD, GET, PUT, POST, DELETE, PATCH
Access-Control-Allow-Headers: *
Access-Control-Expose-Headers: 
Accept: */*
Accept-Language: en-US, en
Accept-Charset: ISO-8859-1, utf-8
Date: Tue, 24 Sep 2024 05:35:31 GMT
Connection: close
```

## Read object

Request
* Bucket: defulat
* Key: hello.txt

```
GET http://localhost:8000/default/hello.txt HTTP/1.1
User-Agent: aws-sdk-dotnet-coreclr/3.7.202.1 aws-sdk-dotnet-core/3.7.201.1 .NET_Core/8.0.8 OS/Microsoft_Windows_10.0.19045 ClientAsync
amz-sdk-invocation-id: 00a8d8b1-0dc6-4b08-9393-34b9bc9e757a
amz-sdk-request: attempt=1; max=5
Host: localhost:8000
X-Amz-Date: 20240924T054442Z
X-Amz-Content-SHA256: e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855
Authorization: AWS4-HMAC-SHA256 Credential=AKIAIOSFODNN7EXAMPLE/20240924/us-east-1/s3/aws4_request, SignedHeaders=host;user-agent;x-amz-content-sha256;x-amz-date, Signature=fc2dec1787b067149d5b435e76e2bbec1147e92df7961b98f64f3c90385a81c4


```

Response

```
HTTP/1.1 200 OK
Cache-Control: no-cache
Content-Length: 13
Content-Type: text/plain
Last-Modified: Tue, 24 Sep 2024 13:44:42 GMT
Accept-Ranges: bytes
ETag: "etag"
Server: S3Server Microsoft-HTTPAPI/2.0
x-amz-request-id: VU5RR0EvdkVERUNjS2c3NUVWd29tQT09
x-amz-id-2: aWNZUTlTRXVERW11RXZFNTM3STN4QT09
x-amz-storage-class: STANDARD
X-Amz-Date: Tue, 24 Sep 2024 05:44:42 GMT
Host: localhost
Access-Control-Allow-Origin: *
Access-Control-Allow-Methods: OPTIONS, HEAD, GET, PUT, POST, DELETE, PATCH
Access-Control-Allow-Headers: *
Access-Control-Expose-Headers: 
Accept: */*
Accept-Language: en-US, en
Accept-Charset: ISO-8859-1, utf-8
Date: Tue, 24 Sep 2024 05:44:42 GMT
Connection: close

Hello, world!
```
