pipeline {
  agent {
    docker {
      args '''-p 3000:3000
'''
      image 'microsoft/dotnet:2.0-sdk'
    }

  }
  stages {
    stage('AddDocker') {
      steps {
        sh 'cat /etc/*-release'
        sh 'whoami'
        sh '''apt-get update
yes | apt-get install \\
     apt-transport-https \\
     ca-certificates \\
     curl \\
     gnupg2 \\
     software-properties-common
curl -fsSL https://download.docker.com/linux/debian/gpg | apt-key add -
apt-key fingerprint 0EBFCD88
add-apt-repository \\
   "deb [arch=amd64] https://download.docker.com/linux/debian \\
   $(lsb_release -cs) \\
   stable"
apt-get update
yes | apt-get install docker-ce'''
        sh 'docker --version'
        sh 'docker ps'
        sh 'curl -L https://github.com/docker/compose/releases/download/1.21.0/docker-compose-$(uname -s)-$(uname -m) -o /usr/local/bin/docker-compose'
        sh 'chmod +x /usr/local/bin/docker-compose'
      }
    }
    stage('TestDotNetCore') {
      steps {
        sh 'dotnet --version'
        sh 'dotnet restore Builder.sln'
        sh 'dotnet build Builder.sln'
        sh 'dotnet test Builder.sln'
      }
    }
    if (env.BRANCH_NAME == 'master') {    
      stage('DockerBuild') {
        steps {
          sh 'docker-compose build'
          sh 'echo "Push to docker hub"'
        }
      }
    }
  }
}