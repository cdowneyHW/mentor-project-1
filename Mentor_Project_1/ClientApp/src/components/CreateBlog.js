import React, { Component } from 'react';

export const CreateBlog = async ({URL}) => {
    const response = await fetch('https://localhost:44386/api/blog/', {
      method: "POST",
      mode: "cors",
      cache: "no-cache",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify({url: URL})
    });
    return response.data;
  };