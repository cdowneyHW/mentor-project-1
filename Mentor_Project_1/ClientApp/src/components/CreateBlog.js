import React, { Component } from 'react';

export const CreateBlog = async ({title}) => {
    const response = await fetch('https://localhost:44386/api/blog/', {
      method: "POST",
      mode: "cors",
      cache: "no-cache",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify({title: title})
    });
    return response.json().data;
  };
