# Lambda dotnet invoke

This project contains a simple AWS Lambda using dotnet as a runtime, SAM for local invoke and write to dynamodb.

## Building the Project

To build the project, navigate to the `src` directory and run:

``` bash
dotnet build
```


## Deploying the Lambda Function

To deploy the Lambda function, use the AWS CLI with the following command:

```bash
aws lambda create-function \
    --function-name <lambda_name> \
    --runtime dotnet6 \
    --handler <assembly::namespace.class::function> \
    --zip-file fileb://<zip_file> \
    --role <role_arn>
```

