import React from 'react';
import { render } from '@testing-library/react';
import '@testing-library/jest-dom/extend-expect';
import HomeModule from './Home';

test('renders smart library text', () => {
  const { getByText } = render(<HomeModule.HomeIndex />);
  const textElement = getByText(/Book List/i);
  expect(textElement).toBeInTheDocument();
});